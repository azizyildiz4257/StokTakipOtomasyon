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
    public partial class Frm_BankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();

        int BankaID = -1;
        int IslemID = -1;

        public Frm_BankaHareketleri()
        {
            InitializeComponent();
        }

        private void Frm_BankaHareketleri_Load(object sender, EventArgs e)
        {

        }
        void Listele()  // Ders 7 21:40
        {
            var lst = from s in Db.VW_BankaHareketleris
                      where s.BankaID == BankaID
                      select s;
            Grd_Liste.DataSource = lst;
        }
        public void BankaAc(int ID)    // Ders 7 25:56
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BankaListesi Banka = Db.VW_BankaListesis.First(s => s.Id == BankaID);
                //Txt_HesapTürü_Adi.Text = Db.VW_BankaListesis.First(s => s.Id == BankaID).HesapAdi;
                Txt_HesapTürü_Adi.Text = Banka.HesapAdi;/*Bu satır aslında yukarıdaki işlemi yapıyor. tabi öncelikle nesne tanımlaması gerekmektedir.*/
                Txt_HesapNo.Text = Banka.HesapNo;
                Txt_Giris.Text = Banka.Gırıs.Value.ToString();
                Txt_Cikis.Text = Banka.Cikis.Value.ToString();
                Txt_Bakiye.Text = Banka.Bakiye.Value.ToString();
                Listele();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
                throw;
            }
        }

        private void Txt_HesapTürü_Adi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = frm.BankaListesi(true);
            if (ID > 0) BankaAc(ID);
            AnaForm.Aktarma = -1;
        }
    }
}