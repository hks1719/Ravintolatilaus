namespace Ravintolatilaus
{
    partial class Kokki
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
            this.PaluuAlkuun = new System.Windows.Forms.Button();
            this.ravintolaDataSet1 = new Ravintolatilaus.RavintolaDataSet1();
            this.tilausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tilausTableAdapter = new Ravintolatilaus.RavintolaDataSet1TableAdapters.tilausTableAdapter();
            this.tableAdapterManager = new Ravintolatilaus.RavintolaDataSet1TableAdapters.TableAdapterManager();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tilausID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kommentti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poyta_poytaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ruokalista_annos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.henkilokunta_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.auki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaluuAlkuun
            // 
            this.PaluuAlkuun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaluuAlkuun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PaluuAlkuun.Location = new System.Drawing.Point(332, 414);
            this.PaluuAlkuun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaluuAlkuun.Name = "PaluuAlkuun";
            this.PaluuAlkuun.Size = new System.Drawing.Size(200, 70);
            this.PaluuAlkuun.TabIndex = 0;
            this.PaluuAlkuun.Text = "Paluu päävalikkoon";
            this.PaluuAlkuun.UseVisualStyleBackColor = true;
            this.PaluuAlkuun.Click += new System.EventHandler(this.button1_Click);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tilausID,
            this.kommentti,
            this.poyta_poytaID,
            this.ruokalista_annos,
            this.henkilokunta_id,
            this.auki});
            this.listView1.Location = new System.Drawing.Point(16, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(516, 344);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tilausID
            // 
            this.tilausID.Text = "Tilaus";
            this.tilausID.Width = 59;
            // 
            // kommentti
            // 
            this.kommentti.Text = "Kommentti";
            this.kommentti.Width = 81;
            // 
            // poyta_poytaID
            // 
            this.poyta_poytaID.Text = "Pöytä numero";
            this.poyta_poytaID.Width = 79;
            // 
            // ruokalista_annos
            // 
            this.ruokalista_annos.Text = "Annos";
            // 
            // henkilokunta_id
            // 
            this.henkilokunta_id.Text = "Tarjoilija";
            // 
            // auki
            // 
            this.auki.Text = "Auki";
            this.auki.Width = 41;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.update.Location = new System.Drawing.Point(16, 414);
            this.update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(200, 70);
            this.update.TabIndex = 2;
            this.update.Text = "Päivitä tilaukset";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tilatut annokset";
            // 
            // Kokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PaluuAlkuun);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kokki";
            this.Text = "Kokki";
            this.Load += new System.EventHandler(this.Kokki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PaluuAlkuun;
        private RavintolaDataSet1 ravintolaDataSet1;
        private System.Windows.Forms.BindingSource tilausBindingSource;
        private RavintolaDataSet1TableAdapters.tilausTableAdapter tilausTableAdapter;
        private RavintolaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tilausID;
        private System.Windows.Forms.ColumnHeader kommentti;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ColumnHeader poyta_poytaID;
        private System.Windows.Forms.ColumnHeader ruokalista_annos;
        private System.Windows.Forms.ColumnHeader henkilokunta_id;
        private System.Windows.Forms.ColumnHeader auki;
        private System.Windows.Forms.Label label1;
    }
}