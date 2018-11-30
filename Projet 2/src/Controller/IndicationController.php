<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Medicament;
use App\Entity\Indication;
use App\Entity\Traitement;
use App\Form\IndicationType;
use Symfony\Component\HttpFoundation\Request;

class IndicationController extends AbstractController
{
    /**
     * @Route("/indication", name="indication")
     */
    public function getIndications()
    {
       $repository=$this->getDoctrine()->getRepository(Indication::class);
		$lesIndications=$repository->findAll();
		return $this->render('indication/index.html.twig',['indications'=>$lesIndications,]);
    }
	
	/**
     * @Route("/indications/ajouter", name="ajouterIndication")  
     */
	public function ajouterIndication(Request $request) // ici la route medicament/inscription ne peut pas marcher car /medicament/{id}  ici le {id} est une variable
	{
		$indication=new Indication(); // je crée un medicament
		$form=$this->createForm(IndicationType::class,$indication); // je crée un formulaire les données seront plus tard enregistrée dans l'objet medicament
		$form->handleRequest($request);// recupere les infos saisie par l'utilisateur 
		if($form->isSubmitted() && $form->isValid())
		{
			$indication=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($indication);
			$em->flush(); 
			return $this->redirectToRoute('indication');
		}
		return $this->render('indication/inscription.html.twig',array('form'=>$form->createView(),));
	}
	/**
     * @Route("/indication/{id}", name="indicationID")
     */
	public function getIdIndication($id) 
	{
		$repository=$this->getDoctrine()->getRepository(Indication::class);
		$uneIndication=$repository->find($id); 
		
		return $this->render('indication/indicationID.html.twig',['lindication'=>$uneIndication,]);

    }
	/**
     * @Route("/indications/modifIndication/{id}", name="modifIndication")  
     */
	public function modifIndication($id,Request $request) 
	{
		$repository=$this->getDoctrine()->getRepository(Indication::class);
		$uneIndication=$repository->find($id); 
		$form=$this->createForm(IndicationType::class,$uneIndication);
		$form->handleRequest($request);
		if($form->isSubmitted() && $form->isValid())
		{
			$uneIndication=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($uneIndication);
			$em->flush(); 
			return $this->redirectToRoute('indication');
		}
		
		return $this->render('indication/modification.html.twig',array('form'=>$form->createView(),));	

    }
	/**
     * @Route("/medicaments/supprimerIndication/{id}", name="supprimerIndication")  
     */
	public function supprimerIndication($id) 
	{
		$repository=$this->getDoctrine()->getRepository(Indication::class);
		$uneIndication=$repository->find($id); 
		if($uneIndication!=null)
		{
			$em=$this->getDoctrine()->getManager();
			$em->remove($uneIndication);
			$em->flush(); 
			return $this->redirectToRoute('indication');
		}
		return $this->render('indication/suppression.html.twig');	
    }
}
