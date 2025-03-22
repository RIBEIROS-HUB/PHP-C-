<?php
$infos = "Informações: ";
$nome = "Lyss e Daniel";
$altura = "1,62 e 1,78";
$profissao = "Vendedor e Estagiário";
$cidade_nascimento = "Guarulhos";
$pais = "Brasil";
$ano_atual = 2025;
$ano_nascimento = 2006;
$ano_nascimento2 = 2003;
$idade = $ano_atual - $ano_nascimento;
$idade2 = $ano_atual - $ano_nascimento2;

$textinho = $infos . "
------------------------------------
Nomes: " . $nome . "
Alturas: " . $altura . "
Profissões: " . $profissao . "
Cidades de nascimento: " . $cidade_nascimento . "
País: " . $pais . "
Idades: " . $idade . " anos, e " . $idade2 . " anos.";

echo $textinho;

?>