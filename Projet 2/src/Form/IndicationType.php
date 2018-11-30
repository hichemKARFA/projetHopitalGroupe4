<?php

namespace App\Form;


use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;
use App\Entity\Medicament;
use App\Entity\Indication;
use App\Entity\Traitement;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;

class IndicationType extends AbstractType
{
    public function buildForm(FormBuilderInterface $builder, array $options)
    {
        $builder
            ->add('Posologie')
			->add('Medicament',EntityType::class,array('class'=>Medicament::class, //nom de la classe
													  'choice_label'=>'libelle')) //attribut a afficher
			->add('Traitement',EntityType::class,array('class'=>Traitement::class, //nom de la classe
													  'choice_label'=>'id')) //attribut a afficher
			->add('Enregistrer',SubmitType::class)
        ;
    }

    public function configureOptions(OptionsResolver $resolver)
    {
        $resolver->setDefaults([
            'data_class' => Indication::class,
        ]);
    }
}
