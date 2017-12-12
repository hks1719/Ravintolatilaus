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
            this.esimies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kokki
            // 
            this.kokki.Location = new System.Drawing.Point(29, 43);
            this.kokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kokki.Name = "kokki";
            this.kokki.Size = new System.Drawing.Size(85, 71);
            this.kokki.TabIndex = 0;
            this.kokki.Text = "Kokki";
            this.kokki.UseVisualStyleBackColor = true;
            // 
            // tarjoilija
            // 
            this.tarjoilija.Location = new System.Drawing.Point(167, 43);
            this.tarjoilija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tarjoilija.Name = "tarjoilija";
            this.tarjoilija.Size = new System.Drawing.Size(100, 71);
            this.tarjoilija.TabIndex = 1;
            this.tarjoilija.Text = "Tarjoilija";
            this.tarjoilija.UseVisualStyleBackColor = true;
            // 
            // esimies
            // 
            this.esimies.Location = new System.Drawing.Point(332, 43);
            this.esimies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.esimies.Name = "esimies";
            this.esimies.Size = new System.Drawing.Size(100, 71);
            this.esimies.TabIndex = 2;
            this.esimies.Text = "Esimies";
            this.esimies.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 353);
            this.Controls.Add(this.esimies);
            this.Controls.Add(this.tarjoilija);
            this.Controls.Add(this.kokki);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kokki;
        private System.Windows.Forms.Button tarjoilija;
        private System.Windows.Forms.Button esimies;
    }
}

