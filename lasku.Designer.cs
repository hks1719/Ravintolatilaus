﻿namespace Ravintolatilaus
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
            this.poyta_poytaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ruokalista_annos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.haeTilaus = new System.Windows.Forms.Button();
            this.tilausYhteensa_label = new System.Windows.Forms.Label();
            this.tilausYhteensa = new System.Windows.Forms.TextBox();
            this.NaytaYhteensa = new System.Windows.Forms.Button();
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
            this.comboBox1.Location = new System.Drawing.Point(29, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valitse pöytä";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tilausID,
            this.poyta_poytaID,
            this.ruokalista_annos,
            this.hinta});
            this.listView1.Location = new System.Drawing.Point(29, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 244);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tilausID
            // 
            this.tilausID.Text = "Tilaus";
            this.tilausID.Width = 83;
            // 
            // poyta_poytaID
            // 
            this.poyta_poytaID.Text = "PöytäID";
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
            this.haeTilaus.Location = new System.Drawing.Point(186, 49);
            this.haeTilaus.Name = "haeTilaus";
            this.haeTilaus.Size = new System.Drawing.Size(179, 40);
            this.haeTilaus.TabIndex = 3;
            this.haeTilaus.Text = "Hae tilaus";
            this.haeTilaus.UseVisualStyleBackColor = true;
            this.haeTilaus.Click += new System.EventHandler(this.HaeTilaus_Click);
            // 
            // tilausYhteensa_label
            // 
            this.tilausYhteensa_label.AutoSize = true;
            this.tilausYhteensa_label.Location = new System.Drawing.Point(332, 408);
            this.tilausYhteensa_label.Name = "tilausYhteensa_label";
            this.tilausYhteensa_label.Size = new System.Drawing.Size(110, 17);
            this.tilausYhteensa_label.TabIndex = 4;
            this.tilausYhteensa_label.Text = "Tilaus Yhteensä";
            // 
            // tilausYhteensa
            // 
            this.tilausYhteensa.Location = new System.Drawing.Point(468, 408);
            this.tilausYhteensa.Multiline = true;
            this.tilausYhteensa.Name = "tilausYhteensa";
            this.tilausYhteensa.Size = new System.Drawing.Size(120, 77);
            this.tilausYhteensa.TabIndex = 5;
            // 
            // NaytaYhteensa
            // 
            this.NaytaYhteensa.Location = new System.Drawing.Point(133, 408);
            this.NaytaYhteensa.Name = "NaytaYhteensa";
            this.NaytaYhteensa.Size = new System.Drawing.Size(152, 77);
            this.NaytaYhteensa.TabIndex = 6;
            this.NaytaYhteensa.Text = "Näytä tilauksen yhteissumma";
            this.NaytaYhteensa.UseVisualStyleBackColor = true;
            this.NaytaYhteensa.Click += new System.EventHandler(this.NaytaYhteensa_Click);
            // 
            // Lasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 587);
            this.Controls.Add(this.NaytaYhteensa);
            this.Controls.Add(this.tilausYhteensa);
            this.Controls.Add(this.tilausYhteensa_label);
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
        private System.Windows.Forms.ColumnHeader poyta_poytaID;
        private System.Windows.Forms.Label tilausYhteensa_label;
        private System.Windows.Forms.TextBox tilausYhteensa;
        private System.Windows.Forms.Button NaytaYhteensa;
    }
}