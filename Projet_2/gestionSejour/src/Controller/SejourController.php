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
     * @Route("/sejour", name="sejour")
     */
    public function index()
    {
        return $this->render('sejour/index.html.twig', [
            'controller_name' => 'SejourController',
        ]);
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
	return $this->RedirectToRoute('sejour');
	}
	return $this->render('Sejour/formulaireSejour.html.twig', array(
			'form'=>$form->CreateView(),
			));  
    }
}
