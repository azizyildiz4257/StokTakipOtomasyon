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
    public partial class Frm_MusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public Frm_MusteriCeki()
        {
            InitializeComponent();
        }

        public void Ac(int id)
        {
            try
            {
                CekID = id;
                Fonksiyonlar.Tbl_Cekler cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                Txt_Aciklama.Text = cek.Aciklama;
                if (cek.ACKodu == "A") Txt_CekTuru.SelectedIndex = 0;
                if (cek.ACKodu == "C") Txt_CekTuru.SelectedIndex = 1;
                Txt_AsilBorclu.Text = cek.AsilBorclu;
                Txt_Banka.Text = cek.Banka;
                Txt_BelgeNo.Text = cek.BelgeNo;
                Txt_CekNo.Text = cek.CekNo;
                Txt_HesapNo.Text = cek.HesapNo;
                Txt_Sube.Text = cek.Sube;
                Txt_Tutar.Text = cek.Tutar.Value.ToString();
                Txt_VadeTarihi.Text = cek.VadeTarihi.Value.ToShortDateString();
                CariAc(cek.AlinanCariID.Value);
                Edit = true;

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
                Temizle();
            }
        }

        void Temizle()
        {
            Txt_Aciklama.Text = "";
            Txt_AsilBorclu.Text = "";
            Txt_Banka.Text = "";
            Txt_BelgeNo.Text = "";
            Txt_CariAdi.Text = "";
            Txt_CariKodu.Text = "";
            Txt_CekNo.Text = "";
            Txt_CekTuru.Text = "";
            Txt_CekTuru.SelectedIndex = 0;
            Txt_HesapNo.Text = "";
            Txt_Sube.Text = "";
            Txt_Tutar.Text = "";
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            AnaForm.Aktarma = -1;
            Edit = false;
        }

        private void Frm_MusteriCeki_Load(object sender, EventArgs e)
        {
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void YeniCekKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Cekler Cek = new Fonksiyonlar.Tbl_Cekler();
                Cek.Aciklama = Txt_Aciklama.Text;
                if (Txt_CekTuru.SelectedIndex == 0) Cek.ACKodu = "A";
                if (Txt_CekTuru.SelectedIndex == 1) Cek.ACKodu = "C";
                Cek.AlinanCariID = CariID;
                Cek.Banka = Txt_Banka.Text;
                Cek.BelgeNo = Txt_BelgeNo.Text;
                Cek.CekNo = Txt_CekNo.Text;
                Cek.Durumu = "Portföy";
                Cek.HesapNo = Txt_HesapNo.Text;
                Cek.Sube = Txt_Sube.Text;
                Cek.Tahsil = "Hayır";
                Cek.Tarih = DateTime.Now;
                Cek.VadeTarihi = DateTime.Parse(Txt_VadeTarihi.Text);
                Cek.Tutar = decimal.Parse(Txt_Tutar.Text);
                Cek.Tipi = "Müşteri Çeki";
                Cek.AsilBorclu = Txt_AsilBorclu.Text;
                Cek.SaveDate = DateTime.Now;
                Cek.SaveUser = AnaForm.UserID;
                Db.Tbl_Ceklers.InsertOnSubmit(Cek);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "No'lu müşteri çeki kaydı gerçekleşmiştir.");
                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = new Fonksiyonlar.Tbl_CariHareketleri();
                cariHareketleri.Aciklama = Txt_BelgeNo.Text + "belge numaralı ve " + Txt_CekNo.Text + "cek numaralı müşteri çeki";
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = Cek.Id;   /*SubmitChanges ten sonra geldiği için cekin id'sini alabiliyoruz*/
                cariHareketleri.EvrakTuru = "Müşteri Çeki";
                cariHareketleri.Tarih = DateTime.Now;
                cariHareketleri.Tipi = "MÇ";    /*MÇ==>Müşteri Çeki*/
                cariHareketleri.SaveDate = DateTime.Now;
                cariHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_CariHareketleris.InsertOnSubmit(cariHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_CekNo.Text + "No'lu müşteri çeki cari kaydı gerçekleşmiştir.");
                /*cariHareketleri.Alacak=decimal.Parse(Txt_Tutar.Text);*/   /*Biz müşteriden aldığımız için müşterinin alacaklanması gerekiyor. bize borçlanmıyor. Ders 9 14:28*/
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
                Fonksiyonlar.Tbl_Cekler Cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                Cek.Aciklama = Txt_Aciklama.Text;
                if (Txt_CekTuru.SelectedIndex == 0) Cek.ACKodu = "A";
                if (Txt_CekTuru.SelectedIndex == 1) Cek.ACKodu = "C";
                Cek.AlinanCariID = CariID;
                Cek.Banka = Txt_Banka.Text;
                Cek.BelgeNo = Txt_BelgeNo.Text;
                Cek.CekNo = Txt_CekNo.Text;
                Cek.Durumu = "Portföy";
                Cek.HesapNo = Txt_HesapNo.Text;
                Cek.Sube = Txt_Sube.Text;
                Cek.Tahsil = "Hayır";
                Cek.VadeTarihi = DateTime.Parse(Txt_VadeTarihi.Text);
                Cek.Tutar = decimal.Parse(Txt_Tutar.Text);
                Cek.Tipi = "Müşteri Çeki";
                Cek.AsilBorclu = Txt_AsilBorclu.Text;
                Cek.EditDate = DateTime.Now;
                Cek.EditUser = AnaForm.UserID;
                Db.SubmitChanges();

                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = Db.Tbl_CariHareketleris.First(s => s.EvrakID == CekID && s.EvrakTuru == "Müşteri Çeki" && s.Tipi == "MÇ");
                cariHareketleri.Aciklama = Txt_BelgeNo.Text + "belge numaralı ve " + Txt_CekNo.Text + "cek numaralı müşteri çeki";
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = Cek.Id;   /*SubmitChanges ten sonra geldiği için cekin id'sini alabiliyoruz*/
                cariHareketleri.EvrakTuru = "Müşteri Çeki";
                cariHareketleri.Tarih = DateTime.Now;
                cariHareketleri.Tipi = "MÇ";    /*MÇ==>Müşteri Çeki*/
                cariHareketleri.EditDate = DateTime.Now;
                cariHareketleri.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                /*cariHareketleri.Alacak=decimal.Parse(Txt_Tutar.Text);*/   /*Biz müşteriden aldığımız için müşterinin alacaklanması gerekiyor. bize borçlanmıyor. Ders 9 14:28*/
                Temizle();

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        void CariAc(int id)
        {
            CariID = id;    /*Her ihtimale karşı belki dışardan public ifadesiyle açılmasına müsade eder ve başka bir yerden erişmek isteriz diye tanımladık. Gerekte olmayabilir. Ders 9 29:25*/
            Fonksiyonlar.Tbl_Cariler cari = Db.Tbl_Carilers.First(s => s.Id == CariID);
            Txt_CariAdi.Text = cari.CariAdi;
            Txt_CariKodu.Text = cari.CariKodu;

        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = frm.CariListesi(true);
            if (id > 0)
            {
                CariAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            /*Böyle bir kontrol mekanizması koyduk ama formda boş text olursa kayıt işlemini gerçekleştirmemesini yapabiliriz. Ders 9 33:00*/
            if (Edit)
            {
                Guncelle();
            }
            else
            {
                YeniCekKaydet();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            /*Burda iki işlem yapmamız gerekiyor Yani ceki sildiğimiz zaman carideki kaydıda silmemiz gerekiyor.*/
            if (Edit && CekID > 0 && mesajlar.Sil() == DialogResult.Yes)
            {
                Db.Tbl_Ceklers.DeleteOnSubmit(Db.Tbl_Ceklers.First(s => s.Id == CekID));
                Db.Tbl_CariHareketleris.DeleteOnSubmit(Db.Tbl_CariHareketleris.First(s => s.EvrakID == CekID && s.EvrakTuru == "Müşteri Çeki"));
                Temizle();
            }
        }
    }
}