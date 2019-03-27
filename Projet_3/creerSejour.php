<?php
include_once 'mesFonctions.php';
$tableau=array('2019-03-19',2,4);
$json= json_encode($tableau);
$sejour= json_decode($json);
creerSejour($sejour[0], $sejour[1],$sejour[2]);



/*A AJOUTER DANS mesFonctions.php : */
    
function creerSejour($dateArrivee,$idPatient,$idLit)
{
    $idSejour= attribuerIdMaxSejour();
    $monObjPdoStatement=getPDO()->prepare("Insert into sejour values (:idSejour,:dateArrivee ,null,:idPatient,:idLit)");
    $monObjPdoStatement->bindValue(':idSejour', $idSejour);
    $monObjPdoStatement->bindValue(':dateArrivee', $dateArrivee);
    $monObjPdoStatement->bindValue(':idPatient', $idPatient);
    $monObjPdoStatement->bindValue(':idLit', $idLit);
    $okExecution=$monObjPdoStatement->execute();
}

function attribuerIdMaxSejour()
{
   $id=1;
   $monObjPdoStatement=getPDO()->prepare("Select Count(id) From sejour");
   $okExecution=$monObjPdoStatement->execute();
   $lesLignesResultatDeLaRequete=$monObjPdoStatement->fetch(PDO::FETCH_ASSOC);
   if($lesLignesResultatDeLaRequete['Count(id)']!=0)
   {
       $monObjPdoStatement=getPDO()->prepare("Select Max(id) From sejour");
       $okExecution=$monObjPdoStatement->execute();
       $lesLignesResultatDeLaRequete=$monObjPdoStatement->fetch(PDO::FETCH_ASSOC);
       $id=$lesLignesResultatDeLaRequete['Max(id)']+1;
   }
   return $id;
}
?>