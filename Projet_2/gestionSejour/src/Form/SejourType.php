<?php

namespace App\Form;

use App\Entity\Sejour;
use App\Entity\Lit;
use App\Entity\Patient;
use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;
use Symfony\Component\Form\Extension\Core\Type\DateType;

class SejourType extends AbstractType
{
    public function buildForm(FormBuilderInterface $builder, array $options)
    {
        $builder
            ->add('dateArrivee',DateType::class, array(
              'widget' => 'single_text',))
			->add('patient',EntityType::class,array('class'=>Patient::class, //nom de lattribut dans la classe patient + nom de la classe
													  'choice_label'=>'libelle')) //un get de la classe patient
			->add('lit',EntityType::class,array('class'=>Lit::class, //nom de la classe
													  'choice_label'=>'litchambre')) //attribut a afficher
			->add('save',SubmitType::class,array('label'=>'valider'))
        ;
    }

    public function configureOptions(OptionsResolver $resolver)
    {
        $resolver->setDefaults([
            'data_class' => Sejour::class,
        ]);
    }
}
