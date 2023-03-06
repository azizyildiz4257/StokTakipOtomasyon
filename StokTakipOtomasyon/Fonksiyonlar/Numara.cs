using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipOtomasyon.Fonksiyonlar
{
    internal class Numara
    {
		DatabaseDataContext Db = new DatabaseDataContext();
		Mesajlar mesajlar = new Mesajlar();
        public string StokKodNumarasi()
        {
			try
			{
				int Numara = int.Parse((from s in Db.Tbl_Stoklars
										orderby s.Id descending
										select s).First().StokKodu);
				Numara++;
				string Num = Numara.ToString().PadLeft(7, '0');// Alınan numarayı 7 hane olacak şekile getiriyor sonra geri döndürüyor.
				return Num;
			}
			catch (Exception)
			{
				return "0000001"; // Harhangi bir numara yok ise 1 nolu kodu getiriyor.		
			}
        }
        public string CariKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in Db.Tbl_Carilers
                                        orderby s.Id descending
                                        select s).First().CariKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');// Alınan numarayı 7 hane olacak şekile getiriyor sonra geri döndürüyor.
                return Num;
            }
            catch (Exception)
            {
                return "0000001"; // Harhangi bir numara yok ise 1 nolu kodu getiriyor.		
            }
        }
        public string KasaKodNumarasi()
        {
            try
            {
                int Numara = int.Parse((from s in Db.Tbl_Kasalars
                                        orderby s.Id descending
                                        select s).First().KasaKodu);
                Numara++;
                string Num = Numara.ToString().PadLeft(7, '0');// Alınan numarayı 7 hane olacak şekile getiriyor sonra geri döndürüyor.
                return Num;
            }
            catch (Exception)
            {
                return "0000001"; // Harhangi bir numara yok ise 1 nolu kodu getiriyor.		
            }
        }
    }
}
