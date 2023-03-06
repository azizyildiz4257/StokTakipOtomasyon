namespace StokTakipOtomasyon.Modül_Kasa
{
    partial class Frm_KasaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_KasaAcilisKarti));
            this.Grp_BankaListesi = new DevExpress.XtraEditors.GroupControl();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bakıye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Btn_Kapat = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_KasaAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Aciklama = new DevExpress.XtraEditors.MemoEdit();
            this.Txt_KasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.Grp_BankaBilgileri = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_BankaListesi)).BeginInit();
            this.Grp_BankaListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KasaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Aciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_BankaBilgileri)).BeginInit();
            this.Grp_BankaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_BankaListesi
            // 
            this.Grp_BankaListesi.Controls.Add(this.Grd_Liste);
            this.Grp_BankaListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grp_BankaListesi.Location = new System.Drawing.Point(0, 194);
            this.Grp_BankaListesi.Name = "Grp_BankaListesi";
            this.Grp_BankaListesi.Size = new System.Drawing.Size(312, 201);
            this.Grp_BankaListesi.TabIndex = 3;
            this.Grp_BankaListesi.Text = "Banka Listesi";
            // 
            // Grd_Liste
            // 
            this.Grd_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Liste.Location = new System.Drawing.Point(2, 23);
            this.Grd_Liste.MainView = this.gridView1;
            this.Grd_Liste.Name = "Grd_Liste";
            this.Grd_Liste.Size = new System.Drawing.Size(308, 176);
            this.Grd_Liste.TabIndex = 0;
            this.Grd_Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Liste.DoubleClick += new System.EventHandler(this.Grd_Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.KasaKodu,
            this.KasaAdi,
            this.Bakıye,
            this.Aciklama});
            this.gridView1.GridControl = this.Grd_Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // KasaKodu
            // 
            this.KasaKodu.Caption = "Kasa Kodu";
            this.KasaKodu.FieldName = "KasaKodu";
            this.KasaKodu.Name = "KasaKodu";
            this.KasaKodu.OptionsColumn.AllowEdit = false;
            this.KasaKodu.OptionsColumn.AllowFocus = false;
            this.KasaKodu.OptionsColumn.FixedWidth = true;
            this.KasaKodu.Visible = true;
            this.KasaKodu.VisibleIndex = 0;
            this.KasaKodu.Width = 100;
            // 
            // KasaAdi
            // 
            this.KasaAdi.Caption = "Kasa Adı";
            this.KasaAdi.FieldName = "KasaAdi";
            this.KasaAdi.Name = "KasaAdi";
            this.KasaAdi.OptionsColumn.AllowEdit = false;
            this.KasaAdi.OptionsColumn.AllowFocus = false;
            this.KasaAdi.Visible = true;
            this.KasaAdi.VisibleIndex = 1;
            this.KasaAdi.Width = 117;
            // 
            // Bakıye
            // 
            this.Bakıye.Caption = "Bakiye";
            this.Bakıye.FieldName = "Bakıye";
            this.Bakıye.Name = "Bakıye";
            this.Bakıye.OptionsColumn.AllowEdit = false;
            this.Bakıye.OptionsColumn.AllowFocus = false;
            this.Bakıye.OptionsColumn.FixedWidth = true;
            this.Bakıye.Visible = true;
            this.Bakıye.VisibleIndex = 2;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kapat.Appearance.Options.UseFont = true;
            this.Btn_Kapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kapat.ImageOptions.Image")));
            this.Btn_Kapat.Location = new System.Drawing.Point(210, 145);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.Btn_Kapat.Size = new System.Drawing.Size(96, 43);
            this.Btn_Kapat.TabIndex = 29;
            this.Btn_Kapat.Text = "Kapat";
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(108, 145);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(96, 43);
            this.Btn_Sil.TabIndex = 28;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(6, 145);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(96, 43);
            this.Btn_Kaydet.TabIndex = 27;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 17);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Açıklama :";
            // 
            // Txt_KasaAdı
            // 
            this.Txt_KasaAdı.Location = new System.Drawing.Point(87, 54);
            this.Txt_KasaAdı.Name = "Txt_KasaAdı";
            this.Txt_KasaAdı.Size = new System.Drawing.Size(219, 20);
            this.Txt_KasaAdı.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 17);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Kasa Adı :\r\n";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // Txt_Aciklama
            // 
            this.Txt_Aciklama.Location = new System.Drawing.Point(87, 80);
            this.Txt_Aciklama.Name = "Txt_Aciklama";
            this.Txt_Aciklama.Size = new System.Drawing.Size(219, 59);
            this.Txt_Aciklama.TabIndex = 21;
            // 
            // Txt_KasaKodu
            // 
            this.Txt_KasaKodu.Location = new System.Drawing.Point(87, 28);
            this.Txt_KasaKodu.Name = "Txt_KasaKodu";
            this.Txt_KasaKodu.Size = new System.Drawing.Size(219, 20);
            this.Txt_KasaKodu.TabIndex = 9;
            // 
            // Grp_BankaBilgileri
            // 
            this.Grp_BankaBilgileri.Controls.Add(this.Btn_Kapat);
            this.Grp_BankaBilgileri.Controls.Add(this.Btn_Sil);
            this.Grp_BankaBilgileri.Controls.Add(this.Btn_Kaydet);
            this.Grp_BankaBilgileri.Controls.Add(this.labelControl6);
            this.Grp_BankaBilgileri.Controls.Add(this.Txt_KasaAdı);
            this.Grp_BankaBilgileri.Controls.Add(this.labelControl2);
            this.Grp_BankaBilgileri.Controls.Add(this.Txt_KasaKodu);
            this.Grp_BankaBilgileri.Controls.Add(this.labelControl1);
            this.Grp_BankaBilgileri.Controls.Add(this.Txt_Aciklama);
            this.Grp_BankaBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_BankaBilgileri.Location = new System.Drawing.Point(0, 0);
            this.Grp_BankaBilgileri.Name = "Grp_BankaBilgileri";
            this.Grp_BankaBilgileri.Size = new System.Drawing.Size(312, 395);
            this.Grp_BankaBilgileri.TabIndex = 2;
            this.Grp_BankaBilgileri.Text = "Banka Bilgileri";
            // 
            // Frm_KasaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 395);
            this.Controls.Add(this.Grp_BankaListesi);
            this.Controls.Add(this.Grp_BankaBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_KasaAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Açılış Kartı";
            this.Load += new System.EventHandler(this.Frm_KasaAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_BankaListesi)).EndInit();
            this.Grp_BankaListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KasaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Aciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_BankaBilgileri)).EndInit();
            this.Grp_BankaBilgileri.ResumeLayout(false);
            this.Grp_BankaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_BankaListesi;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn KasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn KasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Bakıye;
        private DevExpress.XtraEditors.SimpleButton Btn_Kapat;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit Txt_KasaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit Txt_Aciklama;
        private DevExpress.XtraEditors.TextEdit Txt_KasaKodu;
        private DevExpress.XtraEditors.GroupControl Grp_BankaBilgileri;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
    }
}