
namespace Miasto_w_heroes
{
    partial class Mapa_widok
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
            this.panel_po_prawej = new System.Windows.Forms.Panel();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.Pasek_ruchu_bohatera = new Kontrolki_by_wwsi.Pasek_postępu();
            this.numer_gracza_label = new System.Windows.Forms.Label();
            this.Ilosc_ruchu_label = new System.Windows.Forms.Label();
            this.ekran_prawo_button = new System.Windows.Forms.Button();
            this.ekran_lewo_button = new System.Windows.Forms.Button();
            this.ekran_dol_button = new System.Windows.Forms.Button();
            this.ekran_gora_button = new System.Windows.Forms.Button();
            this.aktualny_bohater_label = new System.Windows.Forms.Label();
            this.Bohaterowie_lista_listbox = new System.Windows.Forms.ListBox();
            this.prawo_button = new System.Windows.Forms.Button();
            this.lewy_button = new System.Windows.Forms.Button();
            this.dol_button = new System.Windows.Forms.Button();
            this.gora_button = new System.Windows.Forms.Button();
            this.Miasta_lista_listbox = new System.Windows.Forms.ListBox();
            this.Ilosc_golda_label = new System.Windows.Forms.Label();
            this.aktualny_gracz_label = new System.Windows.Forms.Label();
            this.tydzien_label = new System.Windows.Forms.Label();
            this.zakoncz_ture_button = new System.Windows.Forms.Button();
            this.Miesiac_label = new System.Windows.Forms.Label();
            this.dzien_Label = new System.Windows.Forms.Label();
            this.panel_po_prawej.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_po_prawej
            // 
            this.panel_po_prawej.BackColor = System.Drawing.Color.Aquamarine;
            this.panel_po_prawej.Controls.Add(this.buttonZapisz);
            this.panel_po_prawej.Controls.Add(this.Pasek_ruchu_bohatera);
            this.panel_po_prawej.Controls.Add(this.numer_gracza_label);
            this.panel_po_prawej.Controls.Add(this.Ilosc_ruchu_label);
            this.panel_po_prawej.Controls.Add(this.ekran_prawo_button);
            this.panel_po_prawej.Controls.Add(this.ekran_lewo_button);
            this.panel_po_prawej.Controls.Add(this.ekran_dol_button);
            this.panel_po_prawej.Controls.Add(this.ekran_gora_button);
            this.panel_po_prawej.Controls.Add(this.aktualny_bohater_label);
            this.panel_po_prawej.Controls.Add(this.Bohaterowie_lista_listbox);
            this.panel_po_prawej.Controls.Add(this.prawo_button);
            this.panel_po_prawej.Controls.Add(this.lewy_button);
            this.panel_po_prawej.Controls.Add(this.dol_button);
            this.panel_po_prawej.Controls.Add(this.gora_button);
            this.panel_po_prawej.Controls.Add(this.Miasta_lista_listbox);
            this.panel_po_prawej.Controls.Add(this.Ilosc_golda_label);
            this.panel_po_prawej.Controls.Add(this.aktualny_gracz_label);
            this.panel_po_prawej.Controls.Add(this.tydzien_label);
            this.panel_po_prawej.Controls.Add(this.zakoncz_ture_button);
            this.panel_po_prawej.Controls.Add(this.Miesiac_label);
            this.panel_po_prawej.Controls.Add(this.dzien_Label);
            this.panel_po_prawej.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_po_prawej.Location = new System.Drawing.Point(1038, 0);
            this.panel_po_prawej.Name = "panel_po_prawej";
            this.panel_po_prawej.Size = new System.Drawing.Size(200, 642);
            this.panel_po_prawej.TabIndex = 0;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonZapisz.Location = new System.Drawing.Point(106, 349);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(82, 50);
            this.buttonZapisz.TabIndex = 30;
            this.buttonZapisz.Text = "Zapisz grę";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // Pasek_ruchu_bohatera
            // 
            this.Pasek_ruchu_bohatera.Kolor = System.Drawing.Color.DodgerBlue;
            this.Pasek_ruchu_bohatera.Location = new System.Drawing.Point(0, 199);
            this.Pasek_ruchu_bohatera.Max_wartosc = 1000D;
            this.Pasek_ruchu_bohatera.Name = "Pasek_ruchu_bohatera";
            this.Pasek_ruchu_bohatera.Obecna_wartosc = 1000D;
            this.Pasek_ruchu_bohatera.Size = new System.Drawing.Size(200, 20);
            this.Pasek_ruchu_bohatera.TabIndex = 1;
            // 
            // numer_gracza_label
            // 
            this.numer_gracza_label.AutoSize = true;
            this.numer_gracza_label.Location = new System.Drawing.Point(106, 31);
            this.numer_gracza_label.Name = "numer_gracza_label";
            this.numer_gracza_label.Size = new System.Drawing.Size(13, 13);
            this.numer_gracza_label.TabIndex = 29;
            this.numer_gracza_label.Text = "0";
            this.numer_gracza_label.Visible = false;
            // 
            // Ilosc_ruchu_label
            // 
            this.Ilosc_ruchu_label.AutoSize = true;
            this.Ilosc_ruchu_label.Location = new System.Drawing.Point(2, 170);
            this.Ilosc_ruchu_label.Name = "Ilosc_ruchu_label";
            this.Ilosc_ruchu_label.Size = new System.Drawing.Size(64, 13);
            this.Ilosc_ruchu_label.TabIndex = 28;
            this.Ilosc_ruchu_label.Text = "ilość ruchu :";
            // 
            // ekran_prawo_button
            // 
            this.ekran_prawo_button.Location = new System.Drawing.Point(138, 293);
            this.ekran_prawo_button.Name = "ekran_prawo_button";
            this.ekran_prawo_button.Size = new System.Drawing.Size(50, 50);
            this.ekran_prawo_button.TabIndex = 27;
            this.ekran_prawo_button.Text = "prawo";
            this.ekran_prawo_button.UseVisualStyleBackColor = true;
            this.ekran_prawo_button.Click += new System.EventHandler(this.ekran_prawo_button_Click);
            // 
            // ekran_lewo_button
            // 
            this.ekran_lewo_button.Location = new System.Drawing.Point(26, 293);
            this.ekran_lewo_button.Name = "ekran_lewo_button";
            this.ekran_lewo_button.Size = new System.Drawing.Size(50, 50);
            this.ekran_lewo_button.TabIndex = 26;
            this.ekran_lewo_button.Text = "lewo";
            this.ekran_lewo_button.UseVisualStyleBackColor = true;
            this.ekran_lewo_button.Click += new System.EventHandler(this.ekran_lewo_button_Click);
            // 
            // ekran_dol_button
            // 
            this.ekran_dol_button.Location = new System.Drawing.Point(82, 293);
            this.ekran_dol_button.Name = "ekran_dol_button";
            this.ekran_dol_button.Size = new System.Drawing.Size(50, 50);
            this.ekran_dol_button.TabIndex = 25;
            this.ekran_dol_button.Text = "dol";
            this.ekran_dol_button.UseVisualStyleBackColor = true;
            this.ekran_dol_button.Click += new System.EventHandler(this.ekran_dol_button_Click);
            // 
            // ekran_gora_button
            // 
            this.ekran_gora_button.Location = new System.Drawing.Point(82, 237);
            this.ekran_gora_button.Name = "ekran_gora_button";
            this.ekran_gora_button.Size = new System.Drawing.Size(50, 50);
            this.ekran_gora_button.TabIndex = 24;
            this.ekran_gora_button.Text = "gora";
            this.ekran_gora_button.UseVisualStyleBackColor = true;
            this.ekran_gora_button.Click += new System.EventHandler(this.ekran_gora_button_Click);
            // 
            // aktualny_bohater_label
            // 
            this.aktualny_bohater_label.AutoSize = true;
            this.aktualny_bohater_label.Location = new System.Drawing.Point(3, 157);
            this.aktualny_bohater_label.Name = "aktualny_bohater_label";
            this.aktualny_bohater_label.Size = new System.Drawing.Size(92, 13);
            this.aktualny_bohater_label.TabIndex = 23;
            this.aktualny_bohater_label.Text = "aktulany bohater :";
            // 
            // Bohaterowie_lista_listbox
            // 
            this.Bohaterowie_lista_listbox.FormattingEnabled = true;
            this.Bohaterowie_lista_listbox.Location = new System.Drawing.Point(5, 47);
            this.Bohaterowie_lista_listbox.Name = "Bohaterowie_lista_listbox";
            this.Bohaterowie_lista_listbox.Size = new System.Drawing.Size(79, 95);
            this.Bohaterowie_lista_listbox.TabIndex = 19;
            this.Bohaterowie_lista_listbox.SelectedIndexChanged += new System.EventHandler(this.Bohaterowie_lista_listbox_SelectedIndexChanged);
            // 
            // prawo_button
            // 
            this.prawo_button.Location = new System.Drawing.Point(138, 580);
            this.prawo_button.Name = "prawo_button";
            this.prawo_button.Size = new System.Drawing.Size(50, 50);
            this.prawo_button.TabIndex = 22;
            this.prawo_button.Text = "prawo";
            this.prawo_button.UseVisualStyleBackColor = true;
            this.prawo_button.Click += new System.EventHandler(this.prawo_button_Click);
            // 
            // lewy_button
            // 
            this.lewy_button.Location = new System.Drawing.Point(26, 580);
            this.lewy_button.Name = "lewy_button";
            this.lewy_button.Size = new System.Drawing.Size(50, 50);
            this.lewy_button.TabIndex = 21;
            this.lewy_button.Text = "lewo";
            this.lewy_button.UseVisualStyleBackColor = true;
            this.lewy_button.Click += new System.EventHandler(this.lewy_button_Click);
            // 
            // dol_button
            // 
            this.dol_button.Location = new System.Drawing.Point(82, 580);
            this.dol_button.Name = "dol_button";
            this.dol_button.Size = new System.Drawing.Size(50, 50);
            this.dol_button.TabIndex = 20;
            this.dol_button.Text = "dol";
            this.dol_button.UseVisualStyleBackColor = true;
            this.dol_button.Click += new System.EventHandler(this.dol_button_Click);
            // 
            // gora_button
            // 
            this.gora_button.Location = new System.Drawing.Point(82, 524);
            this.gora_button.Name = "gora_button";
            this.gora_button.Size = new System.Drawing.Size(50, 50);
            this.gora_button.TabIndex = 19;
            this.gora_button.Text = "gora";
            this.gora_button.UseVisualStyleBackColor = true;
            this.gora_button.Click += new System.EventHandler(this.gora_button_Click);
            // 
            // Miasta_lista_listbox
            // 
            this.Miasta_lista_listbox.FormattingEnabled = true;
            this.Miasta_lista_listbox.Location = new System.Drawing.Point(90, 47);
            this.Miasta_lista_listbox.Name = "Miasta_lista_listbox";
            this.Miasta_lista_listbox.Size = new System.Drawing.Size(79, 95);
            this.Miasta_lista_listbox.TabIndex = 18;
            this.Miasta_lista_listbox.SelectedIndexChanged += new System.EventHandler(this.Miasta_lista_listbox_SelectedIndexChanged);
            // 
            // Ilosc_golda_label
            // 
            this.Ilosc_golda_label.AutoSize = true;
            this.Ilosc_golda_label.Location = new System.Drawing.Point(3, 31);
            this.Ilosc_golda_label.Name = "Ilosc_golda_label";
            this.Ilosc_golda_label.Size = new System.Drawing.Size(59, 13);
            this.Ilosc_golda_label.TabIndex = 17;
            this.Ilosc_golda_label.Text = "ilosc kasy :";
            // 
            // aktualny_gracz_label
            // 
            this.aktualny_gracz_label.AutoSize = true;
            this.aktualny_gracz_label.Location = new System.Drawing.Point(3, 9);
            this.aktualny_gracz_label.Name = "aktualny_gracz_label";
            this.aktualny_gracz_label.Size = new System.Drawing.Size(116, 13);
            this.aktualny_gracz_label.TabIndex = 16;
            this.aktualny_gracz_label.Text = "aktualny gracz: Gracz1";
            // 
            // tydzien_label
            // 
            this.tydzien_label.AutoEllipsis = true;
            this.tydzien_label.AutoSize = true;
            this.tydzien_label.Location = new System.Drawing.Point(2, 415);
            this.tydzien_label.Name = "tydzien_label";
            this.tydzien_label.Size = new System.Drawing.Size(56, 13);
            this.tydzien_label.TabIndex = 15;
            this.tydzien_label.Text = "Tydzień: 1";
            // 
            // zakoncz_ture_button
            // 
            this.zakoncz_ture_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.zakoncz_ture_button.Location = new System.Drawing.Point(0, 349);
            this.zakoncz_ture_button.Name = "zakoncz_ture_button";
            this.zakoncz_ture_button.Size = new System.Drawing.Size(100, 50);
            this.zakoncz_ture_button.TabIndex = 0;
            this.zakoncz_ture_button.Text = "Zakończ Turę";
            this.zakoncz_ture_button.UseVisualStyleBackColor = true;
            this.zakoncz_ture_button.Click += new System.EventHandler(this.zakoncz_ture_button_Click);
            // 
            // Miesiac_label
            // 
            this.Miesiac_label.AutoEllipsis = true;
            this.Miesiac_label.AutoSize = true;
            this.Miesiac_label.Location = new System.Drawing.Point(3, 428);
            this.Miesiac_label.Name = "Miesiac_label";
            this.Miesiac_label.Size = new System.Drawing.Size(55, 13);
            this.Miesiac_label.TabIndex = 14;
            this.Miesiac_label.Text = "Miesiąc: 1";
            // 
            // dzien_Label
            // 
            this.dzien_Label.AutoEllipsis = true;
            this.dzien_Label.AutoSize = true;
            this.dzien_Label.Location = new System.Drawing.Point(3, 402);
            this.dzien_Label.Name = "dzien_Label";
            this.dzien_Label.Size = new System.Drawing.Size(43, 13);
            this.dzien_Label.TabIndex = 13;
            this.dzien_Label.Text = "Dzień:1";
            // 
            // Mapa_widok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1238, 642);
            this.Controls.Add(this.panel_po_prawej);
            this.DoubleBuffered = true;
            this.Name = "Mapa_widok";
            this.Text = "50";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Mapa_widok_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mapa_widok_MouseClick);
            this.panel_po_prawej.ResumeLayout(false);
            this.panel_po_prawej.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel_po_prawej;
        protected System.Windows.Forms.Button zakoncz_ture_button;
        protected System.Windows.Forms.Label tydzien_label;
        protected System.Windows.Forms.Label Miesiac_label;
        protected System.Windows.Forms.Label dzien_Label;
        protected System.Windows.Forms.Label Ilosc_golda_label;
        protected System.Windows.Forms.Label aktualny_gracz_label;
        protected System.Windows.Forms.ListBox Miasta_lista_listbox;
        protected System.Windows.Forms.Button prawo_button;
        protected System.Windows.Forms.Button lewy_button;
        protected System.Windows.Forms.Button dol_button;
        protected System.Windows.Forms.Button gora_button;
        protected System.Windows.Forms.ListBox Bohaterowie_lista_listbox;
        protected System.Windows.Forms.Label aktualny_bohater_label;
        protected System.Windows.Forms.Button ekran_prawo_button;
        protected System.Windows.Forms.Button ekran_lewo_button;
        protected System.Windows.Forms.Button ekran_dol_button;
        protected System.Windows.Forms.Button ekran_gora_button;
        protected System.Windows.Forms.Label Ilosc_ruchu_label;
        private System.Windows.Forms.Label numer_gracza_label;
        private Kontrolki_by_wwsi.Pasek_postępu Pasek_ruchu_bohatera;
        protected System.Windows.Forms.Button buttonZapisz;
    }
}