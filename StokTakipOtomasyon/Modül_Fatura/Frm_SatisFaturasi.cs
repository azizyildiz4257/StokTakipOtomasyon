using DevExpress.Utils.Extensions;
using DevExpress.Utils.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraRichEdit.Model.History;
using StokTakipOtomasyon.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyon.Modül_Fatura
{
    public partial class Frm_SatisFaturasi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;
        int IrsaliyeID = -1;
        string OdemeYeri = "";
        bool Edit = false;
        bool IrsaliyeAc = false;

        void Temizle()    //Ders 15 33:05
        {
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsaliyeID = -1;
            OdemeYeri = null;
            Edit = false;
            IrsaliyeAc = false;
            Txt_Aciklama.Text = "";
            Txt_AraToplam.Text = "0.00";
            Txt_CariAdi.Text = "";
            Txt_CariKodu.Text = "";
            Txt_FaturaNo.Text = "";     //Hoca boşaltıyor biz otomatik fatura numarası almasını sağlayabiliriz. Ders 15 30:45
            Txt_FaturaTarihi.Text = DateTime.Now.ToShortDateString();
            Txt_FaturaTürü.SelectedIndex = 0;
            Txt_GenelToplam.Text = "0.00";
            Txt_HesapAdi.Text = "";
            Txt_HesapNo.Text = "";
            Txt_IrsaliyeNo.Text = "";
            Txt_IrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
            Txt_KasaAdi.Text = "";
            Txt_KasaKodu.Text = "";
            Txt_KDV.Text = "0.00";
            Txt_ÖdemeYeri.SelectedIndex = 0;
            AnaForm.Aktarma = -1;
            for (int i = gridView1.RowCount; i > -1; i--)
            {
                gridView1.DeleteRow(i);     //Sürekli i'nin olduğu satırı silmiş olacağız.
            }

        }

        /*public Frm_SatisFaturasi()    //Hoca sabit değer haline getirmek için sildi. Ders16 2:50
        {
            InitializeComponent();
        }*/
        void FaturaGetir()      //Ders 16 başından 30:51 e kadar 
        {
            try
            {
                Fonksiyonlar.Tbl_Faturalar faturalar = Db.Tbl_Faturalars.First(s => s.Id == FaturaID);
                IrsaliyeID = faturalar.IrsaliyeID.Value;    //Ders 17 02:54 revize
                Txt_Aciklama.Text = faturalar.Aciklama;
                Txt_FaturaNo.Text = faturalar.FaturaNo;
                if (faturalar.OdemeYeriID > 0)
                {
                    Txt_FaturaTürü.SelectedIndex = 1;
                    if (faturalar.OdemeYeri == "Kasa")
                    {
                        Txt_ÖdemeYeri.SelectedIndex = 0;
                        OdemeYeri = faturalar.OdemeYeri;
                        Txt_KasaAdi.Text = Db.Tbl_Kasalars.First(s => s.Id == faturalar.OdemeYeriID.Value).KasaAdi;
                        Txt_KasaKodu.Text = Db.Tbl_Kasalars.First(s => s.Id == faturalar.OdemeYeriID.Value).KasaKodu;
                    }
                    else if (faturalar.OdemeYeri == "Banka")
                    {
                        Txt_ÖdemeYeri.SelectedIndex = 1;
                        OdemeYeri = faturalar.OdemeYeri;
                        Txt_HesapAdi.Text = Db.Tbl_Bankalars.First(s => s.Id == faturalar.OdemeYeriID.Value).HesapAdi;
                        Txt_HesapNo.Text = Db.Tbl_Bankalars.First(s => s.Id == faturalar.OdemeYeriID.Value).HesapNo;

                    }
                    OdemeID = faturalar.OdemeYeriID.Value;
                }
                else if (faturalar.OdemeYeriID < 1) Txt_FaturaTürü.SelectedIndex = 0;
                /**************************************Ders 16 49:25*****************************************/
                /*İrsaliye getirme*/
                Txt_IrsaliyeNo.Text = Db.Tbl_Irsaliyelers.First(s => s.Id == faturalar.IrsaliyeID.Value).IrsaliyeNo;
                Txt_IrsaliyeTarihi.EditValue = Db.Tbl_Irsaliyelers.First(s => s.Id == faturalar.IrsaliyeID.Value).Tarihi.Value.ToShortDateString();
                /********************************************************************************************/
                Txt_CariAdi.Text = Db.Tbl_Carilers.First(s => s.CariKodu == faturalar.CariKodu).CariAdi;    // Bu satır açıklayıcı olabilir bakmanda fayda var Ders 16 20:53
                Txt_CariKodu.Text = faturalar.CariKodu;
                Txt_FaturaTarihi.EditValue = faturalar.Tarihi.Value.ToShortDateString();
                var srg = from s in Db.VW_Kalemlers
                          where s.FaturaID == FaturaID
                          select s;
                foreach (Fonksiyonlar.VW_Kalemler k in srg)     //Başka ne yapabiliriz Ders 16 28:46
                {
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("Miktar", k.Miktar);
                    gridView1.SetFocusedRowCellValue("BirimFiyat", k.BirimFiyat);
                    gridView1.SetFocusedRowCellValue("KDV", k.KDV);
                    gridView1.SetFocusedRowCellValue("Barkod", k.StokBarkod);
                    gridView1.SetFocusedRowCellValue("StokKodu", k.StokKodu);
                    gridView1.SetFocusedRowCellValue("StokAdı", k.StokAdı);
                    gridView1.SetFocusedRowCellValue("Birim", k.StokBirim);
                    gridView1.UpdateCurrentRow();
                }
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        public Frm_SatisFaturasi(bool Ac, int ID, bool Irsaliye)     /*Ders 14 24:50 SatisFaturası formunda constructor ile overload ederek ilk bilgilerini girmiş oluyoruz. - Ders 16 4:05*/
        {
            InitializeComponent();
            Edit = Ac;
            if (Irsaliye) IrsaliyeID = ID;
            else FaturaID = ID;
            IrsaliyeAc = Irsaliye;
            this.Shown += Frm_SatisFaturasi_Shown;
        }

        private void Frm_SatisFaturasi_Shown(object sender, EventArgs e)    //Ders 16 31:40 shown kullanımı nedir ve niçin kullanılır
        {
            if (Edit) FaturaGetir();
        }

        void StokGetir(int stokID)     //Ders 16 1:30
        {
            try
            {
                Fonksiyonlar.Tbl_Stoklar stok = Db.Tbl_Stoklars.First(s => s.Id == stokID);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("Miktar", 0);
                gridView1.SetFocusedRowCellValue("Barkod", stok.StokBarkod);
                gridView1.SetFocusedRowCellValue("StokKodu", stok.StokKodu);
                gridView1.SetFocusedRowCellValue("StokAdi", stok.StokAdı);
                gridView1.SetFocusedRowCellValue("Birim", stok.StokBirim);
                gridView1.SetFocusedRowCellValue("BirimFiyat", stok.StokSatisFiyat);
                gridView1.SetFocusedRowCellValue("KDV", stok.StokSatisKDV);
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Btn_StokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int stokID = frm.StokListesi(true);     //Ders 14 37:40
            if (stokID > 0)
            {
                StokGetir(stokID);
            }
            AnaForm.Aktarma = -1;
        }

        private void Frm_SatisFaturasi_Load(object sender, EventArgs e)
        {
            Txt_FaturaTarihi.Text = DateTime.Now.ToShortDateString();
            Txt_IrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal miktar = 0, birimFiyat = 0, toplam = 0;
                if (e.Column.Name != "colToplam")      /*Her sütün değişikleiğinde toplam sürekli değişeceği için burda bir sonsuz döngü oluşabilir. Engel olması için bu şekilde tanımladık Ders 14 40:20*/
                {
                    miktar = decimal.Parse(gridView1.GetFocusedRowCellValue("Miktar").ToString());
                    if (gridView1.GetFocusedRowCellValue("BirimFiyat").ToString() != "")
                    {
                        birimFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("BirimFiyat").ToString());
                    }
                    toplam = miktar * birimFiyat;

                    gridView1.SetFocusedRowCellValue("Toplam", toplam.ToString());
                    Hesapla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Hesapla()     //Ders 14 58:20
        {
            try
            {
                decimal BirimFiyat = 0, Miktar = 0, GenelToplam = 0, AraToplam = 0, KDV = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BirimFiyat").ToString());
                    Miktar = decimal.Parse(gridView1.GetRowCellValue(i, "Miktar").ToString());
                    KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString()) / 100 + 1;
                    AraToplam += Miktar * BirimFiyat;
                    GenelToplam += decimal.Parse(gridView1.GetRowCellValue(i, "Toplam").ToString()) * KDV;
                }
                Txt_AraToplam.Text = AraToplam.ToString("0.00");
                Txt_KDV.Text = (GenelToplam - AraToplam).ToString("0.00");
                Txt_GenelToplam.Text = GenelToplam.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)      //Ders 14 58:58
        {
            Hesapla();
        }

        private void Txt_CariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = frm.CariListesi(true);
            if (id > 0)
            {
                CariSec(id);
            }
            AnaForm.Aktarma = -1;
        }

        void CariSec(int id)
        {
            try
            {
                CariID = id;
                Fonksiyonlar.Tbl_Cariler cari = Db.Tbl_Carilers.First(s => s.Id == CariID);
                Txt_CariKodu.Text = cari.CariKodu;
                Txt_CariAdi.Text = cari.CariAdi;

            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Txt_FaturaTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txt_FaturaTürü.SelectedIndex == 0)
            {
                Pnl_OdemeYerleri.Enabled = false;
                Txt_ÖdemeYeri.Enabled = false;
            }
            if (Txt_FaturaTürü.SelectedIndex == 1)
            {
                Pnl_OdemeYerleri.Enabled = true;
                Txt_ÖdemeYeri.Enabled = true;
            }
        }

        private void Txt_ÖdemeYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txt_ÖdemeYeri.SelectedIndex == 0)
            {
                Txt_HesapAdi.Enabled = false;
                Txt_HesapNo.Enabled = false;
                Txt_KasaAdi.Enabled = true;
                Txt_KasaKodu.Enabled = true;
                OdemeYeri = Txt_ÖdemeYeri.Text;
            }
            if (Txt_ÖdemeYeri.SelectedIndex == 1)
            {
                Txt_HesapAdi.Enabled = true;
                Txt_HesapNo.Enabled = true;
                Txt_KasaKodu.Enabled = false;
                Txt_KasaAdi.Enabled = false;
                OdemeYeri = Txt_ÖdemeYeri.Text;
            }
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void YeniFaturaKaydet()     //Ders 15 13:19
        {
            try
            {
                Fonksiyonlar.Tbl_Faturalar faturalar = new Fonksiyonlar.Tbl_Faturalar();
                faturalar.Aciklama = Txt_Aciklama.Text;
                faturalar.CariKodu = Txt_CariKodu.Text;
                faturalar.FaturaNo = Txt_FaturaNo.Text;
                //faturalar.FaturaSeri=     Bize bağlı Ders 15 6:42
                faturalar.FaturaTuru = "Satış Faturası";
                faturalar.GenelToplam = decimal.Parse(Txt_GenelToplam.Text);
                faturalar.IrsaliyeID = IrsaliyeID;
                faturalar.OdemeYeri = OdemeYeri;
                faturalar.OdemeYeriID = OdemeID;
                faturalar.Tarihi = DateTime.Parse(Txt_FaturaTarihi.Text);
                faturalar.SaveDate = DateTime.Now;
                faturalar.SaveUser = AnaForm.UserID;
                Db.Tbl_Faturalars.InsertOnSubmit(faturalar);
                Db.SubmitChanges();
                FaturaID = faturalar.Id;

                if (IrsaliyeID < 0)     //Yani bir irsaliyemiz yoksa
                {
                    Fonksiyonlar.Tbl_Irsaliyeler ırsaliyeler = new Fonksiyonlar.Tbl_Irsaliyeler();
                    ırsaliyeler.Aciklama = Txt_Aciklama.Text;
                    ırsaliyeler.CariKodu = Txt_CariKodu.Text;
                    ırsaliyeler.FaturaID = faturalar.Id;    //Çünkü biz bunu işlediğimiz için bunun artık bir ID'si var. Ders 15 10:43
                    ırsaliyeler.IrsaliyeNo = Txt_IrsaliyeNo.Text;
                    ırsaliyeler.Tarihi = DateTime.Parse(Txt_IrsaliyeTarihi.Text);
                    ırsaliyeler.SaveDate = DateTime.Now;
                    ırsaliyeler.SaveUser = AnaForm.UserID;
                    Db.Tbl_Irsaliyelers.InsertOnSubmit(ırsaliyeler);
                    Db.SubmitChanges();
                    IrsaliyeID = ırsaliyeler.Id;
                    faturalar.IrsaliyeID = IrsaliyeID;
                }

                Fonksiyonlar.Tbl_StokHareketleri[] stokHareketleri = new Fonksiyonlar.Tbl_StokHareketleri[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    stokHareketleri[i] = new Fonksiyonlar.Tbl_StokHareketleri();
                    stokHareketleri[i].BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BirimFiyat").ToString());
                    stokHareketleri[i].FaturaID = faturalar.Id;
                    stokHareketleri[i].GCKodu = "C";
                    stokHareketleri[i].IrsaliyeID = IrsaliyeID;
                    stokHareketleri[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                    stokHareketleri[i].Miktar = int.Parse(gridView1.GetRowCellValue(i, "Miktar").ToString());
                    stokHareketleri[i].StokKodu = gridView1.GetRowCellValue(i, "StokKodu").ToString();
                    stokHareketleri[i].Tipi = "Satış Faturası";
                    stokHareketleri[i].SaveDate = DateTime.Now;
                    stokHareketleri[i].SaveUser = AnaForm.UserID;
                    Db.Tbl_StokHareketleris.InsertOnSubmit(stokHareketleri[i]);
                }
                Db.SubmitChanges();
                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = new Fonksiyonlar.Tbl_CariHareketleri();
                cariHareketleri.Aciklama = Txt_FaturaNo.Text + "no'lu satış faturası tutarı";
                if (Txt_FaturaTürü.SelectedIndex == 0)
                {
                    cariHareketleri.Alacak = 0;
                    cariHareketleri.Borc = decimal.Parse(Txt_GenelToplam.Text);
                }
                else if (Txt_FaturaTürü.SelectedIndex == 1)
                {
                    cariHareketleri.Alacak = decimal.Parse(Txt_GenelToplam.Text);
                    cariHareketleri.Borc = decimal.Parse(Txt_GenelToplam.Text);
                }
                cariHareketleri.CariID = CariID;
                cariHareketleri.Tarih = DateTime.Now;
                cariHareketleri.Tipi = "SF";
                cariHareketleri.EvrakTuru = "Satış Faturası";
                cariHareketleri.EvrakID = faturalar.Id;
                cariHareketleri.SaveDate = DateTime.Now;
                cariHareketleri.SaveUser = AnaForm.UserID;
                Db.Tbl_CariHareketleris.InsertOnSubmit(cariHareketleri);
                Db.SubmitChanges();
                mesajlar.YeniKayit("Yeni fatura kaydı gerçekleştirildi.");
                Temizle();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        void FaturaGuncelle()       //Ders 17 09:20
        {
            try
            {
                Fonksiyonlar.Tbl_Faturalar faturalar = Db.Tbl_Faturalars.First(s => s.Id == FaturaID);
                faturalar.FaturaNo = Txt_FaturaNo.Text;
                faturalar.Aciklama = Txt_Aciklama.Text;
                faturalar.CariKodu = Txt_CariKodu.Text;
                faturalar.GenelToplam = decimal.Parse(Txt_GenelToplam.Text);
                faturalar.OdemeYeri = OdemeYeri;
                faturalar.OdemeYeriID = OdemeID;
                faturalar.EditDate = DateTime.Now;
                faturalar.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                /****************************************İrsaliye Güncelleme****************************************/
                Fonksiyonlar.Tbl_Irsaliyeler ırsaliyeler = Db.Tbl_Irsaliyelers.First(s => s.Id == IrsaliyeID);
                ırsaliyeler.IrsaliyeNo = Txt_IrsaliyeNo.Text;
                ırsaliyeler.Tarihi = DateTime.Parse(Txt_IrsaliyeTarihi.SelectedText);
                ırsaliyeler.EditDate = DateTime.Now;
                ırsaliyeler.EditUser = AnaForm.UserID;
                Db.Tbl_StokHareketleris.DeleteAllOnSubmit(Db.Tbl_StokHareketleris.Where(s => s.FaturaID == FaturaID));
                Db.SubmitChanges();
                /***************************************************************************************************/
                Fonksiyonlar.Tbl_StokHareketleri[] stokHareketi = new Fonksiyonlar.Tbl_StokHareketleri[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    stokHareketi[i] = new Fonksiyonlar.Tbl_StokHareketleri();
                    stokHareketi[i].FaturaID = FaturaID;
                    stokHareketi[i].BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BirimFiyat").ToString());
                    stokHareketi[i].GCKodu = "C";
                    stokHareketi[i].IrsaliyeID = IrsaliyeID;
                    stokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                    stokHareketi[i].Miktar = int.Parse(gridView1.GetRowCellValue(i, "Miktar").ToString());
                    stokHareketi[i].StokKodu = gridView1.GetRowCellValue(i, "StokKodu").ToString();
                    stokHareketi[i].Tipi = "Satış Faturası";
                    stokHareketi[i].SaveDate = DateTime.Now;
                    stokHareketi[i].SaveUser = AnaForm.UserID;
                    Db.Tbl_StokHareketleris.InsertOnSubmit(stokHareketi[i]);
                }
                Db.SubmitChanges();
                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = Db.Tbl_CariHareketleris.First(s => s.EvrakTuru == "Satış Faturası" && s.EvrakID == FaturaID);
                if (Txt_FaturaTürü.SelectedIndex == 0)      //Ders 17 24:24 Kontrol mekanizması koyarak güncelleme ve kayıt işlemlerini yapabiliriz.
                {
                    cariHareketleri.Alacak = 0;
                    cariHareketleri.Borc = decimal.Parse(Txt_GenelToplam.Text);
                }
                else if (Txt_FaturaTürü.SelectedIndex == 1)
                {
                    cariHareketleri.Borc = decimal.Parse(Txt_GenelToplam.Text);
                    cariHareketleri.Alacak = decimal.Parse(Txt_GenelToplam.Text);
                }
                cariHareketleri.EditDate = DateTime.Now;
                cariHareketleri.EditUser = AnaForm.UserID;
                Db.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (Edit && FaturaID > 0)
            {
                FaturaGuncelle();
            }
            else
            {
                YeniFaturaKaydet();
            }
        }

        private void Txt_ÖdemeYeri_EnabledChanged(object sender, EventArgs e)
        {
            if (Txt_ÖdemeYeri.Enabled)
            {
                OdemeYeri = Txt_ÖdemeYeri.Text;
            }
            else if (!Txt_ÖdemeYeri.Enabled)
            {
                OdemeYeri = "";
            }
        }

        private void Btn_Yazdir_Click(object sender, EventArgs e)
        {
            var srg = Db.VW_Faturalars.Where(s => s.FaturaNo == Txt_FaturaNo.Text);

            DataSet ds = new DataSet();
            ds.Tables.Add(LINQToDataTable(srg));

            Rpr_SatisFaturasi Rpr = new Rpr_SatisFaturasi();
            Rpr.DataSource= ds;
            Rpr.ShowPreview();
        }

        public DataTable LINQToDataTable<T>(IEnumerable<T> Lnqlst)      /*Ders 19 23:00*/
        {
            DataTable dt = new DataTable();


            PropertyInfo[] columns = null;

            if (Lnqlst == null) return dt;

            foreach (T Record in Lnqlst)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }

    }
}