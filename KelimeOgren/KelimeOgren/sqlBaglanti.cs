using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KelimeOgren
{
    public class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-CCP65NT\SQLEXPRESS;Initial Catalog=KelimeOgren;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
