<?php

echo "digite a sua distância em KM: ";
$distancia = (float) readline();

echo "digite o consumo do carro em (Km por litro): ";
$consumo_carro = (float) readline();

$litros_necessarios = number_format($distancia / $consumo_carro, 2);

echo "A quantidade de litros necessários são: $litros_necessarios \n";

echo "digite o preço do combustível: ";
$preco_combust = (float) readline();

$custo_total = number_format($litros_necessarios * $preco_combust, 2);

echo "O preço da viagem será: $custo_total"

?>