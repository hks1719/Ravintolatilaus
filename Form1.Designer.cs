namespace Ravintolatilaus
{
    partial class Form1
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
            this.kokki.Location = new System.Drawing.Point(22, 35);
            this.kokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kokki.Name = "kokki";
            this.kokki.Size = new System.Drawing.Size(64, 58);
            this.kokki.TabIndex = 0;
            this.kokki.Text = "Kokki";
            this.kokki.UseVisualStyleBackColor = true;
            // 
            // tarjoilija
            // 
            this.tarjoilija.Location = new System.Drawing.Point(125, 35);
            this.tarjoilija.Name = "tarjoilija";
            this.tarjoilija.Size = new System.Drawing.Size(75, 58);
            this.tarjoilija.TabIndex = 1;
            this.tarjoilija.Text = "Tarjoilija";
            this.tarjoilija.UseVisualStyleBackColor = true;
            // 
            // esimies = pomo 
            // 
            this.pomo.Location = new System.Drawing.Point(249, 35);
            this.pomo.Name = "esimies";
            this.pomo.Size = new System.Drawing.Size(75, 58);
            this.pomo.TabIndex = 2;
            this.pomo.Text = "Esimies";
            this.pomo.UseVisualStyleBackColor = true;
            this.pomo.Click += new System.EventHandler(this.pomo_Click);
            // 
            // Sulje
            // 
            this.Sulje.Location = new System.Drawing.Point(12, 242);
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(87, 33);
            this.Sulje.TabIndex = 3;
            this.Sulje.Text = "Sulje";
            this.Sulje.UseVisualStyleBackColor = true;
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.Sulje);
            this.Controls.Add(this.pomo);
            this.Controls.Add(this.tarjoilija);
            this.Controls.Add(this.kokki);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kokki;
        private System.Windows.Forms.Button tarjoilija;
        private System.Windows.Forms.Button pomo;
        private System.Windows.Forms.Button Sulje;
    }
}

