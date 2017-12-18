namespace Ravintolatilaus
{
    partial class Ruokalista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ruokalista));
            this.paluuTarjoilijaNayttoon = new System.Windows.Forms.Button();
            this.ravintolaDataSet1 = new Ravintolatilaus.RavintolaDataSet1();
            this.ruokalistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruokalistaTableAdapter = new Ravintolatilaus.RavintolaDataSet1TableAdapters.ruokalistaTableAdapter();
            this.tableAdapterManager = new Ravintolatilaus.RavintolaDataSet1TableAdapters.TableAdapterManager();
            this.ruokalistaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ruokalistaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ruokalistaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruokalistanMuokkaus = new System.Windows.Forms.Button();
            this.paluuEsimiehenNayttoon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaBindingNavigator)).BeginInit();
            this.ruokalistaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paluuTarjoilijaNayttoon
            // 
            this.paluuTarjoilijaNayttoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paluuTarjoilijaNayttoon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paluuTarjoilijaNayttoon.Location = new System.Drawing.Point(29, 414);
            this.paluuTarjoilijaNayttoon.Name = "paluuTarjoilijaNayttoon";
            this.paluuTarjoilijaNayttoon.Size = new System.Drawing.Size(125, 85);
            this.paluuTarjoilijaNayttoon.TabIndex = 0;
            this.paluuTarjoilijaNayttoon.Text = "Paluu tarjoilija näyttöön";
            this.paluuTarjoilijaNayttoon.UseVisualStyleBackColor = true;
            // 
            // ravintolaDataSet1
            // 
            this.ravintolaDataSet1.DataSetName = "RavintolaDataSet1";
            this.ravintolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruokalistaBindingSource
            // 
            this.ruokalistaBindingSource.DataMember = "ruokalista";
            this.ruokalistaBindingSource.DataSource = this.ravintolaDataSet1;
            // 
            // ruokalistaTableAdapter
            // 
            this.ruokalistaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.henkilokuntaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.poytaTableAdapter = null;
            this.tableAdapterManager.rooliTableAdapter = null;
            this.tableAdapterManager.ruokalistaTableAdapter = this.ruokalistaTableAdapter;
            this.tableAdapterManager.tilausTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ravintolatilaus.RavintolaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ruokalistaBindingNavigator
            // 
            this.ruokalistaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ruokalistaBindingNavigator.BindingSource = this.ruokalistaBindingSource;
            this.ruokalistaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ruokalistaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ruokalistaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ruokalistaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ruokalistaBindingNavigatorSaveItem});
            this.ruokalistaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ruokalistaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ruokalistaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ruokalistaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ruokalistaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ruokalistaBindingNavigator.Name = "ruokalistaBindingNavigator";
            this.ruokalistaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ruokalistaBindingNavigator.Size = new System.Drawing.Size(661, 27);
            this.ruokalistaBindingNavigator.TabIndex = 1;
            this.ruokalistaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ruokalistaBindingNavigatorSaveItem
            // 
            this.ruokalistaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ruokalistaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ruokalistaBindingNavigatorSaveItem.Image")));
            this.ruokalistaBindingNavigatorSaveItem.Name = "ruokalistaBindingNavigatorSaveItem";
            this.ruokalistaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.ruokalistaBindingNavigatorSaveItem.Text = "Save Data";
            this.ruokalistaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ruokalistaBindingNavigatorSaveItem_Click);
            // 
            // ruokalistaDataGridView
            // 
            this.ruokalistaDataGridView.AutoGenerateColumns = false;
            this.ruokalistaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruokalistaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ruokalistaDataGridView.DataSource = this.ruokalistaBindingSource;
            this.ruokalistaDataGridView.Location = new System.Drawing.Point(29, 45);
            this.ruokalistaDataGridView.Name = "ruokalistaDataGridView";
            this.ruokalistaDataGridView.RowTemplate.Height = 24;
            this.ruokalistaDataGridView.Size = new System.Drawing.Size(544, 351);
            this.ruokalistaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "annos";
            this.dataGridViewTextBoxColumn1.HeaderText = "annos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "annosNimi";
            this.dataGridViewTextBoxColumn2.HeaderText = "annosNimi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kuvaus";
            this.dataGridViewTextBoxColumn3.HeaderText = "kuvaus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hinta";
            this.dataGridViewTextBoxColumn4.HeaderText = "hinta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "henkilokunta_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "henkilokunta_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ruokalistanMuokkaus
            // 
            this.ruokalistanMuokkaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruokalistanMuokkaus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ruokalistanMuokkaus.Location = new System.Drawing.Point(448, 414);
            this.ruokalistanMuokkaus.Name = "ruokalistanMuokkaus";
            this.ruokalistanMuokkaus.Size = new System.Drawing.Size(125, 85);
            this.ruokalistanMuokkaus.TabIndex = 3;
            this.ruokalistanMuokkaus.Text = "Ruokalistan muokkaus";
            this.ruokalistanMuokkaus.UseVisualStyleBackColor = true;
            // 
            // paluuEsimiehenNayttoon
            // 
            this.paluuEsimiehenNayttoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paluuEsimiehenNayttoon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paluuEsimiehenNayttoon.Location = new System.Drawing.Point(160, 414);
            this.paluuEsimiehenNayttoon.Name = "paluuEsimiehenNayttoon";
            this.paluuEsimiehenNayttoon.Size = new System.Drawing.Size(125, 85);
            this.paluuEsimiehenNayttoon.TabIndex = 4;
            this.paluuEsimiehenNayttoon.Text = "Paluu esimiehen näyttöön";
            this.paluuEsimiehenNayttoon.UseVisualStyleBackColor = true;
            // 
            // Ruokalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 510);
            this.Controls.Add(this.paluuEsimiehenNayttoon);
            this.Controls.Add(this.ruokalistanMuokkaus);
            this.Controls.Add(this.ruokalistaDataGridView);
            this.Controls.Add(this.ruokalistaBindingNavigator);
            this.Controls.Add(this.paluuTarjoilijaNayttoon);
            this.Name = "Ruokalista";
            this.Text = "Ruokalista";
            this.Load += new System.EventHandler(this.Ruokalista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaBindingNavigator)).EndInit();
            this.ruokalistaBindingNavigator.ResumeLayout(false);
            this.ruokalistaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruokalistaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paluuTarjoilijaNayttoon;
        private RavintolaDataSet1 ravintolaDataSet1;
        private System.Windows.Forms.BindingSource ruokalistaBindingSource;
        private RavintolaDataSet1TableAdapters.ruokalistaTableAdapter ruokalistaTableAdapter;
        private RavintolaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ruokalistaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ruokalistaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ruokalistaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button ruokalistanMuokkaus;
        private System.Windows.Forms.Button paluuEsimiehenNayttoon;
    }
}