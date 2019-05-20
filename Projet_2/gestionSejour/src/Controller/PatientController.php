<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use App\Entity\Patient;
use App\Entity\Sejour;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\IntegerType;

class PatientController extends AbstractController
{
    /**
     * @Route("/index", name="index")
     */
    public function index()
    {
        return $this->render('index.html.twig');
    }

     /**
     * @Route("/listePatients", name="listePatients")
     */
	public function afficherPatients()
	{
		$repository=$this->getDoctrine()->getRepository(Patient::class);
		$lesPatients=$repository->findAll();
		return $this->render('patient/listePatients.html.twig',[
		'patients'=>$lesPatients,
		]);
		
	}

	/**
	* @Route("/supprimerPatient/{id}", name="supprimerPatient")
	*/
	public function supprimerPatient($id)
	{
		$repository=$this->getDoctrine()->getRepository(Patient::class);
		$patient=$repository->find($id);
		$em=$this->getDoctrine()->getManager();
		$em->remove($patient);
		$em->flush();
		return $this->render('patient/supprimerPatient.html.twig',[
		'patient'=>$patient,
		]);
	}

		/**
	* @Route("/sejoursPatient/{id}", name="sejoursPatient")
	*/
	public function sejoursPatient($id)
	{
		$em=$this->getDoctrine()->getManager();
		$repository=$this->getDoctrine()->getRepository(Patient::class);
		$patient=$repository->find($id);
		return $this->render('patient/sejoursPatient.html.twig',[
		'patient'=>$patient,
		]);
	}


	/**
	* @Route("/modifierPatient/{id}", name="modifierPatient")
	*/
	public function modifierPatient($id, Request $request)
	{
		$repository=$this->getDoctrine()->getRepository(Patient::class);
		$patient=$repository->find($id);		
		$form = $this->createFormBuilder($patient)
				->add('nom', TextType::class, array('label'=>'Nom du patient : '))
				->add('prenom', TextType::class, array('label'=>'Prénom : '))
				->add('age', IntegerType::class, array('label'=>'Âge : '))
				->add('adresse', TextType::class, array('label'=>'Adresse : '))
				->add('ville', TextType::class, array('label'=>'Ville : '))
				->add('cp', TextType::class, array('label'=>'Code Postal : '))
				->add('telephone', TextType::class, array('label'=>'Téléphone : '))
				->add('mail', TextType::class, array('label'=>'Adresse mail : '))

				->add('save', SubmitType::class, array('label'=>'Modifier le patient'))
				->getForm();
		
		
		$form->handleRequest($request);
		if($form->isSubmitted()&&$form->isValid())
		{
			$patient = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($patient);
			$em->flush();
			return $this->redirectToRoute('listePatients');
		}
		return $this->render('patient/modifierPatient.html.twig',array(
		'form'=>$form->createView(),
		));
	}

	/**
     * @Route("/ajouterPatient", name="ajouterPatient")
     */
	public function ajouterPatient(Request $request)
	{
		$Patient=new Patient();
		$form = $this->createFormBuilder($Patient)
				->add('nom', TextType::class, array('label'=>'Nom du patient : '))
				->add('prenom', TextType::class, array('label'=>'Prénom : '))
				->add('age', IntegerType::class, array('label'=>'Âge : '))
				->add('adresse', TextType::class, array('label'=>'Adresse : '))
				->add('ville', TextType::class, array('label'=>'Ville : '))
				->add('cp', TextType::class, array('label'=>'Code Postal : '))
				->add('telephone', TextType::class, array('label'=>'Téléphone : '))
				->add('mail', TextType::class, array('label'=>'Adresse mail : '))

				->add('save', SubmitType::class, array('label'=>'Créer le patient'))
				->getForm();
		
		
		$form->handleRequest($request);
		if($form->isSubmitted()&&$form->isValid())
		{
			$Patient = $form->getData();
			$em=$this->getDoctrine()->getManager();
			$em->persist($Patient);
			$em->flush();
			return $this->redirectToRoute('listePatients');
		}
		return $this->render('patient/ajouterPatient.html.twig',array(
		'form'=>$form->createView(),
		));
	}
}
