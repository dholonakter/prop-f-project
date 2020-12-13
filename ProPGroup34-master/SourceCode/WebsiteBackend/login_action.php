<?php
		include('config.php');

		session_start();
		$error = false;
		
		if (isset($_POST['username']) && isset($_POST['password'])) {
			$myusername = ($_POST['username']);
			$mypassword = ($_POST['password']);

			// query database for a user with the given username or password
			$sql = $conn->prepare("SELECT COUNT(*) FROM visitor WHERE Email = '$myusername' and UserPassword = '$mypassword'");
			$sql->execute();
			$res = $sql->fetchAll();
	
			if($res != null) // if the array was successfully created
			{
			  // if there is exactly one row matching that username and password
			  if($res[0]['COUNT(*)'] == 1)
			  {
					$sql = $conn->prepare("SELECT IdNr FROM visitor WHERE Email = '$myusername' and UserPassword = '$mypassword'");
					$sql->execute();
					$res = $sql->fetchAll();
					$_SESSION['login_user'] = $myusername;
					echo "success";
			  }
			  else {
				  echo "failed";
			  }
			}
	}
?>
