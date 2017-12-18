﻿namespace Ravintolatilaus
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
            this.poytaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet1 = new Ravintolatilaus.RavintolaDataSet1();
            this.poytaTableAdapter = new Ravintolatilaus.RavintolaDataSet1TableAdapters.poytaTableAdapter();
            this.poytaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakaspaikkojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poytaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sulje
            // 
            this.Sulje.Location = new System.Drawing.Point(24, 315);
            this.Sulje.Name = "Sulje";
            this.Sulje.Size = new System.Drawing.Size(176, 42);
            this.Sulje.TabIndex = 0;
            this.Sulje.Text = "Sulje";
            this.Sulje.UseVisualStyleBackColor = true;
            this.Sulje.Click += new System.EventHandler(this.Sulje_Click);
            // 
            // MuokkaaPoytia
            // 
            this.MuokkaaPoytia.Location = new System.Drawing.Point(226, 315);
            this.MuokkaaPoytia.Name = "MuokkaaPoytia";
            this.MuokkaaPoytia.Size = new System.Drawing.Size(176, 42);
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 163);
            this.dataGridView1.TabIndex = 2;
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
            // poytaIDDataGridViewTextBoxColumn
            // 
            this.poytaIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poytaIDDataGridViewTextBoxColumn.DataPropertyName = "poytaID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.poytaIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.poytaIDDataGridViewTextBoxColumn.HeaderText = "poytaID";
            this.poytaIDDataGridViewTextBoxColumn.Name = "poytaIDDataGridViewTextBoxColumn";
            this.poytaIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // asiakaspaikkojaDataGridViewTextBoxColumn
            // 
            this.asiakaspaikkojaDataGridViewTextBoxColumn.DataPropertyName = "asiakaspaikkoja";
            this.asiakaspaikkojaDataGridViewTextBoxColumn.HeaderText = "asiakaspaikkoja";
            this.asiakaspaikkojaDataGridViewTextBoxColumn.Name = "asiakaspaikkojaDataGridViewTextBoxColumn";
            // 
            // lluku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MuokkaaPoytia);
            this.Controls.Add(this.Sulje);
            this.Name = "lluku";
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