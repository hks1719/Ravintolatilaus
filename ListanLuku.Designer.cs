namespace Ravintolatilaus
{
    partial class ListanLuku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListanLuku));
            this.Sulje = new System.Windows.Forms.Button();
            this.MuokkaaListaa = new System.Windows.Forms.Button();
            this.ravintolaDataSet = new Ravintolatilaus.RavintolaDataSet();
            this.ravintolaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sulje
            // 
            this.Sulje.Location = new System.Drawing.Point(25, 561);
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(176, 42);
            this.Sulje.TabIndex = 0;
            this.Sulje.Text = "Sulje";
            this.Sulje.UseVisualStyleBackColor = true;
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // MuokkaaListaa
            // 
            this.MuokkaaListaa.Location = new System.Drawing.Point(238, 561);
            this.MuokkaaListaa.Name = "MuokkaaListaa";
            this.MuokkaaListaa.Size = new System.Drawing.Size(176, 42);
            this.MuokkaaListaa.TabIndex = 1;
            this.MuokkaaListaa.Text = "Muokkaa ruokalistaa";
            this.MuokkaaListaa.UseVisualStyleBackColor = true;
            this.MuokkaaListaa.Click += new System.EventHandler(this.MuokkaaListaa_Click);
            // 
            // ravintolaDataSet
            // 
            this.ravintolaDataSet.DataSetName = "RavintolaDataSet";
            this.ravintolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ravintolaDataSetBindingSource
            // 
            this.ravintolaDataSetBindingSource.DataSource = this.ravintolaDataSet;
            this.ravintolaDataSetBindingSource.Position = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(20, 23);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(393, 456);
            this.printPreviewControl1.TabIndex = 2;
            // 
            // ListanLuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 615);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.MuokkaaListaa);
            this.Controls.Add(this.Sulje);
            this.Name = "ListanLuku";
            this.Text = "Pöytävaraukset";
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sulje;
        private System.Windows.Forms.Button MuokkaaListaa;
        private System.Windows.Forms.BindingSource ravintolaDataSetBindingSource;
        private RavintolaDataSet ravintolaDataSet;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        public System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}