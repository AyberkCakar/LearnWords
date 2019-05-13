using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class Kelime : IOrneklenebilir
    {
        public int KelimeId { get; set; }
        public int KelimeKontrol { get; set; }
        public string Turkce { get; set; }
        public string Ingilizce { get; set; }
        public string Turu { get; set; }
        public string OrnCumle { get; set; }
        public string TurkceCumle { get; set; }
        public string Resim { get; set; }

        public List<Kelime> Kelimeler = new List<Kelime>(); //Kişinin Öğrenebileceği kelimeler
        public List<Kelime> OgrendigimKelimeler = new List<Kelime>(); // Kisinin öğrenmeye başladığı kelimeler 
        public List<Kelime> TumKelimeler = new List<Kelime>(); //Tüm Kelimeler
        sqlBaglanti connect = new sqlBaglanti();
        int kelimeSayac=0;
        public void KelimeOgren(Uye uye) //Üyenin kullanıcıID'sine göre öğrenmediği kelimeleri List'e alıyoruz.
        {
            OyunOyna oyun = new OyunOyna();
            SqlCommand select = new SqlCommand("select * from Tbl_Kelime where not KelimeId in (select KelimeID from Tbl_Oyun where KullaniciID=@a1) ", connect.baglanti());
            select.Parameters.AddWithValue("@a1", uye.kullaniciAdi);
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Kelime kelime = new Kelime();
                kelime.KelimeKontrol = kelimeSayac;
                kelime.KelimeId = Convert.ToInt32(Dtr[0]);
                kelime.Turkce = Dtr[1].ToString();
                kelime.Ingilizce = Dtr[2].ToString();
                kelime.Turu = Dtr[3].ToString();
                kelime.OrnCumle = Dtr[4].ToString();
                kelime.TurkceCumle = Dtr[5].ToString();
                kelime.Resim = Dtr[6].ToString();
                Kelimeler.Add(kelime);
                kelimeSayac++;
            }
        }
        public void TumKelime(Uye uye) // Üye Oyun oynarken rastgele şık oluşturmak için bütün kelimeler liste alınır.
        {
            SqlCommand select = new SqlCommand("select * from Tbl_Kelime ", connect.baglanti());
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Kelime kelime = new Kelime();
                kelime.KelimeId = Convert.ToInt32(Dtr[0]);
                kelime.Turkce = Dtr[1].ToString();
                kelime.Ingilizce = Dtr[2].ToString();
                TumKelimeler.Add(kelime);
            }
        }
        public void YetkiliKelime() //Yetkili tüm kelimeleri görür
        {
            SqlCommand select = new SqlCommand("select * from Tbl_Kelime order by KelimeId" , connect.baglanti());
            SqlDataReader Dtr = select.ExecuteReader();
            while (Dtr.Read())
            {
                Kelime kelime = new Kelime();
                kelime.KelimeKontrol = kelimeSayac;
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
        public Kelime UyeKelimeOgren(int _sayac) //Butonun KontrolSayacındaki değere eşit olan Kelimeyi alıyorum.
        {
            foreach(Kelime kelime in Kelimeler)
            {
                if (kelime.KelimeKontrol == _sayac)
                {
                    return kelime;
                }
                else
                    continue;
            }
            return null;
         }
    }
}
