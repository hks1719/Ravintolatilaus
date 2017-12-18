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
            this.kokki = new System.Windows.Forms.Button();
            this.tarjoilija = new System.Windows.Forms.Button();
            this.pomo = new System.Windows.Forms.Button();
            this.Sulje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kokki
            // 
            this.kokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kokki.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kokki.Location = new System.Drawing.Point(65, 71);
            this.kokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kokki.Name = "kokki";
            this.kokki.Size = new System.Drawing.Size(120, 85);
            this.kokki.TabIndex = 0;
            this.kokki.Text = "Kokki";
            this.kokki.UseVisualStyleBackColor = true;
            // 
            // tarjoilija
            // 
            this.tarjoilija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjoilija.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tarjoilija.Location = new System.Drawing.Point(249, 71);
            this.tarjoilija.Margin = new System.Windows.Forms.Padding(4);
            this.tarjoilija.Name = "tarjoilija";
            this.tarjoilija.Size = new System.Drawing.Size(120, 85);
            this.tarjoilija.TabIndex = 1;
            this.tarjoilija.Text = "Tarjoilija";
            this.tarjoilija.UseVisualStyleBackColor = true;
            this.tarjoilija.Click += new System.EventHandler(this.tarjoilija_Click_1);
            // 
            // pomo
            // 
            this.pomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pomo.Location = new System.Drawing.Point(435, 71);
            this.pomo.Margin = new System.Windows.Forms.Padding(4);
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
            this.Sulje.Margin = new System.Windows.Forms.Padding(4);
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
            this.ClientSize = new System.Drawing.Size(613, 353);
            this.Controls.Add(this.Sulje);
            this.Controls.Add(this.pomo);
            this.Controls.Add(this.tarjoilija);
            this.Controls.Add(this.kokki);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AloitusUI";
            this.Text = "Aloitusnäyttö";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kokki;
        private System.Windows.Forms.Button tarjoilija;
        private System.Windows.Forms.Button pomo;
        private System.Windows.Forms.Button Sulje;
    }
}

