
namespace Praca_Inżynierska_Piotr_Złoch.Kontrolki
{
    partial class JednostkaWidok
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
            this.JednostkaPictureBox = new System.Windows.Forms.PictureBox();
            this.LiczbaJednostekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JednostkaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // JednostkaPictureBox
            // 
            this.JednostkaPictureBox.Location = new System.Drawing.Point(4, 4);
            this.JednostkaPictureBox.Name = "JednostkaPictureBox";
            this.JednostkaPictureBox.Size = new System.Drawing.Size(100, 100);
            this.JednostkaPictureBox.TabIndex = 0;
            this.JednostkaPictureBox.TabStop = false;
            // 
            // LiczbaJednostekLabel
            // 
            this.LiczbaJednostekLabel.AutoSize = true;
            this.LiczbaJednostekLabel.Location = new System.Drawing.Point(91, 91);
            this.LiczbaJednostekLabel.Name = "LiczbaJednostekLabel";
            this.LiczbaJednostekLabel.Size = new System.Drawing.Size(13, 13);
            this.LiczbaJednostekLabel.TabIndex = 1;
            this.LiczbaJednostekLabel.Text = "0";
            // 
            // BohaterArmia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LiczbaJednostekLabel);
            this.Controls.Add(this.JednostkaPictureBox);
            this.Name = "BohaterArmia";
            this.Size = new System.Drawing.Size(109, 109);
            ((System.ComponentModel.ISupportInitialize)(this.JednostkaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JednostkaPictureBox;
        private System.Windows.Forms.Label LiczbaJednostekLabel;
    }
}
