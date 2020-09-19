<?php
$con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');

if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   $Name = $_POST["Name"];
	   $Runtime = $_POST["Laufzeit"];
	   $Volume = $_POST["Volume"];
	   $sql = "INSERT INTO Loans (Name, Runtime, Volume) VALUES ('".$Name."','".$Runtime."','".$Volume."');"
	   
    mysqli_query($con,$sql) or die ("geht immer noch nicht");
	   
	   
	   
	   
	   
	   
	  ?>