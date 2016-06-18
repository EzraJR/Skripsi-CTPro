using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace frm_select.dao
{
    class import_dao
    {
        string connf = "server = 127.0.0.1;" +
        "port = 3306;" +
        "UID = root;" +
        "PWD = ;" +
        "database = miningcontin";
        MySqlConnection conn = new MySqlConnection();

        public import_dao() { conn.ConnectionString = connf; }

        public void hapusDataAwal()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string query = "TRUNCATE dataawal";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void hapusDataKode()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string query = "TRUNCATE kodeitem";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void hapusDataFrekuensi()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string query = "TRUNCATE frekuensi";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void hapusDataJoin()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string query = "TRUNCATE tb_join";
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
