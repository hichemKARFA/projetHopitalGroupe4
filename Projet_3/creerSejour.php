<?php
include_once 'mesFonctions.php';
$tableau=array('25-02-2019',2,4);
$json= json_encode($tableau);
$sejour= json_decode($json);
creerSejour($sejour[0], $sejour[1],$sejour[2])


?>