<?php
include_once 'mesFonctions.php';
$methode=$_SERVER["REQUEST_METHOD"];
switch ($methode)
{
    case "GET":
    if (!isset($_GET['id']))
    {
        $lesPatients=getPatients();
        $json=json_encode($lesPatients);
        echo ($json);       
    }
    else 
    {
        $unPatient=getPatient($_GET['id']);
        if($unPatient==false)
        {
            $message="Pas de patient avec cet identifiant";
            $json=json_encode($message);
        }
        else
        {
        $json=json_encode($unPatient);
        }
        echo($json);
    }
    break;
    
}
?>