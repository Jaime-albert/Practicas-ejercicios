<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {

    if ($_POST['usuario'] == 'admin' && $_POST['contra'] == 'admin'){
    header('location: central.html');
    exit();
    }
}
?>