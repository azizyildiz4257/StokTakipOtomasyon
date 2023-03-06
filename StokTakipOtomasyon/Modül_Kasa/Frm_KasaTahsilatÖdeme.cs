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
    public partial class Frm_KasaTahsilatÖdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int CariHareketID = -1;
        int KasaID = -1;
        int CariID = -1;
        //string IslemTuru = "Kasa Tahsilat";

        public Frm_KasaTahsilatÖdeme()
        {
            InitializeComponent();
        }

        private void Frm_KasaTahsilatÖdeme_Load(object sender, EventArgs e)
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
        }

        private void Txt_IslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IslemTuru = Txt_IslemTuru.SelectedIndex.ToString();
        }

        void Temizle()
        {
            Txt_BelgeNo.Text = "";
            Txt_KasaKodu.Text = "";
            Txt_KasaAdı.Text = "";
            Txt_CariKodu.Text = "";
            Txt_CariAdi.Text = "";
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_Tutar.Text = "0";
            Txt_IslemTuru.SelectedIndex = 0;
            Txt_Aciklama.Text = "";
            Edit = false;
            IslemID = -1;
            CariID = -1;
            KasaID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }
        public void Ac(int HareketID)   //Ders 4 1:50:00
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID);
                CariHareketID = Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == kasaHareketleri.EvrakTuru && s.EvrakID == IslemID).Id;
                MessageBox.Show("Cari Hareket ID : " + CariHareketID.ToString());
                Txt_Aciklama.Text = kasaHareketleri.Aciklama;
                Txt_BelgeNo.Text = kasaHareketleri.BelgeNo;
                if (kasaHareketleri.EvrakTuru == "Kasa Tahsilat") /*ise*/ Txt_IslemTuru.SelectedIndex = 0;
                if (kasaHareketleri.EvrakTuru == "Kasa Ödeme") /*ise*/ Txt_IslemTuru.SelectedIndex = 1;
                Txt_Tarih.Text = kasaHareketleri.Tairh.Value.ToShortDateString();
                Txt_Tutar.Text = kasaHareketleri.Tutar.Value.ToString();
                KasaAc(kasaHareketleri.KasaID.Value);
                CariAc(kasaHareketleri.KasaID.Value);
            }
            catch (Exception e)
            {
                Temizle();
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
                KasaID = -1;
            }
        }
        void CariAc(int ID) //Ders 4 - 01:22:10
        {
            try
            {
                CariID = ID;
                Txt_CariKodu.Text = Db.Tbl_Carilers.First(s => s.Id == /*KasaID*/CariID).CariKodu;
                Txt_CariAdi.Text = Db.Tbl_Carilers.First(s => s.Id == /*KasaID*/CariID).CariAdi;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = new Fonksiyonlar.Tbl_KasaHareketleri();
                kasaHareketleri.Aciklama = Txt_Aciklama.Text;
                kasaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                kasaHareketleri.CarID = CariID;
                kasaHareketleri.EvrakTuru = Txt_IslemTuru.SelectedItem.ToString();
                if (Txt_IslemTuru.SelectedIndex == 0) kasaHareketleri.GCKodu = "G";
                if (Txt_IslemTuru.SelectedIndex == 1) kasaHareketleri.GCKodu = "C";
                kasaHareketleri.KasaID = KasaID;
                kasaHareketleri.SaveDate = DateTime.Now;
                kasaHareketleri.SaveUser = AnaForm.UserID;
                kasaHareketleri.Tairh = DateTime.Parse(Txt_Tarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(Txt_Tutar.Text);
                Db.Tbl_KasaHareketleris.InsertOnSubmit(kasaHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_IslemTuru.SelectedItem.ToString() + "Yeni kasa hareketi olarak işlenmiştir.");

                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = new Fonksiyonlar.Tbl_CariHareketleri();
                cariHareketleri.Aciklama = Txt_BelgeNo.Text + "belge numaralı" + Txt_IslemTuru.SelectedItem.ToString() + "işlemi";
                if (Txt_IslemTuru.SelectedIndex == 0) cariHareketleri.Alacak = decimal.Parse(Txt_Tutar.Text);
                if (Txt_IslemTuru.SelectedIndex == 1) cariHareketleri.Borc = decimal.Parse(Txt_Tutar.Text);
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = kasaHareketleri.Id;
                cariHareketleri.EvrakTuru = Txt_IslemTuru.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(Txt_Tarih.Text);
                if (Txt_IslemTuru.SelectedIndex == 0) cariHareketleri.Tipi = "KT";  // Kasa Tahsilat
                if (Txt_IslemTuru.SelectedIndex == 1) cariHareketleri.Tipi = "KÖ";  // Kasa Ödeme
                cariHareketleri.SaveDate = DateTime.Now;
                cariHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_CariHareketleris.InsertOnSubmit(cariHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit(Txt_IslemTuru.SelectedItem.ToString() + "Yeni cari hareketi olarak işlenmiştir.");
                Temizle();

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Guncelle() //Ders 4 - 01:38:00
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID);
                // Daha önce burda olduğu için sorun yaşadık o yüzden yukarı aldık --- Ders 4 01:42:12
                kasaHareketleri.Aciklama = Txt_Aciklama.Text;
                kasaHareketleri.BelgeNo = Txt_BelgeNo.Text;
                kasaHareketleri.CarID = CariID;
                kasaHareketleri.EvrakTuru = Txt_IslemTuru.SelectedItem.ToString();
                if (Txt_IslemTuru.SelectedIndex == 0) kasaHareketleri.GCKodu = "G";
                if (Txt_IslemTuru.SelectedIndex == 1) kasaHareketleri.GCKodu = "C";
                kasaHareketleri.KasaID = KasaID;
                kasaHareketleri.EditDate = DateTime.Now;
                kasaHareketleri.EditUser = AnaForm.UserID;
                kasaHareketleri.Tairh = DateTime.Parse(Txt_Tarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(Txt_Tutar.Text);
                Db.SubmitChanges();
                mesajlar.Guncelle(true);

                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = Db.Tbl_CariHareketleris.First(s => s.Id == CariHareketID);   //Yukardaydı buraya aldık --- Ders 4 01:55:50
                /*********** Burda ************/
                cariHareketleri.Aciklama = Txt_BelgeNo.Text + "belge numaralı" + Txt_IslemTuru.SelectedItem.ToString() + "işlemi";
                if (Txt_IslemTuru.SelectedIndex == 0) cariHareketleri.Alacak = decimal.Parse(Txt_Tutar.Text);
                if (Txt_IslemTuru.SelectedIndex == 1) cariHareketleri.Borc = decimal.Parse(Txt_Tutar.Text);
                cariHareketleri.CariID = CariID;
                cariHareketleri.EvrakID = kasaHareketleri.Id;
                cariHareketleri.EvrakTuru = Txt_IslemTuru.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(Txt_Tarih.Text);
                if (Txt_IslemTuru.SelectedIndex == 0) cariHareketleri.Tipi = "KT";  // Kasa Tahsilat
                if (Txt_IslemTuru.SelectedIndex == 1) cariHareketleri.Tipi = "KÖ";  // Kasa Ödeme
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
        void Sil()
        {
            try
            {
                Db.Tbl_KasaHareketleris.DeleteOnSubmit(Db.Tbl_KasaHareketleris.First(s => s.Id == IslemID));
                Db.Tbl_CariHareketleris.DeleteOnSubmit(Db.Tbl_CariHareketleris.First(s => s.Id == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }

        }

        private void Txt_KasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = formlar.KasaListesi(true);
            if (id > 0)
            {
                KasaAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)  // Ders 4 01:59:40
        {
            int id = formlar.CariListesi(true);
            if (id > 0)
            {
                CariAc(id);
                AnaForm.Aktarma = -1;
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)   // Ders 4 01:57:40
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)  // Ders 4 1:53:40
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && mesajlar.Sil() == DialogResult.Yes)
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