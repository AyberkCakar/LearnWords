using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class GirisServisi
    {
        public static bool KullaniciUyeDogrula(string kullaniciAdi,string sifre) // Üye adi şifre kontrolü
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Uye where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            komut.Parameters.AddWithValue("@p1",kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        public static bool KullaniciYetkiliDogrula(string kullaniciAdi, string sifre)// Yetkili adi şifre kontrolü
        {
            sqlBaglanti connect = new sqlBaglanti();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yetkili where KullaniciAdi =@p1 and Sifre = @p2", connect.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciAdi);
            komut.Parameters.AddWithValue("@p2", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public  Kisi GirisYap(string kullaniciAdi,string sifre) //Üye giriş yapma
        {
            if (KullaniciUyeDogrula(kullaniciAdi, sifre))
            {
                return new Uye(kullaniciAdi);
            }    
            else
            {
                return null;  
            }
        }
        public  Kisi GirisYapYetkili(string kullaniciAdi, string sifre) // Yetkili Giriş Yapma
        {
            if (KullaniciYetkiliDogrula(kullaniciAdi, sifre))
            {
                return new Yetkili(kullaniciAdi);
            }
            else
            {
                return null;
            }              
        }
    }
}
