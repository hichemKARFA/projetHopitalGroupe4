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
            this.lbldemandes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldemandes
            // 
            this.lbldemandes.AutoSize = true;
            this.lbldemandes.Font = new System.Drawing.Font("News Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldemandes.Location = new System.Drawing.Point(329, 26);
            this.lbldemandes.Name = "lbldemandes";
            this.lbldemandes.Size = new System.Drawing.Size(346, 38);
            this.lbldemandes.TabIndex = 1;
            this.lbldemandes.Text = "Gestion demandes";
            // 
            // Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 694);
            this.Controls.Add(this.lbldemandes);
            this.Name = "Demande";
            this.Text = "Demande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldemandes;
    }
}