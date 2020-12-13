<?php
    include('userData.php');

    // retrieve spot data for all available spots
    $spot_sql = ("SELECT * FROM camping_spot WHERE IsFree = 1");

    if (isset($_SESSION["reservNr"]))
    {
        echo "alr";
    }
    else {
        //define variables and set to empty values
        $spotnr = $nrregistered = $endDate = $startDate = "";
        
        // input validation
        function test_input($data) {
            $data = trim($data);
            $data = stripslashes($data);
            $data = htmlspecialchars($data);
            return $data;
        }

        // generate confirm code
        function generateRandomString($length) {
            $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ';
            $charactersLength = strlen($characters);
            $randomString = '';
            for ($i = 0; $i < $length; $i++) {
                $randomString .= $characters[rand(0, $charactersLength - 1)];
            }
            return $randomString;
        }

        // data retrieval
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $spotnr = test_input($_POST["campingSpot"]);
        $nrregistered = test_input($_POST["campers"]);
        $endDate = ($_POST["endDate"]) . " 00:00:00";
        $startDate = ($_POST["startDate"]) . " 00:00:00";
        $confirmCode = generateRandomString(5);

        $sql_cmd = "INSERT INTO camping_reservation(SpotNr, NrOfRegistered, ConfirmCode, StartDate, EndDate) VALUES(" 
        . $spotnr . ", " 
        . $nrregistered . ", "
        . "'". $confirmCode . "', "
        . "CONVERT('" . $startDate . "', DATETIME), "
        . "CONVERT('" . $endDate . "', DATETIME)); ";


        $sql = $conn->prepare($sql_cmd);
        if ($sql->execute()) {
            $sql = $conn->prepare("SELECT MAX(ReservNr) 'ReservNr' FROM camping_reservation");
            $sql->execute();
            $res = $sql->fetchAll();
            
            $_SESSION["reserv_nr"] = $res[0]["ReservNr"];

            $sql_cmd = "INSERT INTO reserve_visitor(ReservNr, VisitorNr)
            VALUES(" . $_SESSION["reserv_nr"] .", ". $_SESSION["user_id"] . ");";
            
            $sql = $conn->prepare($sql_cmd);

            if($sql->execute())
            {
                echo "success";
                header("Location: participant.php");
            }
            else {
                echo "failed";
            }
        }
        else {
            echo "failed";
        }
        }
    }
?>