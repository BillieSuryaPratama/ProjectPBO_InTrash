﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Riwayat_Nasbah : Form
    {
        public Riwayat_Nasbah()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void Riwayat_Nasbah_Load(object sender, EventArgs e)
        {
            int idCustomer = GetCurrentCustomerId();

            LoadTransactionHistory(idCustomer);
        }

        private int GetCurrentCustomerId()
        {
            return 1;
        }

        private void LoadTransactionHistory(int idCustomer)
        {
            dgvRiwayatTransaksi.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Jumlah Imbalan", typeof(int));
            dataTable.Columns.Add("Nama Tempat Pengepul", typeof(string));
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();

                string query = @"SELECT 
                            t.id_transaksi, 
                            t.tanggal_transaksi, 
                            t.jumlah_imbalan, 
                            tp.nama_tempat AS tempat_pengepul, 
                            st.status AS status_transaksi
                         FROM transaksi t
                         JOIN tempatpengepul tp ON t.id_tempatpengepul = tp.id_tempatpengepul
                         JOIN status_transaksi st ON t.id_statustransaksi = st.id_statustransaksi
                         WHERE t.id_customer = @idCustomer";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idCustomer", idCustomer);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["jumlah_imbalan"], reader["tempat_pengepul"], reader["status_transaksi"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Jumlah Imbalan";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Nama Tempat Pengepul";
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Status Transaksi";

            try
            {
                DBConnection.openConn();

                string queryTahun = @"SELECT DISTINCT EXTRACT(YEAR FROM tanggal_transaksi) AS tahun
                                      FROM transaksi
                                      ORDER BY tahun";

                using (var cmdTahun = new NpgsqlCommand(queryTahun, DBConnection.connection))
                using (var readerTahun = cmdTahun.ExecuteReader())
                {
                    var tahunList = new List<int>();
                    while (readerTahun.Read())
                    {
                        int tahun = readerTahun.GetInt32(0);
                        tahunList.Add(tahun);
                    }

                    cbPerTahun.DataSource = tahunList;
                }

                string queryBulan = @"SELECT DISTINCT TO_CHAR(tanggal_transaksi, 'MM/YYYY') AS bulan_tahun
                                      FROM transaksi
                                      ORDER BY bulan_tahun";

                using (var cmdBulan = new NpgsqlCommand(queryBulan, DBConnection.connection))
                using (var readerBulan = cmdBulan.ExecuteReader())
                {
                    var bulanList = new List<string>();
                    while (readerBulan.Read())
                    {
                        string bulanTahun = readerBulan.GetString(0);
                        bulanList.Add(bulanTahun);
                    }

                    cbPerBulan.DataSource = bulanList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }
        }



        private void btnBulan_Click(object sender, EventArgs e)
        {
            int idCustomer = GetCurrentCustomerId();

            dgvRiwayatTransaksi.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Jumlah Imbalan", typeof(int));
            dataTable.Columns.Add("Nama Tempat Pengepul", typeof(string));
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();

                string BulanTahun = (string)cbPerBulan.SelectedItem;
                var SplitBulanTahun = BulanTahun.Split('/');
                int Bulan = int.Parse(SplitBulanTahun[0]);
                int Tahun = int.Parse(SplitBulanTahun[1]);
                string query = @"SELECT 
             t.id_transaksi, 
             t.tanggal_transaksi, 
             t.jumlah_imbalan, 
             tp.nama_tempat AS tempat_pengepul, 
             st.status AS status_transaksi
          FROM transaksi t
          JOIN tempatpengepul tp ON t.id_tempatpengepul = tp.id_tempatpengepul
          JOIN status_transaksi st ON t.id_statustransaksi = st.id_statustransaksi
          WHERE t.id_customer = @idCustomer
          AND EXTRACT(YEAR FROM t.tanggal_transaksi) = @tahun 
          AND EXTRACT(MONTH FROM t.tanggal_transaksi) = @bulan";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idCustomer", idCustomer);
                    cmd.Parameters.AddWithValue("@tahun", Tahun);
                    cmd.Parameters.AddWithValue("@bulan", Bulan);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["jumlah_imbalan"], reader["tempat_pengepul"], reader["status_transaksi"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Jumlah Imbalan";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Nama Tempat Pengepul";
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Status Transaksi";
        }

        private void btnTahun_Click(object sender, EventArgs e)
        {
            int idCustomer = GetCurrentCustomerId();

            dgvRiwayatTransaksi.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Jumlah Imbalan", typeof(int));
            dataTable.Columns.Add("Tempat Pengepul", typeof(string)); // Menyesuaikan dengan nama kolom yang digunakan dalam query SQL
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();

                int Tahun = (int)cbPerTahun.SelectedItem;
                string query = @"SELECT 
                t.id_transaksi, 
                t.tanggal_transaksi, 
                t.jumlah_imbalan, 
                tp.nama_tempat AS tempat_pengepul, 
                st.status AS status_transaksi
             FROM transaksi t
             JOIN tempatpengepul tp ON t.id_tempatpengepul = tp.id_tempatpengepul
             JOIN status_transaksi st ON t.id_statustransaksi = st.id_statustransaksi
             WHERE t.id_customer = @idCustomer
             AND EXTRACT(YEAR FROM t.tanggal_transaksi) = @tahun";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idCustomer", idCustomer);
                    cmd.Parameters.AddWithValue("@tahun", Tahun);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["jumlah_imbalan"], reader["tempat_pengepul"], reader["status_transaksi"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Jumlah Imbalan";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Tempat Pengepul"; 
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Status Transaksi";
        }

    }

}



