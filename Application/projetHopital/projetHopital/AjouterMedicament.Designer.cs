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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.txtSeuil = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(807, 629);
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
            this.btnRetour.Location = new System.Drawing.Point(641, 629);
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
            this.lblAjouterMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterMedicament.Location = new System.Drawing.Point(12, 26);
            this.lblAjouterMedicament.Name = "lblAjouterMedicament";
            this.lblAjouterMedicament.Size = new System.Drawing.Size(421, 42);
            this.lblAjouterMedicament.TabIndex = 7;
            this.lblAjouterMedicament.Text = "Ajouter un médicament";
            this.lblAjouterMedicament.Click += new System.EventHandler(this.lblAjouterMedicament_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(120, 143);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(161, 140);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 9;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(102, 176);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblQuantite.TabIndex = 10;
            this.lblQuantite.Text = "Quantité :";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(161, 173);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(100, 20);
            this.txtQuantite.TabIndex = 11;
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.Location = new System.Drawing.Point(119, 207);
            this.lblSeuil.Name = "lblSeuil";
            this.lblSeuil.Size = new System.Drawing.Size(36, 13);
            this.lblSeuil.TabIndex = 12;
            this.lblSeuil.Text = "Seuil :";
            // 
            // txtSeuil
            // 
            this.txtSeuil.Location = new System.Drawing.Point(161, 204);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.Size = new System.Drawing.Size(100, 20);
            this.txtSeuil.TabIndex = 13;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(145, 258);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // AjouterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 326);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtSeuil);
            this.Controls.Add(this.lblSeuil);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAjouterMedicament);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnQuitter);
            this.Name = "AjouterMedicament";
            this.Text = "AjouterMedicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblAjouterMedicament;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.TextBox txtSeuil;
        private System.Windows.Forms.Button btnAjouter;
    }
}