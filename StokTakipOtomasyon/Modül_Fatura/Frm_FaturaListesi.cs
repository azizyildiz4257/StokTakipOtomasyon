using DevExpress.Utils.Filtering;
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

namespace StokTakipOtomasyon.Modül_Fatura
{
    public partial class Frm_FaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();

        bool secim = false;
        public Frm_FaturaListesi(bool Secim)    // Ders 16 36:10
        {
            InitializeComponent();
            secim = Secim;
        }
        void Listele()      //Ders 16 40:23
        {
            var lst = from s in Db.Tbl_Faturalars
                      where s.FaturaTuru.Contains(Txt_FaturaTürü.Text) && s.FaturaNo.Contains(Txt_FaturaNo.Text)
                      select s;
            Grd_Liste.DataSource = lst;
        }

        private void Txt_FaturaTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Frm_FaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)      //Ders 16 45:30
        {
            //Satış fatutrsınsa yönendirme yapıyoruz
            int id = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            if (id > 0)
            {
                frm.Fatura(true, id, false);
            }
        }

        private void SagTikYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}