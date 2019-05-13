using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class Yetkili:Kisi,IKelimeEkle
    {
        private string kullaniciAdi;

        public Yetkili(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }
        public Yetkili()
        {
        }
        public string Yetki { get; set; }
        public double YetkiliNo { get; set; }
        sqlBaglanti connect = new sqlBaglanti();
        public void KelimeEkle(Kelime kelime)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Kelime(Kelime,İngilizcesi,Türü,OrnCümle,OrnCumleTürk,Resim) values(@a1, @a2, @a3, @a4, @a5, @a6)", connect.baglanti() );
            command.Parameters.AddWithValue("@a1", kelime.Turkce);
            command.Parameters.AddWithValue("@a2", kelime.Ingilizce);
            command.Parameters.AddWithValue("@a3", kelime.Turu);
            command.Parameters.AddWithValue("@a4", kelime.OrnCumle);
            command.Parameters.AddWithValue("@a5", kelime.TurkceCumle);
            command.Parameters.AddWithValue("@a6", kelime.Resim);
            command.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public void KelimeGuncelle(Kelime kelime)
        {
            SqlCommand update = new SqlCommand("update Tbl_Kelime set Kelime=@a2,İngilizcesi=@a3,Türü=@a4,OrnCümle=@a5,OrnCumleTürk=@a6,Resim=@a7 where KelimeId=@a1 ", connect.baglanti());
            update.Parameters.AddWithValue("@a1", kelime.KelimeId);
            update.Parameters.AddWithValue("@a2", kelime.Turkce);
            update.Parameters.AddWithValue("@a3", kelime.Ingilizce);
            update.Parameters.AddWithValue("@a4", kelime.Turu);
            update.Parameters.AddWithValue("@a5", kelime.OrnCumle);
            update.Parameters.AddWithValue("@a6", kelime.TurkceCumle);
            update.Parameters.AddWithValue("@a7", kelime.Resim);
            update.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public override void KisiEkle() // Yeni yetkili kayıtı yap.
        {
            SqlCommand Ekle = new SqlCommand("insert into Tbl_Yetkili (YetkiliAd,Soyad,Telefon,Mail,KullaniciAdi,Sifre,Yetki) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", connect.baglanti());
            Ekle.Parameters.AddWithValue("@p1", Ad);
            Ekle.Parameters.AddWithValue("@p2", Soyad);
            Ekle.Parameters.AddWithValue("@p3", Telefon);
            Ekle.Parameters.AddWithValue("@p4", Mail);
            Ekle.Parameters.AddWithValue("@p5", KullaniciID);
            Ekle.Parameters.AddWithValue("@p6", Sifre);
            Ekle.Parameters.AddWithValue("@p7", Yetki);
            Ekle.ExecuteNonQuery();
            connect.baglanti().Close();
        }
        public override void KisiBilgiGetir(string kullaniciID) //Yetkilinin Bilgilerini Getir.
        {
            SqlCommand UyeBilgiGetir = new SqlCommand("Select * From Tbl_Yetkili where KullaniciAdi=@p1", connect.baglanti());
            UyeBilgiGetir.Parameters.AddWithValue("@p1", kullaniciAdi);
            SqlDataReader dr = UyeBilgiGetir.ExecuteReader();
            if (dr.Read())
            {
                Ad = dr[1].ToString();
                Soyad = dr[2].ToString();
                Mail = dr[4].ToString();
                Telefon = dr[3].ToString();
                KullaniciID = dr[5].ToString();
                Sifre = dr[6].ToString();
                Yetki = dr[7].ToString();
                YetkiliNo = Convert.ToInt32(dr[0]);
            }
        }
        public override void KisiBilgiGuncelle() //Yetkili bilgilerini Güncelle
        {
            SqlCommand UyeBilgiGuncelle = new SqlCommand("update Tbl_Yetkili set Telefon =@a1,Mail=@a2,Sifre=@a3 where YetkiliID=@a4", connect.baglanti());
            UyeBilgiGuncelle.Parameters.AddWithValue("@a1", Telefon);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a2", Mail);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a3", Sifre);
            UyeBilgiGuncelle.Parameters.AddWithValue("@a4", YetkiliNo);
            UyeBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
