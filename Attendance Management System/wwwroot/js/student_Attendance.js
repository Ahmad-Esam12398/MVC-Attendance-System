$(document).ready(function () {
    var table = $('#myTable').DataTable({
        lengthMenu: [[7, 14, 21, 30], [7, 14, 21, 30]], // Specify the page length options

        layout: {
            topStart: {
                // buttons: ['copy', 'csv', 'excel', 'pdf', 'print', 'colvis']
                buttons: [
                    {
                        extend: 'copy',
                        exportOptions: {
                            rows: ':visible',
                            columns: ':visible'
                        }
                    },

                    {
                        extend: 'excel',
                        exportOptions: {
                            rows: ':visible',
                            columns: ':visible',

                        },
                        action: function (e, dt, node, config) {
                            swal({
                                buttons: [true, "Save"],
                                title: "Save",
                                content: {
                                    element: "input",
                                    attributes: {
                                        placeholder: "File Name",
                                    },
                                },
                            })
                                .then(value => {
                                    $(node).removeClass('processing');
                                    if (value) {
                                        config.filename = value;
                                        $.fn.dataTable.ext.buttons.excelHtml5.action.call(this, e, dt, node, config);

                                    }
                                })
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            rows: ':visible',
                            columns: ':visible',
                        },
                        action: function (e, dt, node, config) {
                            swal({
                                buttons: [true, "Save"],
                                title: "Save",
                                content: {
                                    element: "input",
                                    attributes: {
                                        placeholder: "File Name",
                                    },
                                },
                            })
                                .then(value => {
                                    $(node).removeClass('processing');
                                    if (value) {
                                        config.filename = value;
                                        $.fn.dataTable.ext.buttons.pdfHtml5.action.call(this, e, dt, node, config);

                                    }
                                })
                        }
                    },
                    {
                        extend: 'print',
                        exportOptions: {
                            rows: ':visible',
                            columns: ':visible'
                        }
                    },
                    'pageLength'
                ]
            }
        },
        // dom: 'Bfrtip',
        order: [[1, 'asc'], [0, 'asc']],
        pageLength: 7,
    });
    table.buttons().container().appendTo($('.col-sm-6:eq(0)', table.table().container()));
    $("#Status").on('change', function () {
        if (this.value == "")
            table.columns(3).search("").draw();
        else
            table.columns(3).search(this.value).draw();
    })
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
});