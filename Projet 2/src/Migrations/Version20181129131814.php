<?php declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20181129131814 extends AbstractMigration
{
    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('CREATE TABLE indication (id INT AUTO_INCREMENT NOT NULL, medicament_id INT DEFAULT NULL, traitement_id INT DEFAULT NULL, posologie VARCHAR(255) DEFAULT NULL, INDEX IDX_D15065D7AB0D61F7 (medicament_id), INDEX IDX_D15065D7DDA344B6 (traitement_id), PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('CREATE TABLE medicament (id INT AUTO_INCREMENT NOT NULL, libelle VARCHAR(255) DEFAULT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('CREATE TABLE traitement (id INT AUTO_INCREMENT NOT NULL, date DATETIME DEFAULT NULL, duree INT DEFAULT NULL, nom_patient VARCHAR(255) DEFAULT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('ALTER TABLE indication ADD CONSTRAINT FK_D15065D7AB0D61F7 FOREIGN KEY (medicament_id) REFERENCES medicament (id)');
        $this->addSql('ALTER TABLE indication ADD CONSTRAINT FK_D15065D7DDA344B6 FOREIGN KEY (traitement_id) REFERENCES traitement (id)');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE indication DROP FOREIGN KEY FK_D15065D7AB0D61F7');
        $this->addSql('ALTER TABLE indication DROP FOREIGN KEY FK_D15065D7DDA344B6');
        $this->addSql('DROP TABLE indication');
        $this->addSql('DROP TABLE medicament');
        $this->addSql('DROP TABLE traitement');
    }
}
