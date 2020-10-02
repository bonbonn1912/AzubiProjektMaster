<?php
$con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');

if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	  // $tutorial = $_POST["tut"];
	   $username = $_POST["Username"];
	   
	   $sql = "UPDATE Stats SET Tutorial = 1 WHERE Username = '" . $username ."'";
	   
mysqli_query($con,$sql) or die ("geht immer noch nicht");
	   
	   
	   
	   
	   
	   
	  ?>