<?php

namespace App\Controller;

use App\Entity\Sejour;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Form\SejourType;
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
     * @Route("/ajoutSejour", name="ajoutSejour")
     */
	 public function creationSejour(Request $request)
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
	return $this->RedirectToRoute('index');
	}
	return $this->render('sejour/formulaireSejour.html.twig', array(
			'form'=>$form->CreateView(),
			));  
    }
	
	
	  /**
     * @Route("/listesejours", name="sejourListeSejours")
     */
		public function afficherSejour()
	{
		$repository=$this->getDoctrine()->getRepository(Sejour::class);
		$lesSejours=$repository->findAll();
		return $this->render('sejour/liste_Sejour.html.twig',[
		'lesSejours'=>$lesSejours,
		]);
		
	}
<<<<<<< HEAD
=======
	
	/**
     * @Route("/finSejour", name="finSejour")
     */
	public function finSejour(Request $request)
    {
	$em=$this->getDoctrine()->getManager();
	$repository=$this->getDoctrine()->getRepository(Sejour::class);
	$lesSejours=$repository->findAll();
	return $this->render('sejour/finSejour.html.twig',[
		'lesSejours'=>$lesSejours,
		]);
    }
>>>>>>> c7da927cab19448e2296908911c0451766d61642
}
