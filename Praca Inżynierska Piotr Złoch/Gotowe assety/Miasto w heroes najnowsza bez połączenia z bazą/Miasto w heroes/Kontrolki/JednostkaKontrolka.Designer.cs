
namespace Miasto_w_heroes.Kontrolki
{
    partial class JednostkaKontrolka
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
            this.pictureBoxBacgroun = new System.Windows.Forms.PictureBox();
            this.jednostka_w_miescie_picturebox = new System.Windows.Forms.PictureBox();
            this.iloscJednostekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBacgroun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostka_w_miescie_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBacgroun
            // 
            this.pictureBoxBacgroun.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxBacgroun.Name = "pictureBoxBacgroun";
            this.pictureBoxBacgroun.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxBacgroun.TabIndex = 29;
            this.pictureBoxBacgroun.TabStop = false;
            this.pictureBoxBacgroun.Click += new System.EventHandler(this.pictureBoxBacgroun_Click);
            // 
            // jednostka_w_miescie_picturebox
            // 
            this.jednostka_w_miescie_picturebox.Location = new System.Drawing.Point(15, 15);
            this.jednostka_w_miescie_picturebox.Name = "jednostka_w_miescie_picturebox";
            this.jednostka_w_miescie_picturebox.Size = new System.Drawing.Size(100, 100);
            this.jednostka_w_miescie_picturebox.TabIndex = 32;
            this.jednostka_w_miescie_picturebox.TabStop = false;
            this.jednostka_w_miescie_picturebox.Click += new System.EventHandler(this.jednostka_w_miescie_picturebox_Click_1);
            // 
            // iloscJednostekLabel
            // 
            this.iloscJednostekLabel.AutoSize = true;
            this.iloscJednostekLabel.BackColor = System.Drawing.Color.White;
            this.iloscJednostekLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscJednostekLabel.Location = new System.Drawing.Point(64, 95);
            this.iloscJednostekLabel.Name = "iloscJednostekLabel";
            this.iloscJednostekLabel.Size = new System.Drawing.Size(51, 20);
            this.iloscJednostekLabel.TabIndex = 34;
            this.iloscJednostekLabel.Text = "label1";
            this.iloscJednostekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JednostkaKontrolka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.iloscJednostekLabel);
            this.Controls.Add(this.jednostka_w_miescie_picturebox);
            this.Controls.Add(this.pictureBoxBacgroun);
            this.Name = "JednostkaKontrolka";
            this.Size = new System.Drawing.Size(130, 125);
            this.Click += new System.EventHandler(this.JednostkaKontrolka_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBacgroun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jednostka_w_miescie_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBacgroun;
        private System.Windows.Forms.PictureBox jednostka_w_miescie_picturebox;
        private System.Windows.Forms.Label iloscJednostekLabel;
    }
}
