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
using System.Data.Linq;

namespace StokTakipOtomasyon.Modül_Stok
{
    public partial class frmStokGrupları : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;

        public frmStokGrupları()
        {
            InitializeComponent();
        }

        private void frmStokGrupları_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_StokGruplarıs
                      select s;
            Grd_Liste.DataSource = lst;
        }
        void Temizle()
        {
            Txt_GrupAdı.Text = "";
            Txt_GrupKodu.Text = "";
            Edit = false;
            Listele();
        }
        void Kaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_StokGrupları Grup = new Fonksiyonlar.Tbl_StokGrupları();
                Grup.GrupAdı = Txt_GrupAdı.Text;
                Grup.GrupKodu = Txt_GrupKodu.Text;
                Grup.GrupSaveDate = DateTime.Now;
                Grup.GrupSaveUser = AnaForm.UserID;
                Db.Tbl_StokGruplarıs.InsertOnSubmit(Grup);
                Db.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Grup Kaydı Oluşturuldu.");
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
                Fonksiyonlar.Tbl_StokGrupları Grup = Db.Tbl_StokGruplarıs.First(x => x.Id == SecimID);
                Grup.GrupAdı = Txt_GrupAdı.Text;
                Grup.GrupKodu = Txt_GrupKodu.Text;
                Grup.GrupEditUser = AnaForm.UserID;
                Grup.GrupEditDate = DateTime.Now;
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
                Db.Tbl_StokGruplarıs.DeleteOnSubmit(Db.Tbl_StokGruplarıs.First(s => s.Id == SecimID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if(Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();     // Ders 1 1:28
            }
            else
            {
                Kaydet();
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}