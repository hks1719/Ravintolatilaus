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
            this.keskeneraisetTilaukset = new System.Windows.Forms.Button();
            this.ruokalista = new System.Windows.Forms.Button();
            this.lasku = new System.Windows.Forms.Button();
            this.poytavaraukset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uusiTilaus
            // 
            this.uusiTilaus.Location = new System.Drawing.Point(35, 32);
            this.uusiTilaus.Name = "uusiTilaus";
            this.uusiTilaus.Size = new System.Drawing.Size(153, 93);
            this.uusiTilaus.TabIndex = 0;
            this.uusiTilaus.Text = "Uusi tilaus";
            this.uusiTilaus.UseVisualStyleBackColor = true;
            // 
            // keskeneraisetTilaukset
            // 
            this.keskeneraisetTilaukset.Location = new System.Drawing.Point(222, 32);
            this.keskeneraisetTilaukset.Name = "keskeneraisetTilaukset";
            this.keskeneraisetTilaukset.Size = new System.Drawing.Size(153, 93);
            this.keskeneraisetTilaukset.TabIndex = 1;
            this.keskeneraisetTilaukset.Text = "Keskeneräiset tilaukset";
            this.keskeneraisetTilaukset.UseVisualStyleBackColor = true;
            // 
            // ruokalista
            // 
            this.ruokalista.Location = new System.Drawing.Point(412, 32);
            this.ruokalista.Name = "ruokalista";
            this.ruokalista.Size = new System.Drawing.Size(153, 93);
            this.ruokalista.TabIndex = 2;
            this.ruokalista.Text = "Ruokalista";
            this.ruokalista.UseVisualStyleBackColor = true;
            // 
            // lasku
            // 
            this.lasku.Location = new System.Drawing.Point(132, 191);
            this.lasku.Name = "lasku";
            this.lasku.Size = new System.Drawing.Size(153, 93);
            this.lasku.TabIndex = 3;
            this.lasku.Text = "Lasku";
            this.lasku.UseVisualStyleBackColor = true;
            // 
            // poytavaraukset
            // 
            this.poytavaraukset.Location = new System.Drawing.Point(327, 191);
            this.poytavaraukset.Name = "poytavaraukset";
            this.poytavaraukset.Size = new System.Drawing.Size(153, 93);
            this.poytavaraukset.TabIndex = 4;
            this.poytavaraukset.Text = "Pöytävaraukset";
            this.poytavaraukset.UseVisualStyleBackColor = true;
            // 
            // Tarjoilija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 427);
            this.Controls.Add(this.poytavaraukset);
            this.Controls.Add(this.lasku);
            this.Controls.Add(this.ruokalista);
            this.Controls.Add(this.keskeneraisetTilaukset);
            this.Controls.Add(this.uusiTilaus);
            this.Name = "Tarjoilija";
            this.Text = "Tarjoilija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uusiTilaus;
        private System.Windows.Forms.Button keskeneraisetTilaukset;
        private System.Windows.Forms.Button ruokalista;
        private System.Windows.Forms.Button lasku;
        private System.Windows.Forms.Button poytavaraukset;
    }
}