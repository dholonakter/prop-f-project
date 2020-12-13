<?php
    include('userData.php');
?>

<!DOCTYPE html>
<html>
    <head>
        <title>Participant's information</title>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"> 		
        <link rel="stylesheet" href="./css/bootstrap.min.css">
        <link rel="stylesheet" href="./js/bootstrap.bundle.min.js">
        <link rel="stylesheet" href="./css/styles.css">

        <script src="js/jquery.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
		<script src="./js/scripts.js"></script>
        <script>
            $(document).ready(function() {
                $("header").load("header.php");
                $("footer").load("footer.html");
            });
        </script>

    </head>

    <body class="bg-dark">
        
        <header></header>
        <div class="container" >
            <h2 class="mt-5 pb-3">Your information</h2>
        <div class="row">
            <div class="col-4">
                <div class="">
                    <img src="images/ProfileImage.png" class="img-fluid" id="">
                </div>
                    <div class="mt-3">
                        <h2><?php echo $user_data[0]['FirstName']; ?> <?php echo $retrieve_data[0]['LastName']; ?></h2>
                        <ul>
                            <li>Credits: <?php echo $user_data[0]['Credit']; ?></li>
                            <li>Email: <?php echo $user_data[0]['Email']; ?></li>
                            <li>Phone: <?php echo $user_data[0]['Phone']; ?></li>
                        </ul>
                        <!-- No time for this<a href="campingreg.html" class="btn btn-info">Change Details</a> -->
                    </div>
            </div>
            <div class="col-4">
                <?php 
                    if ($ticket_found) {
                        echo '<h3 class="mb-3">Ticket nr '. $user_ticket_data[0]["TicketNr"] . '</h3>'
                        . '<img src="test_qr.php?id='.$_SESSION["ticket_nr"].'" /><p></p>'
                        . '<ul>
                        <li>Ticket type: ' . $user_ticket_data[0]['TicketType'] . '</li>
                        <li>Ticket price: €' . $user_ticket_data[0]["TicketPrice"] . '</li>
                        </ul>';
                    }
                    else {
                        echo '<h3 class="mb-3">Purchase Ticket</h3>
                        <form id = "buyTicketForm" action="ticket_action.php" method="POST">    
                        <span>Choose your ticket type: </span>
                            <div class="mb-3">
                                <select name="tickettype">
                                    <option value ="Deluxe">Deluxe</option>
                                    <option value ="Normal">Normal</option>
                                </select>
                            </div>
                            <span>Choose your payment method: </span>
                            <div class="mb-3">
                                <input type="radio" name="payment" value="ideal"> iDeal<br>
                                <input type="radio" name="payment" value="paypal"> PayPal<br>
                                <input type="radio" name="payment" value="ipay"> iPay<br>
                            </div>
                            <button type="submit" class="btn btn-info">Buy Ticket</button>
                            </form>';
                    }
                ?>
            </div>

            <div class="col-4">
                <?php 
                    if ($reservation_found) {
                        echo '<h3 class="mb-3">Spot: '. $user_reserv_data[0]["SpotName"] . '</h3>
                        <ul>
                            <li>Number of people: ' . $user_reserv_data[0]['NrOfRegistered'] . '</li>
                            <li>Start date: ' . $user_reserv_data[0]["StartDate"] . '</li>
                            <li>End date: ' . $user_reserv_data[0]["EndDate"] . '</li>
                            <li>Confirm code: ' .  $user_reserv_data[0]['ConfirmCode'] . '</li>
                        </ul>';
                    }
                    else {
                        echo '<h3 class="mb-3">Camping</h3>
                        <a href="campingreg.php" class="btn btn-info">Rent a Camping Spot!</a>
                        <div class="row">
                        <div class="col-6">
                            <label for="activationcode" class="mb-1 mt-4">Enter camp code:</label>
                        <form id="activateCampForm" action="activate_camp.php" method="post">
                        <div class="row">
                            <div class="col-8 pr-0">
                            <input type="text" placeholder="Enter Code" name="activationcode" id="activationcode" class="mb-2 form-control">
                                
                            </div>
                            <div class="col-4">
                                <button type="submit" class="btn btn-info">Activate</button> 
                                
                            </div>
                        </div>
                        </form>
                        </div>';
                    }
                ?>

                
            <!-- no time ofr this
            <div class="col-6">
                <label for="activationcode" class="mb-1 mt-4">Don't have a bundle?</label><br>
                <a href="bundles.html" class="btn btn-info">Buy Bundles Here!</a> 
            </div> -->
            
        </div>
            </div>
        </div>
        
        </div>
        
        
        
        <footer></footer>
    </body>
</html>