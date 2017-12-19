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
            this.Tilaukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tilaukset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Tilaukset.Location = new System.Drawing.Point(39, 105);
            this.Tilaukset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tilaukset.Name = "Tilaukset";
            this.Tilaukset.Size = new System.Drawing.Size(208, 71);
            this.Tilaukset.TabIndex = 0;
            this.Tilaukset.Text = "Tilaukset";
            this.Tilaukset.UseVisualStyleBackColor = true;
            this.Tilaukset.Click += new System.EventHandler(this.Tilaukset_Click);
            // 
            // Poydat
            // 
            this.Poydat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poydat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Poydat.Location = new System.Drawing.Point(288, 105);
            this.Poydat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Poydat.Name = "Poydat";
            this.Poydat.Size = new System.Drawing.Size(208, 71);
            this.Poydat.TabIndex = 2;
            this.Poydat.Text = "Pöytävaraukset";
            this.Poydat.UseVisualStyleBackColor = true;
            this.Poydat.Click += new System.EventHandler(this.Poydat_Click);
            // 
            // Ruokalista
            // 
            this.Ruokalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ruokalista.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Ruokalista.Location = new System.Drawing.Point(288, 208);
            this.Ruokalista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ruokalista.Name = "Ruokalista";
            this.Ruokalista.Size = new System.Drawing.Size(208, 71);
            this.Ruokalista.TabIndex = 3;
            this.Ruokalista.Text = "Ruokalista";
            this.Ruokalista.UseVisualStyleBackColor = true;
            this.Ruokalista.Click += new System.EventHandler(this.Ruokalista_Click);
            // 
            // Takaisin
            // 
            this.Takaisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Takaisin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Takaisin.Location = new System.Drawing.Point(39, 208);
            this.Takaisin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Takaisin.Name = "Takaisin";
            this.Takaisin.Size = new System.Drawing.Size(208, 71);
            this.Takaisin.TabIndex = 4;
            this.Takaisin.Text = "Päävalikkoon";
            this.Takaisin.UseVisualStyleBackColor = true;
            this.Takaisin.Click += new System.EventHandler(this.Takaisin_Click);
            // 
            // Esimies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 496);
            this.Controls.Add(this.Takaisin);
            this.Controls.Add(this.Ruokalista);
            this.Controls.Add(this.Poydat);
            this.Controls.Add(this.Tilaukset);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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