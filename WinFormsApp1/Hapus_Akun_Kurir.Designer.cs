﻿namespace WinFormsApp1
{
    partial class Hapus_Akun_Kurir
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
            btnKonfirmasi = new Button();
            btnKembali = new Button();
            tbID = new TextBox();
            dgvListKurir = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            tbSandi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).BeginInit();
            SuspendLayout();
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(520, 309);
            btnKonfirmasi.Margin = new Padding(2);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(106, 27);
            btnKonfirmasi.TabIndex = 50;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(10, 313);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 49;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // tbID
            // 
            tbID.Location = new Point(295, 250);
            tbID.Margin = new Padding(2);
            tbID.Name = "tbID";
            tbID.Size = new Size(166, 27);
            tbID.TabIndex = 48;
            // 
            // dgvListKurir
            // 
            dgvListKurir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListKurir.Location = new Point(35, 8);
            dgvListKurir.Margin = new Padding(2);
            dgvListKurir.Name = "dgvListKurir";
            dgvListKurir.RowHeadersWidth = 62;
            dgvListKurir.Size = new Size(575, 225);
            dgvListKurir.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 253);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 51;
            label1.Text = "ID Kurir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 284);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 52;
            label2.Text = "Sandi Kurir";
            // 
            // tbSandi
            // 
            tbSandi.Location = new Point(295, 281);
            tbSandi.Margin = new Padding(2);
            tbSandi.Name = "tbSandi";
            tbSandi.Size = new Size(166, 27);
            tbSandi.TabIndex = 53;
            // 
            // Hapus_Akun_Kurir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 347);
            Controls.Add(tbSandi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKonfirmasi);
            Controls.Add(btnKembali);
            Controls.Add(tbID);
            Controls.Add(dgvListKurir);
            Name = "Hapus_Akun_Kurir";
            Text = "Hapus_Akun_Kurir";
            ((System.ComponentModel.ISupportInitialize)dgvListKurir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKonfirmasi;
        private Button btnKembali;
        private TextBox tbID;
        private DataGridView dgvListKurir;
        private Label label1;
        private Label label2;
        private TextBox tbSandi;
    }
}