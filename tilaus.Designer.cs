﻿namespace Ravintolatilaus
{
    partial class tilaus
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
            System.Windows.Forms.Label tilausIDLabel;
            System.Windows.Forms.Label kommenttiLabel;
            System.Windows.Forms.Label poyta_poytaIDLabel;
            System.Windows.Forms.Label ruokalista_annosLabel;
            System.Windows.Forms.Label henkilokunta_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tilaus));
            this.paluuTarjoilijaNayttoon = new System.Windows.Forms.Button();
            this.ravintolaDataSet1 = new Ravintolatilaus.RavintolaDataSet1();
            this.tilausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tilausTableAdapter = new Ravintolatilaus.RavintolaDataSet1TableAdapters.tilausTableAdapter();
            this.tableAdapterManager = new Ravintolatilaus.RavintolaDataSet1TableAdapters.TableAdapterManager();
            this.tilausBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tilausBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tilausIDTextBox = new System.Windows.Forms.TextBox();
            this.kommenttiTextBox = new System.Windows.Forms.TextBox();
            this.poyta_poytaIDTextBox = new System.Windows.Forms.TextBox();
            this.ruokalista_annosTextBox = new System.Windows.Forms.TextBox();
            this.henkilokunta_idTextBox = new System.Windows.Forms.TextBox();
            this.tilausDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            tilausIDLabel = new System.Windows.Forms.Label();
            kommenttiLabel = new System.Windows.Forms.Label();
            poyta_poytaIDLabel = new System.Windows.Forms.Label();
            ruokalista_annosLabel = new System.Windows.Forms.Label();
            henkilokunta_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingNavigator)).BeginInit();
            this.tilausBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilausDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tilausIDLabel
            // 
            tilausIDLabel.AutoSize = true;
            tilausIDLabel.Location = new System.Drawing.Point(34, 106);
            tilausIDLabel.Name = "tilausIDLabel";
            tilausIDLabel.Size = new System.Drawing.Size(62, 17);
            tilausIDLabel.TabIndex = 2;
            tilausIDLabel.Text = "tilaus ID:";
            // 
            // kommenttiLabel
            // 
            kommenttiLabel.AutoSize = true;
            kommenttiLabel.Location = new System.Drawing.Point(34, 134);
            kommenttiLabel.Name = "kommenttiLabel";
            kommenttiLabel.Size = new System.Drawing.Size(76, 17);
            kommenttiLabel.TabIndex = 4;
            kommenttiLabel.Text = "kommentti:";
            // 
            // poyta_poytaIDLabel
            // 
            poyta_poytaIDLabel.AutoSize = true;
            poyta_poytaIDLabel.Location = new System.Drawing.Point(34, 162);
            poyta_poytaIDLabel.Name = "poyta_poytaIDLabel";
            poyta_poytaIDLabel.Size = new System.Drawing.Size(103, 17);
            poyta_poytaIDLabel.TabIndex = 6;
            poyta_poytaIDLabel.Text = "poyta poyta ID:";
            // 
            // ruokalista_annosLabel
            // 
            ruokalista_annosLabel.AutoSize = true;
            ruokalista_annosLabel.Location = new System.Drawing.Point(34, 190);
            ruokalista_annosLabel.Name = "ruokalista_annosLabel";
            ruokalista_annosLabel.Size = new System.Drawing.Size(116, 17);
            ruokalista_annosLabel.TabIndex = 8;
            ruokalista_annosLabel.Text = "ruokalista annos:";
            // 
            // henkilokunta_idLabel
            // 
            henkilokunta_idLabel.AutoSize = true;
            henkilokunta_idLabel.Location = new System.Drawing.Point(34, 218);
            henkilokunta_idLabel.Name = "henkilokunta_idLabel";
            henkilokunta_idLabel.Size = new System.Drawing.Size(107, 17);
            henkilokunta_idLabel.TabIndex = 10;
            henkilokunta_idLabel.Text = "henkilokunta id:";
            // 
            // paluuTarjoilijaNayttoon
            // 
            this.paluuTarjoilijaNayttoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paluuTarjoilijaNayttoon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paluuTarjoilijaNayttoon.Location = new System.Drawing.Point(774, 438);
            this.paluuTarjoilijaNayttoon.Name = "paluuTarjoilijaNayttoon";
            this.paluuTarjoilijaNayttoon.Size = new System.Drawing.Size(154, 85);
            this.paluuTarjoilijaNayttoon.TabIndex = 1;
            this.paluuTarjoilijaNayttoon.Text = "Paluu Tarjoilija näyttöön";
            this.paluuTarjoilijaNayttoon.UseVisualStyleBackColor = true;
            // 
            // ravintolaDataSet1
            // 
            this.ravintolaDataSet1.DataSetName = "RavintolaDataSet1";
            this.ravintolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tilausBindingSource
            // 
            this.tilausBindingSource.DataMember = "tilaus";
            this.tilausBindingSource.DataSource = this.ravintolaDataSet1;
            // 
            // tilausTableAdapter
            // 
            this.tilausTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.henkilokuntaTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.poytaTableAdapter = null;
            this.tableAdapterManager.rooliTableAdapter = null;
            this.tableAdapterManager.ruokalistaTableAdapter = null;
            this.tableAdapterManager.tilausTableAdapter = this.tilausTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ravintolatilaus.RavintolaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tilausBindingNavigator
            // 
            this.tilausBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tilausBindingNavigator.BindingSource = this.tilausBindingSource;
            this.tilausBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tilausBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tilausBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tilausBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tilausBindingNavigatorSaveItem});
            this.tilausBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tilausBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tilausBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tilausBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tilausBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tilausBindingNavigator.Name = "tilausBindingNavigator";
            this.tilausBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tilausBindingNavigator.Size = new System.Drawing.Size(977, 27);
            this.tilausBindingNavigator.TabIndex = 2;
            this.tilausBindingNavigator.Text = "bindingNavigator1";
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
            // tilausBindingNavigatorSaveItem
            // 
            this.tilausBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tilausBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tilausBindingNavigatorSaveItem.Image")));
            this.tilausBindingNavigatorSaveItem.Name = "tilausBindingNavigatorSaveItem";
            this.tilausBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tilausBindingNavigatorSaveItem.Text = "Save Data";
            this.tilausBindingNavigatorSaveItem.Click += new System.EventHandler(this.tilausBindingNavigatorSaveItem_Click);
            // 
            // tilausIDTextBox
            // 
            this.tilausIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tilausBindingSource, "tilausID", true));
            this.tilausIDTextBox.Location = new System.Drawing.Point(156, 103);
            this.tilausIDTextBox.Name = "tilausIDTextBox";
            this.tilausIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.tilausIDTextBox.TabIndex = 3;
            // 
            // kommenttiTextBox
            // 
            this.kommenttiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tilausBindingSource, "kommentti", true));
            this.kommenttiTextBox.Location = new System.Drawing.Point(156, 131);
            this.kommenttiTextBox.Name = "kommenttiTextBox";
            this.kommenttiTextBox.Size = new System.Drawing.Size(100, 22);
            this.kommenttiTextBox.TabIndex = 5;
            // 
            // poyta_poytaIDTextBox
            // 
            this.poyta_poytaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tilausBindingSource, "poyta_poytaID", true));
            this.poyta_poytaIDTextBox.Location = new System.Drawing.Point(156, 159);
            this.poyta_poytaIDTextBox.Name = "poyta_poytaIDTextBox";
            this.poyta_poytaIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.poyta_poytaIDTextBox.TabIndex = 7;
            // 
            // ruokalista_annosTextBox
            // 
            this.ruokalista_annosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tilausBindingSource, "ruokalista_annos", true));
            this.ruokalista_annosTextBox.Location = new System.Drawing.Point(156, 187);
            this.ruokalista_annosTextBox.Name = "ruokalista_annosTextBox";
            this.ruokalista_annosTextBox.Size = new System.Drawing.Size(100, 22);
            this.ruokalista_annosTextBox.TabIndex = 9;
            // 
            // henkilokunta_idTextBox
            // 
            this.henkilokunta_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tilausBindingSource, "henkilokunta_id", true));
            this.henkilokunta_idTextBox.Location = new System.Drawing.Point(156, 215);
            this.henkilokunta_idTextBox.Name = "henkilokunta_idTextBox";
            this.henkilokunta_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.henkilokunta_idTextBox.TabIndex = 11;
            // 
            // tilausDataGridView
            // 
            this.tilausDataGridView.AutoGenerateColumns = false;
            this.tilausDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tilausDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.tilausDataGridView.DataSource = this.tilausBindingSource;
            this.tilausDataGridView.Location = new System.Drawing.Point(289, 108);
            this.tilausDataGridView.Name = "tilausDataGridView";
            this.tilausDataGridView.RowTemplate.Height = 24;
            this.tilausDataGridView.Size = new System.Drawing.Size(653, 220);
            this.tilausDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tilausID";
            this.dataGridViewTextBoxColumn1.HeaderText = "tilausID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kommentti";
            this.dataGridViewTextBoxColumn2.HeaderText = "kommentti";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "poyta_poytaID";
            this.dataGridViewTextBoxColumn3.HeaderText = "poyta_poytaID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ruokalista_annos";
            this.dataGridViewTextBoxColumn4.HeaderText = "ruokalista_annos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "henkilokunta_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "henkilokunta_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "auki";
            this.dataGridViewImageColumn1.HeaderText = "auki";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // tilaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 552);
            this.Controls.Add(this.tilausDataGridView);
            this.Controls.Add(tilausIDLabel);
            this.Controls.Add(this.tilausIDTextBox);
            this.Controls.Add(kommenttiLabel);
            this.Controls.Add(this.kommenttiTextBox);
            this.Controls.Add(poyta_poytaIDLabel);
            this.Controls.Add(this.poyta_poytaIDTextBox);
            this.Controls.Add(ruokalista_annosLabel);
            this.Controls.Add(this.ruokalista_annosTextBox);
            this.Controls.Add(henkilokunta_idLabel);
            this.Controls.Add(this.henkilokunta_idTextBox);
            this.Controls.Add(this.tilausBindingNavigator);
            this.Controls.Add(this.paluuTarjoilijaNayttoon);
            this.Name = "tilaus";
            this.Text = "Tilaus";
            this.Load += new System.EventHandler(this.lasku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingNavigator)).EndInit();
            this.tilausBindingNavigator.ResumeLayout(false);
            this.tilausBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tilausDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button paluuTarjoilijaNayttoon;
        private RavintolaDataSet1 ravintolaDataSet1;
        private System.Windows.Forms.BindingSource tilausBindingSource;
        private RavintolaDataSet1TableAdapters.tilausTableAdapter tilausTableAdapter;
        private RavintolaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tilausBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tilausBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tilausIDTextBox;
        private System.Windows.Forms.TextBox kommenttiTextBox;
        private System.Windows.Forms.TextBox poyta_poytaIDTextBox;
        private System.Windows.Forms.TextBox ruokalista_annosTextBox;
        private System.Windows.Forms.TextBox henkilokunta_idTextBox;
        private System.Windows.Forms.DataGridView tilausDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}