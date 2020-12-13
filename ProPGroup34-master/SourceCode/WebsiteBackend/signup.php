<?php
    include("config.php");

    // define variables and set to empty values
    $firstName = $lastName = $email = $telephone = $password = $password_repeat = "";

    function test_input($data) {
        $data = trim($data);
        $data = stripslashes($data);
        $data = htmlspecialchars($data);
        return $data;
      }

    // data retrieval
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
      $firstName = test_input($_POST["firstname"]);
      $lastName = test_input($_POST["lastname"]);
      $email = test_input($_POST["email"]);
      $telephone = test_input($_POST["phonenumber"]);
      $password = test_input($_POST["psw"]);
      $password_repeat = test_input($_POST["psw_repeat"]);

      if($password != $password_repeat)
      {
        echo "<script>alert('Password mismatched')</script>";
      }
      else 
      {
        $sql = $conn->prepare("INSERT INTO visitor(FirstName, LastName, Phone, Email, UserPassword)
        VALUES('$firstName', '$lastName', '$telephone', '$email', '$password');");
  
        if ($sql->execute()) {
          $subject = 'Registration at LARPFestival';
          $message = 'Dear ' . $firstName . ' ' . $lastName . ", \n
          We have received your registration to join our LARP Festival. Purchase a ticket online to save money. \n
          Best regards, \n
          The LARPFestival Staff.";
          $headers = 'From: i390396@hera.fhict.nl' . "\r\n" .
          'Reply-To: i390396@hera.fhict.nl' . "\r\n" .
          'X-Mailer: PHP/' . phpversion();
          mail($email, $subject, $message, $headers);
          echo "<script>alert('Sucessfully registered')</script>";
        }
      }
    }
?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"> 		<link rel="stylesheet" href="./css/bootstrap.min.css">
        <link rel="stylesheet" href="./js/bootstrap.bundle.min.js">
        <link rel="stylesheet" href="./css/styles_talia.css">
        <title>Sign Up</title>
    </head>

    <body>
        <div class="container">
            <div class="row login">
                <div class ="col-12"  style="text-align: center; margin-top: 10px;">
                    <img src="./images/test.png" alt="Eloniah" class="logo img-responsive col-lg-12">
                </div>

                <form  method="post" action="<?php echo $_SERVER["PHP_SELF"];?>" class="col-12 loginForm">
                    <div class="row">
                        <h3 class="col-12">Create Account</h3>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">First Name</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="text" placeholder="Enter Your First Name" name="firstname" required>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">Last Name</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="text" placeholder="Enter Your Last Name" name="lastname" required>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">Email</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="text" placeholder="Enter Email" name="email" required>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">Phone Number</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="text" placeholder="Enter Phone Number" name="phonenumber" required>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">Password</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="password" placeholder="Enter Password" name="psw" required>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-sm-12 col-lg-4">
                            <label for="firstname">Repeat Password</label>
                        </div>

                        <div class="col-sm-12 col-lg-8">
                            <input type="password" placeholder="Repeat Password" name="psw_repeat" required>
                        </div>
                    </div>

                    <!-- button jackshit -->
                    <div class="row">
                        <div class="col-12">
                            <button type="submit" class="btn" >Sign Up</button>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-12" style="margin-top: 5px; margin-bottom: 5px;">Have an account already?</div>

                        <div class="col-12">
                            <a href="login.html"><button type="button" class="btn">Login Now!</button></a>
                        </div>
                    </div>

                </form>
            </div>
        </div>
    </body>
</html>
