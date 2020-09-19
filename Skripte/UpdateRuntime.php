<?php
$con = mysqli_connect('178.254.41.75', 'dominik', 'Xeng72*5','dominik','3306');





$user = $_POST["User"];
$sql = "UPDATE Loans SET Runtime = Runtime - 1 WHERE Username = '".$user."'";
 mysqli_query($con,$sql);
 ?>