<?php

	$con = mysqli_connect('localhost','root',"",'test');


	$fromunity1 = $_POST["Mitarbeiter"];
	$fromunity2 = $_POST["Kosten"];
	$fromunity3 = $_POST["Kapital"];
	
	$updatedata1 = "UPDATE allgemein SET Mitarbeiter = '" . $fromunity1 . "'";
	$updatedata2 = "UPDATE allgemein SET Kosten = '" . $fromunity2 . "'";
	$updatedata3 = "UPDATE allgemein SET Kapital = '" . $fromunity3 . "'";
	
	mysqli_query($con,$updatedata1);
	mysqli_query($con,$updatedata2);
	mysqli_query($con,$updatedata3);

?>