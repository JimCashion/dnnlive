var runninginAPSX = false;
var gameID = "";

function getPrize() {

    a = document.getElementById("tbprize").value;

    return a;
}

function postback(arg, data) {
    // assume correct as the checksum will be correct.
    //  will perform an exact check when in ASPX mode

    //bonustext = data;
    __doPostBack('bpostback', arg + "," + data);
}
function getSecretCode(){

	var sc = "123456";

	return sc;
}

function getTitle() {

    var a = "DinoNanoNonagon BONUS";

    return a;
}

function getInstructions() {
    var a;

    a = "This is smiple to play and should be just as easy using a touch screen as a keyboard";

    return a;

}

function getMission() {

    var a = "This is in three simple stages, complete each stage to progress to the next.";
    a += "\nOnce the last stage is completed you will be given the coordinates to the bonus cache.";
    return a;

}

