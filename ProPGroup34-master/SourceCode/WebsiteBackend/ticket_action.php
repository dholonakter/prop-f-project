<?php
    include('userData.php');

    // retrieve spot data
    $spot_sql = ("SELECT * FROM camping_spot");

    if (isset($_SESSION["user_id"]))
    {
        // data retrieval
        if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $tickettype = ($_POST["tickettype"]);

        $sql_cmd = "INSERT INTO ticket(BuyerNr, TicketType) VALUES(" . $_SESSION['user_id'] . ", '" . $tickettype . "')";
        echo $sql_cmd;

        $sql = $conn->prepare($sql_cmd);
        if ($sql->execute()) {
            
                header("Location: participant.php");
        }
        
        }
    }
?>