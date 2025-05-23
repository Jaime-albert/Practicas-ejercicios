<?php
if ($_SERVER["REQUEST_METHOD"] == "GET") {

    $valor1 = $_GET["valor1"];
    $valor2 = $_GET["valor2"];

    $operacion = $_GET["operacion"];

    $resultado = 0;

    switch ($operacion) {

        case "suma":
            $resultado = $valor1 + $valor2;
            break;

        case "resta":
            $resultado = $valor1 - $valor2;
            break;

        case "division":
            if ($valor2 != 0) {
                $resultado = $valor1 / $valor2;
            } else {
                $resultado = "no se puede dividir entre cero";
            }
            break;

        case "multiplicacion":
            $resultado = $valor1 * $valor2;
            break;

        default:
            $resultado = "No se ingreso nada pipipi";

    }

    echo "<h2 style='text-align:center; font-family: Georgia, \"Times New Roman\", serif; color: #0078d7; background: #f0f4f8; padding: 1rem; border-radius: 10px;'>El resultado es : $resultado </h2>";
}
?>