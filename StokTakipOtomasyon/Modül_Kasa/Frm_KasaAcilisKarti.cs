using DevExpress.XtraEditors;
using StokTakipOtomasyon.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon.Modül_Kasa
{
    public partial class Frm_KasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;

        public Frm_KasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void Frm_KasaAcilisKarti_Load(object sender, EventArgs e)
        {
            Txt_KasaKodu.Text = Numara.KasaKodNumarasi();
            Listele();
        }
        void Temizle()
        {
            Txt_KasaKodu.Text = Numara.KasaKodNumarasi();
            Txt_KasaAdı.Text = "";
            Txt_Aciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Kasalar Kasa = new Fonksiyonlar.Tbl_Kasalar();
                Kasa.KasaKodu = Txt_KasaKodu.Text;
                Kasa.KasaAdi = Txt_KasaAdı.Text;
                Kasa.Aciklama = Txt_Aciklama.Text;
                Kasa.SaveDate = DateTime.Now;
                Kasa.SaveUser = AnaForm.UserID;
                Db.Tbl_Kasalars.InsertOnSubmit(Kasa);
                Db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni kasa kaydı oluşturulmuştur.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.Tbl_Kasalar Kasa = Db.Tbl_Kasalars.First(x => x.Id == SecimID);
                Kasa.KasaKodu = Txt_KasaKodu.Text;
                Kasa.KasaAdi = Txt_KasaAdı.Text;
                Kasa.Aciklama = Txt_Aciklama.Text;
                Kasa.EditDate = DateTime.Now;
                Kasa.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                Db.Tbl_Kasalars.DeleteOnSubmit(Db.Tbl_Kasalars.First(x => x.Id == SecimID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                Txt_KasaKodu.Text = gridView1.GetFocusedRowCellValue("KasaKodu").ToString();
                Txt_KasaAdı.Text = gridView1.GetFocusedRowCellValue("KasaAdi").ToString();
                Txt_Aciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
                //Txt_Aciklama.Text = Db.Tbl_Kasalars.First(x => x.Id == SecimID).ToString();  DERS 4 19:55
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Listele()
        {
            var Lst = from s in Db.Tbl_Kasalars
                      select s;
            Grd_Liste.DataSource = Lst;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Txt_KasaAdı.Text != null && Txt_Aciklama.Text != null)
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
                {
                    Guncelle();
                }
                else
                {
                    YeniKaydet();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz.", "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grd_Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}