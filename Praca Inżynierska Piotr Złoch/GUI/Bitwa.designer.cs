﻿
namespace Praca_Inżynierska_Piotr_Złoch.GUI
{
    partial class Bitwa
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
            this.panel_lewy = new System.Windows.Forms.Panel();
            this.UmiejetnoscLewyButton = new System.Windows.Forms.Button();
            this.LewybohaterWidok = new Praca_Inżynierska_Piotr_Złoch.Kontrolki.BohaterWidok();
            this.panel_prawy = new System.Windows.Forms.Panel();
            this.PrawybohaterWidok = new Praca_Inżynierska_Piotr_Złoch.Kontrolki.BohaterWidok();
            this.prawo_button = new System.Windows.Forms.Button();
            this.lewy_button = new System.Windows.Forms.Button();
            this.dol_button = new System.Windows.Forms.Button();
            this.gora_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrawyDolButton = new System.Windows.Forms.Button();
            this.LewyDolButton = new System.Windows.Forms.Button();
            this.LewoGoraButton = new System.Windows.Forms.Button();
            this.PrawoGoraButtno = new System.Windows.Forms.Button();
            this.kolejkaJednostek1 = new Praca_Inżynierska_Piotr_Złoch.Kontrolki.KolejkaJednostek();
            this.zakoncz_bitwe_button = new System.Windows.Forms.Button();
            this.zakoncz_ture_button = new System.Windows.Forms.Button();
            this.ilosc_ruchu_label = new System.Windows.Forms.Label();
            this.UmiejetnoscPrawyButton = new System.Windows.Forms.Button();
            this.panel_lewy.SuspendLayout();
            this.panel_prawy.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_lewy
            // 
            this.panel_lewy.Controls.Add(this.UmiejetnoscLewyButton);
            this.panel_lewy.Controls.Add(this.LewybohaterWidok);
            this.panel_lewy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lewy.Location = new System.Drawing.Point(0, 0);
            this.panel_lewy.Name = "panel_lewy";
            this.panel_lewy.Size = new System.Drawing.Size(100, 701);
            this.panel_lewy.TabIndex = 0;
            // 
            // UmiejetnoscLewyButton
            // 
            this.UmiejetnoscLewyButton.Location = new System.Drawing.Point(12, 165);
            this.UmiejetnoscLewyButton.Name = "UmiejetnoscLewyButton";
            this.UmiejetnoscLewyButton.Size = new System.Drawing.Size(80, 40);
            this.UmiejetnoscLewyButton.TabIndex = 33;
            this.UmiejetnoscLewyButton.Text = "Umiejetności";
            this.UmiejetnoscLewyButton.UseVisualStyleBackColor = true;
            this.UmiejetnoscLewyButton.Click += new System.EventHandler(this.UmiejetnoscButton_Click);
            // 
            // LewybohaterWidok
            // 
            this.LewybohaterWidok.Location = new System.Drawing.Point(-1, 0);
            this.LewybohaterWidok.Name = "LewybohaterWidok";
            this.LewybohaterWidok.Size = new System.Drawing.Size(101, 159);
            this.LewybohaterWidok.TabIndex = 28;
            // 
            // panel_prawy
            // 
            this.panel_prawy.Controls.Add(this.UmiejetnoscPrawyButton);
            this.panel_prawy.Controls.Add(this.PrawybohaterWidok);
            this.panel_prawy.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_prawy.Location = new System.Drawing.Point(1101, 0);
            this.panel_prawy.Name = "panel_prawy";
            this.panel_prawy.Size = new System.Drawing.Size(100, 701);
            this.panel_prawy.TabIndex = 1;
            // 
            // PrawybohaterWidok
            // 
            this.PrawybohaterWidok.Location = new System.Drawing.Point(0, 0);
            this.PrawybohaterWidok.Name = "PrawybohaterWidok";
            this.PrawybohaterWidok.Size = new System.Drawing.Size(101, 159);
            this.PrawybohaterWidok.TabIndex = 29;
            // 
            // prawo_button
            // 
            this.prawo_button.Location = new System.Drawing.Point(482, 50);
            this.prawo_button.Name = "prawo_button";
            this.prawo_button.Size = new System.Drawing.Size(50, 40);
            this.prawo_button.TabIndex = 26;
            this.prawo_button.Text = "prawo";
            this.prawo_button.UseVisualStyleBackColor = true;
            this.prawo_button.Click += new System.EventHandler(this.prawo_button_Click);
            // 
            // lewy_button
            // 
            this.lewy_button.Location = new System.Drawing.Point(370, 50);
            this.lewy_button.Name = "lewy_button";
            this.lewy_button.Size = new System.Drawing.Size(50, 40);
            this.lewy_button.TabIndex = 25;
            this.lewy_button.Text = "lewo";
            this.lewy_button.UseVisualStyleBackColor = true;
            this.lewy_button.Click += new System.EventHandler(this.lewy_button_Click);
            // 
            // dol_button
            // 
            this.dol_button.Location = new System.Drawing.Point(426, 100);
            this.dol_button.Name = "dol_button";
            this.dol_button.Size = new System.Drawing.Size(50, 40);
            this.dol_button.TabIndex = 24;
            this.dol_button.Text = "dol";
            this.dol_button.UseVisualStyleBackColor = true;
            this.dol_button.Click += new System.EventHandler(this.dol_button_Click);
            // 
            // gora_button
            // 
            this.gora_button.Location = new System.Drawing.Point(426, 4);
            this.gora_button.Name = "gora_button";
            this.gora_button.Size = new System.Drawing.Size(50, 40);
            this.gora_button.TabIndex = 23;
            this.gora_button.Text = "gora";
            this.gora_button.UseVisualStyleBackColor = true;
            this.gora_button.Click += new System.EventHandler(this.gora_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrawyDolButton);
            this.panel1.Controls.Add(this.LewyDolButton);
            this.panel1.Controls.Add(this.LewoGoraButton);
            this.panel1.Controls.Add(this.PrawoGoraButtno);
            this.panel1.Controls.Add(this.kolejkaJednostek1);
            this.panel1.Controls.Add(this.zakoncz_bitwe_button);
            this.panel1.Controls.Add(this.zakoncz_ture_button);
            this.panel1.Controls.Add(this.ilosc_ruchu_label);
            this.panel1.Controls.Add(this.dol_button);
            this.panel1.Controls.Add(this.prawo_button);
            this.panel1.Controls.Add(this.gora_button);
            this.panel1.Controls.Add(this.lewy_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(100, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 200);
            this.panel1.TabIndex = 27;
            // 
            // PrawyDolButton
            // 
            this.PrawyDolButton.Location = new System.Drawing.Point(482, 100);
            this.PrawyDolButton.Name = "PrawyDolButton";
            this.PrawyDolButton.Size = new System.Drawing.Size(50, 40);
            this.PrawyDolButton.TabIndex = 32;
            this.PrawyDolButton.Text = "skos";
            this.PrawyDolButton.UseVisualStyleBackColor = true;
            this.PrawyDolButton.Click += new System.EventHandler(this.PrawyDolButton_Click);
            // 
            // LewyDolButton
            // 
            this.LewyDolButton.Location = new System.Drawing.Point(370, 100);
            this.LewyDolButton.Name = "LewyDolButton";
            this.LewyDolButton.Size = new System.Drawing.Size(50, 40);
            this.LewyDolButton.TabIndex = 31;
            this.LewyDolButton.Text = "skos";
            this.LewyDolButton.UseVisualStyleBackColor = true;
            this.LewyDolButton.Click += new System.EventHandler(this.LewyDolButton_Click);
            // 
            // LewoGoraButton
            // 
            this.LewoGoraButton.Location = new System.Drawing.Point(370, 4);
            this.LewoGoraButton.Name = "LewoGoraButton";
            this.LewoGoraButton.Size = new System.Drawing.Size(50, 40);
            this.LewoGoraButton.TabIndex = 30;
            this.LewoGoraButton.Text = "skos";
            this.LewoGoraButton.UseVisualStyleBackColor = true;
            this.LewoGoraButton.Click += new System.EventHandler(this.LewoGoraButton_Click);
            // 
            // PrawoGoraButtno
            // 
            this.PrawoGoraButtno.Location = new System.Drawing.Point(482, 4);
            this.PrawoGoraButtno.Name = "PrawoGoraButtno";
            this.PrawoGoraButtno.Size = new System.Drawing.Size(50, 40);
            this.PrawoGoraButtno.TabIndex = 28;
            this.PrawoGoraButtno.Text = "skos";
            this.PrawoGoraButtno.UseVisualStyleBackColor = true;
            this.PrawoGoraButtno.Click += new System.EventHandler(this.PrawoGoraButtno_Click);
            // 
            // kolejkaJednostek1
            // 
            this.kolejkaJednostek1.Location = new System.Drawing.Point(0, 150);
            this.kolejkaJednostek1.Name = "kolejkaJednostek1";
            this.kolejkaJednostek1.Size = new System.Drawing.Size(1000, 50);
            this.kolejkaJednostek1.TabIndex = 28;
            // 
            // zakoncz_bitwe_button
            // 
            this.zakoncz_bitwe_button.Location = new System.Drawing.Point(77, 48);
            this.zakoncz_bitwe_button.Name = "zakoncz_bitwe_button";
            this.zakoncz_bitwe_button.Size = new System.Drawing.Size(61, 40);
            this.zakoncz_bitwe_button.TabIndex = 29;
            this.zakoncz_bitwe_button.Text = "zakończ bitwę";
            this.zakoncz_bitwe_button.UseVisualStyleBackColor = true;
            this.zakoncz_bitwe_button.Click += new System.EventHandler(this.zakoncz_bitwe_button_Click);
            // 
            // zakoncz_ture_button
            // 
            this.zakoncz_ture_button.Location = new System.Drawing.Point(10, 48);
            this.zakoncz_ture_button.Name = "zakoncz_ture_button";
            this.zakoncz_ture_button.Size = new System.Drawing.Size(61, 40);
            this.zakoncz_ture_button.TabIndex = 28;
            this.zakoncz_ture_button.Text = "zakończ turę";
            this.zakoncz_ture_button.UseVisualStyleBackColor = true;
            this.zakoncz_ture_button.Click += new System.EventHandler(this.zakoncz_ture_button_Click);
            // 
            // ilosc_ruchu_label
            // 
            this.ilosc_ruchu_label.AutoSize = true;
            this.ilosc_ruchu_label.Location = new System.Drawing.Point(7, 4);
            this.ilosc_ruchu_label.Name = "ilosc_ruchu_label";
            this.ilosc_ruchu_label.Size = new System.Drawing.Size(64, 13);
            this.ilosc_ruchu_label.TabIndex = 27;
            this.ilosc_ruchu_label.Text = "ilosc_ruchu:";
            // 
            // UmiejetnoscPrawyButton
            // 
            this.UmiejetnoscPrawyButton.Location = new System.Drawing.Point(8, 165);
            this.UmiejetnoscPrawyButton.Name = "UmiejetnoscPrawyButton";
            this.UmiejetnoscPrawyButton.Size = new System.Drawing.Size(80, 40);
            this.UmiejetnoscPrawyButton.TabIndex = 34;
            this.UmiejetnoscPrawyButton.Text = "Umiejetności";
            this.UmiejetnoscPrawyButton.UseVisualStyleBackColor = true;
            this.UmiejetnoscPrawyButton.Click += new System.EventHandler(this.UmiejetnoscPrawyButton_Click);
            // 
            // Bitwa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1201, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_prawy);
            this.Controls.Add(this.panel_lewy);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1217, 740);
            this.MinimumSize = new System.Drawing.Size(1217, 740);
            this.Name = "Bitwa";
            this.Text = "Bitwa";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Bitwa_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Bitwa_MouseClick);
            this.panel_lewy.ResumeLayout(false);
            this.panel_prawy.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lewy;
        private System.Windows.Forms.Panel panel_prawy;
        private System.Windows.Forms.Button prawo_button;
        private System.Windows.Forms.Button lewy_button;
        private System.Windows.Forms.Button dol_button;
        private System.Windows.Forms.Button gora_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ilosc_ruchu_label;
        private System.Windows.Forms.Button zakoncz_ture_button;
        private System.Windows.Forms.Button zakoncz_bitwe_button;
        private Kontrolki.BohaterWidok LewybohaterWidok;
        private Kontrolki.BohaterWidok PrawybohaterWidok;
        private Kontrolki.KolejkaJednostek kolejkaJednostek1;
        private System.Windows.Forms.Button PrawyDolButton;
        private System.Windows.Forms.Button LewyDolButton;
        private System.Windows.Forms.Button LewoGoraButton;
        private System.Windows.Forms.Button PrawoGoraButtno;
        private System.Windows.Forms.Button UmiejetnoscLewyButton;
        private System.Windows.Forms.Button UmiejetnoscPrawyButton;
    }
}