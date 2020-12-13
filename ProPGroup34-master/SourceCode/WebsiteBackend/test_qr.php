<?php
    
    include('./lib/qrlib.php');
        
    $param = $_GET['id']; 
    // outputs image directly into browser, as PNG stream
    QRcode::png($param);
?>