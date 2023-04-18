namespace StokTakipOtomasyon
{
    partial class Frm_Login
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Ayar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Giris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 17);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Kullanıcı Adı :";
            // 
            // Txt_KullaniciAdi
            // 
            this.Txt_KullaniciAdi.EditValue = "tekbiryazilim";
            this.Txt_KullaniciAdi.Location = new System.Drawing.Point(106, 12);
            this.Txt_KullaniciAdi.Name = "Txt_KullaniciAdi";
            this.Txt_KullaniciAdi.Size = new System.Drawing.Size(115, 20);
            this.Txt_KullaniciAdi.TabIndex = 0;
            // 
            // Btn_Ayar
            // 
            this.Btn_Ayar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Ayar.Appearance.Options.UseFont = true;
            this.Btn_Ayar.Location = new System.Drawing.Point(13, 65);
            this.Btn_Ayar.Name = "Btn_Ayar";
            this.Btn_Ayar.Size = new System.Drawing.Size(100, 26);
            this.Btn_Ayar.TabIndex = 3;
            this.Btn_Ayar.Text = "Ayar";
            this.Btn_Ayar.Click += new System.EventHandler(this.Btn_Ayar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(63, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 17);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Şifre :";
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(106, 38);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.Properties.PasswordChar = '•';
            this.Txt_Sifre.Size = new System.Drawing.Size(115, 20);
            this.Txt_Sifre.TabIndex = 1;
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris.Appearance.Options.UseFont = true;
            this.Btn_Giris.Location = new System.Drawing.Point(121, 65);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(100, 26);
            this.Btn_Giris.TabIndex = 2;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.Btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 107);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Btn_Ayar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.Txt_KullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_KullaniciAdi;
        private DevExpress.XtraEditors.SimpleButton Btn_Ayar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Txt_Sifre;
        private DevExpress.XtraEditors.SimpleButton Btn_Giris;
    }
}