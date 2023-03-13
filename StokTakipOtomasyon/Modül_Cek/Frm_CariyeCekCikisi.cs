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
    public partial class Frm_CariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public Frm_CariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void Frm_CariyeCekCikisi_Load(object sender, EventArgs e)
        {
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            Txt_Banka.Text = "";
            Txt_BelgeNo.Text = "";
            Txt_CariAdi.Text = "";
            Txt_CariKodu.Text = "";
            Txt_CekNo.Text = "";
            Txt_Sube.Text = "";
            Txt_Tarih.Text = DateTime.Now.ToShortDateString();
            Txt_Tutar.Text = "";
            Txt_VadeTarihi.Text = "";
            Txt_VadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void CariAc(int id)    //Ders 11 8:40
        {
            try
            {
                CariID = id;
                Fonksiyonlar.Tbl_Cariler cari = Db.Tbl_Carilers.First(s => s.Id == CariID);
                Txt_CariAdi.Text = cari.CariAdi;
                Txt_CariKodu.Text = cari.CariKodu;
                //Açıklama koyup koymamakta tereddüt etti Ders 11 8:10
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void CekGetir(int id)     //Ders 11 10:50
        {
            try
            {
                CekID = id;
                Fonksiyonlar.Tbl_Cekler cekler = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                Txt_Banka.Text = cekler.Banka;
                Txt_CekNo.Text = cekler.CekNo;
                Txt_Sube.Text = cekler.Sube;
                Txt_VadeTarihi.Text = cekler.VadeTarihi.Value.ToShortDateString();
                Txt_Tutar.Text = cekler.Tutar.Value.ToString();

                if (cekler.VerilenCairID != null)
                {
                    /*Cariyi alıyoruz*/
                    if (cekler.VerilenCairID.Value > 0)
                    {
                        CariAc(cekler.VerilenCairID.Value);
                        Txt_BelgeNo.Text = cekler.VerilenCari_BelgeNo;
                        Txt_Tarih.Text = cekler.VerilenCari_Tarihi.Value.ToShortDateString();
                    }
                }
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void YeniKaydet()   //Ders 11 24:40
        {
            try
            {
                Fonksiyonlar.Tbl_Cekler cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                cek.VerilenCairID = CariID;
                cek.VerilenCari_Tarihi = DateTime.Parse(Txt_Tarih.Text);
                cek.VerilenCari_BelgeNo = Txt_BelgeNo.Text;
                cek.Durumu = "Caride";
                cek.EditDate = DateTime.Now;
                cek.EditUser = AnaForm.UserID;
                Db.SubmitChanges();

                Fonksiyonlar.Tbl_CariHareketleri carihareket = new Fonksiyonlar.Tbl_CariHareketleri();
                carihareket.Aciklama = Txt_CekNo.Text + " cek numaralı ve " + Txt_BelgeNo.Text + " belge numaralı cek";
                carihareket.Borc = decimal.Parse(Txt_Tutar.Text);
                carihareket.CariID = CariID;
                carihareket.EvrakID = CekID;
                carihareket.EvrakTuru = "Cariye Çek";
                carihareket.Tarih = DateTime.Now;
                carihareket.Tipi = "Çek İşlemi";
                carihareket.SaveDate = DateTime.Now;
                carihareket.SaveUser = AnaForm.UserID;
                Db.Tbl_CariHareketleris.InsertOnSubmit(carihareket);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Cariye Çek Çıkışı işleminin hareket ve çek kaydı güncellemesi yapılmıştır.");
                Temizle();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.Tbl_Cekler cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                cek.VerilenCairID = CariID;
                cek.VerilenCari_Tarihi = DateTime.Parse(Txt_Tarih.Text);
                cek.VerilenCari_BelgeNo = Txt_BelgeNo.Text;
                cek.Durumu = "Caride";
                cek.EditDate = DateTime.Now;
                cek.EditUser = AnaForm.UserID;
                Db.SubmitChanges();

                Fonksiyonlar.Tbl_CariHareketleri carihareket = Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == "Cariye Çek" && s.EvrakID == CekID);
                carihareket.Aciklama = Txt_CekNo.Text + " cek numaralı ve " + Txt_BelgeNo.Text + " belge numaralı cek";
                carihareket.Borc = decimal.Parse(Txt_Tutar.Text);
                carihareket.CariID = CariID;
                carihareket.EvrakID = CekID;
                carihareket.EvrakTuru = "Cariye Çek";
                carihareket.Tarih = DateTime.Now;
                carihareket.Tipi = "Çek İşlemi";
                carihareket.EditDate = DateTime.Now;
                carihareket.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        public void Ac(int CekID_si)    //Ders 11 33:15
        {
            try
            {
                CekID = CekID_si;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
                Temizle();
            }
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = frm.CariListesi(true);
            if (id > 0)
            {
                CariAc(id);
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
            if (Edit && mesajlar.Guncelle() == DialogResult.Yes && CariID > 0 && CekID > 0)
            {
                Guncelle();
            }
            else if (CariID > 0 && CekID > 0)
            {
                YeniKaydet();
            }
            else
            {
                MessageBox.Show("Çek veya Cari seçimi yapılmadı");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit && mesajlar.Sil() == DialogResult.Yes && CariID > 0 && CekID > 0)
                {
                    Db.Tbl_CariHareketleris.DeleteOnSubmit(Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == "Cariye Çek" && s.EvrakID == CekID));
                    Fonksiyonlar.Tbl_Cekler cek = Db.Tbl_Ceklers.First(s => s.Id == CekID);
                    cek.VerilenCairID = -1; ;
                    cek.VerilenCari_BelgeNo = "";
                    //cek.VerilenCari_Tarihi = null;    Ders 11 1:04:50
                    Db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}