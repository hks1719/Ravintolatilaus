namespace Ravintolatilaus
{
    partial class AloitusUI
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
            this.kokkiPainike = new System.Windows.Forms.Button();
            this.tarjoilija = new System.Windows.Forms.Button();
            this.pomo = new System.Windows.Forms.Button();
            this.Sulje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kokkiPainike
            // 
            this.kokkiPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kokkiPainike.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kokkiPainike.Location = new System.Drawing.Point(65, 71);
            this.kokkiPainike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kokkiPainike.Name = "kokkiPainike";
            this.kokkiPainike.Size = new System.Drawing.Size(120, 85);
            this.kokkiPainike.TabIndex = 0;
            this.kokkiPainike.Text = "Kokki";
            this.kokkiPainike.UseVisualStyleBackColor = true;
            this.kokkiPainike.Click += new System.EventHandler(this.kokkiPainike_Click);
            // 
            // tarjoilija
            // 
            this.tarjoilija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjoilija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tarjoilija.Location = new System.Drawing.Point(249, 71);
            this.tarjoilija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tarjoilija.Name = "tarjoilija";
            this.tarjoilija.Size = new System.Drawing.Size(120, 85);
            this.tarjoilija.TabIndex = 1;
            this.tarjoilija.Text = "Tarjoilija";
            this.tarjoilija.UseVisualStyleBackColor = true;
            this.tarjoilija.Click += new System.EventHandler(this.tarjoilija_Click_1);
            // 
            // pomo
            // 
            this.pomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pomo.Location = new System.Drawing.Point(435, 71);
            this.pomo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomo.Name = "pomo";
            this.pomo.Size = new System.Drawing.Size(120, 85);
            this.pomo.TabIndex = 2;
            this.pomo.Text = "Esimies";
            this.pomo.UseVisualStyleBackColor = true;
            this.pomo.Click += new System.EventHandler(this.pomo_Click);
            // 
            // Sulje
            // 
            this.Sulje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sulje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Sulje.Location = new System.Drawing.Point(65, 268);
            this.Sulje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(116, 41);
            this.Sulje.TabIndex = 3;
            this.Sulje.Text = "Sulje";
            this.Sulje.UseVisualStyleBackColor = true;
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // AloitusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 374);
            this.Controls.Add(this.Sulje);
            this.Controls.Add(this.pomo);
            this.Controls.Add(this.tarjoilija);
            this.Controls.Add(this.kokkiPainike);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AloitusUI";
            this.Text = "Aloitusnäyttö";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kokkiPainike;
        private System.Windows.Forms.Button tarjoilija;
        private System.Windows.Forms.Button pomo;
        private System.Windows.Forms.Button Sulje;
    }
}

