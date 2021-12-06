function validation() {
    var errCount = 0;

    //Title Validation
    if (document.getElementById("title").value == "Title") {
        document.getElementById("title").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("title").style.border = "";
    }

    //Forename Validation
    if (document.getElementById("forename").value == "") {
        document.getElementById("forename").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("forename").style.border = "";
    }

    //Surname Validation
    if (document.getElementById("surname").value == "") {
        document.getElementById("surname").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("surname").style.border = "";
    }

    //Email Validation
    if (document.getElementById("email").value == "") {
        document.getElementById("email").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("email").style.border = "";
    }

    //Telephone Validation
    if (document.getElementById("telephone").value == "") {
        document.getElementById("telephone").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("telephone").style.border = "";
    }

    //Details Validation
    if (document.getElementById("details").value == "") {
        document.getElementById("details").style.border = "2px solid red";
        errCount++;
    }
    else {
        document.getElementById("details").style.border = "";
    }

    //Error Counter
    if (errCount > 0) {
        return false
    }
    else {
        return true;
    }
}