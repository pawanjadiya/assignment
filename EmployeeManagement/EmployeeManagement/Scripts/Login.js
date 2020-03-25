function checkuser() {
    debugger;
    var userName = $('#UserName').val();
    var password = $('#Password').val()
   
    if (userName != "" && password != "") {
        return true;
    }
    else {
        alert("All fields required...!!!!");
        return false;
    }
}