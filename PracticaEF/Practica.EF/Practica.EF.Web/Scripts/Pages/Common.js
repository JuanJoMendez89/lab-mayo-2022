function OnlyNumbers(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;

    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        evt.preventDefault();
        return false;
    }
    return true;
}

function OnlyNumbersParentheses(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;

    if (charCode > 31 && (charCode < 48 || charCode > 57)
        && charCode != 40
        && charCode != 41
        && charCode != 45) {

        evt.preventDefault();
        return false;
    }
    return true;
}

function OnlyLetters(evt) {
    evt = (evt) ? evt : window.event;
    var charCode = (evt.which) ? evt.which : evt.keyCode;

    if (!((charCode > 64 && charCode < 91) || (charCode > 96 && charCode < 123))) {

        evt.preventDefault();
        return false;
    }
    return true;

}