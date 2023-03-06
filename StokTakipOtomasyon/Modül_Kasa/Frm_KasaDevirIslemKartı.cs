using DevExpress.Data.Filtering;
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
    public partial class Frm_KasaDevirIslemKartı : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;

        public Frm_KasaDevirIslemKartı()
        {
            InitializeComponent();
        }

        private void Frm_KasaDevirIslemKartı_Load(object sender, EventArgs e)
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_KasaKodu.Text = "";
            Txt_KasaAdı.Text = "";
            Txt_BelgeNo.Text = "";
            Txt_Tutar.Text = "0";
            Txt_Aciklama.Text = "";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = new Fonksiyonlar.Tbl_KasaHareketleri();
                kasaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                kasaHareketleri.Aciklama = Txt_Aciklama.Text;
                kasaHareketleri.EvrakTuru = "Kasa Devir Kartı";
                if (RBtn_CikisIslemi.Checked) kasaHareketleri.GCKodu = "C";
                if (RBtn_GirisIslemi.Checked) kasaHareketleri.GCKodu = "G";
                kasaHareketleri.KasaID = KasaID;
                kasaHareketleri.Tairh = DateTime.Parse(Txt_Tarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(Txt_Tutar.Text);
                kasaHareketleri.SaveDate = DateTime.Now;
                kasaHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_KasaHareketleris.InsertOnSubmit(kasaHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Devir Kartı hareket kaydı yapılmıştır.");
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID);
                kasaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                kasaHareketleri.Aciklama = Txt_Aciklama.Text;
                kasaHareketleri.EvrakTuru = "Kasa Devir Kartı";
                if (RBtn_CikisIslemi.Checked) kasaHareketleri.GCKodu = "C";
                if (RBtn_GirisIslemi.Checked) kasaHareketleri.GCKodu = "G";
                kasaHareketleri.KasaID = KasaID;
                kasaHareketleri.Tairh = DateTime.Parse(Txt_Tarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(Txt_Tutar.Text);
                kasaHareketleri.EditDate = DateTime.Now;
                kasaHareketleri.EditUser = AnaForm.UserID;
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
                Db.Tbl_KasaHareketleris.DeleteOnSubmit(Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                Txt_KasaKodu.Text = Db.Tbl_Kasalars.First(s => s.Id == KasaID).KasaKodu;
                Txt_KasaAdı.Text = Db.Tbl_Kasalars.First(s => s.Id == KasaID).KasaAdi;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.Tbl_KasaHareketleri hareket = Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID);
                Txt_Aciklama.Text = hareket.Aciklama;
                Txt_BelgeNo.Text = hareket.BelgeNo;
                KasaAc(hareket.KasaID.Value);
                Txt_Tarih.Text = hareket.Tairh.Value.ToShortDateString();
                Txt_Tutar.Text = hareket.Tutar.Value.ToString();
                if (hareket.GCKodu == "G") RBtn_GirisIslemi.Checked = true;
                if (hareket.GCKodu == "C") RBtn_CikisIslemi.Checked = true;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
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

        private void Btn_Sil_Click(object sender, EventArgs e)
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

        private void Txt_KasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void Txt_BelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}