using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string KullaniciID { get; set; }
        public string Sifre { get; set; }
        public abstract void KisiEkle();
        public abstract void KisiBilgiGetir(string kullaniciAdi);
        public abstract void KisiBilgiGuncelle();

    }
}
