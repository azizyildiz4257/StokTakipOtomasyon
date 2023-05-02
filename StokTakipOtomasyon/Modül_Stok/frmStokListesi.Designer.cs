namespace StokTakipOtomasyon.Modül_Stok
{
    partial class frmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Barkod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_StokAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_StokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_PDF = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_XLS = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Barkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StokAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Grd_Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(848, 518);
            this.splitContainerControl1.SplitterPosition = 226;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(226, 518);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.Btn_XLS);
            this.xtraTabPage1.Controls.Add(this.Btn_PDF);
            this.xtraTabPage1.Controls.Add(this.Btn_Sil);
            this.xtraTabPage1.Controls.Add(this.Btn_Ara);
            this.xtraTabPage1.Controls.Add(this.Txt_Barkod);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.Txt_StokAdı);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.Txt_StokKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 493);
            this.xtraTabPage1.Text = "Arama";
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(116, 182);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(96, 43);
            this.Btn_Sil.TabIndex = 7;
            this.Btn_Sil.Text = "Temizle";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Ara
            // 
            this.Btn_Ara.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ara.Appearance.Options.UseFont = true;
            this.Btn_Ara.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ara.ImageOptions.Image")));
            this.Btn_Ara.Location = new System.Drawing.Point(11, 182);
            this.Btn_Ara.Name = "Btn_Ara";
            this.Btn_Ara.Size = new System.Drawing.Size(96, 43);
            this.Btn_Ara.TabIndex = 6;
            this.Btn_Ara.Text = "Ara";
            this.Btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // Txt_Barkod
            // 
            this.Txt_Barkod.Location = new System.Drawing.Point(11, 153);
            this.Txt_Barkod.Name = "Txt_Barkod";
            this.Txt_Barkod.Size = new System.Drawing.Size(201, 20);
            this.Txt_Barkod.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Barkod";
            // 
            // Txt_StokAdı
            // 
            this.Txt_StokAdı.Location = new System.Drawing.Point(11, 104);
            this.Txt_StokAdı.Name = "Txt_StokAdı";
            this.Txt_StokAdı.Size = new System.Drawing.Size(201, 20);
            this.Txt_StokAdı.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // Txt_StokKodu
            // 
            this.Txt_StokKodu.Location = new System.Drawing.Point(11, 52);
            this.Txt_StokKodu.Name = "Txt_StokKodu";
            this.Txt_StokKodu.Size = new System.Drawing.Size(201, 20);
            this.Txt_StokKodu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // Grd_Liste
            // 
            this.Grd_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Liste.Location = new System.Drawing.Point(0, 0);
            this.Grd_Liste.MainView = this.gridView1;
            this.Grd_Liste.Name = "Grd_Liste";
            this.Grd_Liste.Size = new System.Drawing.Size(612, 518);
            this.Grd_Liste.TabIndex = 0;
            this.Grd_Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.StokKodu,
            this.StokAdı,
            this.StokBarkod});
            this.gridView1.GridControl = this.Grd_Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // StokKodu
            // 
            this.StokKodu.Caption = "StokKodu";
            this.StokKodu.FieldName = "StokKodu";
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.OptionsColumn.AllowEdit = false;
            this.StokKodu.OptionsColumn.AllowFocus = false;
            this.StokKodu.OptionsColumn.FixedWidth = true;
            this.StokKodu.Visible = true;
            this.StokKodu.VisibleIndex = 0;
            // 
            // StokAdı
            // 
            this.StokAdı.Caption = "StokAdı";
            this.StokAdı.FieldName = "StokAdı";
            this.StokAdı.Name = "StokAdı";
            this.StokAdı.OptionsColumn.AllowEdit = false;
            this.StokAdı.OptionsColumn.AllowFocus = false;
            this.StokAdı.OptionsColumn.FixedWidth = true;
            this.StokAdı.Visible = true;
            this.StokAdı.VisibleIndex = 1;
            // 
            // StokBarkod
            // 
            this.StokBarkod.Caption = "StokBarkod";
            this.StokBarkod.FieldName = "StokBarkod";
            this.StokBarkod.Name = "StokBarkod";
            this.StokBarkod.OptionsColumn.AllowEdit = false;
            this.StokBarkod.OptionsColumn.AllowFocus = false;
            this.StokBarkod.OptionsColumn.FixedWidth = true;
            this.StokBarkod.Visible = true;
            this.StokBarkod.VisibleIndex = 2;
            // 
            // Btn_PDF
            // 
            this.Btn_PDF.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_PDF.Appearance.Options.UseFont = true;
            this.Btn_PDF.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_PDF.Location = new System.Drawing.Point(11, 231);
            this.Btn_PDF.Name = "Btn_PDF";
            this.Btn_PDF.Size = new System.Drawing.Size(201, 43);
            this.Btn_PDF.TabIndex = 8;
            this.Btn_PDF.Text = "PDF Aktar";
            this.Btn_PDF.Click += new System.EventHandler(this.Btn_PDF_Click);
            // 
            // Btn_XLS
            // 
            this.Btn_XLS.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_XLS.Appearance.Options.UseFont = true;
            this.Btn_XLS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.Btn_XLS.Location = new System.Drawing.Point(11, 280);
            this.Btn_XLS.Name = "Btn_XLS";
            this.Btn_XLS.Size = new System.Drawing.Size(201, 43);
            this.Btn_XLS.TabIndex = 9;
            this.Btn_XLS.Text = "XLS Aktar";
            this.Btn_XLS.Click += new System.EventHandler(this.Btn_XLS_Click);
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmStokListesi.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokListesi";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Barkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StokAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Ara;
        private DevExpress.XtraEditors.TextEdit Txt_Barkod;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_StokAdı;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_StokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn StokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdı;
        private DevExpress.XtraGrid.Columns.GridColumn StokBarkod;
        private DevExpress.XtraEditors.SimpleButton Btn_XLS;
        private DevExpress.XtraEditors.SimpleButton Btn_PDF;
    }
}