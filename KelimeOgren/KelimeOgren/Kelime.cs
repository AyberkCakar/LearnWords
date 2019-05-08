using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class Kelime : IOrneklenebilir ,ITersCevir, ITamamlanan
    {
        public int KelimeId { get; set; }
        public int KelimeKontrol { get; set; }
        public string Turkce { get; set; }
        public string Ingilizce { get; set; }
        public string Turu { get; set; }
        public string OrnCumle { get; set; }
        public string TurkceCumle { get; set; }
        public string Resim { get; set; }
        public void TersCevir()
        {

        }

        public List<Kelime> Kelimeler = new List<Kelime>();
        public List<Kelime> OgrendigimKelimeler = new List<Kelime>();
        int say=0;
        public void KelimeOgren(Uye uye)
        {
            OyunOyna oyun = new OyunOyna();
            uye.OyunBilgileriniGetir(oyun);
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand select = new SqlCommand("select * from Tbl_Kelime where not KelimeId in (select KelimeID from Tbl_Oyun where KullaniciID=@a1) ", connect.baglanti());
            select.Parameters.AddWithValue("@a1", uye.kullaniciAdi);
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {

                Kelime kelime = new Kelime();
                kelime.KelimeKontrol = say;
                kelime.KelimeId = Convert.ToInt32(Dtr[0]);
                kelime.Turkce = Dtr[1].ToString();
                kelime.Ingilizce = Dtr[2].ToString();
                kelime.Turu = Dtr[3].ToString();
                kelime.OrnCumle = Dtr[4].ToString();
                kelime.TurkceCumle = Dtr[5].ToString();
                kelime.Resim = Dtr[6].ToString();
                for(int i=say;i<uye.Kontrol.Length;i++)
                {
                    if (kelime.KelimeId == uye.Kontrol[i])
                    {
                        break;
                    }
                    else
                    {
                        Kelimeler.Add(kelime);
                        say++;
                        break;
                    }
                        
                }

            }
        }
        public void YetkiliKelime()
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand select = new SqlCommand("select * from Tbl_Kelime order by KelimeId" , connect.baglanti());
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Kelime kelime = new Kelime();
                kelime.KelimeKontrol = say;
                kelime.KelimeId = Convert.ToInt32(Dtr[0]);
                kelime.Turkce = Dtr[1].ToString();
                kelime.Ingilizce = Dtr[2].ToString();
                kelime.Turu = Dtr[3].ToString();
                kelime.OrnCumle = Dtr[4].ToString();
                kelime.TurkceCumle = Dtr[5].ToString();
                kelime.Resim = Dtr[6].ToString();
                Kelimeler.Add(kelime);
            }
        }
        public Kelime UyeKelimeOgren(int _sayac)
        {
            foreach(Kelime klm in Kelimeler)
            {
                if (klm.KelimeKontrol==_sayac)
                {
                    return klm;
                }                
            }
            return null;
         }
    }
}
