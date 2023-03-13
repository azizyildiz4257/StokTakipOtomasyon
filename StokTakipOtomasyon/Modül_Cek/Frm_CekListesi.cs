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
    public partial class Frm_CekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();

        int SecilenID = -1;
        public bool Secim = false;

        public Frm_CekListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_Ceklers
                      where s.Tipi.Contains(Txt_CekTuru.Text) && s.Banka.Contains(Txt_Bankası.Text) && s.CekNo.Contains(Txt_CekNumarası.Text)
                      select s;
            Grd_Liste.DataSource = lst;
        }

        private void Frm_CekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Sec()
        {
            try
            {
                SecilenID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)  //Ders 11 56:30
        {
            Sec();
            if (Secim&&SecilenID>0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}