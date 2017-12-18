namespace Ravintolatilaus
{
    partial class TilausLista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tilausIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kommenttiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poytapoytaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruokalistaannosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilokuntaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aukiDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tilausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ravintolaDataSet2 = new Ravintolatilaus.RavintolaDataSet2();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tilausTableAdapter = new Ravintolatilaus.RavintolaDataSet2TableAdapters.tilausTableAdapter();
            this.TakaisinEsimies = new System.Windows.Forms.Button();
            this.EsimiesMuokkaaTilausta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet2)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tilausIDDataGridViewTextBoxColumn,
            this.kommenttiDataGridViewTextBoxColumn,
            this.poytapoytaIDDataGridViewTextBoxColumn,
            this.ruokalistaannosDataGridViewTextBoxColumn,
            this.henkilokuntaidDataGridViewTextBoxColumn,
            this.aukiDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.tilausBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // tilausIDDataGridViewTextBoxColumn
            // 
            this.tilausIDDataGridViewTextBoxColumn.DataPropertyName = "tilausID";
            this.tilausIDDataGridViewTextBoxColumn.HeaderText = "tilausID";
            this.tilausIDDataGridViewTextBoxColumn.Name = "tilausIDDataGridViewTextBoxColumn";
            // 
            // kommenttiDataGridViewTextBoxColumn
            // 
            this.kommenttiDataGridViewTextBoxColumn.DataPropertyName = "kommentti";
            this.kommenttiDataGridViewTextBoxColumn.HeaderText = "kommentti";
            this.kommenttiDataGridViewTextBoxColumn.Name = "kommenttiDataGridViewTextBoxColumn";
            // 
            // poytapoytaIDDataGridViewTextBoxColumn
            // 
            this.poytapoytaIDDataGridViewTextBoxColumn.DataPropertyName = "poyta_poytaID";
            this.poytapoytaIDDataGridViewTextBoxColumn.HeaderText = "poyta_poytaID";
            this.poytapoytaIDDataGridViewTextBoxColumn.Name = "poytapoytaIDDataGridViewTextBoxColumn";
            // 
            // ruokalistaannosDataGridViewTextBoxColumn
            // 
            this.ruokalistaannosDataGridViewTextBoxColumn.DataPropertyName = "ruokalista_annos";
            this.ruokalistaannosDataGridViewTextBoxColumn.HeaderText = "ruokalista_annos";
            this.ruokalistaannosDataGridViewTextBoxColumn.Name = "ruokalistaannosDataGridViewTextBoxColumn";
            // 
            // henkilokuntaidDataGridViewTextBoxColumn
            // 
            this.henkilokuntaidDataGridViewTextBoxColumn.DataPropertyName = "henkilokunta_id";
            this.henkilokuntaidDataGridViewTextBoxColumn.HeaderText = "henkilokunta_id";
            this.henkilokuntaidDataGridViewTextBoxColumn.Name = "henkilokuntaidDataGridViewTextBoxColumn";
            // 
            // aukiDataGridViewImageColumn
            // 
            this.aukiDataGridViewImageColumn.DataPropertyName = "auki";
            this.aukiDataGridViewImageColumn.HeaderText = "auki";
            this.aukiDataGridViewImageColumn.Name = "aukiDataGridViewImageColumn";
            // 
            // tilausBindingSource
            // 
            this.tilausBindingSource.DataMember = "tilaus";
            this.tilausBindingSource.DataSource = this.ravintolaDataSet2BindingSource;
            // 
            // ravintolaDataSet2BindingSource
            // 
            this.ravintolaDataSet2BindingSource.DataSource = this.ravintolaDataSet2;
            this.ravintolaDataSet2BindingSource.Position = 0;
            // 
            // ravintolaDataSet2
            // 
            this.ravintolaDataSet2.DataSetName = "RavintolaDataSet2";
            this.ravintolaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(425, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // tilausTableAdapter
            // 
            this.tilausTableAdapter.ClearBeforeFill = true;
            // 
            // TakaisinEsimies
            // 
            this.TakaisinEsimies.Location = new System.Drawing.Point(21, 366);
            this.TakaisinEsimies.Name = "TakaisinEsimies";
            this.TakaisinEsimies.Size = new System.Drawing.Size(124, 40);
            this.TakaisinEsimies.TabIndex = 2;
            this.TakaisinEsimies.Text = "Takaisin";
            this.TakaisinEsimies.UseVisualStyleBackColor = true;
            this.TakaisinEsimies.Click += new System.EventHandler(this.button1_Click);
            // 
            // EsimiesMuokkaaTilausta
            // 
            this.EsimiesMuokkaaTilausta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EsimiesMuokkaaTilausta.Location = new System.Drawing.Point(280, 366);
            this.EsimiesMuokkaaTilausta.Name = "EsimiesMuokkaaTilausta";
            this.EsimiesMuokkaaTilausta.Size = new System.Drawing.Size(124, 40);
            this.EsimiesMuokkaaTilausta.TabIndex = 3;
            this.EsimiesMuokkaaTilausta.Text = "Muokkaa tilausta";
            this.EsimiesMuokkaaTilausta.UseVisualStyleBackColor = true;
            // 
            // TilausLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 479);
            this.Controls.Add(this.EsimiesMuokkaaTilausta);
            this.Controls.Add(this.TakaisinEsimies);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TilausLista";
            this.Text = "TilausLista";
            this.Load += new System.EventHandler(this.TilausLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet2)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ravintolaDataSet2BindingSource;
        private RavintolaDataSet2 ravintolaDataSet2;
        private System.Windows.Forms.BindingSource tilausBindingSource;
        private RavintolaDataSet2TableAdapters.tilausTableAdapter tilausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tilausIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kommenttiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poytapoytaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruokalistaannosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilokuntaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn aukiDataGridViewImageColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button TakaisinEsimies;
        private System.Windows.Forms.Button EsimiesMuokkaaTilausta;
    }
}