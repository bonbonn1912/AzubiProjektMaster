<?php
$con = mysqli_connect('rdbms.strato.de', 'U4311041', 'Datenbank123!','DB4311041','3306');

if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   $balance = $_POST["Balance"];
	   $username = $_POST["username"];
	   $employees = $_POST["Employees"];
	   $sql = "UPDATE Stats SET Balance = '". $balance . "' , Employees = '".$employees ."' WHERE Username = '" . $username ."'";
	   
mysqli_query($con,$sql) or die ("geht immer noch nicht");
	   
	   
	   
	   
	   
	   
	  ?>