
namespace Praca_Inżynierska_Piotr_Złoch.GUI
{
    partial class MenuGlowne
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
            this.WyborPoziomuButton = new System.Windows.Forms.Button();
            this.OpcjeButton = new System.Windows.Forms.Button();
            this.ZamknijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WyborPoziomuButton
            // 
            this.WyborPoziomuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WyborPoziomuButton.Location = new System.Drawing.Point(12, 12);
            this.WyborPoziomuButton.Name = "WyborPoziomuButton";
            this.WyborPoziomuButton.Size = new System.Drawing.Size(250, 100);
            this.WyborPoziomuButton.TabIndex = 5;
            this.WyborPoziomuButton.Text = "WyborPoziomow";
            this.WyborPoziomuButton.UseVisualStyleBackColor = true;
            this.WyborPoziomuButton.Click += new System.EventHandler(this.WyborPoziomuButton_Click);
            // 
            // OpcjeButton
            // 
            this.OpcjeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpcjeButton.Location = new System.Drawing.Point(12, 118);
            this.OpcjeButton.Name = "OpcjeButton";
            this.OpcjeButton.Size = new System.Drawing.Size(250, 100);
            this.OpcjeButton.TabIndex = 4;
            this.OpcjeButton.Text = "Opcje";
            this.OpcjeButton.UseVisualStyleBackColor = true;
            this.OpcjeButton.Click += new System.EventHandler(this.OpcjeButton_Click);
            // 
            // ZamknijButton
            // 
            this.ZamknijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZamknijButton.Location = new System.Drawing.Point(12, 224);
            this.ZamknijButton.Name = "ZamknijButton";
            this.ZamknijButton.Size = new System.Drawing.Size(250, 100);
            this.ZamknijButton.TabIndex = 3;
            this.ZamknijButton.Text = "Zamknij";
            this.ZamknijButton.UseVisualStyleBackColor = true;
            this.ZamknijButton.Click += new System.EventHandler(this.ZamknijButton_Click);
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 331);
            this.Controls.Add(this.WyborPoziomuButton);
            this.Controls.Add(this.OpcjeButton);
            this.Controls.Add(this.ZamknijButton);
            this.Name = "MenuGlowne";
            this.Text = "MenuGlowne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WyborPoziomuButton;
        private System.Windows.Forms.Button OpcjeButton;
        private System.Windows.Forms.Button ZamknijButton;
    }
}