namespace projetHopital
{
    partial class gestionDemandes
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Numéro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Médicament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Etat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Infirmier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCommande = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.btnRefuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numéro,
            this.Médicament,
            this.Quantité,
            this.Etat,
            this.Infirmier});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(144, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(740, 358);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // Infirmier
            // 
            this.Infirmier.Text = "Infirmier";
            this.Infirmier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Infirmier.Width = 196;
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(350, 9);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(348, 42);
            this.lblCommande.TabIndex = 15;
            this.lblCommande.Text = "Gestion demandes";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(696, 556);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(143, 48);
            this.btnRetour.TabIndex = 16;
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
            this.btnQuitter.Location = new System.Drawing.Point(858, 556);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 48);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAccepter
            // 
            this.btnAccepter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAccepter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccepter.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccepter.ForeColor = System.Drawing.Color.White;
            this.btnAccepter.Location = new System.Drawing.Point(343, 456);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(143, 48);
            this.btnAccepter.TabIndex = 18;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = false;
            // 
            // btnRefuser
            // 
            this.btnRefuser.BackColor = System.Drawing.Color.Red;
            this.btnRefuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefuser.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefuser.ForeColor = System.Drawing.Color.White;
            this.btnRefuser.Location = new System.Drawing.Point(542, 456);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(143, 48);
            this.btnRefuser.TabIndex = 19;
            this.btnRefuser.Text = "Refuser";
            this.btnRefuser.UseVisualStyleBackColor = false;
            // 
            // gestionDemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 616);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.listView1);
            this.Name = "gestionDemandes";
            this.Text = "gestionDemandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Numéro;
        private System.Windows.Forms.ColumnHeader Médicament;
        private System.Windows.Forms.ColumnHeader Quantité;
        private System.Windows.Forms.ColumnHeader Etat;
        private System.Windows.Forms.ColumnHeader Infirmier;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Button btnRefuser;
    }
}