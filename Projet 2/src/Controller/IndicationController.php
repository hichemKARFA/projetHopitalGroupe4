<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Medicament;
use App\Entity\Indication;
use App\Entity\Traitement;

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
}
