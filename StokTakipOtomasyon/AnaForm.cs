using DevExpress.XtraBars;
using DevExpress.XtraRichEdit.Commands.Internal;
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

namespace StokTakipOtomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();

        public static int UserID = -1;
        public static int Aktarma = 1;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Btn_StokKartı_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokKartı();
        }

        private void Btn_StokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokListesi();
        }

        private void Btn_StokGrupları_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokGrupları();
        }

        private void Btn_StokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokHareketleri();
        }

        private void Btn_CariGrupları_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariGruplari();
        }

        private void Btn_CariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariAcilisKarti();
        }

        private void Btn_KasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaAcilisKarti();
        }

        private void Btn_KasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaListesi();
        }

        private void Btn_KasaDevirIslemKartı_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaDevirIslemKarti();
        }

        private void Btn_KasaTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaTahsilatÖdemeKartı();
        }

        private void Btn_KasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaHareketleri();
        }

        private void Btn_BankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.BankaAcilisKarti();
        }

        private void Btn_BankaIslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.BankaIslem();
        }

        private void Btn_BankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.BankaListesi();
        }

        private void Btn_ParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.BankaParaTransfer();
        }

        private void Btn_BankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}