<?php

try
{
   // connection strings
    $server = "mysql:host=studmysql01.fhict.local"; // the HERA server
    $database = ";dbname=dbi387862"; // instead of dbi123456 , put your DBI account 
                                             // (dbi followed by your PCN)       
    $user = "dbi387862"; // again, your DBI account
    $password = "blueberrypie"; // your HERA password
  // connect to database
  $conn = new PDO($server.$database,$user,$password);
}
catch (PDOException $e)
{
  echo $e->getMessage();
  die(); // the rest of the page will not be displayed
}
?>
