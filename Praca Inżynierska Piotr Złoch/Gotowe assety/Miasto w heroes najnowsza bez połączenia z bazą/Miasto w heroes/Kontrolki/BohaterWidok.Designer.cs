
namespace Miasto_w_heroes.Kontrolki
{
    partial class BohaterWidok
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BohaterObronaLabel = new System.Windows.Forms.Label();
            this.BohaterAtakLabel = new System.Windows.Forms.Label();
            this.BohaterPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BohaterPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // BohaterObronaLabel
            // 
            this.BohaterObronaLabel.AutoSize = true;
            this.BohaterObronaLabel.Location = new System.Drawing.Point(3, 116);
            this.BohaterObronaLabel.Name = "BohaterObronaLabel";
            this.BohaterObronaLabel.Size = new System.Drawing.Size(46, 13);
            this.BohaterObronaLabel.TabIndex = 7;
            this.BohaterObronaLabel.Text = "obrona :";
            // 
            // BohaterAtakLabel
            // 
            this.BohaterAtakLabel.AutoSize = true;
            this.BohaterAtakLabel.Location = new System.Drawing.Point(3, 103);
            this.BohaterAtakLabel.Name = "BohaterAtakLabel";
            this.BohaterAtakLabel.Size = new System.Drawing.Size(34, 13);
            this.BohaterAtakLabel.TabIndex = 6;
            this.BohaterAtakLabel.Text = "atak :";
            // 
            // BohaterPicturebox
            // 
            this.BohaterPicturebox.Location = new System.Drawing.Point(0, 0);
            this.BohaterPicturebox.Name = "BohaterPicturebox";
            this.BohaterPicturebox.Size = new System.Drawing.Size(100, 100);
            this.BohaterPicturebox.TabIndex = 5;
            this.BohaterPicturebox.TabStop = false;
            // 
            // BohaterWidok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BohaterObronaLabel);
            this.Controls.Add(this.BohaterAtakLabel);
            this.Controls.Add(this.BohaterPicturebox);
            this.Name = "BohaterWidok";
            this.Size = new System.Drawing.Size(101, 159);
            ((System.ComponentModel.ISupportInitialize)(this.BohaterPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BohaterObronaLabel;
        private System.Windows.Forms.Label BohaterAtakLabel;
        private System.Windows.Forms.PictureBox BohaterPicturebox;
    }
}
