namespace Ravintolatilaus
{
    partial class Ruokalista
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
            this.paluuTarjoilijaNayttoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paluuTarjoilijaNayttoon
            // 
            this.paluuTarjoilijaNayttoon.Location = new System.Drawing.Point(39, 166);
            this.paluuTarjoilijaNayttoon.Name = "paluuTarjoilijaNayttoon";
            this.paluuTarjoilijaNayttoon.Size = new System.Drawing.Size(128, 65);
            this.paluuTarjoilijaNayttoon.TabIndex = 0;
            this.paluuTarjoilijaNayttoon.Text = "Paluu tarjoilija näyttöön";
            this.paluuTarjoilijaNayttoon.UseVisualStyleBackColor = true;
            // 
            // Ruokalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 253);
            this.Controls.Add(this.paluuTarjoilijaNayttoon);
            this.Name = "Ruokalista";
            this.Text = "Ruokalista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paluuTarjoilijaNayttoon;
    }
}