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

namespace StokTakipOtomasyon.Modül_Cek
{
    public partial class Frm_BankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int CekID = -1;
        int BankaID = -1;
        Fonksiyonlar.Tbl_Cekler cek;

        public Frm_BankayaCekCikisi()
        {
            InitializeComponent();
        }

        private void Frm_BankayaCekCikisi_Load(object sender, EventArgs e)
        {
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            Txt_Banka.Text = "";
            Txt_BankaAdi.Text = "";
            Txt_BelgeNo.Text = "";
            Txt_CekNo.Text = "";
            Txt_HesapNo.Text = "";
            Txt_Sube.Text = "";
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_Tutar.Text = "";
            CekID = -1;
            BankaID = -1;
            cek = null;
            AnaForm.Aktarma = -1;
        }

        void CekGetir(int id)   //Ders 12 9:50
        {
            try
            {
                CekID = id;
                cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                Txt_Banka.Text = cek.Banka;
                Txt_CekNo.Text = cek.CekNo;
                Txt_Sube.Text = cek.Sube;
                Txt_VadeTarihi.Text = cek.VadeTarihi.Value.ToShortDateString();
                Txt_Tutar.Text = cek.Tutar.ToString();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void BankaGetir(int id)
        {
            try
            {
                BankaID = id;
                Txt_HesapNo.Text = Db.Tbl_Bankalars.First(s => s.Id == BankaID).HesapNo;
                Txt_BankaAdi.Text = Db.Tbl_Bankalars.First(s => s.Id == BankaID).BankaAdi;
                /*BankaID den ID ye eşit olamsı durumunda HesapNo ve BankaAdi ni getir.*/
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void YeniKaydet()
        {
            try
            {

            }
            catch (Exception)
            {
                Fonksiyonlar.Tbl_BankaHareketleri bankaHareketleri = new Fonksiyonlar.Tbl_BankaHareketleri();
                bankaHareketleri.Aciklama = Txt_BelgeNo.Text + "belge numaralı" + Txt_CekNo.Text + "numaralı çekin bankaya çıkışı";
                bankaHareketleri.BankaID = BankaID;
                bankaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                bankaHareketleri.EvrakID = CekID;
                bankaHareketleri.EvrakTuru = "Bankaya Çek";
                bankaHareketleri.GCKodu = "G";
                bankaHareketleri.Tarih = DateTime.Parse(Txt_Tarih.Text);
                bankaHareketleri.Tutar = decimal.Parse(Txt_Tutar.Text);
                bankaHareketleri.SaveDate = DateTime.Now;
                bankaHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_BankaHareketleris.InsertOnSubmit(bankaHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "nolu çekin banka hareket kaydı işlenmiştir.");

                cek.VerilenBanka_BelgeNo = Txt_BelgeNo.Text;
                cek.VerilenBanka_Tarihi = DateTime.Parse(Txt_Tarih.Text);
                cek.VerilenBanka_ID = BankaID;
                cek.Durumu = "Bankada";
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "nolu çekin durum güncellemesi yapılmıştır.");
                Temizle();
            }
        }

        private void Txt_HesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = frm.BankaListesi(true);
            if (id > 0)
            {
                BankaGetir(id);
            }
            AnaForm.Aktarma = -1;
        }

        private void Txt_CekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = frm.CekListesi(true);
            if (id > 0)
            {
                CekGetir(id);
            }
            AnaForm.Aktarma = -1;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (cek != null && CekID > 0 && BankaID > 0)
            {
                YeniKaydet();
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}