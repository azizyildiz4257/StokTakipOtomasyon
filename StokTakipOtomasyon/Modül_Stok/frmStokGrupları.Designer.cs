namespace StokTakipOtomasyon.Modül_Stok
{
    partial class frmStokGrupları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokGrupları));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Txt_GrupAdı = new DevExpress.XtraEditors.TextEdit();
            this.Txt_GrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Kapat = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Grd_Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrupKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrupAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GrupAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Txt_GrupAdı);
            this.groupControl1.Controls.Add(this.Txt_GrupKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(326, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Grup Bilgisi";
            // 
            // Txt_GrupAdı
            // 
            this.Txt_GrupAdı.Location = new System.Drawing.Point(88, 65);
            this.Txt_GrupAdı.Name = "Txt_GrupAdı";
            this.Txt_GrupAdı.Size = new System.Drawing.Size(224, 20);
            this.Txt_GrupAdı.TabIndex = 6;
            // 
            // Txt_GrupKodu
            // 
            this.Txt_GrupKodu.Location = new System.Drawing.Point(88, 37);
            this.Txt_GrupKodu.Name = "Txt_GrupKodu";
            this.Txt_GrupKodu.Size = new System.Drawing.Size(224, 20);
            this.Txt_GrupKodu.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Grup Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Grup Kodu :";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Btn_Kapat);
            this.groupControl3.Controls.Add(this.Btn_Sil);
            this.groupControl3.Controls.Add(this.Btn_Kaydet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 335);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(326, 69);
            this.groupControl3.TabIndex = 1;
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kapat.Appearance.Options.UseFont = true;
            this.Btn_Kapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kapat.ImageOptions.Image")));
            this.Btn_Kapat.Location = new System.Drawing.Point(216, 13);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.Btn_Kapat.Size = new System.Drawing.Size(96, 43);
            this.Btn_Kapat.TabIndex = 9;
            this.Btn_Kapat.Text = "Kapat";
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(114, 13);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(96, 43);
            this.Btn_Sil.TabIndex = 8;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(12, 13);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(96, 43);
            this.Btn_Kaydet.TabIndex = 7;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Grd_Liste
            // 
            this.Grd_Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Liste.Location = new System.Drawing.Point(0, 100);
            this.Grd_Liste.MainView = this.gridView1;
            this.Grd_Liste.Name = "Grd_Liste";
            this.Grd_Liste.Size = new System.Drawing.Size(326, 235);
            this.Grd_Liste.TabIndex = 2;
            this.Grd_Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.GrupKodu,
            this.GrupAdı});
            this.gridView1.GridControl = this.Grd_Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // GrupKodu
            // 
            this.GrupKodu.Caption = "Grup Kodu";
            this.GrupKodu.FieldName = "GrupKodu";
            this.GrupKodu.Name = "GrupKodu";
            this.GrupKodu.OptionsColumn.AllowEdit = false;
            this.GrupKodu.OptionsColumn.AllowFocus = false;
            this.GrupKodu.OptionsColumn.FixedWidth = true;
            this.GrupKodu.Visible = true;
            this.GrupKodu.VisibleIndex = 0;
            this.GrupKodu.Width = 50;
            // 
            // GrupAdı
            // 
            this.GrupAdı.Caption = "Grup Adı";
            this.GrupAdı.FieldName = "GrupAdı";
            this.GrupAdı.Name = "GrupAdı";
            this.GrupAdı.OptionsColumn.AllowEdit = false;
            this.GrupAdı.OptionsColumn.AllowFocus = false;
            this.GrupAdı.OptionsColumn.FixedWidth = true;
            this.GrupAdı.Visible = true;
            this.GrupAdı.VisibleIndex = 1;
            // 
            // frmStokGrupları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 404);
            this.Controls.Add(this.Grd_Liste);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmStokGrupları.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokGrupları";
            this.Text = "Stok Grupları";
            this.Load += new System.EventHandler(this.frmStokGrupları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GrupAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_GrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit Txt_GrupAdı;
        private DevExpress.XtraEditors.TextEdit Txt_GrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_Kapat;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraGrid.GridControl Grd_Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn GrupKodu;
        private DevExpress.XtraGrid.Columns.GridColumn GrupAdı;
    }
}