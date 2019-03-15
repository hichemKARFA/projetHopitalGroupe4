<?php
include_once 'mesFonctions.php';
$lesPatients=getPatients();
$json=json_encode($lesPatients);
var_dump(json_decode($json));
?>