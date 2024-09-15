
namespace Miasto_w_heroes
{
    partial class Ekran_startowy
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
            this.wejscie_do_formularza_testowego = new System.Windows.Forms.Button();
            this.Graj_button = new System.Windows.Forms.Button();
            this.Opcje_button = new System.Windows.Forms.Button();
            this.Wczytaj_button = new System.Windows.Forms.Button();
            this.sala_chwaly_button = new System.Windows.Forms.Button();
            this.Zamknij_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wejscie_do_formularza_testowego
            // 
            this.wejscie_do_formularza_testowego.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.wejscie_do_formularza_testowego.Location = new System.Drawing.Point(12, 12);
            this.wejscie_do_formularza_testowego.Name = "wejscie_do_formularza_testowego";
            this.wejscie_do_formularza_testowego.Size = new System.Drawing.Size(135, 62);
            this.wejscie_do_formularza_testowego.TabIndex = 5;
            this.wejscie_do_formularza_testowego.Text = "Testowy";
            this.wejscie_do_formularza_testowego.UseVisualStyleBackColor = true;
            this.wejscie_do_formularza_testowego.Click += new System.EventHandler(this.wejscie_do_formularza_testowego_Click);
            // 
            // Graj_button
            // 
            this.Graj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Graj_button.Location = new System.Drawing.Point(320, 12);
            this.Graj_button.Name = "Graj_button";
            this.Graj_button.Size = new System.Drawing.Size(135, 62);
            this.Graj_button.TabIndex = 6;
            this.Graj_button.Text = "Graj";
            this.Graj_button.UseVisualStyleBackColor = true;
            this.Graj_button.Click += new System.EventHandler(this.Graj_button_Click);
            // 
            // Opcje_button
            // 
            this.Opcje_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Opcje_button.Location = new System.Drawing.Point(320, 148);
            this.Opcje_button.Name = "Opcje_button";
            this.Opcje_button.Size = new System.Drawing.Size(135, 62);
            this.Opcje_button.TabIndex = 7;
            this.Opcje_button.Text = "Opcje";
            this.Opcje_button.UseVisualStyleBackColor = true;
            this.Opcje_button.Click += new System.EventHandler(this.Opcje_button_Click);
            // 
            // Wczytaj_button
            // 
            this.Wczytaj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Wczytaj_button.Location = new System.Drawing.Point(320, 80);
            this.Wczytaj_button.Name = "Wczytaj_button";
            this.Wczytaj_button.Size = new System.Drawing.Size(135, 62);
            this.Wczytaj_button.TabIndex = 8;
            this.Wczytaj_button.Text = "Wczytaj";
            this.Wczytaj_button.UseVisualStyleBackColor = true;
            this.Wczytaj_button.Click += new System.EventHandler(this.Wczytaj_button_Click);
            // 
            // sala_chwaly_button
            // 
            this.sala_chwaly_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.sala_chwaly_button.Location = new System.Drawing.Point(320, 216);
            this.sala_chwaly_button.Name = "sala_chwaly_button";
            this.sala_chwaly_button.Size = new System.Drawing.Size(135, 83);
            this.sala_chwaly_button.TabIndex = 9;
            this.sala_chwaly_button.Text = "Sala chwały";
            this.sala_chwaly_button.UseVisualStyleBackColor = true;
            // 
            // Zamknij_button
            // 
            this.Zamknij_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Zamknij_button.Location = new System.Drawing.Point(320, 305);
            this.Zamknij_button.Name = "Zamknij_button";
            this.Zamknij_button.Size = new System.Drawing.Size(135, 62);
            this.Zamknij_button.TabIndex = 10;
            this.Zamknij_button.Text = "Zamkij";
            this.Zamknij_button.UseVisualStyleBackColor = true;
            this.Zamknij_button.Click += new System.EventHandler(this.Zamknij_button_Click);
            // 
            // Ekran_startowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.Zamknij_button);
            this.Controls.Add(this.sala_chwaly_button);
            this.Controls.Add(this.Wczytaj_button);
            this.Controls.Add(this.Opcje_button);
            this.Controls.Add(this.Graj_button);
            this.Controls.Add(this.wejscie_do_formularza_testowego);
            this.Name = "Ekran_startowy";
            this.Text = "Ekran_startowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wejscie_do_formularza_testowego;
        private System.Windows.Forms.Button Graj_button;
        private System.Windows.Forms.Button Opcje_button;
        private System.Windows.Forms.Button Wczytaj_button;
        private System.Windows.Forms.Button sala_chwaly_button;
        private System.Windows.Forms.Button Zamknij_button;
    }
}