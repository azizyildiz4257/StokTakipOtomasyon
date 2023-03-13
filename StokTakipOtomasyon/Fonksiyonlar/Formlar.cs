using StokTakipOtomasyon;
using StokTakipOtomasyon.Modül_Cek;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyon.Fonksiyonlar
{
    internal class Formlar
    {
        #region Stok Formları
        public int StokListesi(bool Secim = false)
        {
            Modül_Stok.frmStokListesi frm = new Modül_Stok.frmStokListesi();
            if (Secim)
            {
                frm.secim = true;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public int StokGrupları(bool Secim = false)
        {
            Modül_Stok.frmStokGrupları frm = new Modül_Stok.frmStokGrupları();

            if (Secim)
            {
                frm.Secim = Secim;
            }
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }

        public void StokKartı(bool Ac = false)
        {
            Modül_Stok.frmStokKartı frm = new Modül_Stok.frmStokKartı();
            frm.ShowDialog();
        }
        #endregion

        #region Cari Formları
        public int CariGruplari(bool Secim = false)
        {
            Modül_Cari.Frm_CariGruplari frm = new Modül_Cari.Frm_CariGruplari();
            if (Secim)
            {
                frm.Secim = Secim;
            }
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public int CariListesi(bool Secim = false)
        {
            Modül_Cari.Frm_CariListesi frm = new Modül_Cari.Frm_CariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modül_Cari.Frm_CariAcilisKarti frm = new Modül_Cari.Frm_CariAcilisKarti();
            if (Ac)
            {
                frm.Ac(CariID);
            }
            frm.ShowDialog();
        }
        #endregion

        #region Kasa Formları
        public void KasaAcilisKarti()
        {
            Modül_Kasa.Frm_KasaAcilisKarti frm = new Modül_Kasa.Frm_KasaAcilisKarti();
            frm.ShowDialog();
        }
        public void KasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modül_Kasa.Frm_KasaDevirIslemKartı frm = new Modül_Kasa.Frm_KasaDevirIslemKartı();
            if (Ac) frm.Ac(IslemID);    //Eğer acılacaksa KasaDevirIslemKartı fromunda Ac metodunu çalıştır.    Ders 4 50 küsür dk
            frm.ShowDialog();
        }
        public int KasaListesi(bool Secim = false)
        {
            Modül_Kasa.Frm_KasaListesi frm = new Modül_Kasa.Frm_KasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else                                    // Ders 4 1.08
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void KasaTahsilatÖdemeKartı(bool Ac = false, int ID = -1)
        {
            Modül_Kasa.Frm_KasaTahsilatÖdeme frm = new Modül_Kasa.Frm_KasaTahsilatÖdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modül_Kasa.Frm_KasaHareketleri frm = new Modül_Kasa.Frm_KasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac)
            {
                frm.Ac(ID);
            }
            frm.Show();
        }
        #endregion

        #region Banka Formları
        public void BankaAcilisKarti()
        {
            Modul_Banka.Frm_BankaAcilisKarti frm = new Modul_Banka.Frm_BankaAcilisKarti();
            frm.ShowDialog();
        }
        public void BankaIslem(bool Ac = false, int ID = -1)
        {
            Modul_Banka.Frm_BankaIslemi frm = new Modul_Banka.Frm_BankaIslemi();
            if (Ac)
            {
                frm.Ac(ID);
            }
            frm.ShowDialog();
        }
        public int BankaListesi(bool Secim = false)    //Ders 6 1:01:30
        {
            Modul_Banka.Frm_BankaListesi frm = new Modul_Banka.Frm_BankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void BankaParaTransfer(bool Ac = false, int ID = -1)    //Ders 6 1:41:40
        {
            Modul_Banka.Frm_ParaTransferi frm = new Modul_Banka.Frm_ParaTransferi();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Banka.Frm_BankaHareketleri frm = new Modul_Banka.Frm_BankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac)
            {
                frm.BankaAc(ID);
            }
            frm.Show();
        }
        #endregion

        #region Çek Formları
        public void KendiCekimiz(int id = 0, bool Ac = false)
        {
            Modül_Cek.Frm_KendiCekimiz frm = new Modül_Cek.Frm_KendiCekimiz();
            //if (Ac) ;
            frm.ShowDialog();
        }

        public void MusteriCeki(int id = 0, bool Ac = false)
        {
            Modül_Cek.Frm_MusteriCeki frm = new Modül_Cek.Frm_MusteriCeki();
            //if (Ac) ;
            frm.ShowDialog();
        }

        public void CariyeCekCikisi()
        {
            Modül_Cek.Frm_CariyeCekCikisi frm = new Modül_Cek.Frm_CariyeCekCikisi();
            frm.ShowDialog();
        }

        public void BankayaCekCikisi()
        {
            Modül_Cek.Frm_BankayaCekCikisi frm = new Modül_Cek.Frm_BankayaCekCikisi();
            frm.ShowDialog();
        }
        public int CekListesi(bool Secim = false)
        {
            Modül_Cek.Frm_CekListesi frm = new Modül_Cek.Frm_CekListesi();
            if (Secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                foreach (DevExpress.XtraEditors.XtraForm K in AnaForm.ActiveForm.MdiChildren)
                {
                    if (K.Name == "Frm_CekListesi")
                    {
                        K.BringToFront();
                        return AnaForm.Aktarma;
                    }
                }
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        #endregion
    }
}

//foreach (DevExpress.XtraEditors.XtraForm K in AnaForm.ActiveForm.MdiChildren)
//{
//    if (K.Name == "Frm_CekListesi")
//    {
//        K.BringToFront();
//        return AnaForm.Aktarma;
//    }
//}
