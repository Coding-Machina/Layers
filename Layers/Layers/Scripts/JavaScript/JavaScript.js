$(document).ready(function () {

});

function showBatches() {
    $ajax({
        url: "/odataapi/batch",
        type: "GET",
        dataType: "json",
        success: function (data) {
            let batches = data.value;
            var html = '';
            $.each(batches, function (i, itemData) {
                html += "<tr>";
                html += "<td>" + itemData.BatchName + "</td>";
                html += "<td>" + itemData.TotalHours + "</td>";
                html += "<td>" + itemData.HoursTaken + "</td>";
                html += "</tr>";
            });
            $("#batchTable > tbody").html(html);
        }
    });
}