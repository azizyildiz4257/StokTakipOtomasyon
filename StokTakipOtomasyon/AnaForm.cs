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

        public void Mesaj(string baslik, string mesaj)  //Ders 7 1:12:35
        {
            alertControl1.Show(this, baslik, mesaj);
        }

        #region Stok Butonları
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

        private void NavBTN_StokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.StokKartı();
        }

        private void NavBTN_StokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.StokListesi();
        }

        private void NavBTN_StokGrupları_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.StokGrupları();
        }

        private void NavBTN_StokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.StokHareketleri();
        }
        #endregion

        #region Cari Butonları
        private void Btn_CariGrupları_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariGruplari();
        }

        private void Btn_CariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariAcilisKarti();
        }

        private void NavBTN_CariAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.CariAcilisKarti();
        }

        private void NavBTN_CariGrupları_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.CariGruplari();
        }

        private void NavBTN_CariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.CariListesi();
        }

        private void NavBTN_CariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
        #endregion

        #region Kasa Butonları
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

        private void NavBTN_KasaAcilisİslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.KasaAcilisKarti();
        }

        private void NavBTN_KasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.KasaListesi();
        }

        private void NavBTN_KasaDevirİslemKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.KasaDevirIslemKarti();
        }

        private void NavBTN_KasaTahsilatÖdeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.KasaTahsilatÖdemeKartı();
        }

        private void NavBTN_KasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.KasaHareketleri();
        }
        #endregion

        #region Banka Butonları
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
            formlar.BankaHareketleri();
        }

        private void NavBTN_BankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.BankaAcilisKarti();
        }

        private void NavBTN_BankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.BankaListesi();
        }

        private void NavBTN_Bankaİslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.BankaIslem();
        }

        private void NavBTN_BankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.BankaHareketleri();
        }

        private void NavBTN_ParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            formlar.BankaParaTransfer();
        }
        #endregion

        private void Btn_MusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.MusteriCeki();
        }

        private void Btn_KendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KendiCekimiz();
        }

        private void Btn_BankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.BankayaCekCikisi();
        }

        private void Btn_CariyeCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariyeCekCikisi();
        }

        private void Btn_CekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CekListesi();
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();    //Ders 13 2:18
            /*Anaform artık application form olmayacağı için anaformu kapattığımızda applicationdan çıkmayacak. Yani uygulamayı kapatmayacak.*/
        }
    }
}