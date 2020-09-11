<?php
$con = mysqli_connect('178.254.41.75', 'dominik','Xeng72*5','dominik','3306');
$updatedata = "SELECT * FROM Unternehmen WHERE Name ='Deutsche Bank'";
$namecheck = mysqli_query($con, $updatedata) or die("Name check query failed"); 
$logininfo = mysqli_fetch_array($namecheck);
echo  $logininfo["Kapital"];

?>