<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Medicament;
class MedicamentController extends AbstractController
{
    /**
     * @Route("/medicaments", name="medicaments")
     */
    public function geMedicaments()
    {
	
		$repository=$this->getDoctrine()->getRepository(Medicament::class);	
		$lesMedicaments=$repository->findAll(); 
        return $this->render('medicament/index.html.twig',[
			'medicaments'=>$lesMedicaments,]);
    }
}


