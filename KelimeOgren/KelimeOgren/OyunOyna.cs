using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public class OyunOyna : IZamanHesapla
    {
        public int KelimeSira { get; set; }
        public int KelimeID { get; set; }
        public string Kelime { get; set; }
        public string Ingilizce { get; set; }
        public string Resim { get; set; }
        public string KullanıcıID { get; set; }
        public DateTime Date { get; set; }
        public int KelimeSeviyesi { get; set; }
        public List<OyunOyna> Game = new List<OyunOyna>(); //Oynaya bileceği kelimelerin Listesi
        public List<OyunOyna> TamamlananKelimeler = new List<OyunOyna>(); // Tamamen öğrenilen Kelimeler
        public OyunOyna Oyun(int _sayac)
        {
            foreach (OyunOyna oyun in Game)
            {
                if (oyun.KelimeSira == _sayac)
                {
                    return oyun;
                }
            }
            return null;
        }
        public bool ZamanHesapla(DateTime date, int KelimeSeviyesi) //Kelimelerin seviye'ye göre ki  Bekleme gün sayılarını kontrol ediyoruz.
        {
            DateTime zaman  = DateTime.Parse(date.ToLongDateString());
            TimeSpan dateFark = DateTime.Today - zaman;
            int gunFark = Convert.ToInt32(dateFark.TotalDays.ToString());
            if ((KelimeSeviyesi == 1 && gunFark >= 1 )|| (KelimeSeviyesi == 2 && gunFark >= 2) ||( KelimeSeviyesi == 3 && gunFark >= 3 )|| (KelimeSeviyesi == 4 && gunFark >= 4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
