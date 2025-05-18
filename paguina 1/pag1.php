<!DOCTYPE html>
<html>
<head>
<title>Mostrar Gato</title>
</head>
<body style="background-color: black;">

<?php
$gato = $_GET['gato'];//extraer la imagen la cual va a mostrar
echo "<center><img src='$gato'></center>";//muestra la imagen centrada en la pagina

$nombre = pathinfo($gato, PATHINFO_FILENAME);//pathinfo extrae informacion de la ruta o nombre del archivo
//PATHINFO_FILENAME le dice a pathinfo que devuelva solo el nombre del archivo sin la extensión (por ejemplo: sin el .jpg).

$nombreGato = ucwords(str_replace("_", " ", $nombre));//ucword convierte la primera letra de cada palabra a mayuscula
//str_replace("_", " ", $nombre) Reemplaza guiones bajos _ por espacios. Por ejemplo, convierte "gato_persa" en "gato persa"
echo "<h1 style='color:white; text-align:center;'>$nombreGato</h1>";//mostrar el nombre del gato

?>

</body>
</html> 