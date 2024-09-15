
namespace Miasto_w_heroes
{
    partial class wybor_map
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
            this.Graj_Mape1_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Graj_Mape1_button
            // 
            this.Graj_Mape1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Graj_Mape1_button.Location = new System.Drawing.Point(12, 12);
            this.Graj_Mape1_button.Name = "Graj_Mape1_button";
            this.Graj_Mape1_button.Size = new System.Drawing.Size(135, 62);
            this.Graj_Mape1_button.TabIndex = 7;
            this.Graj_Mape1_button.Text = "Mapa 1";
            this.Graj_Mape1_button.UseVisualStyleBackColor = true;
            this.Graj_Mape1_button.Click += new System.EventHandler(this.Graj_Mape1_button_Click);
            // 
            // wybor_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Graj_Mape1_button);
            this.Name = "wybor_map";
            this.Text = "wybor_map";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Graj_Mape1_button;
    }
}