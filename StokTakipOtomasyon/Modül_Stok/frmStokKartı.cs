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
using System.IO;
using StokTakipOtomasyon.Fonksiyonlar;

namespace StokTakipOtomasyon.Modül_Stok
{
    public partial class frmStokKartı : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numara = new Fonksiyonlar.Numara();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();

        bool Edit = false;
        bool Resimsecim = false;
        int GrupID = -1;
        int StokID = -1;

        public frmStokKartı()
        {
            InitializeComponent();
        }

        private void frmStokKartı_Load(object sender, EventArgs e)
        {
            Txt_StokKodu.Text = Numara.StokKodNumarasi();
        }

        void Temizle()
        {
            Txt_AlısFiyatı.Text = "0";
            Txt_AlısKDV.Text = "0";
            Cmb_Birim.SelectedIndex = 0;
            Txt_Barkod.Text = "";
            Txt_SatısFiyatı.Text = "0";
            Txt_SatısKDV.Text = "0";
            Txt_StokAdi.Text = "";
            Txt_StokGrupAdi.Text = "";
            Txt_StokGrupKodu.Text = "";
            Txt_StokKodu.Text = Numara.StokKodNumarasi();
            pictureBox1.Image = null;

            Edit = false;
            Resimsecim = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }

        OpenFileDialog Dosya = new OpenFileDialog();
        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resimsecim = true;
            }
        }

        private void Btn_StokResmiSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Stoklar Stok = new Fonksiyonlar.Tbl_Stoklar();
                Stok.StokAdı = Txt_StokAdi.Text;
                Stok.StokAlisFiyat = decimal.Parse(Txt_AlısFiyatı.Text);
                Stok.StokAlisKDV = decimal.Parse(Txt_AlısKDV.Text);
                Stok.StokBarkod = Txt_Barkod.Text;
                Stok.StokBirim = Cmb_Birim.Text;
                Stok.StokGrupID = GrupID;
                Stok.StokKodu = Txt_StokKodu.Text;
                Stok.StokResim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image)); // Resmi bu şekilde aldığımız zaman binary halinde veritabanına yüklemiş olacağız. Ders 1 2:06
                Stok.StokSatisFiyat = decimal.Parse(Txt_SatısFiyatı.Text);
                Stok.StokSatisKDV = decimal.Parse(Txt_SatısKDV.Text);
                Stok.StokSaveDate = DateTime.Now;
                Stok.StokSaveUser = AnaForm.UserID;
                Db.Tbl_Stoklars.InsertOnSubmit(Stok);
                Db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Stok kaydı oluşturuldu.");
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
                Fonksiyonlar.Tbl_Stoklar Stok = Db.Tbl_Stoklars.First(s => s.Id == StokID);
                Stok.StokAdı = Txt_StokAdi.Text;
                Stok.StokAlisFiyat = decimal.Parse(Txt_AlısFiyatı.Text);
                Stok.StokAlisKDV = decimal.Parse(Txt_AlısKDV.Text);
                Stok.StokBarkod = Txt_Barkod.Text;
                Stok.StokBirim = Cmb_Birim.Text;
                Stok.StokGrupID = GrupID;
                Stok.StokKodu = Txt_StokKodu.Text;
                if (Resimsecim) // Eger Resim seçildiyse güncelle
                {
                    Stok.StokResim = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image)); // Resmi bu şekilde aldığımız zaman binary halinde veritabanına yüklemiş olacağız. Ders 1 2:06
                }
                Stok.StokSatisFiyat = decimal.Parse(Txt_SatısFiyatı.Text);
                Stok.StokSatisKDV = decimal.Parse(Txt_SatısKDV.Text);
                Stok.StokEditDate = DateTime.Now;
                Stok.StokEditUser = AnaForm.UserID;
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
                Db.Tbl_Stoklars.DeleteOnSubmit(Db.Tbl_Stoklars.First(s => s.Id == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void GrupAc(int ID)
        {
            GrupID = ID;
            Txt_StokGrupAdi.Text = Db.Tbl_StokGruplarıs.First(s => s.Id == GrupID).GrupAdı;
            Txt_StokGrupKodu.Text = Db.Tbl_StokGruplarıs.First(s => s.Id == GrupID).GrupKodu;
        }
        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.Tbl_Stoklar Stok = Db.Tbl_Stoklars.First(s => s.Id == StokID);
            GrupAc(Stok.StokGrupID.Value);
            pictureBox1.Image = Resimleme.ResimGetirme(Stok.StokResim.ToArray());
            Txt_AlısFiyatı.Text = Stok.StokAlisFiyat.ToString();
            Txt_AlısKDV.Text = Stok.StokAlisKDV.ToString();
            Txt_Barkod.Text = Stok.StokBarkod;
            Cmb_Birim.Text = Stok.StokBirim;
            Txt_SatısFiyatı.Text = Stok.StokSatisFiyat.ToString();
            Txt_SatısKDV.Text = Stok.StokSatisKDV.ToString();
            Txt_StokAdi.Text = Stok.StokAdı;
            Txt_StokKodu.Text = Stok.StokKodu;
        }

        private void Txt_StokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void Txt_StokGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokGrupları(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
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
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes)
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