
namespace Miasto_w_heroes.GUI
{
    partial class Opcje
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Predkosc1 = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.Predkosc2 = new System.Windows.Forms.RadioButton();
            this.Predkosc3 = new System.Windows.Forms.RadioButton();
            this.Predkosc4 = new System.Windows.Forms.RadioButton();
            this.Predkosc5 = new System.Windows.Forms.RadioButton();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.ZapiszButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Predkosc5);
            this.panel1.Controls.Add(this.Predkosc4);
            this.panel1.Controls.Add(this.Predkosc3);
            this.panel1.Controls.Add(this.Predkosc2);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.Predkosc1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 160);
            this.panel1.TabIndex = 0;
            // 
            // Predkosc1
            // 
            this.Predkosc1.AutoSize = true;
            this.Predkosc1.Location = new System.Drawing.Point(4, 45);
            this.Predkosc1.Name = "Predkosc1";
            this.Predkosc1.Size = new System.Drawing.Size(51, 17);
            this.Predkosc1.TabIndex = 0;
            this.Predkosc1.Text = "x0.25";
            this.Predkosc1.UseVisualStyleBackColor = true;
            this.Predkosc1.CheckedChanged += new System.EventHandler(this.Predkosc1_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(4, 4);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Predkosc Animacji";
            // 
            // Predkosc2
            // 
            this.Predkosc2.AutoSize = true;
            this.Predkosc2.Location = new System.Drawing.Point(4, 68);
            this.Predkosc2.Name = "Predkosc2";
            this.Predkosc2.Size = new System.Drawing.Size(45, 17);
            this.Predkosc2.TabIndex = 2;
            this.Predkosc2.Text = "x0.5";
            this.Predkosc2.UseVisualStyleBackColor = true;
            this.Predkosc2.CheckedChanged += new System.EventHandler(this.Predkosc2_CheckedChanged);
            // 
            // Predkosc3
            // 
            this.Predkosc3.AutoSize = true;
            this.Predkosc3.Checked = true;
            this.Predkosc3.Location = new System.Drawing.Point(4, 91);
            this.Predkosc3.Name = "Predkosc3";
            this.Predkosc3.Size = new System.Drawing.Size(36, 17);
            this.Predkosc3.TabIndex = 3;
            this.Predkosc3.TabStop = true;
            this.Predkosc3.Text = "x1";
            this.Predkosc3.UseVisualStyleBackColor = true;
            this.Predkosc3.CheckedChanged += new System.EventHandler(this.Predkosc3_CheckedChanged);
            // 
            // Predkosc4
            // 
            this.Predkosc4.AutoSize = true;
            this.Predkosc4.Location = new System.Drawing.Point(4, 114);
            this.Predkosc4.Name = "Predkosc4";
            this.Predkosc4.Size = new System.Drawing.Size(36, 17);
            this.Predkosc4.TabIndex = 4;
            this.Predkosc4.Text = "x2";
            this.Predkosc4.UseVisualStyleBackColor = true;
            this.Predkosc4.CheckedChanged += new System.EventHandler(this.Predkosc4_CheckedChanged);
            // 
            // Predkosc5
            // 
            this.Predkosc5.AutoSize = true;
            this.Predkosc5.Location = new System.Drawing.Point(4, 137);
            this.Predkosc5.Name = "Predkosc5";
            this.Predkosc5.Size = new System.Drawing.Size(36, 17);
            this.Predkosc5.TabIndex = 5;
            this.Predkosc5.Text = "x4";
            this.Predkosc5.UseVisualStyleBackColor = true;
            this.Predkosc5.CheckedChanged += new System.EventHandler(this.Predkosc5_CheckedChanged);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Location = new System.Drawing.Point(13, 376);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(163, 62);
            this.ZamknijButton.TabIndex = 1;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // ZapiszButton
            // 
            this.ZapiszButton.Location = new System.Drawing.Point(13, 308);
            this.ZapiszButton.Name = "ZapiszButton";
            this.ZapiszButton.Size = new System.Drawing.Size(163, 62);
            this.ZapiszButton.TabIndex = 2;
            this.ZapiszButton.Text = "Zapisz";
            this.ZapiszButton.UseVisualStyleBackColor = true;
            this.ZapiszButton.Click += new System.EventHandler(this.ZapiszButton_Click);
            // 
            // Opcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZapiszButton);
            this.Controls.Add(this.ZamknijButton);
            this.Controls.Add(this.panel1);
            this.Name = "Opcje";
            this.Text = "Opcje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Predkosc5;
        private System.Windows.Forms.RadioButton Predkosc4;
        private System.Windows.Forms.RadioButton Predkosc3;
        private System.Windows.Forms.RadioButton Predkosc2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton Predkosc1;
        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.Button ZapiszButton;
    }
}