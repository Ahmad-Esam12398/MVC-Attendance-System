var table;
var api;
var colarray = [0, 1, 2, 3, 4, 5];

$(document).ready(function () {
    table = $('#myTable').DataTable({
        responsive: true,
        orderCellsTop: true,
        fixedHeader: true,
        initComplete: function () {
            api = this.api();
            createFilters();
        },
    });



    function createFilters() {
        // Date Filter
        api
            .columns(0)
            .eq(0)
            .each(function (colIdx) {
                $('#Date')
                    .off('keyup change')
                    .on('keyup change', function (e) {
                        // Get the search value
                        var searchValue = this.value;
                        console.log(searchValue);

                        // Set the search value as the title attribute of the input
                        $(this).attr('title', searchValue);

                        // Search the column for the entered value
                        api
                            .column(colIdx)
                            .search(searchValue)
                            .draw();
                    });
            });
    }

});



$(".btn").click(function () {
    var id = $(this).attr("id");
    var action = $(this).attr("action");
    console.log(action, id);
    var clickedButton = $(this);
    $.ajax({
        url: action,
        type: "POST",
        data: { id: id },
        success: function (data) {
            var $statusCell = clickedButton.closest("tr").find(".status-cell");
            if (action == "/Instructor/Reject") {
                $statusCell.text("Refused");
                $.toast({
                    heading: 'Permission Rejected',
                    text: 'You have successfully rejected the permission.',
                    showHideTransition: 'slide',
                    icon: 'success'
                });
                clickedButton.closest("tr").hide("slow");



            } else if (action == "/Instructor/Accept") {
                $statusCell.text("Accepted");
                $.toast({
                    heading: 'Permission Accepted',
                    text: 'You have successfully accepted the permission.',
                    showHideTransition: 'slide',
                    icon: 'success'
                });
                clickedButton.closest("tr").hide("slow");

            }
            else if (action == "/Instructor/Delete") {
                $.toast({
                    heading: 'Schedule Deleted',
                    text: 'You have successfully deleted the Schedule.',
                    showHideTransition: 'slide',
                    icon: 'success'
                });
                clickedButton.closest("tr").hide("slow");
            }


            },
            error: function (data) {
                $.toast({
                    heading: 'Error',
                    text: 'An error occurred while processing your request.',
                    showHideTransition: 'slide',
                    icon: 'error'
                })
            }
        });
});
$('#ClearDate').click(function () {
    $('#Date').val('');
    $('#Date').attr('title', '');
    api.columns(0).search('').draw();
});
const convertTime12to24 = (time12h) => {
    const [time, modifier] = time12h.split(' ');

    let [hours, minutes] = time.split(':');

    if (hours === '12') {
        hours = '00';
    }

    if (modifier === 'PM') {
        hours = parseInt(hours, 10) + 12;
    }

    return `${hours}:${minutes}`;
}
$('.edit').click(function (event) {
    var button = $(this);
    var id = button.data('id');
    var date = button.data('date');
    var startTime = button.data('start-time');
    var endTime = button.data('end-time');

    // Parse time strings using Moment.js
    var startTimeMoment = moment(startTime, 'hh:mm A');
    var endTimeMoment = moment(endTime, 'hh:mm A');

    // Format time in desired format (12-hour without AM/PM)
    var formattedStartTime = startTimeMoment.format('HH:mm');
    var formattedEndTime = endTimeMoment.format('HH:mm');

    // Fill form fields with data
    $('#EditId').val(id);
    $('#EditDate').val(date);
    $('#EditStartTime').val(formattedStartTime);
    $('#EditEndTime').val(formattedEndTime);
});



