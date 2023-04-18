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

namespace StokTakipOtomasyon.Modül_Kullanici
{
    public partial class Frm_KullaniciYönetimi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int secim = -1;

        public Frm_KullaniciYönetimi()
        {
            InitializeComponent();
            this.Shown += Frm_KullaniciYönetimi_Shown;
        }

        public void Listele()
        {
            var lst = from s in Db.Tbl_Kullanicilars
                      select s;
            gridControl1.DataSource = lst;
        }
        private void Frm_KullaniciYönetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_YeniKullanici_Click(object sender, EventArgs e)
        {
            frm.KullaniciPanel();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            frm.KullaniciPanel(secim, true);
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if (mesajlar.Sil() == DialogResult.Yes)
            {
                Db.Tbl_Kullanicilars.DeleteOnSubmit(Db.Tbl_Kullanicilars.First(s => s.Id == secim));
                Db.SubmitChanges();
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            secim = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
        }
    }
}