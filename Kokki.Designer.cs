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
            this.update = new System.Windows.Forms.Button();
            this.poyta_poytaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ruokalista_annos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.henkilokunta_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.auki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaluuAlkuun
            // 
            this.PaluuAlkuun.Location = new System.Drawing.Point(244, 336);
            this.PaluuAlkuun.Name = "PaluuAlkuun";
            this.PaluuAlkuun.Size = new System.Drawing.Size(156, 58);
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
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 280);
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
            this.kommentti.Width = 82;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(77, 336);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Päivitä";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // poyta_poytaID
            // 
            this.poyta_poytaID.Text = "Pöytä numero";
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
            // 
            // Kokki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 422);
            this.Controls.Add(this.update);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PaluuAlkuun);
            this.Name = "Kokki";
            this.Text = "Kokki";
            this.Load += new System.EventHandler(this.Kokki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ravintolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tilausBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}