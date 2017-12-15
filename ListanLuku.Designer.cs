namespace Ravintolatilaus
{
    partial class ListaLuku
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
            this.Sulje = new System.Windows.Forms.Button();
            this.MuokkaaListaa = new System.Windows.Forms.Button();
            this.ravintolaDataSet = new Ravintolatilaus.RavintolaDataSet();
            this.ravintolaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // ListaLuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 615);
            this.Controls.Add(this.MuokkaaListaa);
            this.Controls.Add(this.Sulje);
            this.Name = "ListaLuku";
            this.Text = "listanluku";
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sulje;
        private System.Windows.Forms.Button MuokkaaListaa;
        private System.Windows.Forms.BindingSource ravintolaDataSetBindingSource;
        private RavintolaDataSet ravintolaDataSet;
    }
}