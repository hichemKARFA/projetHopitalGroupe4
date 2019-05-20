<?php

namespace App\Controller;

use App\Entity\Sejour;
use App\Entity\Patient;
use App\Entity\Lit;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Form\SejourType;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;
use Symfony\Component\HttpFoundation\Request;


class SejourController extends AbstractController
{
    /**
     * @Route("index", name="index")
     */
    public function index()
    {
        return $this->render('index.html.twig');
    }
	
	 /**
     * @Route("/ajouterSejour", name="ajouterSejour")
     */
	 public function ajouterSejour(Request $request)
    {
	$sejour=new Sejour();
	$form=$this->createForm(SejourType::class,$sejour);
    $form->handleRequest($request);
	if($form->isSubmitted()&&$form->isValid())
	{
	$sejour=$form->getData();
	$em=$this->getDoctrine()->getManager();
	$em->persist($sejour);
	$em->flush();
	return $this->RedirectToRoute('listeSejours');
	}
	return $this->render('sejour/ajouterSejour.html.twig', array(
			'form'=>$form->CreateView(),
			));  
    }
	
	
	  /**
     * @Route("/listeSejours", name="listeSejours")
     */
		public function afficherSejours()
	{
		$repository=$this->getDoctrine()->getRepository(Sejour::class);
		$lesSejours=$repository->findAll();
		return $this->render('sejour/listeSejours.html.twig',[
		'lesSejours'=>$lesSejours,
		]);
		
	}
	
	
	/**
	* @Route("/supprimerSejour/{id}", name="supprimerSejour")
	*/
	public function supprimerSejour($id)
	{
		$repository=$this->getDoctrine()->getRepository(Sejour::class);
		$Sejour=$repository->find($id);
		$em=$this->getDoctrine()->getManager();
		$em->remove($Sejour);
		$em->flush();
		return $this->render('sejour/supprimerSejour.html.twig',[
		'Sejour'=>$Sejour,
		]);
	}
	
	
	
	/**
     * @Route("/finSejour/{id}", name="finSejour")
     */
	public function finSejour($id, Request $request)
    {

		$repository=$this->getDoctrine()->getRepository(Sejour::class);
		$sejour=$repository->find($id);		
		$form = $this->createFormBuilder($sejour)
		->add('date_sortie' ,DateType::class, array('widget' => 'single_text',))
		->add('save',SubmitType::class,array('label'=>'valider'))
		->getForm();
	$form->handleRequest($request);
		
		
	if($form->isSubmitted()&&$form->isValid())
		{
			$sejour = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($sejour);
			$em->flush();
			return $this->redirectToRoute('listeSejours');
		}
	return $this->render('sejour/finSejour.html.twig',array(
	'form'=>$form->createView(),
	));
	}
	
	/**
	* @Route("/modifierSejour/{id}", name="modifierSejour")
	*/
	public function modifierSejour($id, Request $request)
	{
		$repository=$this->getDoctrine()->getRepository(Sejour::class);
		$sejour=$repository->find($id);		
		$form = $this->createFormBuilder($sejour)
				->add('patient',EntityType::class,array('class'=>Patient::class, //nom de lattribut dans la classe patient + nom de la classe
													  'choice_label'=>'libelle', 'label'=>'Patient : ')) //un get de la classe patient
			->add('lit',EntityType::class,array('class'=>Lit::class, //nom de la classe
													  'choice_label'=>'litchambre', 'label'=>'Lit : ')) //attribut a afficher
				->add('date_arrivee' ,DateType::class, array('widget' => 'single_text', 'label'=>"Date d'arrivée : "))
				->add('date_sortie' ,DateType::class, array('widget' => 'single_text', 'label'=>'Date de sortie : ', 'required'=>false))

				->add('save', SubmitType::class, array('label'=>'Modifier le séjour'))
				->getForm();
		
		
		$form->handleRequest($request);
		if($form->isSubmitted()&&$form->isValid())
		{
			$sejour = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($sejour);
			$em->flush();
			return $this->redirectToRoute('listeSejours');
		}
		return $this->render('sejour/modifierSejour.html.twig',array(
		'form'=>$form->createView(),
		));
	}
}