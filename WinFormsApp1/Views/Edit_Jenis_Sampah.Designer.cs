﻿namespace WinFormsApp1.Views
{
    partial class Edit_Jenis_Sampah
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
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            tbJenisSampah = new TextBox();
            tbDeskripsi = new TextBox();
            lblInstruksi = new Label();
            btnKembali = new Button();
            btnSimpan = new Button();
            tbHarga = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 205);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 68;
            label3.Text = "Deskripsi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 161);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 67;
            label2.Text = "Harga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(162, 111);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 66;
            label5.Text = "Jenis Sampah";
            // 
            // tbJenisSampah
            // 
            tbJenisSampah.Location = new Point(270, 110);
            tbJenisSampah.Margin = new Padding(2, 3, 2, 3);
            tbJenisSampah.Name = "tbJenisSampah";
            tbJenisSampah.Size = new Size(222, 27);
            tbJenisSampah.TabIndex = 65;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(270, 202);
            tbDeskripsi.Margin = new Padding(2, 3, 2, 3);
            tbDeskripsi.Multiline = true;
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(222, 82);
            tbDeskripsi.TabIndex = 63;
            // 
            // lblInstruksi
            // 
            lblInstruksi.AutoSize = true;
            lblInstruksi.BackColor = Color.Transparent;
            lblInstruksi.Font = new Font("Segoe UI", 16F);
            lblInstruksi.ForeColor = Color.White;
            lblInstruksi.Location = new Point(151, 45);
            lblInstruksi.Name = "lblInstruksi";
            lblInstruksi.Size = new Size(357, 37);
            lblInstruksi.TabIndex = 61;
            lblInstruksi.Text = "Masukkan data jenis sampah";
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Red;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(18, 292);
            btnKembali.Margin = new Padding(2, 3, 2, 3);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 40);
            btnKembali.TabIndex = 70;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.MediumTurquoise;
            btnSimpan.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSimpan.ForeColor = Color.Black;
            btnSimpan.Location = new Point(530, 295);
            btnSimpan.Margin = new Padding(2, 3, 2, 3);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(90, 36);
            btnSimpan.TabIndex = 71;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(270, 157);
            tbHarga.Margin = new Padding(2, 3, 2, 3);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(222, 27);
            tbHarga.TabIndex = 72;
            // 
            // Edit_Jenis_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(638, 347);
            Controls.Add(tbHarga);
            Controls.Add(btnSimpan);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(tbJenisSampah);
            Controls.Add(tbDeskripsi);
            Controls.Add(lblInstruksi);
            Name = "Edit_Jenis_Sampah";
            Text = "InTrash";
            Load += Edit_Jenis_Sampah_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox tbJenisSampah;
        private TextBox tbNomorHP;
        private TextBox tbDeskripsi;
        private TextBox tbSandi;
        private Label lblInstruksi;
        private Button btnKembali;
        private Button btnSimpan;
        private TextBox tbHarga;
    }
}