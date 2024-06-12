﻿namespace WinFormsApp1.Views
{
    partial class Profil_Nasabah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUbahSandi = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbGender = new ComboBox();
            btnKembali = new Button();
            btnSimpan = new Button();
            dtpTanggalLahir = new DateTimePicker();
            tbAlamat = new TextBox();
            tbEmail = new TextBox();
            tbNomorHP = new TextBox();
            tbNama = new TextBox();
            SuspendLayout();
            // 
            // btnUbahSandi
            // 
            btnUbahSandi.BackgroundImage = Properties.Resources.Wireframe___56;
            btnUbahSandi.Font = new Font("Segoe UI", 10F);
            btnUbahSandi.Location = new Point(341, 370);
            btnUbahSandi.Margin = new Padding(4);
            btnUbahSandi.Name = "btnUbahSandi";
            btnUbahSandi.Size = new Size(118, 36);
            btnUbahSandi.TabIndex = 64;
            btnUbahSandi.Text = "Ubah Sandi";
            btnUbahSandi.UseVisualStyleBackColor = true;
            btnUbahSandi.Click += btnUbahSandi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(158, 315);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 30);
            label8.TabIndex = 63;
            label8.Text = "Alamat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(158, 261);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 30);
            label7.TabIndex = 62;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(154, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 30);
            label6.TabIndex = 61;
            label6.Text = "Nomor HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(154, 151);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 60;
            label5.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(154, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 59;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 58;
            label2.Text = "Nama";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(330, 94);
            cbGender.Margin = new Padding(2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(333, 33);
            cbGender.TabIndex = 57;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(14, 402);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 56;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LimeGreen;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(674, 402);
            btnSimpan.Margin = new Padding(2);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 55;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(331, 145);
            dtpTanggalLahir.Margin = new Padding(2);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(332, 31);
            dtpTanggalLahir.TabIndex = 54;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(330, 311);
            tbAlamat.Margin = new Padding(2);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(332, 31);
            tbAlamat.TabIndex = 53;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(330, 258);
            tbEmail.Margin = new Padding(2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(332, 31);
            tbEmail.TabIndex = 52;
            // 
            // tbNomorHP
            // 
            tbNomorHP.Location = new Point(330, 199);
            tbNomorHP.Margin = new Padding(2);
            tbNomorHP.Name = "tbNomorHP";
            tbNomorHP.Size = new Size(332, 31);
            tbNomorHP.TabIndex = 51;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(330, 42);
            tbNama.Margin = new Padding(2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(333, 31);
            tbNama.TabIndex = 50;
            // 
            // Profil_Nasabah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUbahSandi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbGender);
            Controls.Add(btnKembali);
            Controls.Add(btnSimpan);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(tbAlamat);
            Controls.Add(tbEmail);
            Controls.Add(tbNomorHP);
            Controls.Add(tbNama);
            Margin = new Padding(2);
            Name = "Profil_Nasabah";
            Text = "InTrash";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUbahSandi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox cbGender;
        private Button btnKembali;
        private Button btnSimpan;
        private DateTimePicker dtpTanggalLahir;
        private TextBox tbAlamat;
        private TextBox tbEmail;
        private TextBox tbNomorHP;
        private TextBox tbNama;
    }
}