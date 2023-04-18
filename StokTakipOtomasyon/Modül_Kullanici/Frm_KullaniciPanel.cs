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

namespace StokTakipOtomasyon.Modül_Kullanici
{
    public partial class Frm_KullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext Db = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullaniciID = -1;

        public Frm_KullaniciPanel(int ID, bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            if (Ac)
            {
                KullaniciGetir(ID);
                Txt_KullaniciAdi.Enabled = false;
            }
        }
        void Temizle()
        {
            Txt_KullaniciAdi.Text = "";
            Txt_KullaniciTürü.SelectedIndex = 1;
            Txt_Sifre.Text = "";
            Txt_SifreTekrar.Text = "";
            Txt_Soyisim.Text = "";
            Txt_İsim.Text = "";
            RBtn_Pasif.Checked = true;
            Ac = false;
            KullaniciID = -1;
        }
        void KullaniciGetir(int ID)     /*ID almaya gerek yok aslında çünkü form contructer'nda alıyoruz ama biz yinede garanti olması açısından alıyoruz  Ders 18 30:20 */
        {
            KullaniciID = ID;   //Burdada biz tekrar ıd atamasını yapalımda ne olur ne olmaz Ders 18 31:22
            try
            {
                Fonksiyonlar.Tbl_Kullanicilar kullanicilar = Db.Tbl_Kullanicilars.First(s => s.Id == KullaniciID);
                Txt_İsim.Text = kullanicilar.İsim;
                Txt_Soyisim.Text = kullanicilar.Soyisim;
                Txt_KullaniciAdi.Text = kullanicilar.Kullanici;
                Txt_Sifre.Text = kullanicilar.Sifre;
                Txt_SifreTekrar.Text = kullanicilar.Sifre;
                if (kullanicilar.Kodu == "Yönetici") Txt_KullaniciTürü.SelectedIndex = 0;
                if (kullanicilar.Kodu == "Personel") Txt_KullaniciTürü.SelectedIndex = 1;
                if (kullanicilar.Aktif.Value)
                {
                    RBtn_Aktif.Checked = true;
                }
                else
                {
                    RBtn_Pasif.Checked = false;
                }

            }
            catch (Exception ex)
            {
                mesajlar.Hata(ex);
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)   //Ders 18
        {
            if (Txt_Sifre.Text.Trim() == Txt_SifreTekrar.Text.Trim())
            {
                if (Txt_İsim.Text == "")
                {
                    MessageBox.Show("İsim girişi yapmak zorunludur.");
                    return;
                }
                else if (Txt_Soyisim.Text == "")
                {
                    MessageBox.Show("Soyisim girişi yapmak zorunludur.");
                    return;
                }
                else if (Txt_KullaniciAdi.Text == "")
                {
                    MessageBox.Show("Kullanıcı girişi yapmak zorunludur.");
                    return;
                }
                else if (Txt_Sifre.Text == "")
                {
                    MessageBox.Show("Sifre girişi yapmak zorunludur.");
                    return;
                }
                DialogResult DR = MessageBox.Show(Txt_KullaniciTürü.Text + "türünde bir kullanıcı açmak üzeresiniz. Emin misiniz?", "Kullanıcı Kaydı Formu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.Yes)
                {
                    try
                    {
                        /*Biz burda eğer bir güncelleme işlemi için açılmadıysa yeni bir nesne tanımlayarak kullanıcı oluşturduk ama eğer güncelleme için açıldıysa nesnemizin tanımladığımız Id ye sahip olan satır olduğunu belirttik.*/
                        if (!Ac)     //Ders 18 1:26:56
                        {
                            if (Db.Tbl_Kullanicilars.Where(s => s.Kullanici == Txt_KullaniciAdi.Text).Count() > 0)
                            {   /*Texte yazılan kullanıcı adını veritabanında varsa count değeri 0 dan büyükolacağından işlem gerçekleşmez hata mesajını alırız. Ders 18 54:15*/
                                MessageBox.Show("Bu isimde kullanıcı mevcuttur. Lütfen başka bir Kullanıcı adı giriniz.");
                                return;
                            }
                        }
                        Fonksiyonlar.Tbl_Kullanicilar kullanicilar;
                        if (!Ac) kullanicilar = new Fonksiyonlar.Tbl_Kullanicilar();   //if Ac değilse
                        else kullanicilar = Db.Tbl_Kullanicilars.First(s => s.Id == KullaniciID);
                        if (RBtn_Aktif.Checked) kullanicilar.Aktif = true;
                        if (RBtn_Pasif.Checked) kullanicilar.Aktif = false;
                        kullanicilar.İsim = Txt_İsim.Text;
                        kullanicilar.Soyisim = Txt_Soyisim.Text;
                        kullanicilar.Kullanici = Txt_KullaniciAdi.Text;
                        kullanicilar.Kodu = Txt_KullaniciTürü.Text;
                        if (Ac) kullanicilar.EditDate = DateTime.Now;   //Eğer kullanıcı güncelleme için açılmışsa
                        else kullanicilar.SaveDate = DateTime.Now;      //Kayıt için açılmışsa
                        kullanicilar.Sifre = Txt_Sifre.Text;
                        if (!Ac) Db.Tbl_Kullanicilars.InsertOnSubmit(kullanicilar);
                        Db.SubmitChanges();
                        if (Ac) mesajlar.Guncelle(true);
                        else mesajlar.YeniKayit(Txt_KullaniciAdi.Text + "kullanıcı kaydı açılmıştır.");
                        Temizle();
                        Frm_KullaniciYönetimi frm = new Frm_KullaniciYönetimi();
                        frm.Listele();
                    }
                    catch (Exception ex)
                    {
                        mesajlar.Hata(ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girdiniz.");
            }
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}