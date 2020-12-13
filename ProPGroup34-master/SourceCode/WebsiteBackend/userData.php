<?php
include('config.php');
include('session.php');

// email address == logged in address
$username = $_SESSION['login_user'];

// retrieve visitor's data based on email address
$sql = $conn->prepare("SELECT * FROM visitor WHERE Email = '$username'");
$sql->execute();
$user_data = $sql->fetchAll();
$user_id = $user_data[0]['IdNr'];
$_SESSION['user_id'] = $user_id;

// based on user_id retrieve ticket
$sql = $conn->prepare("SELECT COUNT(*) from ticket_info where BuyerNr = '$user_id'");
$sql->execute();
$res = $sql->fetchAll();

if($res != null) // if the array was successfully created
{
	// if there is > 0 rows matched
	if($res[0]['COUNT(*)'] > 0 )
	{
        $ticket_found = true;

		// the actual query
		$user_ticket = $conn->prepare("SELECT * from ticket_info where BuyerNr = '$user_id'");
        $user_ticket->execute();
		$user_ticket_data = $user_ticket->fetchAll();
		$_SESSION["ticket_nr"] = $user_ticket_data[0]["TicketNr"];
    }
    else
    {
        $ticket_found = false;
    }
}

// based on user_id retrieve reservation
$sql = $conn->prepare("SELECT COUNT(*) from reservation_info where VisitorNr = '$user_id'");
$sql->execute();
$res = $sql->fetchAll();

if($res != null) // if the array was successfully created
{
	// if there is > 0 rows matched
	if($res[0]['COUNT(*)'] > 0 )
	{
        $reservation_found = true;
		// the actual query
		$user_reserv = $conn->prepare("SELECT ReservNr,SpotName, StartDate, EndDate, NrOfRegistered, ConfirmCode from reservation_info where VisitorNr = '$user_id'");
        $user_reserv->execute();
		$user_reserv_data = $user_reserv->fetchAll();
		$_SESSION["reserv_nr"] = $user_reserv_data[0]["ReservNr"];
    }
    else
    {
        $reservation_found = false;
    }
}

		?>
