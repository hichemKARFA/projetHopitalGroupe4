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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblActuel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblSeuil = new System.Windows.Forms.Label();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnValiderNum = new System.Windows.Forms.Button();
            this.btnValiderNom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(607, 549);
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
            this.btnQuitter.Location = new System.Drawing.Point(762, 549);
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
            this.lblModifications.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifications.Location = new System.Drawing.Point(181, 18);
            this.lblModifications.Name = "lblModifications";
            this.lblModifications.Size = new System.Drawing.Size(551, 38);
            this.lblModifications.TabIndex = 9;
            this.lblModifications.Text = "Modification d\'un médicament";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(34, 144);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(159, 38);
            this.lblNum.TabIndex = 10;
            this.lblNum.Text = "Numero";
            // 
            // lblActuel
            // 
            this.lblActuel.AutoSize = true;
            this.lblActuel.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuel.Location = new System.Drawing.Point(250, 95);
            this.lblActuel.Name = "lblActuel";
            this.lblActuel.Size = new System.Drawing.Size(130, 38);
            this.lblActuel.TabIndex = 11;
            this.lblActuel.Text = "Actuel";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(88, 245);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(101, 38);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Nom";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(34, 353);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(167, 38);
            this.lblQuantite.TabIndex = 13;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblSeuil
            // 
            this.lblSeuil.AutoSize = true;
            this.lblSeuil.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeuil.Location = new System.Drawing.Point(88, 458);
            this.lblSeuil.Name = "lblSeuil";
            this.lblSeuil.Size = new System.Drawing.Size(105, 38);
            this.lblSeuil.TabIndex = 14;
            this.lblSeuil.Text = "Seuil";
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouveau.Location = new System.Drawing.Point(523, 95);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(172, 38);
            this.lblNouveau.TabIndex = 15;
            this.lblNouveau.Text = "Nouveau";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(562, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 29);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(510, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 29);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(562, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 29);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(562, 467);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 29);
            this.textBox4.TabIndex = 19;
            // 
            // btnValiderNum
            // 
            this.btnValiderNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValiderNum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderNum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderNum.ForeColor = System.Drawing.Color.White;
            this.btnValiderNum.Location = new System.Drawing.Point(762, 152);
            this.btnValiderNum.Name = "btnValiderNum";
            this.btnValiderNum.Size = new System.Drawing.Size(138, 29);
            this.btnValiderNum.TabIndex = 20;
            this.btnValiderNum.Text = "Valider";
            this.btnValiderNum.UseVisualStyleBackColor = false;
            // 
            // btnValiderNom
            // 
            this.btnValiderNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValiderNom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderNom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderNom.ForeColor = System.Drawing.Color.White;
            this.btnValiderNom.Location = new System.Drawing.Point(762, 253);
            this.btnValiderNom.Name = "btnValiderNom";
            this.btnValiderNom.Size = new System.Drawing.Size(138, 29);
            this.btnValiderNom.TabIndex = 21;
            this.btnValiderNom.Text = "Valider";
            this.btnValiderNom.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(762, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(762, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ModifierStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValiderNom);
            this.Controls.Add(this.btnValiderNum);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNouveau);
            this.Controls.Add(this.lblSeuil);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblActuel);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblModifications);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRetour);
            this.Name = "ModifierStock";
            this.Text = "ModifierStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblModifications;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblActuel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnValiderNum;
        private System.Windows.Forms.Button btnValiderNom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}