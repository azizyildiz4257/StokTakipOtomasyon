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

namespace StokTakipOtomasyon.Modül_Cari
{
    public partial class Frm_CariGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public Frm_CariGruplari()
        {
            InitializeComponent();
        }

        private void Frm_CariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            Txt_GrupAdı.Text = "";
            Txt_GrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_CariGruplarıs
                      select s;
            Grd_Liste.DataSource = lst;
        }
        void Sil()
        {
            try
            {
                Db.Tbl_CariGruplarıs.DeleteOnSubmit(Db.Tbl_CariGruplarıs.First(s => s.Id == SecimID));
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
                Txt_GrupAdı.Text = gridView1.GetFocusedRowCellValue("GrupAdı").ToString();
                Txt_GrupKodu.Text = gridView1.GetFocusedRowCellValue("GrupKodu").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_CariGrupları tbl_CariGrupları = new Fonksiyonlar.Tbl_CariGrupları();
                tbl_CariGrupları.GrupKodu = Txt_GrupKodu.Text;
                tbl_CariGrupları.GrupAdı = Txt_GrupAdı.Text;
                tbl_CariGrupları.SaveDate = DateTime.Now;
                tbl_CariGrupları.SaveUser = AnaForm.UserID;
                Db.Tbl_CariGruplarıs.InsertOnSubmit(tbl_CariGrupları);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Yeni Cari Grup Kaydı Oluşturuldu.");
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
                Fonksiyonlar.Tbl_CariGrupları tbl_CariGrupları = Db.Tbl_CariGruplarıs.First(x => x.Id == SecimID);
                tbl_CariGrupları.GrupKodu = Txt_GrupKodu.Text;
                tbl_CariGrupları.GrupAdı = Txt_GrupAdı.Text;
                tbl_CariGrupları.EditDate = DateTime.Now;
                tbl_CariGrupları.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
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
    }
}