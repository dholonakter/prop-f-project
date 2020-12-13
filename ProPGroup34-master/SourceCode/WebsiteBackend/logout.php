<?php
   session_start();

   // once destroyed session, redirect
   if(session_destroy()) {
      header("Location: index.html");
   }
?>