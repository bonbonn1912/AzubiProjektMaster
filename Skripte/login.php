<?php
       $con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');
	   
	   //check that connection happened
	   if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   
	    $username = $_POST["name"];
		$password = $_POST["password"];
		
		// check if name exists 
		
		$namecheckquery = "SELECT Username, salt ,hash, PID FROM Players WHERE Username ='" . $username . "';";
		$namecheck = mysqli_query($con, $namecheckquery) or die("Name check query failed"); // Name is double
		if (mysqli_num_rows($namecheck) != 1)
		{
			$row_cnt = mysqli_num_rows($namecheck);
			echo "1Login Failed" . $row_cnt; // Mehr/weniger user als 1 vorhanden
			exit();
		}
		
		//get login from query 
		
		$logininfo = mysqli_fetch_array($namecheck);
		$salt = $logininfo["salt"];
		$hash = $logininfo["hash"];
		$username = $logininfo["Username"];
		
		$loginhash = crypt($password, $salt);
		if($hash != $loginhash)
		{
			echo "Incorrect password"; //pw falsch
			exit;
		}
		
		echo "0\t" . $logininfo["score"];
		
		


?>