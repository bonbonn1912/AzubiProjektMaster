<?php
      $con = mysqli_connect('h2881784.stratoserver.net', 'root', 'root','unityaccess','3306');
	   
	   //check that connection happened
	   if (mysqli_connect_errno())
	   {
		   echo "Connection failed";  // No connection 
		   exit();
	   }
	   
	    $username = $_POST["name"];
		$password = $_POST["password"];
		
		// check if name exists 
		
		$namecheckquery = "SELECT username, salt ,hash, score FROM players WHERE username ='" . $username . "';";
		$namecheck = mysqli_query($con, $namecheckquery) or die("Name check query failed"); // Name is double
		if (mysqli_num_rows($namecheck) != 1)
		{
			echo "1Login Failed"; // Mehr/weniger user als 1 vorhanden
			exit();
		}
		
		//get login from query 
		
		$logininfo = mysqli_fetch_array($namecheck);
		$salt = $logininfo["salt"];
		$hash = $logininfo["hash"];
		$username = $logininfo["username"];
		
		$loginhash = crypt($password, $salt);
		if($hash != $loginhash)
		{
			echo "Incorrect password"; //pw falsch
			exit;
		}
		
		echo "0\t" . $logininfo["score"];
		
		


?>