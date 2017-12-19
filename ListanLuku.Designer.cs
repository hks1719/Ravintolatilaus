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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sulje = new System.Windows.Forms.Button();
            this.MuokkaaPoytia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poytaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakaspaikkojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poytaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet1 = new Ravintolatilaus.RavintolaDataSet1();
            this.poytaTableAdapter = new Ravintolatilaus.RavintolaDataSet1TableAdapters.poytaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poytaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sulje
            // 
            this.Sulje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sulje.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Sulje.Location = new System.Drawing.Point(52, 388);
            this.Sulje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(215, 50);
            this.Sulje.TabIndex = 0;
            this.Sulje.Text = "Sulje";
            this.Sulje.UseVisualStyleBackColor = true;
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // MuokkaaPoytia
            // 
            this.MuokkaaPoytia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuokkaaPoytia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MuokkaaPoytia.Location = new System.Drawing.Point(320, 388);
            this.MuokkaaPoytia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MuokkaaPoytia.Name = "MuokkaaPoytia";
            this.MuokkaaPoytia.Size = new System.Drawing.Size(215, 50);
            this.MuokkaaPoytia.TabIndex = 1;
            this.MuokkaaPoytia.Text = "Muokkaa pöytävarauksia";
            this.MuokkaaPoytia.UseVisualStyleBackColor = true;
            this.MuokkaaPoytia.Click += new System.EventHandler(this.MuokkaaListaa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poytaIDDataGridViewTextBoxColumn,
            this.asiakaspaikkojaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poytaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(52, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // poytaIDDataGridViewTextBoxColumn
            // 
            this.poytaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poytaIDDataGridViewTextBoxColumn.DataPropertyName = "poytaID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.poytaIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.poytaIDDataGridViewTextBoxColumn.HeaderText = "poytaID";
            this.poytaIDDataGridViewTextBoxColumn.Name = "poytaIDDataGridViewTextBoxColumn";
            this.poytaIDDataGridViewTextBoxColumn.Width = 85;
            // 
            // asiakaspaikkojaDataGridViewTextBoxColumn
            // 
            this.asiakaspaikkojaDataGridViewTextBoxColumn.DataPropertyName = "asiakaspaikkoja";
            this.asiakaspaikkojaDataGridViewTextBoxColumn.HeaderText = "asiakaspaikkoja";
            this.asiakaspaikkojaDataGridViewTextBoxColumn.Name = "asiakaspaikkojaDataGridViewTextBoxColumn";
            // 
            // poytaBindingSource
            // 
            this.poytaBindingSource.DataMember = "poyta";
            this.poytaBindingSource.DataSource = this.ravintolaDataSet1BindingSource;
            // 
            // ravintolaDataSet1BindingSource
            // 
            this.ravintolaDataSet1BindingSource.DataSource = this.ravintolaDataSet1;
            this.ravintolaDataSet1BindingSource.Position = 0;
            // 
            // ravintolaDataSet1
            // 
            this.ravintolaDataSet1.DataSetName = "RavintolaDataSet1";
            this.ravintolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poytaTableAdapter
            // 
            this.poytaTableAdapter.ClearBeforeFill = true;
            // 
            // ListanLuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MuokkaaPoytia);
            this.Controls.Add(this.Sulje);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListanLuku";
            this.Text = "Pöytävaraukset";
            this.Load += new System.EventHandler(this.ListanLuku_load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poytaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sulje;
        private System.Windows.Forms.Button MuokkaaPoytia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ravintolaDataSet1BindingSource;
        private RavintolaDataSet1 ravintolaDataSet1;
        private System.Windows.Forms.BindingSource poytaBindingSource;
        private RavintolaDataSet1TableAdapters.poytaTableAdapter poytaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn poytaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakaspaikkojaDataGridViewTextBoxColumn;
    }
}