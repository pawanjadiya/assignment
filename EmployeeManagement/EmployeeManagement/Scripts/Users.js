$(document).ready(function () {
    $.ajax({
        type: "GET",
        //Calling API",
        url: "http://localhost:50529/api/values/GetUserList",
        dataType: "json",
        success: function (data) {
            console.log(data);
            createTable(data);
        }
    });

    $('body').on('click', '.check', function () {
        var userId = $(this).next().val();
        var check = $(this).prop("checked");
        $.ajax({
            type: "POST",
            url: "Users/UpdateUser",
            data: { 'userId': '' + userId + '', 'status': '' + check + '' },
            dataType: "json",
            success: function (data) {
                createTable(data);
            }
        });
    })
    if ($('#RoleId').val() == "1" || $('#RoleId').val() == "") {
        $('#AddEmployee').show();
    }
    else {
        $('#AddEmployee').hide();
    }
});

function createTable(data) {
    if (data.length != 0) {
        var roleId = $('#RoleId').val();
        var table = "<table class='table'><thead><tr><th>FullName</th><th>Phone</th><th>Address</th><th>Role</th><th>Status</th></thead></tr><tbody>";
        $.each(data, function (index, value) {
            if (roleId == '1') {
                if (!value.Status) {
                    table += "<tr><td>" + value.FullName + "</td><td>" + value.Phone + "</td><td>" + value.Address + "</td><td>" + value.RoleName + "</td><td> <input class='check' type='checkbox' id='test' name='test' /><input type='hidden' value='" + value.UserId + "'/></td></tr>"
                }
                else {
                    table += "<tr><td>" + value.FullName + "</td><td>" + value.Phone + "</td><td>" + value.Address + "</td><td>" + value.RoleName + "</td><td> <input class='check' type='checkbox' id='test' name='test' checked='" + value.Status + "' /><input type='hidden' value='" + value.UserId + "'/></td></tr>"
                }
            }
            else if (roleId == '2') {
                if (value.RoleName != "Admin") {
                    if (!value.Status) {
                        table += "<tr><td>" + value.FullName + "</td><td>" + value.Phone + "</td><td>" + value.Address + "</td><td>" + value.RoleName + "</td><td> <input class='check' type='checkbox' id='test' name='test' /><input type='hidden' value='" + value.UserId + "'/></td></tr>"
                    }
                    else {
                        table += "<tr><td>" + value.FullName + "</td><td>" + value.Phone + "</td><td>" + value.Address + "</td><td>" + value.RoleName + "</td><td> <input class='check' type='checkbox' id='test' name='test' checked='" + value.Status + "' /><input type='hidden' value='" + value.UserId + "'/></td></tr>"
                    }
                }
            }
            else if (roleId == '3') {
                if (value.RoleName != "Admin" && value.RoleName != "Supervisor")
                    table += "<tr><td>" + value.FullName + "</td><td>" + value.Phone + "</td><td>" + value.Address + "</td><td>" + value.RoleName + "</td><td> " + (value.Status ? "Active" : "In Active") + "</td></tr>"
            }
        });
        table += "</tbody></table>";
        if (roleId != "")
            $('#employee').html(table);
        else
            $('#employee').html('Please lgin first....!!!<a href="/Login/Index" >click here</a>');
    }
    else {
        $('#employee').html('No data found....!!!');
    }
}
