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

namespace StokTakipOtomasyon.Modül_Cari
{
    public partial class Frm_CariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public Frm_CariListesi()
        {
            InitializeComponent();
        }

        private void Frm_CariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_Carilers where s.CariAdi.Contains(Txt_CariAdı.Text)&&s.CariKodu.Contains(Txt_CariKodu.Text) select s;
            Grd_Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception /*e*/)     //Ders 4 1.10
            {
                SecimID = -1;
            }
        }

        private void Grd_Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim&&SecimID>0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}