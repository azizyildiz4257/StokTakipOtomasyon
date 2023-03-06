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
    public partial class Frm_BankaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;
        public Frm_BankaListesi()
        {
            InitializeComponent();
        }

        private void Frm_BankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in Db.VW_BankaListesis
                      where s.HesapAdi.Contains(Txt_HesapAdıTürü.Text) && s.HesapNo.Contains(Txt_HesapNumarası.Text) && s.IBAN.Contains(Txt_IBAN.Text)
                      select s;
            Grd_Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)  // Ders 6 1:00:01
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