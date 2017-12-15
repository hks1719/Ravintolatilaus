using System.Windows.Forms;

namespace Ravintolatilaus
{
    partial class Esimies
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
            this.Avoimet = new System.Windows.Forms.Button();
            this.Valmiit = new System.Windows.Forms.Button();
            this.Poydat = new System.Windows.Forms.Button();
            this.Ruokalista = new System.Windows.Forms.Button();
            this.Takaisin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Avoimet
            // 
            this.Avoimet.Location = new System.Drawing.Point(29, 85);
            this.Avoimet.Name = "Avoimet";
            this.Avoimet.Size = new System.Drawing.Size(156, 58);
            this.Avoimet.TabIndex = 0;
            this.Avoimet.Text = "Avoimet tilaukset";
            this.Avoimet.UseVisualStyleBackColor = true;
            this.Avoimet.Click += new System.EventHandler(this.Avoimet_Click);
            // 
            // Valmiit
            // 
            this.Valmiit.Location = new System.Drawing.Point(216, 85);
            this.Valmiit.Name = "Valmiit";
            this.Valmiit.Size = new System.Drawing.Size(156, 58);
            this.Valmiit.TabIndex = 1;
            this.Valmiit.Text = "Valmiit tilaukset";
            this.Valmiit.UseVisualStyleBackColor = true;
            this.Valmiit.Click += new System.EventHandler(this.Valmiit_Click);
            // 
            // Poydat
            // 
            this.Poydat.Location = new System.Drawing.Point(29, 169);
            this.Poydat.Name = "Poydat";
            this.Poydat.Size = new System.Drawing.Size(156, 58);
            this.Poydat.TabIndex = 2;
            this.Poydat.Text = "Pöytävaraukset";
            this.Poydat.UseVisualStyleBackColor = true;
            this.Poydat.Click += new System.EventHandler(this.Poydat_Click);
            // 
            // Ruokalista
            // 
            this.Ruokalista.Location = new System.Drawing.Point(216, 169);
            this.Ruokalista.Name = "Ruokalista";
            this.Ruokalista.Size = new System.Drawing.Size(156, 58);
            this.Ruokalista.TabIndex = 3;
            this.Ruokalista.Text = "Ruokalista";
            this.Ruokalista.UseVisualStyleBackColor = true;
            // 
            // Takaisin
            // 
            this.Takaisin.Location = new System.Drawing.Point(29, 309);
            this.Takaisin.Name = "Takaisin";
            this.Takaisin.Size = new System.Drawing.Size(156, 58);
            this.Takaisin.TabIndex = 4;
            this.Takaisin.Text = "Päävalikkoon";
            this.Takaisin.UseVisualStyleBackColor = true;
            this.Takaisin.Click += new System.EventHandler(this.Takaisin_Click);
            // 
            // Esimies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 403);
            this.Controls.Add(this.Takaisin);
            this.Controls.Add(this.Ruokalista);
            this.Controls.Add(this.Poydat);
            this.Controls.Add(this.Valmiit);
            this.Controls.Add(this.Avoimet);
            this.Name = "Esimies";
            this.Text = "Esimies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Avoimet;
        private System.Windows.Forms.Button Valmiit;
        private System.Windows.Forms.Button Poydat;
        private System.Windows.Forms.Button Ruokalista;
        private System.Windows.Forms.Button Takaisin;
    }
}