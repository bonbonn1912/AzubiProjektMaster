<?php
$con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');

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