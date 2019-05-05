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
        private string kullaniciAdi;

        public Uye(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
        }

        double UyeId { get; set; }
        sqlBaglanti connect = new sqlBaglanti();
        public void OyunBilgileriniGetir(OyunOyna Oyunlar)
        {
            
            int sayac = 1;
            SqlCommand command = new SqlCommand("Select * From Tbl_KimBilmis where KullaniciID= @a1 ", connect.baglanti());
            command.Parameters.AddWithValue("@a1", kullaniciAdi);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                OyunOyna Oyun = new OyunOyna();
                Oyun.KelimeSira = sayac;
                Oyun.KelimeID = Convert.ToInt32( dr[0]);
                Oyun.Kelime = dr[1].ToString();
                Oyun.Ingilizce = dr[2].ToString();
                Oyun.Resim = dr[3].ToString();
                Oyun.Dt = Convert.ToDateTime(dr[5]);
                Oyun.KelimeSeviyesi = Convert.ToInt32(dr[6]);
                if(Oyun.ZamanHesapla(Oyun.Dt, Oyun.KelimeSeviyesi)==true)
                {
                    Oyunlar.Game.Add(Oyun);
                    sayac++;
                }   
                
            }
            connect.baglanti().Close();
        }
        public void OyunBilgileriniKaydet(OyunOyna Oyun)
        {
            SqlCommand Update = new SqlCommand("Update Tbl_KimBilmis set Tarih=@p3,Kademe=@p4 where KullaniciID=@p2,KelimeID=@p1");
            Update.Parameters.AddWithValue("@p1", Oyun.KelimeID);
            Update.Parameters.AddWithValue("@a2", Oyun.KullanıcıID);
            Update.Parameters.AddWithValue("@a3", Oyun.Dt);
            Update.Parameters.AddWithValue("@a4", Oyun.KelimeSeviyesi);
            Update.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
