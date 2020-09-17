<?php

	$con = mysqli_connect('localhost','root',"",'test');
	

	$fromunity1 = $_POST["Kapital"];
	$fromunity2 = $_POST["Ertrag"];

	
	$updatedata1 = "UPDATE allgemein SET Kapital = '" . $fromunity1 . "'";
	$updatedata2 = "UPDATE allgemein SET Ertrag = '" . $fromunity2 . "'";
	
	mysqli_query($con,$updatedata1);
	mysqli_query($con,$updatedata2);
?>