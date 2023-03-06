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

namespace StokTakipOtomasyon.Modul_Banka
{
    public partial class Frm_BankaIslemi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;

        public Frm_BankaIslemi()
        {
            InitializeComponent();
        }

        private void Frm_BankaIslemi_Load(object sender, EventArgs e)
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }
        public void Ac(int ID)  //Ders 6 46:00
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.Tbl_BankaHareketleri hareketler = Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID);
                BankaAc(hareketler.BankaID.Value);
                Txt_Aciklama.Text = hareketler.Aciklama;
                Txt_BelgeNo.Text = hareketler.BelgeNo;
                Txt_Tarih.Text = hareketler.Tarih.Value.ToShortDateString();
                Txt_Tutar.Text = hareketler.Tutar.ToString();
                if (hareketler.GCKodu == "G") RDBTN_GirisIslemi.Checked = true;
                if (hareketler.GCKodu == "C") RDBTN_CikisIslemi.Checked = true;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void BankaAc(int ID)    //Ders 6 43:15
        {
            try
            {
                BankaID = ID;
                Txt_HesapTürü_Adi.Text = Db.Tbl_Bankalars.First(s => s.Id == BankaID).HesapAdi;
                Txt_HesapNo.Text = Db.Tbl_Bankalars.First(s => s.Id == BankaID).HesapNo;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Temizle()
        {
            Txt_BelgeNo.Text = "";
            Txt_HesapTürü_Adi.Text = "";
            Txt_HesapNo.Text = "";
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_Tutar.Text = "0";
            Txt_Aciklama.Text = "";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()   //Ders 6 37:54
        {
            try
            {
                Fonksiyonlar.Tbl_BankaHareketleri hareketler = new Fonksiyonlar.Tbl_BankaHareketleri();
                hareketler.BelgeNo = Txt_BelgeNo.Text;
                hareketler.BankaID = BankaID;
                hareketler.EvrakTuru = "Banka İşlem";
                hareketler.Aciklama = Txt_Aciklama.Text;
                if (RDBTN_GirisIslemi.Checked) hareketler.GCKodu = "G";
                if (RDBTN_CikisIslemi.Checked) hareketler.GCKodu = "C";
                hareketler.Tarih = DateTime.Parse(Txt_Tarih.Text);
                hareketler.Tutar = decimal.Parse(Txt_Tutar.Text);
                hareketler.SaveDate = DateTime.Now;
                hareketler.SaveUser = AnaForm.UserID;
                Db.Tbl_BankaHareketleris.InsertOnSubmit(hareketler);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Banka işlemi kaydı yapılmıştır.");
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Guncelle()     //Ders 6 40:00
        {
            try
            {
                Fonksiyonlar.Tbl_BankaHareketleri hareketler = Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID);
                hareketler.BelgeNo = Txt_BelgeNo.Text;
                hareketler.BankaID = BankaID;
                hareketler.EvrakTuru = "Banka İşlem";
                hareketler.Aciklama = Txt_Aciklama.Text;
                if (RDBTN_GirisIslemi.Checked) hareketler.GCKodu = "G";
                if (RDBTN_CikisIslemi.Checked) hareketler.GCKodu = "C";
                hareketler.Tarih = DateTime.Parse(Txt_Tarih.Text);
                hareketler.Tutar = decimal.Parse(Txt_Tutar.Text);
                hareketler.EditDate = DateTime.Now;
                hareketler.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                Db.Tbl_BankaHareketleris.DeleteOnSubmit(Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void Txt_HesapTürü_Adi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) //Ders6 1:02:33 
        {
            int Id = frm.BankaListesi(true);
            if (Id > 0)
            {
                BankaAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e) // Ders 6 48:30 önemli videoyu dinle
        {
            if (Edit && IslemID > 0 && mesajlar.Sil() == DialogResult.Yes)
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