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
        public int[] Kontrol = new int[100];
        double UyeId { get; set; }
        sqlBaglanti connect = new sqlBaglanti();
        public void OyunBilgileriniGetir(OyunOyna Oyunlar)
        {
            
            int sayac = 1;
            SqlCommand command = new SqlCommand("Select * From Tbl_Oyun where KullaniciID= @a1 ", connect.baglanti());
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
                    Kontrol[sayac] = Convert.ToInt32(Oyun.KelimeID);
                    sayac++;
                }
                else if(Oyun.KelimeSeviyesi == 5)
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
            Update.Parameters.AddWithValue("@p3", Oyun.Dt);
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
            insert.Parameters.AddWithValue("@a6", Oyun.Dt);
            insert.Parameters.AddWithValue("@a7", Oyun.KelimeSeviyesi);
            insert.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
