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
            this.Tilaukset = new System.Windows.Forms.Button();
            this.Poydat = new System.Windows.Forms.Button();
            this.Ruokalista = new System.Windows.Forms.Button();
            this.Takaisin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tilaukset
            // 
            this.Tilaukset.Location = new System.Drawing.Point(29, 85);
            this.Tilaukset.Name = "Tilaukset";
            this.Tilaukset.Size = new System.Drawing.Size(156, 58);
            this.Tilaukset.TabIndex = 0;
            this.Tilaukset.Text = "Tilaukset";
            this.Tilaukset.UseVisualStyleBackColor = true;
            this.Tilaukset.Click += new System.EventHandler(this.Tilaukset_Click);
            // 
            // Poydat
            // 
            this.Poydat.Location = new System.Drawing.Point(216, 85);
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
            this.Takaisin.Location = new System.Drawing.Point(29, 169);
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
            this.Controls.Add(this.Tilaukset);
            this.Name = "Esimies";
            this.Text = "Esimies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tilaukset;
        private System.Windows.Forms.Button Poydat;
        private System.Windows.Forms.Button Ruokalista;
        private System.Windows.Forms.Button Takaisin;
    }
}