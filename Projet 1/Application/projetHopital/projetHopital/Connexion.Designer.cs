namespace projetHopital
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConnexion = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(143, 9);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(354, 42);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Gestion de l\'hopital";
            this.lblConnexion.Click += new System.EventHandler(this.lblHopital_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.BorderSize = 5;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(520, 323);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(142, 50);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(35, 111);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(189, 42);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.Location = new System.Drawing.Point(12, 189);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(255, 42);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de passe";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifiant.Location = new System.Drawing.Point(300, 111);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(336, 38);
            this.txtIdentifiant.TabIndex = 4;
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(300, 190);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(336, 38);
            this.txtMdp.TabIndex = 5;
            this.txtMdp.TextChanged += new System.EventHandler(this.txtMdp_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Lime;
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnValider.FlatAppearance.BorderSize = 5;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(246, 323);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(142, 50);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 385);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lblConnexion);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnValider;
    }
}

