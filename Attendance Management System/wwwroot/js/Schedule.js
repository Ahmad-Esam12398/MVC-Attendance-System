let table = new DataTable('#myTable', {

    lengthMenu: [[7, 14, 21, 30], [7, 14, 21, 30]], // Specify the page length options

    // config options...
    "order": [[0, "desc"]] // Sort by the first column (index 0) in descending order


});

$("#dateFrom").attr('max', new Date().toISOString().split('T')[0]);
$("#dateTo").attr('max', new Date().toISOString().split('T')[0]);

$.fn.dataTable.ext.search.push(
    function (settings, data, dataIndex) {
        var min = new Date($('#dateFrom').val());
        var max = new Date($('#dateTo').val());
        var date = new Date(data[0]); // use data for the date column

        if (
            (isNaN(min) || date >= min) &&
            (isNaN(max) || date <= max)
        ) {
            return true;
        }
        return false;
    }
);
$("#dateFrom, #dateTo").on('change', function () {
    table.draw();
});