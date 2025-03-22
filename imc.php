<?php
echo "digite seu peso: ";
$peso = (float) readline();

echo "digite sua altura: ";
$altura = (float) readline();

$imc = $peso / ($altura * $altura);

echo "Seu IMC é igual a: $imc";

?>