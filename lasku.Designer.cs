namespace Ravintolatilaus
{
    partial class Lasku
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tilausID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ruokalista_annos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.haeTilaus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(81, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse pöytä";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tilausID,
            this.ruokalista_annos,
            this.hinta});
            this.listView1.Location = new System.Drawing.Point(81, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 297);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tilausID
            // 
            this.tilausID.Text = "Tilaus";
            this.tilausID.Width = 83;
            // 
            // ruokalista_annos
            // 
            this.ruokalista_annos.Text = "Ruokalista annos";
            this.ruokalista_annos.Width = 300;
            // 
            // hinta
            // 
            this.hinta.Text = "Hinta";
            this.hinta.Width = 117;
            // 
            // haeTilaus
            // 
            this.haeTilaus.Location = new System.Drawing.Point(236, 53);
            this.haeTilaus.Name = "haeTilaus";
            this.haeTilaus.Size = new System.Drawing.Size(179, 40);
            this.haeTilaus.TabIndex = 3;
            this.haeTilaus.Text = "Hae tilaus";
            this.haeTilaus.UseVisualStyleBackColor = true;
            this.haeTilaus.Click += new System.EventHandler(this.HaeTilaus_Click);
            // 
            // Lasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 510);
            this.Controls.Add(this.haeTilaus);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Lasku";
            this.Text = "Lasku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tilausID;
        private System.Windows.Forms.ColumnHeader ruokalista_annos;
        private System.Windows.Forms.ColumnHeader hinta;
        private System.Windows.Forms.Button haeTilaus;
    }
}