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

namespace StokTakipOtomasyon.Modül_Kasa
{
    public partial class Frm_KasaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public Frm_KasaListesi()
        {
            InitializeComponent();
        }

        private void Frm_KasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from x in Db.VW_KasaListesis
                      where x.KasaKodu.Contains(Txt_KasaKodu.Text) && x.KasaAdi.Contains(Txt_KasaAdı.Text)
                      select x;
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
                throw;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > -1)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}