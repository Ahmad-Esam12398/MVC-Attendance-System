var table;
var api;
var colarray = [0, 1, 2, 3, 4, 5];

$(document).ready(function () {
    table = $('#myTable').DataTable({
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