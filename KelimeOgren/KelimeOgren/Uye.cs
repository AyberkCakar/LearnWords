using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class Uye:Kisi,IOyunOyna
    {
        public string kullaniciAdi;

        public Uye(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        public Uye()
        {
        }
        public double UyeNo { get; set; } //Üyenin sırası
        sqlBaglanti connect = new sqlBaglanti();
        public void OyunBilgileriniGetir(OyunOyna Oyunlar)  //Kullanıcının id'sine göre öğrendiği kelimeleri getiriyoruz.
        {
            int KelimeSayac = 1;
            SqlCommand command = new SqlCommand("Select * From Tbl_Oyun where KullaniciID= @a1 ", connect.baglanti());
            command.Parameters.AddWithValue("@a1", kullaniciAdi);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                OyunOyna Oyun = new OyunOyna();
                Oyun.KelimeSira = KelimeSayac;
                Oyun.KelimeID = Convert.ToInt32( dr[0]);
                Oyun.Kelime = dr[1].ToString();
                Oyun.Ingilizce = dr[2].ToString();
                Oyun.Resim = dr[3].ToString();
                Oyun.Date = Convert.ToDateTime(dr[5]);
                Oyun.KelimeSeviyesi = Convert.ToInt32(dr[6]);
                if(Oyun.ZamanHesapla(Oyun.Date, Oyun.KelimeSeviyesi)==true) //Zaman Hesapla Methodu ile kontrol ediyoruz.Zamanının gelip gelmediğini
                {
                    Oyunlar.Game.Add(Oyun);
                    KelimeSayac++;
                }
                else if(Oyun.KelimeSeviyesi == 5) //Kelime seviyesi 5 olmuş ise Kelime öğrenildi(tamamlandı) kabul edilir.
                {
                    Oyunlar.TamamlananKelimeler.Add(Oyun);
                }
                else
                {
                    continue;
                }              
            }
            connect.baglanti().Close();
        }
        public void OyunBilgileriniUpdate(OyunOyna Oyun)
        {
            SqlCommand Update = new SqlCommand("Update Tbl_Oyun set Tarih=@p3,Kademe=@p4 where KullaniciID=@p2 and KelimeID=@p1",connect.baglanti());
            Update.Parameters.AddWithValue("@p1", Oyun.KelimeID);
            Update.Parameters.AddWithValue("@p2", Oyun.KullanıcıID);
            Update.Parameters.AddWithValue("@p3", Oyun.Date);
            Update.Parameters.AddWithValue("@p4", Oyun.KelimeSeviyesi);
            Update.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public void OyunBilgisiGir(OyunOyna Oyun)
        {
            SqlCommand insert = new SqlCommand("insert into Tbl_Oyun (KelimeID,Kelime,İngilizce,Resim,KullaniciID,Tarih,Kademe) values (@a1,@a2,@a3,@a4,@a5, @a6,@a7)", connect.baglanti());
            insert.Parameters.AddWithValue("@a1",Oyun.KelimeID);
            insert.Parameters.AddWithValue("@a2", Oyun.Kelime);
            insert.Parameters.AddWithValue("@a3", Oyun.Ingilizce);
            insert.Parameters.AddWithValue("@a4", Oyun.Resim);
            insert.Parameters.AddWithValue("@a5", Oyun.KullanıcıID);
            insert.Parameters.AddWithValue("@a6", Oyun.Date);
            insert.Parameters.AddWithValue("@a7", Oyun.KelimeSeviyesi);
            insert.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public override void KisiEkle()
        {
            SqlCommand Ekle = new SqlCommand("insert into Tbl_Uye (UyeAd,Soyad,Telefon,Mail,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)",connect.baglanti());
            Ekle.Parameters.AddWithValue("@p1", Ad);
            Ekle.Parameters.AddWithValue("@p2", Soyad);
            Ekle.Parameters.AddWithValue("@p3", Telefon);
            Ekle.Parameters.AddWithValue("@p4", Mail);
            Ekle.Parameters.AddWithValue("@p5", KullaniciID);
            Ekle.Parameters.AddWithValue("@p6", Sifre);
            Ekle.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public override void KisiBilgiGetir(string kullaniciAdi)
        {
            SqlCommand UyeBilgiGetir = new SqlCommand("Select * From Tbl_Uye where KullaniciAdi=@p1", connect.baglanti());
            UyeBilgiGetir.Parameters.AddWithValue("@p1",kullaniciAdi);
            SqlDataReader dr = UyeBilgiGetir.ExecuteReader();
            if (dr.Read())
            {
                Ad = dr[1].ToString();
                Soyad = dr[2].ToString();
                Mail = dr[4].ToString();
                Telefon = dr[3].ToString();
                KullaniciID = dr[5].ToString();
                Sifre = dr[6].ToString();
                UyeNo = Convert.ToInt32(dr[0]);
            }
            connect.baglanti().Close();
        }
        public override void KisiBilgiGuncelle()
        {
            SqlCommand UyeBilgiGuncelle = new SqlCommand("update Tbl_Uye set Telefon =@a1,Mail=@a2,Sifre=@a3 where UyeID=@a4", connect.baglanti());
            UyeBilgiGuncelle.Parameters.AddWithValue("@a1", Telefon);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a2", Mail);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a3", Sifre);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a4", UyeNo);
            UyeBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
