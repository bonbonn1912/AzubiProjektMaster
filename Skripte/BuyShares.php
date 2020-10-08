<?php
$con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');

if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   $username = $_POST["Username"];
	   $shareName = $_POST["shareName"];
       $amount = $_POST["amount"];	   
	   
	   $sql = "UPDATE Shares_in_posession SET Amount = Amount + ".$amount." WHERE Username = '" . $username ."' AND Share_name ='".$shareName."'";
	   
mysqli_query($con,$sql) or die ("geht immer noch nicht");
	   
	   
	   
	   
	   
	   
	  ?>