<?php
    include('camp_process.php');
?>
<!DOCTYPE html>
<html>

    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"> 		
        <link rel="stylesheet" href="./css/bootstrap.min.css">
        <link rel="stylesheet" href="./js/bootstrap.bundle.min.js">
        <!link rel="stylesheet" href="./css/styles_talia.css">
        <link rel="stylesheet" href="./css/styles.css">
        <title>Camping Registration</title>
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
        
        <div class="container">

            <h2 class="mt-5 mb-4">Camping Registration</h2>
                    
            <span>Choose a spot:</span>

            <div class="row">
                <div class="col-9">
                    <img src="./images/CampingMap.png" class="img-fluid">
                </div>

                <div class="col-3">
                    <form id="campingRegForm" action="camp_process.php" method="post">
                        <!-- no time for this 
                        <h3 class="mb-3">With Bundles</h3>
                        <div class="mb-5">
                            <label for="activationcode" class="mb-1">Enter bundle code:</label><br>
                            <input type="text" placeholder="Enter Code" name="activationcode" class="mb-2 form-control">
                            <button type="submit" class="btn btn-info">Activate Code</button>
                        </div>-->
                            
                        <h3 class="">Registration</h3>
                        <div class="">
                            <div class="">
                                <label for="persons" class="mb-1">Camping spot:</label>    
                            </div>

                            <div  class="mb-4">
                                <select name="campingSpot">
                                    <?php
                                    foreach ($conn->query($spot_sql) as $results)
                                    {
                                        echo '<option value="'. $results["SpotNr"] .'">' . $results["SpotName"] . '</option>';
                                    }?>
                                </select>
                            </div>


                            <div class="">
                                <label for="persons" class="mb-1">How many persons?</label>    
                            </div>

                            <div  class="mb-4">
                                <select name="campers">
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                    <option value="4">4</option>
                                    <option value="5">5</option>
                                    <option value="6">6</option>
                                </select>
                            </div>

                            <div class="">
                                <label class="mb-1">Start Date: </label>    
                            </div>

                            <div  class="mb-4">
                                <input class="" type="date" name="startDate">
                            </div>

                            <div class="">
                                <label class="mb-1">End Date: </label>    
                            </div>

                            <div  class="mb-4">
                                <input class="" type="date" name="endDate">
                            </div>
                        </div>


                        <label class="mb-1">How will you pay?</label>

                        <div class="mb-3">
                            <input type="radio" name="payment" value="ideal"> iDeal<br>
                            <input type="radio" name="payment" value="paypal"> PayPal<br>
                            <input type="radio" name="payment" value="ipay"> iPay<br>
                            <input type="radio" name="payment" value="entrance"> At the entrance<br>
                        </div>
                        
                        <div class="">
                            <button type="submit" class="btn btn-info" >Register Campsite</button>
                        </div>
                        
                    </form> 
                </div>
                
            </div>
            
        </div>
        <footer></footer>
    </body>
</html>
