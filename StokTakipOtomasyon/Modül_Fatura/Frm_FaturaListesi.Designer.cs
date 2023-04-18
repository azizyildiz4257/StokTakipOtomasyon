namespace StokTakipOtomasyon.Modül_Fatura
{
    partial class Frm_FaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FaturaListesi));
            this.CariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FaturaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Ara = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_FaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FaturaTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_FaturaTürü = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Txt_Tarih = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CMS_SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagTikYenile = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FaturaTürü.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.CMS_SagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // CariKodu
            // 
            this.CariKodu.Caption = "Cari Kodu";
            this.CariKodu.FieldName = "CariKodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.OptionsColumn.AllowEdit = false;
            this.CariKodu.OptionsColumn.AllowFocus = false;
            this.CariKodu.OptionsColumn.FixedWidth = true;
            this.CariKodu.Visible = true;
            this.CariKodu.VisibleIndex = 2;
            // 
            // FaturaNo
            // 
            this.FaturaNo.Caption = "Fatura No";
            this.FaturaNo.FieldName = "FaturaNo";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.OptionsColumn.AllowEdit = false;
            this.FaturaNo.OptionsColumn.AllowFocus = false;
            this.FaturaNo.OptionsColumn.FixedWidth = true;
            this.FaturaNo.Visible = true;
            this.FaturaNo.VisibleIndex = 0;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Temizle.Appearance.Options.UseFont = true;
            this.Btn_Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Temizle.ImageOptions.Image")));
            this.Btn_Temizle.Location = new System.Drawing.Point(116, 182);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(96, 43);
            this.Btn_Temizle.TabIndex = 7;
            this.Btn_Temizle.Text = "Temizle";
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tarih";
            // 
            // Txt_FaturaNo
            // 
            this.Txt_FaturaNo.Location = new System.Drawing.Point(11, 104);
            this.Txt_FaturaNo.Name = "Txt_FaturaNo";
            this.Txt_FaturaNo.Size = new System.Drawing.Size(201, 20);
            this.Txt_FaturaNo.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.FaturaNo,
            this.FaturaTuru,
            this.CariKodu});
            this.gridView1.GridControl = this.Grd_Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // FaturaTuru
            // 
            this.FaturaTuru.Caption = "Fatura Türü";
            this.FaturaTuru.FieldName = "FaturaTuru";
            this.FaturaTuru.Name = "FaturaTuru";
            this.FaturaTuru.OptionsColumn.AllowEdit = false;
            this.FaturaTuru.OptionsColumn.AllowFocus = false;
            this.FaturaTuru.OptionsColumn.FixedWidth = true;
            this.FaturaTuru.Visible = true;
            this.FaturaTuru.VisibleIndex = 1;
            // 
            // Grd_Liste
            // 
            this.Grd_Liste.ContextMenuStrip = this.CMS_SagTik;
            this.Grd_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Liste.Location = new System.Drawing.Point(0, 0);
            this.Grd_Liste.MainView = this.gridView1;
            this.Grd_Liste.Name = "Grd_Liste";
            this.Grd_Liste.Size = new System.Drawing.Size(543, 503);
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
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fatura No";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.Btn_Temizle);
            this.xtraTabPage1.Controls.Add(this.Btn_Ara);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.Txt_FaturaNo);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.Txt_FaturaTürü);
            this.xtraTabPage1.Controls.Add(this.Txt_Tarih);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(224, 478);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü";
            // 
            // Txt_FaturaTürü
            // 
            this.Txt_FaturaTürü.EditValue = "Satış Faturası";
            this.Txt_FaturaTürü.Location = new System.Drawing.Point(11, 52);
            this.Txt_FaturaTürü.Name = "Txt_FaturaTürü";
            this.Txt_FaturaTürü.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Txt_FaturaTürü.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.Txt_FaturaTürü.Properties.ReadOnly = true;
            this.Txt_FaturaTürü.Size = new System.Drawing.Size(201, 20);
            this.Txt_FaturaTürü.TabIndex = 1;
            this.Txt_FaturaTürü.SelectedIndexChanged += new System.EventHandler(this.Txt_FaturaTürü_SelectedIndexChanged);
            // 
            // Txt_Tarih
            // 
            this.Txt_Tarih.EditValue = null;
            this.Txt_Tarih.Location = new System.Drawing.Point(11, 153);
            this.Txt_Tarih.Name = "Txt_Tarih";
            this.Txt_Tarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Txt_Tarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Txt_Tarih.Properties.DisplayFormat.FormatString = "";
            this.Txt_Tarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_Tarih.Properties.EditFormat.FormatString = "";
            this.Txt_Tarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Txt_Tarih.Properties.Mask.EditMask = "";
            this.Txt_Tarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.Txt_Tarih.Size = new System.Drawing.Size(201, 20);
            this.Txt_Tarih.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(226, 503);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(779, 503);
            this.splitContainerControl1.SplitterPosition = 226;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // CMS_SagTik
            // 
            this.CMS_SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagTikYenile});
            this.CMS_SagTik.Name = "CMS_SagTik";
            this.CMS_SagTik.Size = new System.Drawing.Size(106, 26);
            // 
            // SagTikYenile
            // 
            this.SagTikYenile.Name = "SagTikYenile";
            this.SagTikYenile.Size = new System.Drawing.Size(180, 22);
            this.SagTikYenile.Text = "Yenile";
            this.SagTikYenile.Click += new System.EventHandler(this.SagTikYenile_Click);
            // 
            // Frm_FaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 503);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Frm_FaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.Frm_FaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FaturaTürü.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.CMS_SagTik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn CariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn FaturaNo;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton Btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton Btn_Ara;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_FaturaNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn FaturaTuru;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit Txt_FaturaTürü;
        private DevExpress.XtraEditors.DateEdit Txt_Tarih;
        private System.Windows.Forms.ContextMenuStrip CMS_SagTik;
        private System.Windows.Forms.ToolStripMenuItem SagTikYenile;
    }
}