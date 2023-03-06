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
    public partial class Frm_KasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();

        int HareketID = -1;
        //int Evrak_ID = -1;
        int KasaID = -1;
        string EvrakTURU;

        public Frm_KasaHareketleri()
        {
            InitializeComponent();
        }

        private void Frm_KasaHareketleri_Load(object sender, EventArgs e)
        {

        }
        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                Txt_KasaKodu.Text = Db.Tbl_Kasalars.First(s => s.Id == KasaID).KasaKodu;
                Txt_KasaAdı.Text = Db.Tbl_Kasalars.First(s => s.Id == KasaID).KasaAdi;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Listele()
        {
            var lst = from s in Db.VW_KasaHareketleri_Ders5_DK5s
                      where s.KasaID == KasaID
                      select s;
            Grd_Liste.DataSource = lst;
        }
        void DurumGetir()
        {
            Fonksiyonlar.VW_KasaDurum Kasa = Db.VW_KasaDurums.First(s => s.KasaID == KasaID);
            Txt_Giris.Text = Kasa.Gırıs.Value.ToString();
            Txt_Cikis.Text = Kasa.Cikis.Value.ToString();
            Txt_Bakiye.Text = Kasa.Bakiye.Value.ToString();
        }

        private void Txt_KasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }
        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                //try
                //{
                //    Evrak_ID = int.Parse(gridView1.GetFocusedRowCellValue("EvrakID").ToString());    //Ders 5 46:00
                //}
                //catch (Exception)   
                //{                                       /*EvrakID null deger olduğu için hata veriyor.*/
                //    Evrak_ID = -1;                      /*Değerini atayacak herhangi bir işlem yok*/
                //}
                EvrakTURU = gridView1.GetFocusedRowCellValue("EvrakTuru").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                //Evrak_ID = -1;
                EvrakTURU = "";
            }
        }

        private void CMS_SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();

            if (EvrakTURU == "Kasa Devir Kartı")
            {
                CmsItem_DevirKartiDüzenle.Enabled = true;
                CmsItem_TahsilatÖdemeDüzenle.Enabled = false;
            }
            else if (EvrakTURU == "Kasa Tahsilat" || EvrakTURU == "Kasa Ödeme")
            {
                CmsItem_DevirKartiDüzenle.Enabled = false;
                CmsItem_TahsilatÖdemeDüzenle.Enabled = true;
            }
        }

        private void CmsItem_DevirKartiDüzenle_Click(object sender, EventArgs e)
        {
            formlar.KasaDevirIslemKarti(true, HareketID);
            Listele();
        }

        private void CmsItem_TahsilatÖdemeDüzenle_Click(object sender, EventArgs e)
        {
            formlar.KasaTahsilatÖdemeKartı(true, HareketID);
            Listele();
        }
    }
}