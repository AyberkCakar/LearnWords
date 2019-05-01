using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public static class GirisServisi
    {
        public static bool KullaniciDogrula(string kullaniciAdi,string sifre)
        {
            return true;
        }

        public static Kisi GirisYap(string kullaniciAdi,string sifre)
        {
            if (KullaniciDogrula(kullaniciAdi, sifre))
                return new Uye(kullaniciAdi);
            else
                return null;
        }
        public static Kisi GirisYapYetkili(string kullaniciAdi, string sifre)
        {
            if (KullaniciDogrula(kullaniciAdi, sifre))
                return new Yetkili(kullaniciAdi);
            else
                return null;
        }
    }
}
