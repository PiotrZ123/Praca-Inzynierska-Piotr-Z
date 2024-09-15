
namespace Praca_Inżynierska_Piotr_Złoch.GUI
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
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.SzybkoscRadioButton1 = new System.Windows.Forms.RadioButton();
            this.SzybkoscRadioButton2 = new System.Windows.Forms.RadioButton();
            this.SzybkoscRadioButton3 = new System.Windows.Forms.RadioButton();
            this.SzybkoscRadioButton4 = new System.Windows.Forms.RadioButton();
            this.SzybkoscRadioButton5 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AktualnaSzybkoscLabel = new System.Windows.Forms.Label();
            this.SzybkoscLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknijButton.Location = new System.Drawing.Point(12, 338);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(250, 100);
            this.ZamknijButton.TabIndex = 4;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // SzybkoscRadioButton1
            // 
            this.SzybkoscRadioButton1.AutoSize = true;
            this.SzybkoscRadioButton1.Location = new System.Drawing.Point(112, 3);
            this.SzybkoscRadioButton1.Name = "SzybkoscRadioButton1";
            this.SzybkoscRadioButton1.Size = new System.Drawing.Size(100, 17);
            this.SzybkoscRadioButton1.TabIndex = 5;
            this.SzybkoscRadioButton1.TabStop = true;
            this.SzybkoscRadioButton1.Text = "Szybkość x0,25";
            this.SzybkoscRadioButton1.UseVisualStyleBackColor = true;
            this.SzybkoscRadioButton1.CheckedChanged += new System.EventHandler(this.SzybkoscRadioButton1_CheckedChanged);
            // 
            // SzybkoscRadioButton2
            // 
            this.SzybkoscRadioButton2.AutoSize = true;
            this.SzybkoscRadioButton2.Location = new System.Drawing.Point(112, 26);
            this.SzybkoscRadioButton2.Name = "SzybkoscRadioButton2";
            this.SzybkoscRadioButton2.Size = new System.Drawing.Size(94, 17);
            this.SzybkoscRadioButton2.TabIndex = 6;
            this.SzybkoscRadioButton2.TabStop = true;
            this.SzybkoscRadioButton2.Text = "Szybkość x0,5";
            this.SzybkoscRadioButton2.UseVisualStyleBackColor = true;
            this.SzybkoscRadioButton2.CheckedChanged += new System.EventHandler(this.SzybkoscRadioButton2_CheckedChanged);
            // 
            // SzybkoscRadioButton3
            // 
            this.SzybkoscRadioButton3.AutoSize = true;
            this.SzybkoscRadioButton3.Location = new System.Drawing.Point(112, 49);
            this.SzybkoscRadioButton3.Name = "SzybkoscRadioButton3";
            this.SzybkoscRadioButton3.Size = new System.Drawing.Size(85, 17);
            this.SzybkoscRadioButton3.TabIndex = 7;
            this.SzybkoscRadioButton3.TabStop = true;
            this.SzybkoscRadioButton3.Text = "Szybkość x1";
            this.SzybkoscRadioButton3.UseVisualStyleBackColor = true;
            this.SzybkoscRadioButton3.CheckedChanged += new System.EventHandler(this.SzybkoscRadioButton3_CheckedChanged);
            // 
            // SzybkoscRadioButton4
            // 
            this.SzybkoscRadioButton4.AutoSize = true;
            this.SzybkoscRadioButton4.Location = new System.Drawing.Point(112, 72);
            this.SzybkoscRadioButton4.Name = "SzybkoscRadioButton4";
            this.SzybkoscRadioButton4.Size = new System.Drawing.Size(85, 17);
            this.SzybkoscRadioButton4.TabIndex = 8;
            this.SzybkoscRadioButton4.TabStop = true;
            this.SzybkoscRadioButton4.Text = "Szybkość x2";
            this.SzybkoscRadioButton4.UseVisualStyleBackColor = true;
            this.SzybkoscRadioButton4.CheckedChanged += new System.EventHandler(this.SzybkoscRadioButton4_CheckedChanged);
            // 
            // SzybkoscRadioButton5
            // 
            this.SzybkoscRadioButton5.AutoSize = true;
            this.SzybkoscRadioButton5.Location = new System.Drawing.Point(112, 95);
            this.SzybkoscRadioButton5.Name = "SzybkoscRadioButton5";
            this.SzybkoscRadioButton5.Size = new System.Drawing.Size(85, 17);
            this.SzybkoscRadioButton5.TabIndex = 9;
            this.SzybkoscRadioButton5.TabStop = true;
            this.SzybkoscRadioButton5.Text = "Szybkość x4";
            this.SzybkoscRadioButton5.UseVisualStyleBackColor = true;
            this.SzybkoscRadioButton5.CheckedChanged += new System.EventHandler(this.SzybkoscRadioButton5_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AktualnaSzybkoscLabel);
            this.panel1.Controls.Add(this.SzybkoscLabel);
            this.panel1.Controls.Add(this.SzybkoscRadioButton1);
            this.panel1.Controls.Add(this.SzybkoscRadioButton5);
            this.panel1.Controls.Add(this.SzybkoscRadioButton2);
            this.panel1.Controls.Add(this.SzybkoscRadioButton4);
            this.panel1.Controls.Add(this.SzybkoscRadioButton3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 118);
            this.panel1.TabIndex = 10;
            // 
            // AktualnaSzybkoscLabel
            // 
            this.AktualnaSzybkoscLabel.AutoSize = true;
            this.AktualnaSzybkoscLabel.Location = new System.Drawing.Point(44, 53);
            this.AktualnaSzybkoscLabel.Name = "AktualnaSzybkoscLabel";
            this.AktualnaSzybkoscLabel.Size = new System.Drawing.Size(18, 13);
            this.AktualnaSzybkoscLabel.TabIndex = 12;
            this.AktualnaSzybkoscLabel.Text = "x1";
            // 
            // SzybkoscLabel
            // 
            this.SzybkoscLabel.AutoSize = true;
            this.SzybkoscLabel.Location = new System.Drawing.Point(3, 7);
            this.SzybkoscLabel.Name = "SzybkoscLabel";
            this.SzybkoscLabel.Size = new System.Drawing.Size(98, 13);
            this.SzybkoscLabel.TabIndex = 11;
            this.SzybkoscLabel.Text = "Szybkość Animacji:";
            // 
            // Opcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ZamknijButton);
            this.Name = "Opcje";
            this.Text = "Opcje";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZamknijButton;
        private System.Windows.Forms.RadioButton SzybkoscRadioButton1;
        private System.Windows.Forms.RadioButton SzybkoscRadioButton2;
        private System.Windows.Forms.RadioButton SzybkoscRadioButton3;
        private System.Windows.Forms.RadioButton SzybkoscRadioButton4;
        private System.Windows.Forms.RadioButton SzybkoscRadioButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SzybkoscLabel;
        private System.Windows.Forms.Label AktualnaSzybkoscLabel;
    }
}