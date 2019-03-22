<?php

namespace App\Entity;

use Doctrine\Common\Collections\ArrayCollection;
use Doctrine\Common\Collections\Collection;
use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\LitRepository")
 */
class Lit
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\OneToMany(targetEntity="App\Entity\Sejour", mappedBy="lit")
     */
    private $sejours;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Chambre", inversedBy="lits")
     */
    private $chambre;

    public function __construct()
    {
        $this->sejours = new ArrayCollection();
    }

    public function getId(): ?int
    {
        return $this->id;
    }

    /**
     * @return Collection|Sejour[]
     */
    public function getSejours(): Collection
    {
        return $this->sejours;
    }

    public function addSejour(Sejour $sejour): self
    {
        if (!$this->sejours->contains($sejour)) {
            $this->sejours[] = $sejour;
            $sejour->setLit($this);
        }

        return $this;
    }

    public function removeSejour(Sejour $sejour): self
    {
        if ($this->sejours->contains($sejour)) {
            $this->sejours->removeElement($sejour);
            // set the owning side to null (unless already changed)
            if ($sejour->getLit() === $this) {
                $sejour->setLit(null);
            }
        }

        return $this;
    }

    public function getChambre(): ?Chambre
    {
        return $this->chambre;
    }
	
	 public function getlitchambre(): ?string
    {
        return $this->chambre->getService()->getLibelle().' - Chambre '.$this->chambre->getId().' - Lit '.$this->id;
    }

    public function setChambre(?Chambre $chambre): self
    {
        $this->chambre = $chambre;

        return $this;
    }
}
