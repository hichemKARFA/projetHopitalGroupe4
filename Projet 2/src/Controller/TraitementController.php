<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Traitement;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\IntegerType;
use Symfony\Component\HttpFoundation\Request;

class TraitementController extends AbstractController
{
    /**
     * @Route("/traitement", name="traitement")
     */
    public function index()
    {
        return $this->render('traitement/index.html.twig', [
            'controller_name' => 'TraitementController',
        ]);
    }
	/**
     * @Route("/traitements", name="traitements")
     */
	public function getTraitements()
	{
		$repository=$this->getDoctrine()->getRepository(Traitement::class);
		$lesTraitements=$repository->findAll();
		return $this->render('traitement/liste_traitements.html.twig',[
		'traitements'=>$lesTraitements,
		]);
		
	}
	
	/**
     * @Route("/ajouterTraitement", name="ajouterTraitement")
     */
	public function ajouterTraitement(Request $request)
	{
		$em=$this->getDoctrine()->getManager();
		$traitement=new Traitement();
		$form = $this->createFormBuilder($traitement)
				->add('date', DateType::class, array('label'=>'Date de début : '))
				
				->add('duree',IntegerType::class , array('label'=>'Durée : '))
				->add('nom_patient',TextType::class , array('label'=>'Nom du patient : '))
				->add('save', SubmitType::class, array('label'=>'ajouter un traitement'))
				->getForm();
		
		
		$form->handleRequest($request);
		if($form->isSubmitted()&&$form->isValid())
		{
			$adherent = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($traitement);
			$em->flush();
			return $this->redirectToRoute('traitements');
		}
		return $this->render('traitement/ajouterTraitement.html.twig',array(
		'form'=>$form->createView(),
		));
	}
	/**
	* @Route("modificationTraitement/{id}", name="modificationTraitement")
	*/
	public function modification($id, Request $request)
	{
		$em=$this->getDoctrine()->getManager();
		$repository=$this->getDoctrine()->getRepository(Traitement::class);
		$traitement=$repository->find($id);
		$em=$this->getDoctrine()->getManager();
		
		$form = $this->createFormBuilder($traitement)
				->add('date', DateType::class, array('label'=>'Date de début : '))
				
				->add('duree',IntegerType::class , array('label'=>'Durée : '))
				->add('nom_patient',TextType::class , array('label'=>'Nom du patient : '))
				->add('save', SubmitType::class, array('label'=>'Modifier le traitement'))
				->getForm();
		
		
		$form->handleRequest($request);
		if($form->isSubmitted()&&$form->isValid())
		{
			$traitement = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($traitement);
			$em->flush();
			return $this->redirectToRoute('traitements');
		}
		return $this->render('traitement/modification.html.twig',array(
		'form'=>$form->createView(),
		));
	}
	
	/**
	* @Route("suppressionTraitement/{id}", name="suppressionTraitement")
	*/
	public function suppression($id)
	{
		$repository=$this->getDoctrine()->getRepository(Traitement::class);
		$traitement=$repository->find($id);
		$em=$this->getDoctrine()->getManager();
		$em->remove($traitement);
		$em->flush();
		return $this->render('traitement/suppression.html.twig',[
		'traitement'=>$traitement,
		]);
	}
}

