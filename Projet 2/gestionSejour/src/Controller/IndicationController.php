<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;

class IndicationController extends AbstractController
{
    /**
     * @Route("/indication", name="indication")
     */
    public function index()
    {
        return $this->render('indication/index.html.twig', [
            'controller_name' => 'IndicationController',
        ]);
    }
}
