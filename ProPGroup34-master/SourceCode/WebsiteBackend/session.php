<?php
  // connect to db
   include('config.php');

   session_start();

   $retrieve_data;

   // take the username from form
   if (isset($_SESSION['login_user']))
   {
     $user_check = $_SESSION['login_user'];

     // ------- extract login details ------- //
     $ses_data = $conn->prepare("SELECT *
                                    FROM visitor
                                    WHERE Email = '$user_check'");
     $ses_data->execute();
     $retrieve_data = $ses_data->fetchAll();
   }

   /* ------- redirect -------
   // if username is not set or is null, redirect.
   if(!isset($_SESSION['login_user'])){
      header("location:login.php");
   }*/
?>
