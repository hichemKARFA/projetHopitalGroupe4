<?php

namespace App\Entity;

use Doctrine\Common\Collections\ArrayCollection;
use Doctrine\Common\Collections\Collection;
use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\TraitementRepository")
 */
class Traitement
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\Column(type="datetime", nullable=true)
     */
    private $Date;

    /**
     * @ORM\Column(type="integer", nullable=true)
     */
    private $duree;

    /**
     * @ORM\Column(type="string", length=255, nullable=true)
     */
    private $NomPatient;

    /**
     * @ORM\OneToMany(targetEntity="App\Entity\Indication", mappedBy="Traitement")
     */
    private $Indications;

    public function __construct()
    {
        $this->Indications = new ArrayCollection();
    }

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getDate(): ?\DateTimeInterface
    {
        return $this->Date;
    }

    public function setDate(?\DateTimeInterface $Date): self
    {
        $this->Date = $Date;

        return $this;
    }

    public function getDuree(): ?int
    {
        return $this->duree;
    }

    public function setDuree(?int $duree): self
    {
        $this->duree = $duree;

        return $this;
    }

    public function getNomPatient(): ?string
    {
        return $this->NomPatient;
    }

    public function setNomPatient(?string $NomPatient): self
    {
        $this->NomPatient = $NomPatient;

        return $this;
    }

    /**
     * @return Collection|Indication[]
     */
    public function getIndications(): Collection
    {
        return $this->Indications;
    }

    public function addIndication(Indication $indication): self
    {
        if (!$this->Indications->contains($indication)) {
            $this->Indications[] = $indication;
            $indication->setTraitement($this);
        }

        return $this;
    }

    public function removeIndication(Indication $indication): self
    {
        if ($this->Indications->contains($indication)) {
            $this->Indications->removeElement($indication);
            // set the owning side to null (unless already changed)
            if ($indication->getTraitement() === $this) {
                $indication->setTraitement(null);
            }
        }

        return $this;
    }
}
