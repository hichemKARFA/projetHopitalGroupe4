<?php

namespace App\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\IndicationRepository")
 */
class Indication
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\Column(type="string", length=255, nullable=true)
     */
    private $Posologie;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Medicament", inversedBy="indications")
     */
    private $Medicament;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Traitement", inversedBy="Indications")
     */
    private $Traitement;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getPosologie(): ?string
    {
        return $this->Posologie;
    }

    public function setPosologie(?string $Posologie): self
    {
        $this->Posologie = $Posologie;

        return $this;
    }

    public function getMedicament(): ?Medicament
    {
        return $this->Medicament;
    }

    public function setMedicament(?Medicament $Medicament): self
    {
        $this->Medicament = $Medicament;

        return $this;
    }

    public function getTraitement(): ?Traitement
    {
        return $this->Traitement;
    }

    public function setTraitement(?Traitement $Traitement): self
    {
        $this->Traitement = $Traitement;

        return $this;
    }
}
