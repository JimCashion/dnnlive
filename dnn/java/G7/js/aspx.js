var runninginAPSX = false;
var gameID = "";

function getPrize(){

    a = document.getElementById("tbprize").value;
  
	return a;
}

function postback(arg) {

       __doPostBack('bpostback', arg);
}


function getTitle() {

    var a = "DinoNanoNonagon #7";

    return a;
}

function getInstructions() {
    var a;
    if (!IsMobile())
        a = "Click the left or right arrows to move and SPACE to fire";
    else
        a = "Touch to the left or right of the player to move and above the player to fire";

    return a;

}

function getMission() {

    var a = "Shoot 10 Spaceships";

    return a;

}
