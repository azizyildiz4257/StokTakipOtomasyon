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

namespace StokTakipOtomasyon.Modul_Banka
{
    public partial class Frm_BankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int SecimID = -1;

        public Frm_BankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void Frm_BankaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            Txt_BankaAdi.Text = "";
            Txt_HesapTürü_Adi.Text = "";
            Txt_HesapNo.Text = "";
            Txt_IBAN.Text = "";
            Txt_BankaSubesi.Text = "";
            Txt_SubeTelefon.Text = "";
            Txt_Adres.Text = "";
            Txt_Yetkili_Temsilci.Text = "";
            Txt_YTEmail.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }
        void Listele() //Ders 6 12:55
        {
            var lst = from s in Db.Tbl_Bankalars
                      select s;
            Grd_Liste.DataSource = lst;
        }
        void YeniKaydet()   //Ders 6 16:15
        {
            try
            {
                Fonksiyonlar.Tbl_Bankalar bankalar = new Fonksiyonlar.Tbl_Bankalar();
                bankalar.BankaAdi = Txt_BankaAdi.Text;
                bankalar.HesapAdi = Txt_HesapTürü_Adi.Text;
                bankalar.HesapNo = Txt_HesapNo.Text;
                bankalar.IBAN = Txt_IBAN.Text;
                bankalar.Sube = Txt_BankaSubesi.Text;
                bankalar.Tel = Txt_SubeTelefon.Text;
                bankalar.Adres = Txt_Adres.Text;
                bankalar.Temsilci = Txt_Yetkili_Temsilci.Text;
                bankalar.TemsilciEmail = Txt_YTEmail.Text;

                bankalar.SaveDate = DateTime.Now;
                bankalar.SaveUser = AnaForm.UserID;
                Db.Tbl_Bankalars.InsertOnSubmit(bankalar);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Yeni Banka kaydı açılmıştır.");
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
                Fonksiyonlar.Tbl_Bankalar bankalar = Db.Tbl_Bankalars.First(s => s.Id == SecimID);
                bankalar.BankaAdi = Txt_BankaAdi.Text;
                bankalar.HesapAdi = Txt_HesapTürü_Adi.Text;
                bankalar.HesapNo = Txt_HesapNo.Text;
                bankalar.IBAN = Txt_IBAN.Text;
                bankalar.Sube = Txt_BankaSubesi.Text;
                bankalar.Tel = Txt_SubeTelefon.Text;
                bankalar.Adres = Txt_Adres.Text;
                bankalar.Temsilci = Txt_Yetkili_Temsilci.Text;
                bankalar.TemsilciEmail = Txt_YTEmail.Text;

                bankalar.EditDate = DateTime.Now;
                bankalar.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sil()  //Ders 6 18:18
        {
            try
            {
                Db.Tbl_Bankalars.DeleteOnSubmit(Db.Tbl_Bankalars.First(s => s.Id == SecimID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                if (SecimID > 0)
                {
                    Ac();
                }
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Ac()   //Ders 6 21:00
        {
            try
            {
                Fonksiyonlar.Tbl_Bankalar bankalar = Db.Tbl_Bankalars.First(s => s.Id == SecimID);
                Txt_BankaAdi.Text = bankalar.BankaAdi;
                Txt_HesapTürü_Adi.Text = bankalar.HesapAdi;
                Txt_HesapNo.Text = bankalar.HesapNo;
                Txt_IBAN.Text = bankalar.IBAN;
                Txt_BankaSubesi.Text = bankalar.Sube;
                Txt_SubeTelefon.Text = bankalar.Tel;
                Txt_Adres.Text = bankalar.Adres;
                Txt_Yetkili_Temsilci.Text = bankalar.Temsilci;
                Txt_YTEmail.Text = bankalar.TemsilciEmail;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)   //Ders 6 23:40
        {
            if (Edit && SecimID > 0 && mesajlar.Guncelle() == DialogResult.Yes)
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
            if (Edit && SecimID > 0 && mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}