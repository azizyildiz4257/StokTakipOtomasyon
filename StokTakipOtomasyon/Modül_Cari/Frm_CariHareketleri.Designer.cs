namespace StokTakipOtomasyon.Modül_Cari
{
    partial class Frm_CariHareketleri
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
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Txt_Bakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Cikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Giris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_HesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Txt_HesapTürü_Adi = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Bakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Cikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Giris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HesapTürü_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 4;
            // 
            // Txt_Bakiye
            // 
            this.Txt_Bakiye.Location = new System.Drawing.Point(282, 79);
            this.Txt_Bakiye.Name = "Txt_Bakiye";
            this.Txt_Bakiye.Size = new System.Drawing.Size(58, 20);
            this.Txt_Bakiye.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(229, 80);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 17);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Bakiye :";
            // 
            // Txt_Cikis
            // 
            this.Txt_Cikis.Location = new System.Drawing.Point(158, 79);
            this.Txt_Cikis.Name = "Txt_Cikis";
            this.Txt_Cikis.Size = new System.Drawing.Size(58, 20);
            this.Txt_Cikis.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(118, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 17);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Çıkış :";
            // 
            // Txt_Giris
            // 
            this.Txt_Giris.Location = new System.Drawing.Point(53, 79);
            this.Txt_Giris.Name = "Txt_Giris";
            this.Txt_Giris.Size = new System.Drawing.Size(58, 20);
            this.Txt_Giris.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 17);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Giriş :";
            // 
            // Txt_HesapNo
            // 
            this.Txt_HesapNo.Location = new System.Drawing.Point(127, 52);
            this.Txt_HesapNo.Name = "Txt_HesapNo";
            this.Txt_HesapNo.Size = new System.Drawing.Size(213, 20);
            this.Txt_HesapNo.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Hesap No :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 17);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Hesap Türü / Adı :";
            // 
            // Giris
            // 
            this.Giris.Caption = "Giriş";
            this.Giris.FieldName = "Giris";
            this.Giris.Name = "Giris";
            this.Giris.OptionsColumn.AllowEdit = false;
            this.Giris.OptionsColumn.AllowFocus = false;
            this.Giris.OptionsColumn.FixedWidth = true;
            this.Giris.Visible = true;
            this.Giris.VisibleIndex = 2;
            // 
            // EvrakID
            // 
            this.EvrakID.Caption = "EvrakID";
            this.EvrakID.FieldName = "EvrakID";
            this.EvrakID.Name = "EvrakID";
            // 
            // EvrakTuru
            // 
            this.EvrakTuru.Caption = "Evrak Türü";
            this.EvrakTuru.FieldName = "EvrakTuru";
            this.EvrakTuru.Name = "EvrakTuru";
            this.EvrakTuru.OptionsColumn.AllowEdit = false;
            this.EvrakTuru.OptionsColumn.AllowFocus = false;
            this.EvrakTuru.OptionsColumn.FixedWidth = true;
            this.EvrakTuru.Visible = true;
            this.EvrakTuru.VisibleIndex = 1;
            // 
            // BelgeNo
            // 
            this.BelgeNo.Caption = "Belge No";
            this.BelgeNo.FieldName = "BelgeNo";
            this.BelgeNo.Name = "BelgeNo";
            this.BelgeNo.OptionsColumn.AllowEdit = false;
            this.BelgeNo.OptionsColumn.AllowFocus = false;
            this.BelgeNo.OptionsColumn.FixedWidth = true;
            this.BelgeNo.Visible = true;
            this.BelgeNo.VisibleIndex = 0;
            // 
            // Txt_HesapTürü_Adi
            // 
            this.Txt_HesapTürü_Adi.Location = new System.Drawing.Point(127, 26);
            this.Txt_HesapTürü_Adi.Name = "Txt_HesapTürü_Adi";
            this.Txt_HesapTürü_Adi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.Txt_HesapTürü_Adi.Size = new System.Drawing.Size(213, 20);
            this.Txt_HesapTürü_Adi.TabIndex = 9;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.BelgeNo,
            this.EvrakTuru,
            this.EvrakID,
            this.Giris,
            this.Cikis,
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
            // Cikis
            // 
            this.Cikis.Caption = "Çıkış";
            this.Cikis.FieldName = "Cikis";
            this.Cikis.Name = "Cikis";
            this.Cikis.OptionsColumn.AllowEdit = false;
            this.Cikis.OptionsColumn.AllowFocus = false;
            this.Cikis.OptionsColumn.FixedWidth = true;
            this.Cikis.Visible = true;
            this.Cikis.VisibleIndex = 3;
            // 
            // Grd_Liste
            // 
            this.Grd_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Liste.Location = new System.Drawing.Point(2, 23);
            this.Grd_Liste.MainView = this.gridView1;
            this.Grd_Liste.Name = "Grd_Liste";
            this.Grd_Liste.Size = new System.Drawing.Size(694, 297);
            this.Grd_Liste.TabIndex = 0;
            this.Grd_Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Grd_Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 113);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(698, 322);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Txt_Bakiye);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Txt_Cikis);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Txt_Giris);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.Txt_HesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.Txt_HesapTürü_Adi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(698, 113);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // Frm_CariHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 435);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_CariHareketleri";
            this.Text = "Cari Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Bakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Cikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Giris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_HesapTürü_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraEditors.TextEdit Txt_Bakiye;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit Txt_Cikis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_Giris;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit Txt_HesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Giris;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakID;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakTuru;
        private DevExpress.XtraGrid.Columns.GridColumn BelgeNo;
        private DevExpress.XtraEditors.ButtonEdit Txt_HesapTürü_Adi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Cikis;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}