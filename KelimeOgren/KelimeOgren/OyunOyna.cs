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
        public DateTime Dt { get; set; }
        public int KelimeSeviyesi { get; set; }
        public List<OyunOyna> Game = new List<OyunOyna>();
        public List<OyunOyna> TamamlananKelimeler = new List<OyunOyna>();
        public OyunOyna Oyun(int _sayac)
        {
            foreach (OyunOyna oyn in Game)
            {
                if (oyn.KelimeSira == _sayac)
                {
                    return oyn;
                }
            }
            return null;
        }
        public bool ZamanHesapla(DateTime dt, int KelimeSeviyesi)
        {
            DateTime da = DateTime.Parse(dt.ToLongDateString());
            TimeSpan fark = DateTime.Today - da;
            int fa = Convert.ToInt32(fark.TotalDays.ToString());
            if ((KelimeSeviyesi == 1 && fa >= 1 )|| (KelimeSeviyesi == 2 && fa >= 2) ||( KelimeSeviyesi == 3 &&fa >= 3 )|| (KelimeSeviyesi == 4 && fa >= 4))
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
