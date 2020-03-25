$(document).ready(function () {
    $('#FullName').addClass('form-control');
    $('#Password').addClass('form-control');
    $('#Phone').addClass('form-control');
    $('#Address').addClass('form-control');
    $('#Password').attr('type', 'password');


});


function checkuser() {
    debugger;
    var fullname = $('#FullName').val();
    var password = $('#Password').val()
    var phone = $('#Phone').val();
    var address = $('#Address').val();
    var ddlroles = $('#ddlroles').val();

    if (fullname != "" && password != "" && phone != "" && address != "" && ddlroles != "") {
        return true;
    }
    else {
        alert("All fields required...!!!!");
        return false;
    }
}

