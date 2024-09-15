
namespace Miasto_w_heroes.Kontrolki
{
    partial class BohaterArmia
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
            this.bohater_picturebox = new System.Windows.Forms.PictureBox();
            this.jednostkaKontrolka5 = new Miasto_w_heroes.Kontrolki.JednostkaKontrolka();
            this.jednostkaKontrolka4 = new Miasto_w_heroes.Kontrolki.JednostkaKontrolka();
            this.jednostkaKontrolka3 = new Miasto_w_heroes.Kontrolki.JednostkaKontrolka();
            this.jednostkaKontrolka2 = new Miasto_w_heroes.Kontrolki.JednostkaKontrolka();
            this.jednostkaKontrolka1 = new Miasto_w_heroes.Kontrolki.JednostkaKontrolka();
            ((System.ComponentModel.ISupportInitialize)(this.bohater_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // bohater_picturebox
            // 
            this.bohater_picturebox.Location = new System.Drawing.Point(20, 18);
            this.bohater_picturebox.Name = "bohater_picturebox";
            this.bohater_picturebox.Size = new System.Drawing.Size(100, 100);
            this.bohater_picturebox.TabIndex = 31;
            this.bohater_picturebox.TabStop = false;
            // 
            // jednostkaKontrolka5
            // 
            this.jednostkaKontrolka5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jednostkaKontrolka5.Jednostka = null;
            this.jednostkaKontrolka5.Location = new System.Drawing.Point(679, 3);
            this.jednostkaKontrolka5.Name = "jednostkaKontrolka5";
            this.jednostkaKontrolka5.Size = new System.Drawing.Size(130, 151);
            this.jednostkaKontrolka5.TabIndex = 36;
            this.jednostkaKontrolka5.Zaznaczenie = false;
            // 
            // jednostkaKontrolka4
            // 
            this.jednostkaKontrolka4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jednostkaKontrolka4.Jednostka = null;
            this.jednostkaKontrolka4.Location = new System.Drawing.Point(543, 3);
            this.jednostkaKontrolka4.Name = "jednostkaKontrolka4";
            this.jednostkaKontrolka4.Size = new System.Drawing.Size(130, 151);
            this.jednostkaKontrolka4.TabIndex = 35;
            this.jednostkaKontrolka4.Zaznaczenie = false;
            // 
            // jednostkaKontrolka3
            // 
            this.jednostkaKontrolka3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jednostkaKontrolka3.Jednostka = null;
            this.jednostkaKontrolka3.Location = new System.Drawing.Point(407, 3);
            this.jednostkaKontrolka3.Name = "jednostkaKontrolka3";
            this.jednostkaKontrolka3.Size = new System.Drawing.Size(130, 151);
            this.jednostkaKontrolka3.TabIndex = 34;
            this.jednostkaKontrolka3.Zaznaczenie = false;
            // 
            // jednostkaKontrolka2
            // 
            this.jednostkaKontrolka2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jednostkaKontrolka2.Jednostka = null;
            this.jednostkaKontrolka2.Location = new System.Drawing.Point(271, 3);
            this.jednostkaKontrolka2.Name = "jednostkaKontrolka2";
            this.jednostkaKontrolka2.Size = new System.Drawing.Size(130, 151);
            this.jednostkaKontrolka2.TabIndex = 33;
            this.jednostkaKontrolka2.Zaznaczenie = false;
            // 
            // jednostkaKontrolka1
            // 
            this.jednostkaKontrolka1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jednostkaKontrolka1.Jednostka = null;
            this.jednostkaKontrolka1.Location = new System.Drawing.Point(135, 3);
            this.jednostkaKontrolka1.Name = "jednostkaKontrolka1";
            this.jednostkaKontrolka1.Size = new System.Drawing.Size(130, 151);
            this.jednostkaKontrolka1.TabIndex = 32;
            this.jednostkaKontrolka1.Zaznaczenie = false;
            // 
            // BohaterArmia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jednostkaKontrolka5);
            this.Controls.Add(this.jednostkaKontrolka4);
            this.Controls.Add(this.jednostkaKontrolka3);
            this.Controls.Add(this.jednostkaKontrolka2);
            this.Controls.Add(this.jednostkaKontrolka1);
            this.Controls.Add(this.bohater_picturebox);
            this.Name = "BohaterArmia";
            this.Size = new System.Drawing.Size(823, 125);
            ((System.ComponentModel.ISupportInitialize)(this.bohater_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bohater_picturebox;
        private JednostkaKontrolka jednostkaKontrolka1;
        private JednostkaKontrolka jednostkaKontrolka2;
        private JednostkaKontrolka jednostkaKontrolka3;
        private JednostkaKontrolka jednostkaKontrolka4;
        private JednostkaKontrolka jednostkaKontrolka5;
    }
}
