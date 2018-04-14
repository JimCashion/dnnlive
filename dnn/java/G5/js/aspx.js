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

    var a = "DinoNanoNonagon #5";

    return a;
}


function getInstructions() {
    var a;
    if (!IsMobile())
        a = "Use all the arrow keys to move around and herd the dinosaurs";
    else
        a = "Touch to the left, right, above or below the player to move around";

    return a;

}

function getMission() {

    var a = "All thirty dinosaurs must be herded through the gates in the order and direction indicated by the arrows and then into the pen to get your coordinates ";

    a += "\nGetting too close to the dinos will make them anxious and they may bolt if they get really anxious!"
    return a;

}



