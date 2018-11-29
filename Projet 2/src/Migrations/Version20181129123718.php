<?php declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20181129123718 extends AbstractMigration
{
    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE indication ADD traitement_id INT DEFAULT NULL');
        $this->addSql('ALTER TABLE indication ADD CONSTRAINT FK_D15065D7DDA344B6 FOREIGN KEY (traitement_id) REFERENCES traitement (id)');
        $this->addSql('CREATE INDEX IDX_D15065D7DDA344B6 ON indication (traitement_id)');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE indication DROP FOREIGN KEY FK_D15065D7DDA344B6');
        $this->addSql('DROP INDEX IDX_D15065D7DDA344B6 ON indication');
        $this->addSql('ALTER TABLE indication DROP traitement_id');
    }
}
