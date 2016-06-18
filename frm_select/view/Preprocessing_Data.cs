using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using frm_select.dao;

namespace frm_select.view
{
    public partial class Preprocessing_Data : DevExpress.XtraEditors.XtraUserControl
    {
        const string connection = @"server = 127.0.0.1; port = 3306; UID = root; PWD = ; database=miningcontin";
        MySqlConnection con = new MySqlConnection(connection);

        import_dao model = new import_dao();

        public Preprocessing_Data()
        {
            InitializeComponent();
        }

        DataTable atribut = new DataTable();
        private void btnAtribut_Click(object sender, EventArgs e)
        {
            #region add atribut
            try
            {
                string query = "select no_faktur, nama_item FROM dataawal";
                atribut = new DataTable();
                var cmd = con.CreateCommand();

                con.Open();
                cmd.CommandText = query;
                var reader = cmd.ExecuteReader();
                atribut.Load(reader);
                con.Close();
                gcAtribut.DataSource = atribut;

                MessageBox.Show("Selected Atribut Berhasil!");
            }
            catch (Exception)
            {
                MessageBox.Show("Selected Atribut Gagal!");
            }
            #endregion
        }

        DataTable cleaning = new DataTable();
        List<string> listITem = new List<string>();
        private void btnCleaning_Click(object sender, EventArgs e)
        {
            cleaning = new DataTable();
            cleaning.Columns.Add("Nomor Faktur", typeof(string));
            cleaning.Columns.Add("Nama Barang", typeof(string));
            listITem = new List<string>();
            //cleaning = atribut;
            #region Cleaning
            try
            {

                string query = "select no_faktur, count(*) as tot from dataawal group by no_faktur ";
                DataTable clean = new DataTable();
                var cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = query;
                var reader = cmd.ExecuteReader();
                clean.Load(reader);
                con.Close();

                for (int idx = 0; idx < clean.Rows.Count; idx++)
                {
                    if (Convert.ToInt16(clean.Rows[idx].ItemArray[1]) == 1)
                    {
                        listITem.Add(clean.Rows[idx].ItemArray[0].ToString());
                    }
                }
                query = "";
                for (int idx = 0; idx < atribut.Rows.Count; idx++)
                {
                    bool proses = true;
                    foreach (string item in listITem)
                    {
                        if (item == atribut.Rows[idx].ItemArray[0].ToString())
                        {
                            proses = false;
                        }
                    }
                    if (proses)
                    {
                        query += "insert into cleaning values('" + atribut.Rows[idx].ItemArray[0].ToString() + "', '" + atribut.Rows[idx].ItemArray[1].ToString() + "');";
                        cleaning.Rows.Add(atribut.Rows[idx].ItemArray[0].ToString(), atribut.Rows[idx].ItemArray[1].ToString());
                    }
                }

                gcCleaning.DataSource = cleaning;

                //input data cleaning
                try
                {
                    string query2 = "truncate cleaning";
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = query2;
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                }
                catch { con.Close(); }


                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = query;
                    reader = cmd.ExecuteReader();
                    reader.Close();
                    con.Close();
                }
                catch { con.Close(); }

                MessageBox.Show("Cleaning Data Berhasil!");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Cleaning Data Gagal!");
            }
            #endregion

            //pengkodean();
        }


        //frekuensi data barang
        List<string> DtKdBarang = new List<string>();
        List<string> DtNmBarang = new List<string>();
        private void btnFrequency_Click(object sender, EventArgs e)
        {
            //clear data frekuensi
            model.hapusDataFrekuensi();
            string query = "DELETE FROM frekuensi;" +
                           "SELECT DISTINCT a.Nama_Barang, b.kode_item FROM cleaning a, dataawal b where a.Nama_Barang=b.nama_item ORDER BY a.Nama_Barang;";
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();

            #region add data frequency
            query = "";
            DtKdBarang = new List<string>();
            DtNmBarang = new List<string>();
            try
            {
                while (reader.Read())
                {
                    DtKdBarang.Add((string)reader[1]);
                    DtNmBarang.Add((string)reader[0]);
                }
                reader.Close();

                for (var i = 0; i < DtKdBarang.Count; i++)
                {
                    query += "INSERT INTO frekuensi (kode_item, frekuensi) VALUES('" + DtKdBarang[i] + "', 0);";
                }

                //eksekusi query to database
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                reader.Close();

                query = "SELECT distinct a.kode_item, COUNT(*) AS frekuensi FROM dataawal a, cleaning b where a.nama_item =b.Nama_Barang GROUP BY a.kode_item ORDER BY frekuensi DESC";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                DtNmBarang = new List<string>();
                var listFreq = new List<int>();
                while (reader.Read())
                {
                    DtNmBarang.Add((string)reader[0]);
                    listFreq.Add(Convert.ToInt32((long)reader[1]));
                }
                reader.Close();

                query = "";
                for (var i = 0; i < listFreq.Count; i++)
                {
                    query += "UPDATE frekuensi set frekuensi = " + listFreq[i] + " WHERE kode_item = '" + DtNmBarang[i] + "';";
                }
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                reader.Close();

                query = "select distinct Nama_Barang, count(*) as frekuensi from cleaning group by Nama_Barang order by frekuensi DESC";
                cmd = con.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                var tableFreq = new DataTable();
                tableFreq.Columns.Add("Nama Barang");
                tableFreq.Columns.Add("Frekuensi");
                while (reader.Read())
                {
                    var id = (string)reader[0];
                    var freq = Convert.ToInt16(reader[1]) + "";
                    var arr = new object[] { id, freq };
                    tableFreq.Rows.Add(arr);
                }

                gcFreequency.DataSource = tableFreq;

                reader.Close();
                con.Close();

                MessageBox.Show("Hitung Frekuensi Kemunculan Item Berhasil!");
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Hitung Frekuensi Kemunculan Item Gagal!");
            }
            #endregion

            sortingData();
        }


