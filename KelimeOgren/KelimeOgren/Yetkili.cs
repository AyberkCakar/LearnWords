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

        string Yetki { get; set; }
        double YetkiliId { get; set; }
        sqlBaglanti connect = new sqlBaglanti();
        public void KelimeEkle(Kelime kelime)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Kelime(Kelime,İngilizcesi,Türü,OrnCümle,OrnCümleTürk,Resim) values(@a1, @a2, @a3, @a4, @a5, @a6)", connect.baglanti() );
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
            SqlCommand update = new SqlCommand("update Tbl_Kelime set Kelime=@a2,İngilizcesi=@a3,Türü=@a4,OrnCümle=@a5,OrnCümleTürk=@a6,Resim=@a7 where KelimeId=@a1 ", connect.baglanti());
            update.Parameters.AddWithValue("@a1", kelime.KelimeId);
            update.Parameters.AddWithValue("@a2", kelime.Turkce);
            update.Parameters.AddWithValue("@a3", kelime.Ingilizce);
            update.Parameters.AddWithValue("@a4", kelime.Turu);
            update.Parameters.AddWithValue("@a5", kelime.OrnCumle);
            update.Parameters.AddWithValue("@a6", kelime.TurkceCumle);
            update.Parameters.AddWithValue("@a7", kelime.Resim);
        }
    }
}
