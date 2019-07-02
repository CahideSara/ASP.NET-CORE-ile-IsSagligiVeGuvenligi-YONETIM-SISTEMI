using bitproje.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace bitproje.Utility
{
    public class baglantiSinifi
    {
     public   SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PME6V4T;Initial Catalog=isg;Integrated Security=True");
       

        public int baglanti(String islem,String sorgu)
        {
            baglan.Open();
            int a = 0;
            if (islem == "ekleme")
            {
             SqlCommand cmd = new SqlCommand(sorgu, baglan);
                cmd.ExecuteNonQuery();
                
            }
           else  if (islem == "güncelle")
            {
                SqlCommand cmd = new SqlCommand(sorgu, baglan);
                cmd.ExecuteNonQuery();
               
            }
            else if (islem == "kullanıcıfirmacıkar")
            {
                SqlCommand cmd = new SqlCommand(sorgu, baglan);
                cmd.ExecuteNonQuery();

            }

            if (islem == "bulgrubu")
            {
               
                SqlCommand cmd = new SqlCommand("select TOP 1 (grup_id) from firmagruplari ORDER BY grup_id DESC", baglan);
                SqlDataReader r = cmd.ExecuteReader();
                
               
                while (r.Read())
                {
                    a = r["grup_id"].GetHashCode();
                    
                }
               
            }
            if (islem == "bulfirma")
            {

                SqlCommand cmd = new SqlCommand("select TOP 1 (firmaid) from firma ORDER BY firmaid DESC", baglan);
                SqlDataReader r = cmd.ExecuteReader();


                while (r.Read())
                {
                    a = r["firmaid"].GetHashCode();

                }

            }
            


                 if (islem == "bulkul")
            {

                SqlCommand cmd = new SqlCommand("select TOP 1 (sicilno) from kullanici ORDER BY sicilno DESC", baglan);
                SqlDataReader r = cmd.ExecuteReader();


                while (r.Read())
                {
                    a = r["sicilno"].GetHashCode();

                }

            }


            baglan.Close();
            return a;
        }
        

        public SqlCommand listele(String liste, SqlConnection baglan)
        {
            SqlCommand cmd = new SqlCommand(liste, baglan);
            return cmd;
        }
        

    }
}
