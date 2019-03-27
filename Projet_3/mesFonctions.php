<?php

function getPDO()
{
     $unObjPDO=new PDO('mysql:host=localhost;dbname=gestionSejour','root','');
     return $unObjPDO;
}

function getPatients()
{
    $monObjPdoStatement=getPDO()->prepare("Select id, nom, prenom From patient");
    $okExecution=$monObjPdoStatement->execute();
    $lesLignesResultatDeLaRequete=$monObjPdoStatement->fetchAll(PDO::FETCH_ASSOC);
    return $lesLignesResultatDeLaRequete;
}

function getPatient($idPatient)
{
    $monObjPdoStatement=getPDO()->prepare("Select * From patient Where id=:idPatient");
    $monObjPdoStatement->bindValue(':idPatient', $idPatient);
    $okExecution=$monObjPdoStatement->execute();
    $lesLignesResultatDeLaRequete=$monObjPdoStatement->fetch(PDO::FETCH_ASSOC);
    return $lesLignesResultatDeLaRequete;
}

function setEtatEntree($idEtat, $idSejour)
{
    $monObjPdoStatement=getPDO()->prepare("Update sejour Set etatEntree=:idEtat Where id=:idSejour");
    $monObjPdoStatement->bindValue(':idEtat', $idEtat);
    $monObjPdoStatement->bindValue(':idSejour', $idSejour);
    $okExecution=$monObjPdoStatement->execute();
}

function setEtatSortie($idEtat, $idSejour)
{
    $monObjPdoStatement=getPDO()->prepare("Update sejour Set etatSortie=:idEtat Where id=:idSejour");
    $monObjPdoStatement->bindValue(':idEtat', $idEtat);
    $monObjPdoStatement->bindValue(':idSejour', $idSejour);
    $okExecution=$monObjPdoStatement->execute();
}

function setCommentaire($commentaire, $idSejour)
{
    $monObjPdoStatement=getPDO()->prepare("Update sejour Set commentaire=:commentaire Where id=:idSejour");
    $monObjPdoStatement->bindValue(':commentaire', $commentaire);
    $monObjPdoStatement->bindValue(':idSejour', $idSejour);
    $okExecution=$monObjPdoStatement->execute();
}


?>