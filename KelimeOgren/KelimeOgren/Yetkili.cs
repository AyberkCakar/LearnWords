using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public class Yetkili:Kisi
    {
        private string kullaniciAdi;

        public Yetkili(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        string Yetki { get; set; }
        double YetkiliId { get; set; }
    }
}
