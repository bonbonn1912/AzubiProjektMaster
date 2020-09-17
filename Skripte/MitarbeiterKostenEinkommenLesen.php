<?php

	$con = mysqli_connect('localhost','root',"",'test');
	
	/*if (mysqli_connect_errno())
	{
		echo "1: Connection failed"; //error code #1 = connection failed
		exit();
	}*/

	$readquery = "SELECT * FROM allgemein";

	$runquery = mysqli_query($con, $readquery);
	
	//Ziehen von Daten und liefern in einem "array"
	$info = mysqli_fetch_assoc($runquery);
	$anzahl = $info["Mitarbeiter"];
	$kapital = $info["Kapital"];
	$tag = $info["Tag"];
	$ertrag = $info["Ertrag"];

	//Ausgabe von dem Wert Anzahl
	echo  $anzahl . '-'. $kapital . '-' . $tag . '-' . $ertrag;
?>