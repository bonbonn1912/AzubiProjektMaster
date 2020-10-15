<?php
$con = mysqli_connect('rdbms.strato.de', 'U4311041', 'Datenbank123!','DB4311041','3306');

if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   $username = $_POST["username"];
$sql = "UPDATE Stats SET Spieltage = Spieltage +1 WHERE Username = '" . $username ."'";
mysqli_query($con,$sql) or die ("geht immer noch nicht");

	?>