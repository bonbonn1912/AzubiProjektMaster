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
		
		$namecheckquery = "SELECT Username FROM Players WHERE Username ='" . $username . "';";
		$namecheck = mysqli_query($con, $namecheckquery) or die("Name check query failed"); // Name is double
		
		if(mysqli_num_rows($namecheck) > 0)
		{
			echo "Name already exists";
			exit();
		}
		
		// add user to the table 
		 $salt = "\$5\$rounds=5000\$" . "steamedhams" . $username . "\$";
		 $hash = crypt($password, $salt);
		 $insertuserquery = "INSERT INTO Players (Username, hash, salt) VALUES ('". $username ."','" . $hash . "','" . $salt . "');";
		// $insertuserquery = "INSERT INTO Players (username, hash, salt) VALUES ('test123','213321','23232323');";
		mysqli_query($con, $insertuserquery) or die ("Insert playerquery failed"); // Player insert failed
		
		echo ("0"); // User created succesfully
		

?>