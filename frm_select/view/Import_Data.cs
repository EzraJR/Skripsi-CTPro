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
using System.Threading;

namespace frm_select.view
{
    public partial class Import_Data : DevExpress.XtraEditors.XtraUserControl
    {
        const string connection = @"server = 127.0.0.1; port = 3306; UID = root; PWD = ; database=miningcontin";
        MySqlConnection _conn = new MySqlConnection(connection);

        import_dao model = new import_dao();

        public Import_Data()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
            {
                // menjalankan backgroundworker
                backgroundWorker1.RunWorkerAsync();
            }
        }

        //============================= tombol cari ===================
        #region tombol cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            //open file dialog pencarian direktori file
            var op1 = new OpenFileDialog
            {
                Title = @"Select File",
                InitialDirectory = @"C:\Users\M Deden Kertawijaya\Documents",
                FileName = teFile.Text,
                Filter = @"Excel Sheet (*.xlsx)|*.xlsx|All Files(*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (op1.ShowDialog() == DialogResult.OK)
            {
                teFile.Text = op1.FileName;
                Application.DoEvents();
            }
            generate();
        }
        #endregion

        //generate file to data grid
        DataTable dtAwal = new DataTable();
        private void generate() 
        {
            dtAwal = new DataTable();
            try
            {
                var constr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                teFile.Text +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
                const string sheet = "Sheet1";
                var con = new OleDbConnection(constr);
                var sda = new OleDbDataAdapter("SELECT * from [" + sheet + "$]", con);
                var dt = new DataTable();
                sda.Fill(dt);

                gvDT.Columns.Clear();
                gcDT.DataSource = dt;
                dtAwal = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //==================== method save data

        private void simpan_data()
        {
            var recordLength = dtAwal.Rows.Count;
            var query = "";

            _conn.Open();
            var cmd = _conn.CreateCommand();
            for (var i = 0; i < recordLength; i++)
            {
                query += "INSERT INTO dataawal(nomor, no_faktur, tgl, customer, status, kode_item, nama_item, size, qty)" +
                         " values(" +
                           "" + (i + 1) + ", " +
                          "'" + dtAwal.Rows[i].ItemArray[1] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[2] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[3] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[4] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[5] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[6] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[7] + "', " +
                          "'" + dtAwal.Rows[i].ItemArray[8] + "');";
            }
            cmd.CommandText = query;
            cmd.ExecuteReader();
            _conn.Close();

            
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            

            for (int j = 0; j < 2; j++)
            {
                string status = "";
                if (j == 0)
                {
                    #region delete history
                    status = "delete histori data dari database!";
                    //clear histori data awal
                    model.hapusDataAwal();
                    #endregion

                }
                else
                {
                    status = "Save data transaksi baru!";
                    try
                    {
                        #region save data
                        //simpan data
                        simpan_data();
                        #endregion
                    }
                    catch
                    { _conn.Close(); }
                }

                // memperbarui reportprogress
                backgroundWorker1.ReportProgress((j == 1) ? 100 : 60, status);

                System.Threading.Thread.Sleep(100);

                // jika backgroundWorker1 di batalkan
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = Convert.ToInt16(e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true) // jika backgroundWorker1 dibatalkan
            {
                MessageBox.Show("Data Gagal Disimpan!");
                progressBar1.Visible = false;
            }
            else if (e.Error != null) // jika terjadi error selama backgroundworker berjalan
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                MessageBox.Show("Data berhasil disimpan!");
                // gcDT.DataSource = dtGrid;
                progressBar1.Visible = false;
            }
        }

        private void Import_Data_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.WorkerReportsProgress = true;
        }

     
    }
}
