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

namespace StokTakipOtomasyon.Modül_Cek
{
    public partial class Frm_KendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int CekID = -1;
        int BankaID = -1;
        bool Edit = false;

        public Frm_KendiCekimiz()
        {
            InitializeComponent();
        }

        private void Frm_KendiCekimiz_Load(object sender, EventArgs e)
        {
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            Txt_Aciklama.Text = "";
            Txt_Banka.Text = "";
            Txt_BelgeNo.Text = "";
            Txt_CekNo.Text = "";
            Txt_HesapNo.Text = "";
            Txt_Sube.Text = "";
            Txt_Tutar.Text = "";
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekID = -1;
            BankaID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int CekinID_si)     //Ders 10 34:35
        {
            try
            {
                CekID = CekinID_si;
                Fonksiyonlar.Tbl_Cekler cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                BankaAc(Db.Tbl_Bankalars.First(s => s.BankaAdi == cek.Banka && s.HesapNo == cek.HesapNo).Id);/*Bankaıd üzerinden banka ac metodunu çalıştırmış olacaz*/
                Txt_Aciklama.Text = cek.Aciklama;
                Txt_BelgeNo.Text = cek.BelgeNo;
                Txt_CekNo.Text = cek.CekNo;
                Txt_Tutar.Text = cek.Tutar.Value.ToString();
                Txt_VadeTarihi.Text = cek.VadeTarihi.Value.ToShortDateString();
                Edit = true;
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
                Temizle();
            }
        }

        void BankaAc(int BankaID_si)    //Ders 10 29:35
        {
            try
            {
                BankaID = BankaID_si;
                Fonksiyonlar.Tbl_Bankalar banka = Db.Tbl_Bankalars.First(s => s.Id == BankaID);
                Txt_Banka.Text = banka.BankaAdi;
                Txt_HesapNo.Text = banka.HesapNo;
                Txt_Sube.Text = banka.Sube;
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void YeniKaydet()   //Ders 10 12:02 Hoca Kararsız Kaldı.
        {
            try
            {
                Fonksiyonlar.Tbl_Cekler Cek = new Fonksiyonlar.Tbl_Cekler();
                Cek.Aciklama = Txt_Aciklama.Text;
                Cek.ACKodu = "A";
                Cek.Banka = Txt_Banka.Text;
                Cek.BelgeNo = Txt_BelgeNo.Text;
                Cek.CekNo = Txt_CekNo.Text;
                Cek.Durumu = "Portföy";
                Cek.HesapNo = Txt_HesapNo.Text;
                Cek.Sube = Txt_Sube.Text;
                Cek.Tahsil = "Hayır";
                Cek.Tarih = DateTime.Now;
                Cek.Tipi = "Kendi Çekimiz";
                Cek.Tutar = decimal.Parse(Txt_Tutar.Text);
                Cek.VadeTarihi = DateTime.Parse(Txt_VadeTarihi.Text);
                Cek.SaveDate = DateTime.Now;
                Cek.SaveUser = AnaForm.UserID;
                Db.Tbl_Ceklers.InsertOnSubmit(Cek);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "nolu kendi çekimzin çek kaydı yapılmıştır.");

                #region Bu kısmı aslında yapmasakta olur ama banka hareketlerinde 0 yani işlem görmemiş olarak görünmesinde fayda var Ders 10 19:26

                Fonksiyonlar.Tbl_BankaHareketleri bankaHareketleri = new Fonksiyonlar.Tbl_BankaHareketleri();
                bankaHareketleri.Aciklama = Txt_CekNo.Text + "nolu ve " + Txt_VadeTarihi + " tarihli kendi çekimiz.";
                bankaHareketleri.BankaID = BankaID;
                bankaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                bankaHareketleri.EvrakID = Cek.Id;
                bankaHareketleri.EvrakTuru = "Kendi Çekimiz";
                bankaHareketleri.GCKodu = "C";
                bankaHareketleri.Tarih = DateTime.Now;
                bankaHareketleri.Tutar = 0;
                bankaHareketleri.SaveDate = DateTime.Now;
                bankaHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_BankaHareketleris.InsertOnSubmit(bankaHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "nolu kendi çekimzin banka kaydı yapılmıştır.");
                Temizle();
                #endregion
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void Guncelle()     //Ders 10 24:30
        {
            try
            {
                Fonksiyonlar.Tbl_Cekler Cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                Cek.Aciklama = Txt_Aciklama.Text;
                Cek.ACKodu = "A";
                Cek.Banka = Txt_Banka.Text;
                Cek.BelgeNo = Txt_BelgeNo.Text;
                Cek.CekNo = Txt_CekNo.Text;
                Cek.Durumu = "Portföy";
                Cek.HesapNo = Txt_HesapNo.Text;
                Cek.Sube = Txt_Sube.Text;
                Cek.Tahsil = "Hayır";
                Cek.Tarih = DateTime.Now;
                Cek.Tipi = "Kendi Çekimiz";
                Cek.Tutar = decimal.Parse(Txt_Tutar.Text);
                Cek.VadeTarihi = DateTime.Parse(Txt_VadeTarihi.Text);
                Cek.EditDate = DateTime.Now;
                Cek.EditUser = AnaForm.UserID;
                Db.SubmitChanges();

                #region Bu kısmı aslında yapmasakta olur ama banka hareketlerinde 0 yani işlem görmemiş olarak görünmesinde fayda var Ders 10 19:26

                Fonksiyonlar.Tbl_BankaHareketleri bankaHareketleri = Db.Tbl_BankaHareketleris.First(s => s.EvrakID == CekID && s.EvrakTuru == "Kendi Çekimiz"); /*Biz burda EvrakID yerine BankaID kullanmış olsaydık Güncelleme sırasında bankanın değişmesi durumunu gözden önüde bulundurursak pek doğru bir seçim olmazdı.*/
                bankaHareketleri.Aciklama = Txt_CekNo.Text + "nolu ve " + Txt_VadeTarihi + " tarihli kendi çekimiz.";
                bankaHareketleri.BankaID = BankaID;
                bankaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                bankaHareketleri.EvrakID = Cek.Id;
                bankaHareketleri.EvrakTuru = "Kendi Çekimiz";
                bankaHareketleri.GCKodu = "C";
                bankaHareketleri.Tarih = DateTime.Now;
                bankaHareketleri.Tutar = 0;
                bankaHareketleri.EditDate = DateTime.Now;
                bankaHareketleri.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
                #endregion
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void Sil()
        {
            try
            {
                Db.Tbl_BankaHareketleris.DeleteOnSubmit(Db.Tbl_BankaHareketleris.First(s => s.EvrakID == CekID && s.EvrakTuru == "Kendi Çekimiz"));
                Db.Tbl_Ceklers.DeleteOnSubmit(Db.Tbl_Ceklers.First(s => s.Id == CekID));
                Db.SubmitChanges();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Txt_HesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)   //Ders 10 37:50
        {
            int id = frm.BankaListesi(true);
            if (id > 0) BankaAc(id);
            AnaForm.Aktarma = -1;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)   //Ders 10 39:50
        {
            if (Edit && CekID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}