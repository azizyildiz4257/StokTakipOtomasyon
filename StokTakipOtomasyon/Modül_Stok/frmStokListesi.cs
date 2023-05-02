using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon.Modül_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();

        public bool secim = false;
        int SecimID = -1;

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = (from s in Db.Tbl_Stoklars
                       where s.StokAdı.Contains(Txt_StokAdı.Text) && s.StokBarkod.Contains(Txt_Barkod.Text) && s.StokKodu.Contains(Txt_StokKodu.Text)
                       select s);
            Grd_Liste.DataSource = lst;
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            Txt_StokKodu.Text = "";
            Txt_StokAdı.Text = "";
            Txt_Barkod.Text = "";
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Btn_PDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Acrobat Reader|*.pdf";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Grd_Liste.ExportToPdf(sf.FileName);
                }
            }
        }

        private void Btn_XLS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Excel|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    Grd_Liste.ExportToXls(sf.FileName);
                }
            }
        }
    }
}