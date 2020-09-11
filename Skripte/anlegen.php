<?php
       $con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');
	   
	   //check that connection happened
	   if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	    $username = $_POST["username"];
		$balance = $_POST["balance"];
		$employees = $_POST["employees"];
		$buildings = $_POST["buildings"];
	   
	    $insertuserquery = "INSERT INTO stats (username, balance, employees, buildings, spielzeit) VALUES ('". $username ."','" . $balance . "','" . $employees . "','" . $buildings . "',1);";
	    mysqli_query($con, $insertuserquery) or die ("Insert Data failed"); // Player insert failed
	   
	    echo ("0"); // User created succesfully
?>