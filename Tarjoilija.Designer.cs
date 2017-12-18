namespace Ravintolatilaus
{
    partial class Tarjoilija
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
            this.uusiTilaus = new System.Windows.Forms.Button();
            this.ruokalista = new System.Windows.Forms.Button();
            this.lasku = new System.Windows.Forms.Button();
            this.poytavaraukset = new System.Windows.Forms.Button();
            this.paluuAloitusnayttoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uusiTilaus
            // 
            this.uusiTilaus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uusiTilaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uusiTilaus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.uusiTilaus.Location = new System.Drawing.Point(70, 45);
            this.uusiTilaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uusiTilaus.Name = "uusiTilaus";
            this.uusiTilaus.Size = new System.Drawing.Size(200, 100);
            this.uusiTilaus.TabIndex = 0;
            this.uusiTilaus.Text = "Uusi tilaus";
            this.uusiTilaus.UseVisualStyleBackColor = false;
            this.uusiTilaus.Click += new System.EventHandler(this.uusiTilaus_Click);
            // 
            // ruokalista
            // 
            this.ruokalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruokalista.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ruokalista.Location = new System.Drawing.Point(348, 45);
            this.ruokalista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ruokalista.Name = "ruokalista";
            this.ruokalista.Size = new System.Drawing.Size(200, 100);
            this.ruokalista.TabIndex = 2;
            this.ruokalista.Text = "Ruokalista";
            this.ruokalista.UseVisualStyleBackColor = true;
            // 
            // lasku
            // 
            this.lasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasku.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lasku.Location = new System.Drawing.Point(70, 191);
            this.lasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lasku.Name = "lasku";
            this.lasku.Size = new System.Drawing.Size(200, 100);
            this.lasku.TabIndex = 3;
            this.lasku.Text = "Lasku";
            this.lasku.UseVisualStyleBackColor = true;
            // 
            // poytavaraukset
            // 
            this.poytavaraukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poytavaraukset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.poytavaraukset.Location = new System.Drawing.Point(348, 191);
            this.poytavaraukset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.poytavaraukset.Name = "poytavaraukset";
            this.poytavaraukset.Size = new System.Drawing.Size(200, 100);
            this.poytavaraukset.TabIndex = 4;
            this.poytavaraukset.Text = "Pöytävaraukset";
            this.poytavaraukset.UseVisualStyleBackColor = true;
            // 
            // paluuAloitusnayttoon
            // 
            this.paluuAloitusnayttoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paluuAloitusnayttoon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paluuAloitusnayttoon.Location = new System.Drawing.Point(348, 344);
            this.paluuAloitusnayttoon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paluuAloitusnayttoon.Name = "paluuAloitusnayttoon";
            this.paluuAloitusnayttoon.Size = new System.Drawing.Size(200, 63);
            this.paluuAloitusnayttoon.TabIndex = 5;
            this.paluuAloitusnayttoon.Text = "Paluu aloitusnäyttöön";
            this.paluuAloitusnayttoon.UseVisualStyleBackColor = true;
            // 
            // Tarjoilija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 427);
            this.Controls.Add(this.paluuAloitusnayttoon);
            this.Controls.Add(this.poytavaraukset);
            this.Controls.Add(this.lasku);
            this.Controls.Add(this.ruokalista);
            this.Controls.Add(this.uusiTilaus);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tarjoilija";
            this.Text = "Tarjoilija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uusiTilaus;
        private System.Windows.Forms.Button ruokalista;
        private System.Windows.Forms.Button lasku;
        private System.Windows.Forms.Button poytavaraukset;
        private System.Windows.Forms.Button paluuAloitusnayttoon;
    }
}