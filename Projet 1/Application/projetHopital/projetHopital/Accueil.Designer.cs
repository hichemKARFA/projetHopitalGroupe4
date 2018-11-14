namespace projetHopital
{
    partial class Accueil
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
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnDemande = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblHopital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStock.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(188, 77);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(248, 77);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stocks";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCommande.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.Location = new System.Drawing.Point(188, 198);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(248, 77);
            this.btnCommande.TabIndex = 4;
            this.btnCommande.Text = "Commande";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnDemande
            // 
            this.btnDemande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDemande.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemande.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemande.ForeColor = System.Drawing.Color.White;
            this.btnDemande.Location = new System.Drawing.Point(188, 321);
            this.btnDemande.Name = "btnDemande";
            this.btnDemande.Size = new System.Drawing.Size(248, 77);
            this.btnDemande.TabIndex = 5;
            this.btnDemande.Text = "Demande";
            this.btnDemande.UseVisualStyleBackColor = false;
            this.btnDemande.Click += new System.EventHandler(this.btnDemande_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitter.FlatAppearance.BorderSize = 5;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(487, 416);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(142, 50);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // lblHopital
            // 
            this.lblHopital.AutoSize = true;
            this.lblHopital.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHopital.Location = new System.Drawing.Point(138, 9);
            this.lblHopital.Name = "lblHopital";
            this.lblHopital.Size = new System.Drawing.Size(361, 38);
            this.lblHopital.TabIndex = 7;
            this.lblHopital.Text = "Gestion de l\'hopital";
            this.lblHopital.Click += new System.EventHandler(this.lblHopital_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 478);
            this.Controls.Add(this.lblHopital);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDemande);
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.btnStock);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnDemande;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblHopital;
    }
}