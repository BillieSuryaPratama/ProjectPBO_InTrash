﻿namespace WinFormsApp1.Views
{
    partial class Ganti_Sandi_Admin
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
            tbPassBaru2 = new TextBox();
            tbPassBaru = new TextBox();
            tbPassLama = new TextBox();
            btnKembali = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblInstruksi = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // tbPassBaru2
            // 
            tbPassBaru2.Location = new Point(279, 189);
            tbPassBaru2.Margin = new Padding(2, 3, 2, 3);
            tbPassBaru2.Name = "tbPassBaru2";
            tbPassBaru2.PasswordChar = '*';
            tbPassBaru2.Size = new Size(193, 27);
            tbPassBaru2.TabIndex = 6;
            // 
            // tbPassBaru
            // 
            tbPassBaru.Location = new Point(279, 143);
            tbPassBaru.Margin = new Padding(2, 3, 2, 3);
            tbPassBaru.Name = "tbPassBaru";
            tbPassBaru.PasswordChar = '*';
            tbPassBaru.Size = new Size(193, 27);
            tbPassBaru.TabIndex = 5;
            // 
            // tbPassLama
            // 
            tbPassLama.Location = new Point(279, 96);
            tbPassLama.Margin = new Padding(2, 3, 2, 3);
            tbPassLama.Name = "tbPassLama";
            tbPassLama.PasswordChar = '*';
            tbPassLama.Size = new Size(193, 27);
            tbPassLama.TabIndex = 4;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(11, 309);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 40);
            btnKembali.TabIndex = 7;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(149, 99);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 10;
            label1.Text = "Sandi saat ini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(149, 145);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 11;
            label2.Text = "Sandi Baru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(149, 192);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 12;
            label3.Text = "Konfirmasi Sandi";
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 15F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(103, 28);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(502, 35);
            lblInstruksi.TabIndex = 14;
            lblInstruksi.Text = "Masukan kata sandi baru untuk melanjutkan";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.Location = new Point(262, 239);
            btnSimpan.Margin = new Padding(2, 3, 2, 3);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 44);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Ganti_Sandi_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(lblInstruksi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(tbPassBaru2);
            Controls.Add(tbPassBaru);
            Controls.Add(tbPassLama);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Ganti_Sandi_Admin";
            Text = "InTrash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassBaru2;
        private TextBox tbPassBaru;
        private TextBox tbPassLama;
        private Button btnKembali;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblInstruksi;
        private Button btnSimpan;
    }
}