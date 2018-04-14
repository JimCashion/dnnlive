var runninginAPSX = false;
var gameID = "";

function getPrize(){

    a = document.getElementById("tbprize").value;
  
	return a;
}

function getSecretCode(){

	var sc = "123456";

	return sc;
}

function postback(arg) {
    //game.world.setBounds(0, 0, 800, 600); 
       __doPostBack('bpostback', arg);
}

function getTitle(){

	var a = "DinoNanoNonagon #9";

	return a;
}

function getInstructions() {
    var a;
    if (!IsMobile())
        a = "Use the arrow keys to move around the maze and collect the caches before the dinos";
    else
        a = "Touch to the left, right, above or below the player to move around the maze and collect the caches before the dinos";

    return a;

}

function getMission() {

    var a = "Collect 20 of each cache type or 200 caches in total before one of the dinos does!";

    return a;

}

