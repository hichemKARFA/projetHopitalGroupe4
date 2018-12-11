<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Form\SejourType;

class SejourController extends AbstractController
{
    /**
     * @Route("/sejour", name="sejour")
     */
    public function index()
    {
        return $this->render('sejour/index.html.twig', [
            'controller_name' => 'SejourController',
        ]);
    }
	/**
     * @Route("/afficherSejours", name="afficherSejours")
     */
	public function afficherSejours()
    {
        $repository=$this->getDoctrine()->getRepository(Sejour::class);
		$lesSejours=$repository->findAll();
		return $this->render('sejour/afficherSejours.html.twig',['indications'=>$lesSejours,]);
    }
	
	/**
     * @Route("/ajouterSejour", name="ajouterSejour")  
     */
	public function ajouterSejour(Request $request)
	{
		$Sejour = new Sejour();
		$form=$this->createForm(IndicationType::class,$Sejour);
		$form->handleRequest($request);
		if($form->isSubmitted() && $form->isValid())
		{
			$Sejour=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($Sejour);
			$em->flush(); 
			return $this->redirectToRoute('sejour');
		}
		return $this->render('sejour/ajouterSejour.html.twig',array('form'=>$form->createView(),));
	}
	
	/**
     * @Route("/modifierSejour{id}", name="modifierSejour")  
     */
	public function modifierSejour($id,Request $request) 
	{
		$repository=$this->getDoctrine()->getRepository(Indication::class);
		$Sejour=$repository->find($id); 
		$form=$this->createForm(IndicationType::class,$Sejour);
		$form->handleRequest($request);
		if($form->isSubmitted() && $form->isValid())
		{
			$Sejour=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($Sejour);
			$em->flush(); 
			return $this->redirectToRoute('sejour');
		}
		
		return $this->render('sejour/modification.html.twig',array('form'=>$form->createView(),));	

    }
	/**
     * @Route("/supprimerSejour/{id}", name="supprimerSejour")  
     */
	public function supprimerSejour($id) 
	{
		$repository=$this->getDoctrine()->getRepository(Indication::class);
		$Sejour=$repository->find($id); 
		if($Sejour!=null)
		{
			$em=$this->getDoctrine()->getManager();
			$em->remove($Sejour);
			$em->flush(); 
			return $this->redirectToRoute('sejour');
		}
		return $this->render('sejour/suppression.html.twig');	
    }
}
