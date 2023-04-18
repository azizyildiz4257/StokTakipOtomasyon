namespace StokTakipOtomasyon.Modül_Kullanici
{
    partial class Frm_KullaniciYönetimi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_YeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soyisim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aktif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Btn_Sil);
            this.panelControl1.Controls.Add(this.Btn_Guncelle);
            this.panelControl1.Controls.Add(this.Btn_YeniKullanici);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(747, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(382, 12);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(179, 23);
            this.Btn_Sil.TabIndex = 2;
            this.Btn_Sil.Text = "Seçili Kullanıcıyı Sil";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(197, 12);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(179, 23);
            this.Btn_Guncelle.TabIndex = 1;
            this.Btn_Guncelle.Text = "Seçili Kullanıcıyı Güncelle";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_YeniKullanici
            // 
            this.Btn_YeniKullanici.Location = new System.Drawing.Point(12, 12);
            this.Btn_YeniKullanici.Name = "Btn_YeniKullanici";
            this.Btn_YeniKullanici.Size = new System.Drawing.Size(179, 23);
            this.Btn_YeniKullanici.TabIndex = 0;
            this.Btn_YeniKullanici.Text = "Yeni Kullanıcı Girişi";
            this.Btn_YeniKullanici.Click += new System.EventHandler(this.Btn_YeniKullanici_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(747, 317);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Kullanici,
            this.İsim,
            this.Soyisim,
            this.Aktif,
            this.Kodu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.OptionsColumn.AllowFocus = false;
            this.Id.OptionsColumn.FixedWidth = true;
            this.Id.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.Id.OptionsColumn.ReadOnly = true;
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            // 
            // Kullanici
            // 
            this.Kullanici.Caption = "Kullanıcı";
            this.Kullanici.FieldName = "Kullanici";
            this.Kullanici.Name = "Kullanici";
            this.Kullanici.OptionsColumn.AllowEdit = false;
            this.Kullanici.OptionsColumn.AllowFocus = false;
            this.Kullanici.OptionsColumn.FixedWidth = true;
            this.Kullanici.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.Kullanici.OptionsColumn.ReadOnly = true;
            this.Kullanici.Visible = true;
            this.Kullanici.VisibleIndex = 1;
            // 
            // İsim
            // 
            this.İsim.Caption = "İsim";
            this.İsim.FieldName = "İsim";
            this.İsim.Name = "İsim";
            this.İsim.OptionsColumn.AllowEdit = false;
            this.İsim.OptionsColumn.AllowFocus = false;
            this.İsim.OptionsColumn.FixedWidth = true;
            this.İsim.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.İsim.OptionsColumn.ReadOnly = true;
            this.İsim.Visible = true;
            this.İsim.VisibleIndex = 2;
            // 
            // Soyisim
            // 
            this.Soyisim.Caption = "Soyisim";
            this.Soyisim.FieldName = "Soyisim";
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.OptionsColumn.AllowEdit = false;
            this.Soyisim.OptionsColumn.AllowFocus = false;
            this.Soyisim.OptionsColumn.FixedWidth = true;
            this.Soyisim.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.Soyisim.OptionsColumn.ReadOnly = true;
            this.Soyisim.Visible = true;
            this.Soyisim.VisibleIndex = 3;
            // 
            // Aktif
            // 
            this.Aktif.Caption = "Durumu";
            this.Aktif.FieldName = "Aktif";
            this.Aktif.Name = "Aktif";
            this.Aktif.OptionsColumn.AllowEdit = false;
            this.Aktif.OptionsColumn.AllowFocus = false;
            this.Aktif.OptionsColumn.FixedWidth = true;
            this.Aktif.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.Aktif.OptionsColumn.ReadOnly = true;
            this.Aktif.Visible = true;
            this.Aktif.VisibleIndex = 4;
            // 
            // Kodu
            // 
            this.Kodu.Caption = "Kullanıcı Kodu";
            this.Kodu.FieldName = "Kodu";
            this.Kodu.Name = "Kodu";
            this.Kodu.OptionsColumn.AllowEdit = false;
            this.Kodu.OptionsColumn.AllowFocus = false;
            this.Kodu.OptionsColumn.FixedWidth = true;
            this.Kodu.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.Kodu.OptionsColumn.ReadOnly = true;
            this.Kodu.Visible = true;
            this.Kodu.VisibleIndex = 5;
            // 
            // Frm_KullaniciYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 367);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_KullaniciYönetimi";
            this.Text = "Kullanıcı Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_YeniKullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Kullanici;
        private DevExpress.XtraGrid.Columns.GridColumn İsim;
        private DevExpress.XtraGrid.Columns.GridColumn Soyisim;
        private DevExpress.XtraGrid.Columns.GridColumn Aktif;
        private DevExpress.XtraGrid.Columns.GridColumn Kodu;
    }
}