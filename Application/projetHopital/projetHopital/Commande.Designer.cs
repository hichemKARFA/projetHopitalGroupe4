namespace projetHopital
{
    partial class Commande
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
            this.lblCommande = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numéro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Médicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.Infirmier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQuantité = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(335, 9);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(429, 38);
            this.lblCommande.TabIndex = 10;
            this.lblCommande.Text = "Ajouter une commande";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(689, 547);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 48);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(857, 547);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 48);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numéro,
            this.Médicament,
            this.Quantité,
            this.Etat,
            this.Infirmier});
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 358);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Numéro
            // 
            this.Numéro.Text = "Numéro";
            this.Numéro.Width = 108;
            // 
            // Médicament
            // 
            this.Médicament.Text = "Médicament";
            this.Médicament.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Médicament.Width = 220;
            // 
            // Quantité
            // 
            this.Quantité.Text = "Quantité";
            this.Quantité.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantité.Width = 88;
            // 
            // Etat
            // 
            this.Etat.Text = "Etat";
            this.Etat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Etat.Width = 124;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(609, 449);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(143, 48);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectionner.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(790, 206);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(189, 48);
            this.btnSelectionner.TabIndex = 15;
            this.btnSelectionner.Text = "Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            // 
            // Infirmier
            // 
            this.Infirmier.Text = "Infirmier";
            this.Infirmier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Infirmier.Width = 196;
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantité.Location = new System.Drawing.Point(221, 454);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(192, 38);
            this.lblQuantité.TabIndex = 16;
            this.lblQuantité.Text = "Quantité :";
            // 
            // txtQuantite
            // 
            this.txtQuantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.Location = new System.Drawing.Point(452, 454);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(117, 38);
            this.txtQuantite.TabIndex = 18;
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 607);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantité);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblCommande);
            this.Name = "Commande";
            this.Text = "Commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numéro;
        private System.Windows.Forms.ColumnHeader Médicament;
        private System.Windows.Forms.ColumnHeader Quantité;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.ColumnHeader Infirmier;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.TextBox txtQuantite;
    }
}