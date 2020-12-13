<div class="container position-relative bg-dark">
    <div class="row">
        <!-- logo -->
        <div class="col-3">
            <a href="index.html"><img src="./images/test.png" class="img-fluid mt-4 pt-3 img-opaque"></a>
        </div>
        
        <div class="col-9">
            <!-- login/sign up area -->
            <div class="col-12">
                <div class="pull-right">
                    <nav class="navbar navbar-expand navbar-dark">

                    <div>
                        

                        <ul class="containeded borderXwidth navbar-nav mr-auto mt-2 mt-lg-0">
                            
                        <?php
                              include('session.php');

                              if (isset($_SESSION['login_user']))
                              {
                                echo '
                                    <li class="nav-item">
                                    <a class="nav-link assigned" href="participant.php">' 
                                    . $retrieve_data[0]['FirstName'] . ' ' . $retrieve_data[0]['LastName'] . '</a>
                                    </li>';
                                echo '<li class="nav-item">
                                    <a class="nav-link assigned" href="logout.php">Logout</a>
                                    </li>';
                              }
                              else
                              {
                                echo '
                                    <li class="nav-item">
                                    <a class="nav-link assigned" href="login.html">Login</a>
                                    </li>';
                                echo '<li class="nav-item">
                                    <a class="nav-link assigned" href="signup.php">Sign Up</a>
                                    </li>';
                              }
                          ?>
                          
                        </ul>
                    </div>
                </nav>
                </div>
                
            </div>
            <!-- navigation bar -->
            <div class="col-12">
                <div class=" pull-right">
                    <nav class="navbar navbar-expand-md navbar-dark">
                        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"></span>
                        </button>

                    <div class="collapse navbar-collapse" id="collapsibleNavbar">
                        <a class ="navbar-brand"></a>
                        <ul class="circleBehind contained navbar-nav mr-auto mt-2 mt-lg-0 font">
                            <li class="nav-item">
                                <a class="nav-link" href="index.html">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="setting.html">Setting</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="events.html">Events</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="activities.html">Activities</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="camping.html">Camping</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="news.html">News</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="compinfo.html">Info</a>
                            </li>
                        </ul>
                    </div>
                </nav>
                </div>
                
            </div>
            
        </div>
    </div>
    
    
    
    
</div>