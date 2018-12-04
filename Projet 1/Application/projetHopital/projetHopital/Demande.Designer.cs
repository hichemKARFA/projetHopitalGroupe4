namespace projetHopital
{
    partial class Demande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAjoutDemande = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.listeMedicaments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtQtte = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.listMedocDemande = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRetirer = new System.Windows.Forms.Button();
            this.lblMedicaments = new System.Windows.Forms.Label();
            this.lblCommande = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAjoutDemande
            // 
            this.lblAjoutDemande.AutoSize = true;
            this.lblAjoutDemande.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjoutDemande.Location = new System.Drawing.Point(419, 11);
            this.lblAjoutDemande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAjoutDemande.Name = "lblAjoutDemande";
            this.lblAjoutDemande.Size = new System.Drawing.Size(487, 54);
            this.lblAjoutDemande.TabIndex = 1;
            this.lblAjoutDemande.Text = "Ajouter une demande";
            this.lblAjoutDemande.Click += new System.EventHandler(this.lbldemandes_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1109, 681);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(191, 59);
            this.btnQuitter.TabIndex = 13;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // listeMedicaments
            // 
            this.listeMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listeMedicaments.FullRowSelect = true;
            this.listeMedicaments.Location = new System.Drawing.Point(49, 156);
            this.listeMedicaments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listeMedicaments.MultiSelect = false;
            this.listeMedicaments.Name = "listeMedicaments";
            this.listeMedicaments.Size = new System.Drawing.Size(559, 266);
            this.listeMedicaments.TabIndex = 14;
            this.listeMedicaments.UseCompatibleStateImageBehavior = false;
            this.listeMedicaments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 297;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectionner.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(216, 545);
            this.btnSelectionner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(172, 59);
            this.btnSelectionner.TabIndex = 15;
            this.btnSelectionner.Text = "Ajouter";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(89, 447);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(222, 54);
            this.lblQuantite.TabIndex = 16;
            this.lblQuantite.Text = "Quantité:";
            // 
            // txtQtte
            // 
            this.txtQtte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtte.Location = new System.Drawing.Point(381, 455);
            this.txtQtte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQtte.Name = "txtQtte";
            this.txtQtte.Size = new System.Drawing.Size(131, 46);
            this.txtQtte.TabIndex = 17;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(841, 545);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(413, 59);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Envoyer";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // listMedocDemande
            // 
            this.listMedocDemande.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listMedocDemande.FullRowSelect = true;
            this.listMedocDemande.Location = new System.Drawing.Point(740, 156);
            this.listMedocDemande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listMedocDemande.MultiSelect = false;
            this.listMedocDemande.Name = "listMedocDemande";
            this.listMedocDemande.Size = new System.Drawing.Size(559, 266);
            this.listMedocDemande.TabIndex = 21;
            this.listMedocDemande.UseCompatibleStateImageBehavior = false;
            this.listMedocDemande.View = System.Windows.Forms.View.Details;
            this.listMedocDemande.SelectedIndexChanged += new System.EventHandler(this.listMedocDemande_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numéro";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nom";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 194;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantité";
            this.columnHeader5.Width = 97;
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirer.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.ForeColor = System.Drawing.Color.White;
            this.btnRetirer.Location = new System.Drawing.Point(956, 447);
            this.btnRetirer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(172, 59);
            this.btnRetirer.TabIndex = 23;
            this.btnRetirer.Text = "Retirer";
            this.btnRetirer.UseVisualStyleBackColor = false;
            // 
            // lblMedicaments
            // 
            this.lblMedicaments.AutoSize = true;
            this.lblMedicaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicaments.Location = new System.Drawing.Point(196, 106);
            this.lblMedicaments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicaments.Name = "lblMedicaments";
            this.lblMedicaments.Size = new System.Drawing.Size(232, 25);
            this.lblMedicaments.TabIndex = 24;
            this.lblMedicaments.Text = "Liste des médicaments";
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(935, 106);
            this.lblCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(159, 25);
            this.lblCommande.TabIndex = 25;
            this.lblCommande.Text = "Votre demande";
            // 
            // Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 767);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.lblMedicaments);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.listMedocDemande);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtQtte);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.listeMedicaments);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblAjoutDemande);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Demande";
            this.Text = "Demande";
            this.Load += new System.EventHandler(this.Demande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutDemande;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListView listeMedicaments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.TextBox txtQtte;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ListView listMedocDemande;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Label lblMedicaments;
        private System.Windows.Forms.Label lblCommande;
    }
}