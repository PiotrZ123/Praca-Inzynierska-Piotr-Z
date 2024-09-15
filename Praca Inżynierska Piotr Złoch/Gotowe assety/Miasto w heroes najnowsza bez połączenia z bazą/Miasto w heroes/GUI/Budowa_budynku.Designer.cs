
namespace Miasto_w_heroes
{
    partial class Budowa_budynku
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
            this.anuluj_button = new System.Windows.Forms.Button();
            this.przed_ulepszeniem_picturebox = new System.Windows.Forms.PictureBox();
            this.strzalka_picturebox = new System.Windows.Forms.PictureBox();
            this.po_budowie_picture_box = new System.Windows.Forms.PictureBox();
            this.Buduj_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.przed_ulepszeniem_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzalka_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.po_budowie_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // anuluj_button
            // 
            this.anuluj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.anuluj_button.Location = new System.Drawing.Point(12, 118);
            this.anuluj_button.Name = "anuluj_button";
            this.anuluj_button.Size = new System.Drawing.Size(100, 40);
            this.anuluj_button.TabIndex = 0;
            this.anuluj_button.Text = "Anuluj";
            this.anuluj_button.UseVisualStyleBackColor = true;
            this.anuluj_button.Click += new System.EventHandler(this.anuluj_button_Click);
            // 
            // przed_ulepszeniem_picturebox
            // 
            this.przed_ulepszeniem_picturebox.InitialImage = global::Miasto_w_heroes.Properties.Resources.b1;
            this.przed_ulepszeniem_picturebox.Location = new System.Drawing.Point(12, 12);
            this.przed_ulepszeniem_picturebox.Name = "przed_ulepszeniem_picturebox";
            this.przed_ulepszeniem_picturebox.Size = new System.Drawing.Size(100, 100);
            this.przed_ulepszeniem_picturebox.TabIndex = 1;
            this.przed_ulepszeniem_picturebox.TabStop = false;
            // 
            // strzalka_picturebox
            // 
            this.strzalka_picturebox.InitialImage = global::Miasto_w_heroes.Properties.Resources.b1;
            this.strzalka_picturebox.Location = new System.Drawing.Point(118, 12);
            this.strzalka_picturebox.Name = "strzalka_picturebox";
            this.strzalka_picturebox.Size = new System.Drawing.Size(100, 100);
            this.strzalka_picturebox.TabIndex = 2;
            this.strzalka_picturebox.TabStop = false;
            // 
            // po_budowie_picture_box
            // 
            this.po_budowie_picture_box.InitialImage = global::Miasto_w_heroes.Properties.Resources.b1;
            this.po_budowie_picture_box.Location = new System.Drawing.Point(224, 12);
            this.po_budowie_picture_box.Name = "po_budowie_picture_box";
            this.po_budowie_picture_box.Size = new System.Drawing.Size(100, 100);
            this.po_budowie_picture_box.TabIndex = 3;
            this.po_budowie_picture_box.TabStop = false;
            // 
            // Buduj_button
            // 
            this.Buduj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Buduj_button.Location = new System.Drawing.Point(224, 118);
            this.Buduj_button.Name = "Buduj_button";
            this.Buduj_button.Size = new System.Drawing.Size(100, 40);
            this.Buduj_button.TabIndex = 4;
            this.Buduj_button.Text = "Buduj";
            this.Buduj_button.UseVisualStyleBackColor = true;
            this.Buduj_button.Click += new System.EventHandler(this.Buduj_button_Click);
            // 
            // Budowa_budynku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buduj_button);
            this.Controls.Add(this.po_budowie_picture_box);
            this.Controls.Add(this.strzalka_picturebox);
            this.Controls.Add(this.przed_ulepszeniem_picturebox);
            this.Controls.Add(this.anuluj_button);
            this.Name = "Budowa_budynku";
            this.Text = "Budowa_budynku";
            ((System.ComponentModel.ISupportInitialize)(this.przed_ulepszeniem_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strzalka_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.po_budowie_picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anuluj_button;
        private System.Windows.Forms.PictureBox przed_ulepszeniem_picturebox;
        private System.Windows.Forms.PictureBox strzalka_picturebox;
        private System.Windows.Forms.PictureBox po_budowie_picture_box;
        private System.Windows.Forms.Button Buduj_button;
    }
}