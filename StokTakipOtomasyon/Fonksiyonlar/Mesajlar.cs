using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace StokTakipOtomasyon.Fonksiyonlar
{
    internal class Mesajlar
    {
        AnaForm Mesajfrm = new AnaForm();
        public void YeniKayit(string Mesaj)
        {
            Mesajfrm.Mesaj("Yeni Kayıt Girişi", Mesaj);     //Ders 7 1:14:05

            //MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıt kalıcı olarak güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz?", "Güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool Guncelle) // Ders 1 1:10 DK
        {
            Mesajfrm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir.");   //Ders 7 1:14:40 /*Buraya güncellemiş olduğumuz kayda ait verileri çekerek popup yarmıyla yazdırabiliriz.*/

            //MessageBox.Show("Kayıt güncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            Mesajfrm.Mesaj("Hata Oluştu", Hata.Message);

            //MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void FormAcilis(string FromAdi)  //Ders 7 1:17:30 Olmasada olur.
        {
            Mesajfrm.Mesaj("", FromAdi + " formu açıldı.");
        }
    }
}
