using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public class Uye:Kisi
    {
        private string kullaniciAdi;

        public Uye(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        double UyeId { get; set; }
    }
}
