<?php
       $con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');
	   
	   //check that connection happened
	   if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	    $username = $_POST["username"];
	   $datacheckquery = "SELECT ID, balance ,spielzeit, employees FROM Players, stats WHERE Players.username = stats.username AND Players.username = '" . $username ."'";
	   $datacheck = mysqli_query($con, $datacheckquery) or die("Auslesen der Daten fehlgeschlagen");
	   $output = mysqli_fetch_array($datacheck);
	   echo $output["ID"] . "-" . $output["balance"] . "-" . $output["spielzeit"] . "-" . $output["employees"];
	   
	   
?>