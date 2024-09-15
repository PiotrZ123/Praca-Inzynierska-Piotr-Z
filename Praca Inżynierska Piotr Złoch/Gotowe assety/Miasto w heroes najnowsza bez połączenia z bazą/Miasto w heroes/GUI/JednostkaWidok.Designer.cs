
namespace Miasto_w_heroes.GUI
{
    partial class JednostkaWidok
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
            this.jednostkaWidokKontrolka1 = new Miasto_w_heroes.Kontrolki.JednostkaWidokKontrolka();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.UlepszenieButton = new System.Windows.Forms.Button();
            this.DegradujJednostkeButton = new System.Windows.Forms.Button();
            this.ZwolnijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jednostkaWidokKontrolka1
            // 
            this.jednostkaWidokKontrolka1.BackColor = System.Drawing.Color.White;
            this.jednostkaWidokKontrolka1.Location = new System.Drawing.Point(12, 12);
            this.jednostkaWidokKontrolka1.Name = "jednostkaWidokKontrolka1";
            this.jednostkaWidokKontrolka1.Size = new System.Drawing.Size(150, 300);
            this.jednostkaWidokKontrolka1.TabIndex = 0;
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Location = new System.Drawing.Point(12, 319);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(150, 75);
            this.ZamknijButton.TabIndex = 1;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // UlepszenieButton
            // 
            this.UlepszenieButton.Location = new System.Drawing.Point(168, 12);
            this.UlepszenieButton.Name = "UlepszenieButton";
            this.UlepszenieButton.Size = new System.Drawing.Size(150, 75);
            this.UlepszenieButton.TabIndex = 2;
            this.UlepszenieButton.Text = "Ulepsz";
            this.UlepszenieButton.UseVisualStyleBackColor = true;
            this.UlepszenieButton.Click += new System.EventHandler(this.UlepszenieButton_Click);
            // 
            // DegradujJednostkeButton
            // 
            this.DegradujJednostkeButton.Location = new System.Drawing.Point(168, 93);
            this.DegradujJednostkeButton.Name = "DegradujJednostkeButton";
            this.DegradujJednostkeButton.Size = new System.Drawing.Size(150, 75);
            this.DegradujJednostkeButton.TabIndex = 3;
            this.DegradujJednostkeButton.Text = "Degraduj";
            this.DegradujJednostkeButton.UseVisualStyleBackColor = true;
            this.DegradujJednostkeButton.Click += new System.EventHandler(this.DegradujJednostkeButton_Click);
            // 
            // ZwolnijButton
            // 
            this.ZwolnijButton.Location = new System.Drawing.Point(168, 174);
            this.ZwolnijButton.Name = "ZwolnijButton";
            this.ZwolnijButton.Size = new System.Drawing.Size(150, 75);
            this.ZwolnijButton.TabIndex = 4;
            this.ZwolnijButton.Text = "Zwolnij";
            this.ZwolnijButton.UseVisualStyleBackColor = true;
            this.ZwolnijButton.Click += new System.EventHandler(this.ZwolnijButton_Click);
            // 
            // JednostkaWidok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.ZwolnijButton);
            this.Controls.Add(this.DegradujJednostkeButton);
            this.Controls.Add(this.UlepszenieButton);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.jednostkaWidokKontrolka1);
            this.Name = "JednostkaWidok";
            this.Text = "JednostkaWidok";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrolki.JednostkaWidokKontrolka jednostkaWidokKontrolka1;
        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.Button UlepszenieButton;
        private System.Windows.Forms.Button DegradujJednostkeButton;
        private System.Windows.Forms.Button ZwolnijButton;
    }
}