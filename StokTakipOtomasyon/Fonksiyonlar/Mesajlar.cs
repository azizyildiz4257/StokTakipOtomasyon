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
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Kayıt güncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
