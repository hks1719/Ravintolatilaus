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
            this.ruokalista = new System.Windows.Forms.Button();
            this.tilaus = new System.Windows.Forms.Button();
            this.poytavaraukset = new System.Windows.Forms.Button();
            this.paluuAloitusnayttoon = new System.Windows.Forms.Button();
            this.uusiTilaus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ruokalista
            // 
            this.ruokalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruokalista.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ruokalista.Location = new System.Drawing.Point(261, 37);
            this.ruokalista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ruokalista.Name = "ruokalista";
            this.ruokalista.Size = new System.Drawing.Size(150, 81);
            this.ruokalista.TabIndex = 2;
            this.ruokalista.Text = "Ruokalista";
            this.ruokalista.UseVisualStyleBackColor = true;
            // 
            // tilaus
            // 
            this.tilaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilaus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tilaus.Location = new System.Drawing.Point(67, 37);
            this.tilaus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tilaus.Name = "tilaus";
            this.tilaus.Size = new System.Drawing.Size(150, 81);
            this.tilaus.TabIndex = 3;
            this.tilaus.Text = "Tilaus";
            this.tilaus.UseVisualStyleBackColor = true;
            // 
            // poytavaraukset
            // 
            this.poytavaraukset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poytavaraukset.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.poytavaraukset.Location = new System.Drawing.Point(67, 150);
            this.poytavaraukset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.poytavaraukset.Name = "poytavaraukset";
            this.poytavaraukset.Size = new System.Drawing.Size(150, 81);
            this.poytavaraukset.TabIndex = 4;
            this.poytavaraukset.Text = "Pöytävaraukset";
            this.poytavaraukset.UseVisualStyleBackColor = true;
            // 
            // paluuAloitusnayttoon
            // 
            this.paluuAloitusnayttoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paluuAloitusnayttoon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paluuAloitusnayttoon.Location = new System.Drawing.Point(261, 274);
            this.paluuAloitusnayttoon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paluuAloitusnayttoon.Name = "paluuAloitusnayttoon";
            this.paluuAloitusnayttoon.Size = new System.Drawing.Size(150, 51);
            this.paluuAloitusnayttoon.TabIndex = 5;
            this.paluuAloitusnayttoon.Text = "Paluu aloitusnäyttöön";
            this.paluuAloitusnayttoon.UseVisualStyleBackColor = true;
            // 
            // uusiTilaus
            // 
            this.uusiTilaus.Location = new System.Drawing.Point(301, 189);
            this.uusiTilaus.Name = "uusiTilaus";
            this.uusiTilaus.Size = new System.Drawing.Size(110, 21);
            this.uusiTilaus.TabIndex = 6;
            this.uusiTilaus.Text = "Testi Uusi tilaus";
            this.uusiTilaus.UseVisualStyleBackColor = true;
            this.uusiTilaus.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tarjoilija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 347);
            this.Controls.Add(this.uusiTilaus);
            this.Controls.Add(this.paluuAloitusnayttoon);
            this.Controls.Add(this.poytavaraukset);
            this.Controls.Add(this.tilaus);
            this.Controls.Add(this.ruokalista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tarjoilija";
            this.Text = "Tarjoilija";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ruokalista;
        private System.Windows.Forms.Button tilaus;
        private System.Windows.Forms.Button poytavaraukset;
        private System.Windows.Forms.Button paluuAloitusnayttoon;
        private System.Windows.Forms.Button uusiTilaus;
    }
}