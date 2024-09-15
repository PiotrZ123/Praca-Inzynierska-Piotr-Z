
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
            this.ZamknijButton.Location = new System.Drawing.Point(12, 399);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(150, 75);
            this.ZamknijButton.TabIndex = 1;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // ZwolnijButton
            // 
            this.ZwolnijButton.Location = new System.Drawing.Point(12, 318);
            this.ZwolnijButton.Name = "ZwolnijButton";
            this.ZwolnijButton.Size = new System.Drawing.Size(150, 75);
            this.ZwolnijButton.TabIndex = 4;
            this.ZwolnijButton.Text = "Uśmierć";
            this.ZwolnijButton.UseVisualStyleBackColor = true;
            this.ZwolnijButton.Click += new System.EventHandler(this.ZwolnijButton_Click);
            // 
            // JednostkaWidok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 474);
            this.Controls.Add(this.ZwolnijButton);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.jednostkaWidokKontrolka1);
            this.Name = "JednostkaWidok";
            this.Text = "JednostkaWidok";
            this.ResumeLayout(false);

        }

        #endregion

        private Kontrolki.JednostkaWidokKontrolka jednostkaWidokKontrolka1;
        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.Button ZwolnijButton;
    }
}