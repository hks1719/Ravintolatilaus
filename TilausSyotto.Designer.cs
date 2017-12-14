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
            this.asiakasnrotext = new System.Windows.Forms.TextBox();
            this.asiakasNroLabel = new System.Windows.Forms.Label();
            this.alkuruokaLabel = new System.Windows.Forms.Label();
            this.alkuruokanrotext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // poytaNroLabel
            // 
            this.poytaNroLabel.AutoSize = true;
            this.poytaNroLabel.Location = new System.Drawing.Point(39, 15);
            this.poytaNroLabel.Name = "poytaNroLabel";
            this.poytaNroLabel.Size = new System.Drawing.Size(72, 13);
            this.poytaNroLabel.TabIndex = 0;
            this.poytaNroLabel.Text = "Pöytä numero";
            // 
            // poytanrotext
            // 
            this.poytanrotext.Location = new System.Drawing.Point(138, 12);
            this.poytanrotext.Name = "poytanrotext";
            this.poytanrotext.Size = new System.Drawing.Size(100, 20);
            this.poytanrotext.TabIndex = 1;
            // 
            // asiakasnrotext
            // 
            this.asiakasnrotext.Location = new System.Drawing.Point(138, 47);
            this.asiakasnrotext.Name = "asiakasnrotext";
            this.asiakasnrotext.Size = new System.Drawing.Size(100, 20);
            this.asiakasnrotext.TabIndex = 2;
            // 
            // asiakasNroLabel
            // 
            this.asiakasNroLabel.AutoSize = true;
            this.asiakasNroLabel.Location = new System.Drawing.Point(39, 54);
            this.asiakasNroLabel.Name = "asiakasNroLabel";
            this.asiakasNroLabel.Size = new System.Drawing.Size(44, 13);
            this.asiakasNroLabel.TabIndex = 3;
            this.asiakasNroLabel.Text = "Asiakas";
            // 
            // alkuruokaLabel
            // 
            this.alkuruokaLabel.AutoSize = true;
            this.alkuruokaLabel.Location = new System.Drawing.Point(48, 93);
            this.alkuruokaLabel.Name = "alkuruokaLabel";
            this.alkuruokaLabel.Size = new System.Drawing.Size(55, 13);
            this.alkuruokaLabel.TabIndex = 4;
            this.alkuruokaLabel.Text = "Alkuruoka";
            // 
            // alkuruokanrotext
            // 
            this.alkuruokanrotext.Location = new System.Drawing.Point(138, 86);
            this.alkuruokanrotext.Name = "alkuruokanrotext";
            this.alkuruokanrotext.Size = new System.Drawing.Size(100, 20);
            this.alkuruokanrotext.TabIndex = 5;
            // 
            // TilausSyotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 394);
            this.Controls.Add(this.alkuruokanrotext);
            this.Controls.Add(this.alkuruokaLabel);
            this.Controls.Add(this.asiakasNroLabel);
            this.Controls.Add(this.asiakasnrotext);
            this.Controls.Add(this.poytanrotext);
            this.Controls.Add(this.poytaNroLabel);
            this.Name = "TilausSyotto";
            this.Text = "TilausSyotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poytaNroLabel;
        private System.Windows.Forms.TextBox poytanrotext;
        private System.Windows.Forms.TextBox asiakasnrotext;
        private System.Windows.Forms.Label asiakasNroLabel;
        private System.Windows.Forms.Label alkuruokaLabel;
        private System.Windows.Forms.TextBox alkuruokanrotext;
    }
}