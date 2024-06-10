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
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Form_Login_Kurir : Form
    {
        public static string UsernameLogin { get; private set; }
        public static string PasswordLogin { get; private set; }

        public Form_Login_Kurir()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opsi_Login nextpage = new Opsi_Login();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DBConnection.openConn();
            string query = @"SELECT COUNT (*)
                            FROM Kurir
                            WHERE Username_Kurir = @Username and Password_Kurir = @Password";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                cmd.Parameters.AddWithValue("password", tbPassword.Text);
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount == 1)
                {
                    UsernameLogin = tbUsername.Text;
                    PasswordLogin = tbPassword.Text;

                    this.Hide();
                    Beranda_Kurir nextpage = new Beranda_Kurir();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mohon isi Username dan Password anda dengan Benar!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLupaPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lupa_Password_Kurir nextpage = new Lupa_Password_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}