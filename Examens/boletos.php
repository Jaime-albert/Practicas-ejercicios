<?php /* variables que voy a utilizar */
$nombre = $_POST['nombre'];
$funcion = $_POST['Funcion'];
$ninos = $_POST['ninos'];
$adultos = $_POST['adultos'];
$estudiantes = $_POST['estudiantes'];
$adulto_mayor =$_POST['adulto_mayor'];

switch ($funcion) { /* dependiendo de que funcion escojan abra un caso 
    se multiplican el total de personas dependiendo su edad por el precio del voleto
    */

    case 'Sala VIP':
        $ninos_total = $ninos * 75.00;
        $adultos_total = $adultos * 150.00;
        $estudiantes_total = $estudiantes *75.00;
        $adulto_mayor_total = $adulto_mayor *45.00;
        break;
    case 'Funcion IMAX':
        $ninos_total = $ninos * 50.00;
        $adultos_total = $adultos * 100.00;
        $estudiantes_total = $estudiantes *50.00;
        $adulto_mayor_total = $adulto_mayor *45.00;
        break;
    case 'Funcion 3D':
        $ninos_total = $ninos * 45.00;
        $adultos_total = $adultos * 75.00;
        $estudiantes_total = $estudiantes * 45.00;
        $adulto_mayor_total = $adulto_mayor * 15.00;
        break;
    case 'Funcion 2D':
        $ninos_total = $ninos * 30.00;
        $adultos_total = $adultos * 65.00;
        $estudiantes_total = $estudiantes * 30.00;
        $adulto_mayor_total = $adulto_mayor * 15.00;
        break;
};

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tiket</title>
</head>
<body>
    
    <center>

        <img src="cm.webp" alt="Logo Cine MX" width="80"><br><!-- logito del cine -->

        <table>
        <tr>
            <td>
                <h4>Tiked de la funcion </h4>
            </td>
        </tr>
        <tr>
            <td>
                Funcion: <?php echo $funcion ?><br><!-- se muestra la funcion -->

                Numero total de boletos:<?php echo $ninos + $estudiantes + $adultos + $adulto_mayor ?><br><!-- se calcula el total d boletos -->

                Boletos niños = <?php echo $ninos ?> total:<?php echo $ninos_total ?><br><!--se muestra el total de boletos de los ninos y su total-->

                Boletos adultos = <?php echo $adultos ?> total:<?php echo $adultos_total ?><br><!--se muestra el total de boletos de los adultos y su total-->

                Boletos estudiantes = <?php echo $estudiantes ?> total:<?php echo $estudiantes_total ?><br><!--se muestra el total de boletos de los estudiantes y su total-->
                
                Boletos adulto mayor = <?php echo $adulto_mayor ?> total:<?php echo $adulto_mayor_total ?><br><!--se muestra el total de boletos de los adultos mayores y su total-->
                <br>
                <?php $total = $ninos_total + $adultos_total + $estudiantes_total + $adulto_mayor_total; ?><!-- se muestra el total a pagar -->
                total a pagar: <?php echo $total; ?>


            </td>
        </tr>
    </table><br>
    <button onclick="window.print()" style="background-color: aliceblue; border: 0;">Imprimir</button><!--boton para inprimir se conecta con windous para inprimir -->
</body>
</html>