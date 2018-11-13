namespace projetHopital
{
    partial class AjouterMedicament
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblAjouterMedicament = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtSeuil = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(865, 442);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 48);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(715, 442);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 48);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblAjouterMedicament
            // 
            this.lblAjouterMedicament.AutoSize = true;
            this.lblAjouterMedicament.BackColor = System.Drawing.Color.Transparent;
            this.lblAjouterMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterMedicament.Location = new System.Drawing.Point(307, 9);
            this.lblAjouterMedicament.Name = "lblAjouterMedicament";
            this.lblAjouterMedicament.Size = new System.Drawing.Size(421, 42);
            this.lblAjouterMedicament.TabIndex = 7;
            this.lblAjouterMedicament.Text = "Ajouter un médicament";
            this.lblAjouterMedicament.Click += new System.EventHandler(this.lblAjouterMedicament_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(65, 118);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(99, 42);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nom";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(65, 230);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(167, 42);
            this.lblQuantite.TabIndex = 10;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.BackColor = System.Drawing.Color.Transparent;
            this.lblSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuil.Location = new System.Drawing.Point(65, 342);
            this.lblSeuil.Name = "lblSeuil";
            this.lblSeuil.Size = new System.Drawing.Size(106, 42);
            this.lblSeuil.TabIndex = 11;
            this.lblSeuil.Text = "Seuil";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(400, 442);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(180, 48);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.Location = new System.Drawing.Point(280, 237);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(150, 38);
            this.txtQuantite.TabIndex = 14;
            // 
            // txtSeuil
            // 
            this.txtSeuil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeuil.Location = new System.Drawing.Point(280, 349);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.Size = new System.Drawing.Size(150, 38);
            this.txtSeuil.TabIndex = 15;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(280, 125);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(382, 38);
            this.txtNom.TabIndex = 16;
            // 
            // AjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1020, 502);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtSeuil);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblSeuil);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAjouterMedicament);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnQuitter);
            this.Name = "AjouterMedicament";
            this.Text = "AjouterMedicament";
            this.Load += new System.EventHandler(this.AjouterMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblAjouterMedicament;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtSeuil;
        private System.Windows.Forms.TextBox txtNom;
    }
}