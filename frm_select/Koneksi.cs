using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace frm_select
{
   public class Koneksi
    {
     public  MySqlCommand cmd = new MySqlCommand();
      public MySqlDataAdapter adp = new MySqlDataAdapter();
       string konfigurasi = "server=localhost;User Id=root;database=db_penjualan";
      public MySqlConnection connection;

       public void openkoneksi()
       {
           try
           {
               connection = new MySqlConnection(konfigurasi);
               connection.Open();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error: "+ex.Message);
               throw;
           }
       }

    }
}
