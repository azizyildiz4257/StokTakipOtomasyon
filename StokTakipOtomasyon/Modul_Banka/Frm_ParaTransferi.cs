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

    public partial class Frm_ParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        //string IslemTuru = "Banka Havale";    Ders6 1:06:48 önce oluşturduk sonra kaldırdık.
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;

        public Frm_ParaTransferi()
        {
            InitializeComponent();
        }

        private void Txt_TransferTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txt_TransferTürü.SelectedIndex == 0)
            {
                RBtn_GelenIslemTuru.Text = "Gelen Havale";
                RBtn_GidenIslemTuru.Text = "Giden Havale";
            }
            if (Txt_TransferTürü.SelectedIndex == 1)
            {
                RBtn_GelenIslemTuru.Text = "Gelen EFT";
                RBtn_GidenIslemTuru.Text = "Giden EFT";
            }
        }

        private void Frm_ParaTransferi_Load(object sender, EventArgs e)
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()   //Ders 6 1:11:00
        {
            Txt_BelgeNo.Text = "";
            Txt_HesapTürü_Adi.Text = "";
            Txt_HesapNo.Text = "";
            Txt_CariKodu.Text = "";
            Txt_CariAdi.Text = "";
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_Tutar.Text = "";
            Txt_Aciklama.Text = "";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }
        public void Ac(int ID)    // Ders 6 1:34:20
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.Tbl_BankaHareketleri Banka = Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID);
                BankaAc(Banka.BankaID.Value);
                CariAc(Banka.CariID.Value);
                Txt_Aciklama.Text = Banka.Aciklama;
                Txt_BelgeNo.Text = Banka.BelgeNo;
                Txt_Tarih.Text = Banka.Tarih.Value.ToShortDateString();
                Txt_TransferTürü.Text = Banka.EvrakTuru;
                Txt_Tutar.Text = Banka.Tutar.ToString();
                if (Banka.GCKodu == "G") RBtn_GelenIslemTuru.Checked = true;
                if (Banka.GCKodu == "C") RBtn_GidenIslemTuru.Checked = true;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void BankaAc(int ID)    //Ders 6 1:13:03
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
        void CariAc(int ID)     //Ders 6 1:14:45
        {
            try
            {
                CariID = ID;
                Txt_CariKodu.Text = Db.Tbl_Carilers.First(s => s.Id == CariID).CariKodu;
                Txt_CariAdi.Text = Db.Tbl_Carilers.First(s => s.Id == CariID).CariAdi;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void YeniKaydet()   //Ders 6 1:24:30
        {
            try
            {
                Fonksiyonlar.Tbl_BankaHareketleri bankahareketler = new Fonksiyonlar.Tbl_BankaHareketleri();
                bankahareketler.BelgeNo = Txt_BelgeNo.Text;
                bankahareketler.BankaID = BankaID;
                bankahareketler.CariID = CariID;
                bankahareketler.EvrakTuru = Txt_TransferTürü.Text;
                if (RBtn_GelenIslemTuru.Checked) bankahareketler.GCKodu = "G";
                if (RBtn_GidenIslemTuru.Checked) bankahareketler.GCKodu = "C";
                bankahareketler.Aciklama = Txt_Aciklama.Text;
                bankahareketler.Tarih = DateTime.Parse(Txt_Tarih.Text);
                bankahareketler.Tutar = decimal.Parse(Txt_Tutar.Text);
                bankahareketler.SaveDate = DateTime.Now;
                bankahareketler.SaveUser = AnaForm.UserID;
                Db.Tbl_BankaHareketleris.InsertOnSubmit(bankahareketler);
                Db.SubmitChanges();

                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = new Fonksiyonlar.Tbl_CariHareketleri();
                cariHareketleri.Aciklama = Txt_Aciklama.Text;
                if (RBtn_GelenIslemTuru.Checked)
                {
                    cariHareketleri.Alacak = decimal.Parse(Txt_Tutar.Text);
                }
                if (RBtn_GidenIslemTuru.Checked)
                {
                    cariHareketleri.Borc = decimal.Parse(Txt_Tutar.Text);
                }
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = bankahareketler.Id;   /*BankaID;*/    //Ders 6 1:44:30 izle ben bu şekilde düzelttim.
                cariHareketleri.EvrakTuru = Txt_TransferTürü.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(Txt_Tarih.Text);
                if (Txt_TransferTürü.SelectedIndex == 0)
                {
                    cariHareketleri.Tipi = "Banka Havale";
                }
                if (Txt_TransferTürü.SelectedIndex == 1)
                {
                    cariHareketleri.Tipi = "Banka EFT";
                }
                cariHareketleri.SaveDate = DateTime.Now;
                cariHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_CariHareketleris.InsertOnSubmit(cariHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Para transfer kaydı gerçekleştirildi.");
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Guncelle()    //Ders 6 1:27:06
        {
            try
            {
                Fonksiyonlar.Tbl_BankaHareketleri bankahareketler = Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID);
                bankahareketler.BelgeNo = Txt_BelgeNo.Text;
                bankahareketler.BankaID = BankaID;
                bankahareketler.CariID = CariID;
                bankahareketler.EvrakTuru = Txt_TransferTürü.Text;
                if (RBtn_GelenIslemTuru.Checked) bankahareketler.GCKodu = "G";
                if (RBtn_GidenIslemTuru.Checked) bankahareketler.GCKodu = "C";
                bankahareketler.Aciklama = Txt_Aciklama.Text;
                bankahareketler.Tarih = DateTime.Parse(Txt_Tarih.Text);
                bankahareketler.Tutar = decimal.Parse(Txt_Tutar.Text);
                bankahareketler.EditDate = DateTime.Now;
                bankahareketler.EditUser = AnaForm.UserID;
                Db.SubmitChanges();

                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == Txt_TransferTürü.SelectedItem.ToString() && s.EvrakID == IslemID);
                cariHareketleri.Aciklama = Txt_Aciklama.Text;
                if (RBtn_GelenIslemTuru.Checked)
                {
                    cariHareketleri.Alacak = decimal.Parse(Txt_Tutar.Text);
                }
                if (RBtn_GidenIslemTuru.Checked)
                {
                    cariHareketleri.Borc = decimal.Parse(Txt_Tutar.Text);
                }
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = BankaID;
                cariHareketleri.EvrakTuru = Txt_TransferTürü.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(Txt_Tarih.Text);
                if (Txt_TransferTürü.SelectedIndex == 0)
                {
                    cariHareketleri.Tipi = "Banka Havale";
                }
                if (Txt_TransferTürü.SelectedIndex == 1)
                {
                    cariHareketleri.Tipi = "Banka EFT";
                }
                cariHareketleri.EditDate = DateTime.Now;
                cariHareketleri.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sil()    //Ders 6 1:30:15
        {
            try
            {
                /* İlişkili tablolar kullandığımızda ana tablomuz BankaHareketleri olduğu için bu tablodaki işlemi silmeden önce Carihareketleri tablosundaki işlemi silmemiz gerekiyor. Ama bu ikisini aynı anda submit ettiğimiz zaman bize bir probkem çıkarmaması için bu şekilde sıralama yapıyoruz. Problem olaması durumunda araya bir SubmitChanges ekleyebiliriz. */
                Db.Tbl_CariHareketleris.DeleteOnSubmit(Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == Txt_TransferTürü.SelectedItem.ToString() && s.EvrakID == IslemID));
                //Db.SubmitChanges();
                Db.Tbl_BankaHareketleris.DeleteOnSubmit(Db.Tbl_BankaHareketleris.First(s => s.Id == IslemID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void Txt_HesapTürü_Adi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = frm.BankaListesi(true);
            if (ID > 0) BankaAc(ID);
            AnaForm.Aktarma = -1;
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = frm.CariListesi(true);
            if (ID > 0) CariAc(ID);
            AnaForm.Aktarma = -1;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
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
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && mesajlar.Sil() == DialogResult.Yes)
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