<?php 
    include('userData.php');

    $activationcode = $_POST['activationcode'];
    $sql = $conn->prepare("SELECT COUNT(*) from CAMPING_reservation i where (SELECT COUNT(*) from reserve_visitor r where r.ReservNr = i.ReservNr) < NrOfRegistered
    AND ConfirmCode = '" . $activationcode . "'");
    $sql->execute();
    $res = $sql->fetchAll();

    if($res != null) // if the array was successfully created
    {
        // if there is 1 rows matched
        if($res[0]['COUNT(*)'] > 0 )
        {
            // get reserv nr
            $sql = $conn->prepare("SELECT ReservNr from CAMPING_reservation i where (SELECT COUNT(*) from reserve_visitor r where r.ReservNr = i.ReservNr) < NrOfRegistered
            AND ConfirmCode = '" . $activationcode . "'");
            $sql->execute();
            $res = $sql->fetchAll();
            $_SESSION["reserv_nr"] = $res[0]["ReservNr"];

            $sql_cmd = "INSERT INTO reserve_visitor(ReservNr, VisitorNr)
            VALUES(" . $_SESSION["reserv_nr"] .", ". $user_id . ");";
            
            $sql = $conn->prepare($sql_cmd);

            if($sql->execute())
            {
                echo "success";
            }
            else {
                echo "failed";
            }
        }
        else {
            echo "failed";
        }
    }
?>