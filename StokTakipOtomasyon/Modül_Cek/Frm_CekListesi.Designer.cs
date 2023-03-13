namespace StokTakipOtomasyon.Modül_Cek
{
    partial class Frm_CekListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CekListesi));
            this.Banka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_Bankası = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CekNumarası = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CekNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_CekTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Bankası.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CekNumarası.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CekTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Banka
            // 
            this.Banka.Caption = "Banka";
            this.Banka.FieldName = "Banka";
            this.Banka.Name = "Banka";
            this.Banka.OptionsColumn.AllowEdit = false;
            this.Banka.OptionsColumn.AllowFocus = false;
            this.Banka.OptionsColumn.FixedWidth = true;
            this.Banka.Visible = true;
            this.Banka.VisibleIndex = 0;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
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
            // Txt_Bankası
            // 
            this.Txt_Bankası.Location = new System.Drawing.Point(11, 153);
            this.Txt_Bankası.Name = "Txt_Bankası";
            this.Txt_Bankası.Size = new System.Drawing.Size(201, 20);
            this.Txt_Bankası.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bankası";
            // 
            // Txt_CekNumarası
            // 
            this.Txt_CekNumarası.Location = new System.Drawing.Point(11, 104);
            this.Txt_CekNumarası.Name = "Txt_CekNumarası";
            this.Txt_CekNumarası.Size = new System.Drawing.Size(201, 20);
            this.Txt_CekNumarası.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Banka,
            this.CekNo,
            this.Tipi});
            this.gridView1.GridControl = this.Grd_Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // CekNo
            // 
            this.CekNo.Caption = "Çek Numarası";
            this.CekNo.FieldName = "CekNo";
            this.CekNo.Name = "CekNo";
            this.CekNo.OptionsColumn.AllowEdit = false;
            this.CekNo.OptionsColumn.AllowFocus = false;
            this.CekNo.OptionsColumn.FixedWidth = true;
            this.CekNo.Visible = true;
            this.CekNo.VisibleIndex = 1;
            // 
            // Tipi
            // 
            this.Tipi.Caption = "Çek Türü";
            this.Tipi.FieldName = "Tipi";
            this.Tipi.Name = "Tipi";
            this.Tipi.Visible = true;
            this.Tipi.VisibleIndex = 2;
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Çek Numarası";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.Btn_Sil);
            this.xtraTabPage1.Controls.Add(this.Btn_Ara);
            this.xtraTabPage1.Controls.Add(this.Txt_Bankası);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.Txt_CekNumarası);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.Txt_CekTuru);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 493);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Türü";
            // 
            // Txt_CekTuru
            // 
            this.Txt_CekTuru.EditValue = "Kendi Çekimiz";
            this.Txt_CekTuru.Location = new System.Drawing.Point(11, 52);
            this.Txt_CekTuru.Name = "Txt_CekTuru";
            this.Txt_CekTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Txt_CekTuru.Properties.Items.AddRange(new object[] {
            "Kendi Çekimiz",
            "Müşteri Çeki"});
            this.Txt_CekTuru.Size = new System.Drawing.Size(201, 20);
            this.Txt_CekTuru.TabIndex = 1;
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
            this.splitContainerControl1.TabIndex = 2;
            // 
            // Frm_CekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
            this.Controls.Add(this.splitContainerControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek Listesi";
            this.Load += new System.EventHandler(this.Frm_CekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Bankası.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CekNumarası.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CekTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Banka;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Ara;
        private DevExpress.XtraEditors.TextEdit Txt_Bankası;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_CekNumarası;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CekNo;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Tipi;
        private DevExpress.XtraEditors.ComboBoxEdit Txt_CekTuru;
    }
}