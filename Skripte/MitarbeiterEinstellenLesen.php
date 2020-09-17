<?php


	//Connection festlegen
	$con = mysqli_connect('localhost','root',"",'test');
	
	//Tabelle festlegen
	$readquery = "SELECT * FROM allgemein";
	//Verbindungsaufbau mit vorgegebenen Parametern
	$runquery = mysqli_query($con, $readquery);
	
	//Ziehen von Daten aus der DB und in einem Array ausgeben"
	$info = mysqli_fetch_assoc($runquery);
	$anzahl = $info["Mitarbeiter"];
	$kosten = $info["Kosten"];
	$kapital = $info["Kapital"];

	//Ausgabe von dem Wert Anzahl
	echo  $anzahl . '-' . $kosten . '-'. $kapital;

	?>