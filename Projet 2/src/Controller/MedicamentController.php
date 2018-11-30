<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Medicament;
use Symfony\Component\HttpFoundation\Request;
use App\Form\MedicamentType;
class MedicamentController extends AbstractController
{
    /**
     * @Route("/afficherMedicaments", name="medicaments")
     */
    public function getMedicaments()
    {
	
		$repository=$this->getDoctrine()->getRepository(Medicament::class);	
		$lesMedicaments=$repository->findAll(); 
        return $this->render('medicament/index.html.twig',[
			'medicaments'=>$lesMedicaments,]);
    }
	
	
	/**
     * @Route("/medicaments/inscription", name="inscription")  
     */
	public function ajouterMedicament(Request $request) // ici la route medicament/inscription ne peut pas marcher car /medicament/{id}  ici le {id} est une variable
	{
		$medicament=new Medicament(); // je crée un medicament
		$form=$this->createForm(MedicamentType::class,$medicament); // je crée un formulaire les données seront plus tard enregistrée dans l'objet medicament
		$form->handleRequest($request);// recupere les infos saisie par l'utilisateur 
		if($form->isSubmitted() && $form->isValid())
		{
			$medicament=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($medicament);
			$em->flush(); 
			return $this->redirectToRoute('medicaments');
		}
		return $this->render('medicament/inscription.html.twig',array('form'=>$form->createView(),));	
	}
	
	/**
     * @Route("/medicament/{id}", name="medicament")
     */
	public function medicament($id) /* affiche medicament avec l'url donné */
	{
		$repository=$this->getDoctrine()->getRepository(Medicament::class);
		$unMedicament=$repository->find($id); 
		
		return $this->render('medicament/medicament.html.twig',['lmedicament'=>$unMedicament,]);

    }
	
	
	/**
     * @Route("/medicaments/modifMedicament/{id}", name="modifMedicament")  
     */
	public function modifMedicament($id,Request $request) 
	{
		$repository=$this->getDoctrine()->getRepository(Medicament::class);
		$unMedicament=$repository->find($id); 
		$form=$this->createForm(MedicamentType::class,$unMedicament);
		$form->handleRequest($request);
		if($form->isSubmitted() && $form->isValid())
		{
			$unMedicament=$form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($unMedicament);
			$em->flush(); 
			return $this->redirectToRoute('medicaments');
		}
		
		return $this->render('medicament/modification.html.twig',array('form'=>$form->createView(),));	

    }
	
		/**
     * @Route("/medicaments/supprimerMedicament/{id}", name="supprimerMedicament")  
     */
	public function modifierMedicament($id) 
	{
		$repository=$this->getDoctrine()->getRepository(Medicament::class);
		$unMedicament=$repository->find($id); 
		if($unMedicament!=null)
		{
			$em=$this->getDoctrine()->getManager();
			$em->remove($unMedicament);
			$em->flush(); 
			return $this->redirectToRoute('medicaments');
		}
		return $this->render('medicament/suppression.html.twig');	
    }
}


