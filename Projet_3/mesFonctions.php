<?php

function getPDO()
{
     $unObjPDO=new PDO('mysql:host=localhost;dbname=ppe_test','root','');
     return $unObjPDO;
}

function getPatients()
{
    $monObjPdoStatement=getPDO()->prepare("Select id, nom, prenom From patient");
    $okExecution=$monObjPdoStatement->execute();
    $lesLignesResultatDeLaRequete=$monObjPdoStatement->fetchAll(PDO::FETCH_ASSOC);
    return $lesLignesResultatDeLaRequete;
}

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