using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        public Frm_Login()
        {
            InitializeComponent();
            Txt_KullaniciAdi.Focus();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.Tbl_Kullanicilar Kullanici = Db.Tbl_Kullanicilars.First(s => s.Kullanici == Txt_KullaniciAdi.Text.Trim() && s.Sifre == Txt_Sifre.Text.Trim());
                Kullanici.LastLogin = DateTime.Now;
                Db.SubmitChanges();
                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);   //Kullanıcıyı anaforma gönderiyoruz. Ders 18 1:22:58
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılamadı. Kullanıcı Adı veya Şifre hatalı Lütfen tekrar deneyiniz. " + ex.Message);
                return;
            }
        }

        private void Btn_Ayar_Click(object sender, EventArgs e)
        {
            Frm_Ayar frm = new Frm_Ayar();
            frm.ShowDialog();
        }
    }
}