        //sorting data
        List<Item> list = new List<Item>();
        List<Item> listDetail = new List<Item>();
        List<ItemSet> itemSet = new List<ItemSet>();
        List<string> listBilangan;
        public static List<Item> FrequentItems;
        public static List<ItemSet> ItemSetGlobal;

        private void sortingData()
        {
            //hapus data tabel tb_join
            model.hapusDataJoin();

            #region sorting data


            //input tabel join
            string query = "insert into tb_join select distinct a.Nomor_Faktur, a.Nama_Barang, b.kode_item  from cleaning a, dataawal b where a.Nama_Barang = b.nama_item";
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();
            con.Close();

            query = "select distinct no_faktur FROM tb_join";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            listBilangan = new List<string>();

            while (reader.Read())
            {
                listBilangan.Add(reader[0].ToString());
            }
            reader.Close();

            query = "select kode_item, nama_item , count(*) as frekuensi from tb_join where nama_item like 'Baju Taqwa%' or nama_item like 'Sajadah%' or nama_item like 'Sorban%' or nama_item like 'Tasbih%' or nama_item like 'Kerudung%' or nama_item like 'Mukena%' group by nama_item, kode_item order by nama_item asc";
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();

            listDetail = new List<Item>();
            while (reader.Read())
            {
                var freq = Convert.ToInt32(reader[2]);
                listDetail.Add(new Item((string)reader[0], (string)reader[1], freq));
            }
            reader.Close();
            con.Close();

            FrequentItems = listDetail;
            #endregion

            #region add sorting data
            try
            {
                list = new List<Item>();
                itemSet = new List<ItemSet>();
                con.Open();
                cmd = con.CreateCommand();
                foreach (var nobill in listBilangan)
                {
                    query = "SELECT kode_item FROM tb_join WHERE no_faktur = '" + nobill + "'";
                    cmd.CommandText = query;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var kodeBarang = (string)reader[0];
                        var itemz = FrequentItems.Find(o => o.Kode.Equals(kodeBarang));
                        if (itemz == null) continue;
                        var freqs = FrequentItems.Find(o => o.Kode.Equals(kodeBarang)).SupportCount;
                        var namaBarang = FrequentItems.Find(o => o.Kode.Equals(kodeBarang)).Symbol;

                        var item = new Item(kodeBarang, namaBarang, freqs);
                        list.Add(item);
                    }
                    reader.Close();
                    var set = new ItemSet(nobill, list);
                    if (list.Count > 1)
                    {
                        itemSet.Add(set);
                    }
                    list = new List<Item>();
                }

                var dt = new DataTable();
                dt.Columns.Add("No Transaksi");
                dt.Columns.Add("Barang");
                var items = "";

                foreach (var t in itemSet)
                {
                    t.Items = t.Items.OrderByDescending(o => o.SupportCount).ThenBy(x => x.Kode).ToList();
                    var row = t.Items;

                    items = row.Aggregate(items, (current, item) => current + (item.Kode + ", "));
                    items = items.Substring(0, items.Length - 2);
                    var arr = new object[] { t.Nobill, items };
                    dt.Rows.Add(arr);
                    items = "";
                }

                ItemSetGlobal = itemSet;

                con.Close();
                //MessageBox.Show("Sorting Data Berhasil!");
            }
            catch (Exception)
            {
                // MessageBox.Show("Sorting Data Gagal!");
            }
            #endregion
        }


    }
}
