$(document).ready(
$(function () {
    $("#create-table").click(function () {
        var rows = $("#rows").val(),
            cols = $("#cols").val(),
            name = $("#table-name").val();
        $.post("/Table/Create", { rows: rows, cols: cols, name: name },
            function (data) {
                $("#containment-wrapper").append(data);
                $("#" + name).editableTableWidget();
            });
    });
}));