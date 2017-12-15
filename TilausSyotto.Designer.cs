namespace Ravintolatilaus
{
    partial class TilausSyotto
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
            this.poytaNroLabel = new System.Windows.Forms.Label();
            this.poytanrotext = new System.Windows.Forms.TextBox();
            this.poytapaikkaNrotext = new System.Windows.Forms.TextBox();
            this.poytapaikkaNroLabel = new System.Windows.Forms.Label();
            this.alkuruokaLabel = new System.Windows.Forms.Label();
            this.alkuruokanrotext = new System.Windows.Forms.TextBox();
            this.TilausSyottoTallenna = new System.Windows.Forms.Button();
            this.palaaTarjoilijaNayttoon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poytaNroLabel
            // 
            this.poytaNroLabel.AutoSize = true;
            this.poytaNroLabel.Location = new System.Drawing.Point(52, 18);
            this.poytaNroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poytaNroLabel.Name = "poytaNroLabel";
            this.poytaNroLabel.Size = new System.Drawing.Size(96, 17);
            this.poytaNroLabel.TabIndex = 0;
            this.poytaNroLabel.Text = "Pöytä numero";
            // 
            // poytanrotext
            // 
            this.poytanrotext.Location = new System.Drawing.Point(184, 15);
            this.poytanrotext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poytanrotext.Name = "poytanrotext";
            this.poytanrotext.Size = new System.Drawing.Size(132, 22);
            this.poytanrotext.TabIndex = 1;
            // 
            // poytapaikkaNrotext
            // 
            this.poytapaikkaNrotext.Location = new System.Drawing.Point(184, 58);
            this.poytapaikkaNrotext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.poytapaikkaNrotext.Name = "poytapaikkaNrotext";
            this.poytapaikkaNrotext.Size = new System.Drawing.Size(132, 22);
            this.poytapaikkaNrotext.TabIndex = 2;
            // 
            // poytapaikkaNroLabel
            // 
            this.poytapaikkaNroLabel.AutoSize = true;
            this.poytapaikkaNroLabel.Location = new System.Drawing.Point(52, 66);
            this.poytapaikkaNroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poytapaikkaNroLabel.Name = "poytapaikkaNroLabel";
            this.poytapaikkaNroLabel.Size = new System.Drawing.Size(86, 17);
            this.poytapaikkaNroLabel.TabIndex = 3;
            this.poytapaikkaNroLabel.Text = "PöytäPaikka";
            // 
            // alkuruokaLabel
            // 
            this.alkuruokaLabel.AutoSize = true;
            this.alkuruokaLabel.Location = new System.Drawing.Point(64, 114);
            this.alkuruokaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alkuruokaLabel.Name = "alkuruokaLabel";
            this.alkuruokaLabel.Size = new System.Drawing.Size(71, 17);
            this.alkuruokaLabel.TabIndex = 4;
            this.alkuruokaLabel.Text = "Alkuruoka";
            // 
            // alkuruokanrotext
            // 
            this.alkuruokanrotext.Location = new System.Drawing.Point(184, 106);
            this.alkuruokanrotext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alkuruokanrotext.Name = "alkuruokanrotext";
            this.alkuruokanrotext.Size = new System.Drawing.Size(132, 22);
            this.alkuruokanrotext.TabIndex = 5;
            // 
            // TilausSyottoTallenna
            // 
            this.TilausSyottoTallenna.Location = new System.Drawing.Point(439, 338);
            this.TilausSyottoTallenna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TilausSyottoTallenna.Name = "TilausSyottoTallenna";
            this.TilausSyottoTallenna.Size = new System.Drawing.Size(100, 67);
            this.TilausSyottoTallenna.TabIndex = 6;
            this.TilausSyottoTallenna.Text = "Tallenna";
            this.TilausSyottoTallenna.UseVisualStyleBackColor = true;
            this.TilausSyottoTallenna.Click += new System.EventHandler(this.TilausSyottoTallenna_Click);
            // 
            // palaaTarjoilijaNayttoon
            // 
            this.palaaTarjoilijaNayttoon.Location = new System.Drawing.Point(108, 338);
            this.palaaTarjoilijaNayttoon.Margin = new System.Windows.Forms.Padding(4);
            this.palaaTarjoilijaNayttoon.Name = "palaaTarjoilijaNayttoon";
            this.palaaTarjoilijaNayttoon.Size = new System.Drawing.Size(100, 67);
            this.palaaTarjoilijaNayttoon.TabIndex = 7;
            this.palaaTarjoilijaNayttoon.Text = "Palaa tarjoilija näyttöön";
            this.palaaTarjoilijaNayttoon.UseVisualStyleBackColor = true;
            // 
            // TilausSyotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 485);
            this.Controls.Add(this.palaaTarjoilijaNayttoon);
            this.Controls.Add(this.TilausSyottoTallenna);
            this.Controls.Add(this.alkuruokanrotext);
            this.Controls.Add(this.alkuruokaLabel);
            this.Controls.Add(this.poytapaikkaNroLabel);
            this.Controls.Add(this.poytapaikkaNrotext);
            this.Controls.Add(this.poytanrotext);
            this.Controls.Add(this.poytaNroLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TilausSyotto";
            this.Text = "TilausSyotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poytaNroLabel;
        private System.Windows.Forms.TextBox poytanrotext;
        private System.Windows.Forms.TextBox poytapaikkaNrotext;
        private System.Windows.Forms.Label poytapaikkaNroLabel;
        private System.Windows.Forms.Label alkuruokaLabel;
        private System.Windows.Forms.TextBox alkuruokanrotext;
        private System.Windows.Forms.Button TilausSyottoTallenna;
        private System.Windows.Forms.Button palaaTarjoilijaNayttoon;
    }
}