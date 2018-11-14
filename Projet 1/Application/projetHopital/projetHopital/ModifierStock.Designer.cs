namespace projetHopital
{
    partial class ModifierStock
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblModifications = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtQtte = new System.Windows.Forms.TextBox();
            this.txtSeuil = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(575, 418);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 48);
            this.btnRetour.TabIndex = 7;
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
            this.btnQuitter.Location = new System.Drawing.Point(737, 418);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 48);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblModifications
            // 
            this.lblModifications.AutoSize = true;
            this.lblModifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifications.Location = new System.Drawing.Point(181, 18);
            this.lblModifications.Name = "lblModifications";
            this.lblModifications.Size = new System.Drawing.Size(537, 42);
            this.lblModifications.TabIndex = 9;
            this.lblModifications.Text = "Modification d\'un médicament";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(59, 139);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(99, 42);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(20, 231);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(167, 42);
            this.lblQuantite.TabIndex = 13;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuil.Location = new System.Drawing.Point(52, 309);
            this.lblSeuil.Name = "lblSeuil";
            this.lblSeuil.Size = new System.Drawing.Size(106, 42);
            this.lblSeuil.TabIndex = 14;
            this.lblSeuil.Text = "Seuil";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(245, 152);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(205, 29);
            this.txtNom.TabIndex = 17;
            // 
            // txtQtte
            // 
            this.txtQtte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtte.Location = new System.Drawing.Point(245, 244);
            this.txtQtte.Name = "txtQtte";
            this.txtQtte.Size = new System.Drawing.Size(99, 29);
            this.txtQtte.TabIndex = 18;
            // 
            // txtSeuil
            // 
            this.txtSeuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeuil.Location = new System.Drawing.Point(245, 322);
            this.txtSeuil.Name = "txtSeuil";
            this.txtSeuil.Size = new System.Drawing.Size(99, 29);
            this.txtSeuil.TabIndex = 19;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.White;
            this.btnValider.Location = new System.Drawing.Point(295, 418);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(143, 48);
            this.btnValider.TabIndex = 20;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // ModifierStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 489);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtSeuil);
            this.Controls.Add(this.txtQtte);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSeuil);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblModifications);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetour);
            this.Name = "ModifierStock";
            this.Text = "ModifierStock";
            this.Load += new System.EventHandler(this.ModifierStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblModifications;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtQtte;
        private System.Windows.Forms.TextBox txtSeuil;
        private System.Windows.Forms.Button btnValider;
    }
}