using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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

namespace StokTakipOtomasyon.Modül_Cari
{
    public partial class Frm_CariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext Db = new DatabaseDataContext();
        Mesajlar mesajlar = new Mesajlar();
        Formlar formlar = new Formlar();
        Numara numara = new Numara();

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public Frm_CariAcilisKarti()
        {
            InitializeComponent();
        }

        private void Frm_CariAcilisKarti_Load(object sender, EventArgs e)
        {
            Txt_CariKodu.Text = numara.CariKodNumarasi();
        }
        void Temizle()
        {
            //foreach (Control CT in this.Controls)
            //{
            //    CT
            //}

            foreach (Control CT in groupControl1.Controls)
            {
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit)
                {
                    CT.Text = "";
                }
            }
            foreach (Control CT2 in groupControl2.Controls)
            {
                if (CT2 is DevExpress.XtraEditors.TextEdit || CT2 is DevExpress.XtraEditors.ButtonEdit || CT2 is DevExpress.XtraEditors.MemoEdit)
                {
                    CT2.Text = "";
                }
            }

            Txt_CariKodu.Text=numara.CariKodNumarasi();
            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Cariler cari = new Fonksiyonlar.Tbl_Cariler();
                cari.CariKodu = Txt_CariKodu.Text;
                cari.CariAdi = Txt_CariAdi.Text;
                cari.VergiDairesi = Txt_VergiDairesi.Text;
                cari.VergiNo = Txt_VergiNumarası.Text;
                cari.Ulke = Txt_Ulke.Text;
                cari.Sehir = Txt_İl.Text;
                cari.Ilce = Txt_İlce.Text;
                cari.Adres = Txt_Adres.Text;
                cari.Yetkili = Txt_Adres.Text;
                cari.Mail = Txt_Mail.Text;
                cari.Telefon1 = Txt_Telefon1.Text;
                cari.Telefon2 = Txt_Telefon2.Text;
                cari.Fax1 = Txt_Fax1.Text;
                cari.Fax2 = Txt_Fax2.Text;
                cari.WebAdresi = Txt_WebSitesi.Text;

                cari.SaveDate = DateTime.Now;
                cari.SaveUser = AnaForm.UserID;
                Db.Tbl_Carilers.InsertOnSubmit(cari);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Yeni Cari Kaydı Oluşturulmustur.");
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
                Fonksiyonlar.Tbl_Cariler cari = Db.Tbl_Carilers.First(s => s.Id == CariID);
                cari.CariKodu = Txt_CariKodu.Text;
                cari.CariAdi = Txt_CariAdi.Text;
                cari.VergiDairesi = Txt_VergiDairesi.Text;
                cari.VergiNo = Txt_VergiNumarası.Text;
                cari.Ulke = Txt_Ulke.Text;
                cari.Sehir = Txt_İl.Text;
                cari.Ilce = Txt_İlce.Text;
                cari.Adres = Txt_Adres.Text;
                cari.Yetkili = Txt_Adres.Text;
                cari.Mail = Txt_Mail.Text;
                cari.Telefon1 = Txt_Telefon1.Text;
                cari.Telefon2 = Txt_Telefon2.Text;
                cari.Fax1 = Txt_Fax1.Text;
                cari.Fax2 = Txt_Fax2.Text;
                cari.WebAdresi = Txt_WebSitesi.Text;

                cari.EditDate = DateTime.Now;
                cari.EditUser = AnaForm.UserID;
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
                Db.Tbl_Carilers.DeleteOnSubmit(Db.Tbl_Carilers.First(s => s.Id == CariID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.Tbl_CariGrupları Grup = Db.Tbl_CariGruplarıs.First(s => s.Id == GrupID);
                Txt_CariGrupAdi.Text = Grup.GrupAdı;
                Txt_CariGrupKodu.Text = Grup.GrupKodu;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        public void Ac(int ID)
        {
            try
            {
                Edit = true; // Yani gelen ıd 0 dan büyükse
                CariID = ID;
                Fonksiyonlar.Tbl_Cariler Cari = Db.Tbl_Carilers.First(s => s.Id == CariID);
                Txt_CariAdi.Text = Cari.CariAdi;
                Txt_CariKodu.Text = Cari.CariKodu;
                Txt_VergiDairesi.Text = Cari.VergiDairesi;
                Txt_VergiNumarası.Text = Cari.VergiNo;
                Txt_Ulke.Text = Cari.Ulke;
                Txt_İl.Text = Cari.Sehir;
                Txt_İlce.Text = Cari.Ilce;
                Txt_Adres.Text = Cari.Adres;
                Txt_Yetkili.Text = Cari.Yetkili;
                Txt_Mail.Text = Cari.Mail;
                Txt_Telefon1.Text = Cari.Telefon1;
                Txt_Telefon2.Text = Cari.Telefon2;
                Txt_Fax1.Text = Cari.Fax1;
                Txt_Fax2.Text = Cari.Fax2;
                Txt_WebSitesi.Text = Cari.WebAdresi;
                GrupAc(Cari.GrupID.Value);
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
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
            if (Edit && CariID > 0 && mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Button Editlerin eventları Ders 2 1:20
        private void Txt_CariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.CariGruplari(true);
            if (ID>0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.CariListesi(true);
            if (ID>0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }
    }
}