﻿namespace WinFormsApp1
{
    partial class Informasi_Sampah
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
            dgvInformasiSampah = new DataGridView();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).BeginInit();
            SuspendLayout();
            // 
            // dgvInformasiSampah
            // 
            dgvInformasiSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInformasiSampah.Location = new Point(23, 20);
            dgvInformasiSampah.Margin = new Padding(2);
            dgvInformasiSampah.Name = "dgvInformasiSampah";
            dgvInformasiSampah.RowHeadersWidth = 62;
            dgvInformasiSampah.Size = new Size(592, 260);
            dgvInformasiSampah.TabIndex = 10;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(23, 313);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 26;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // Informasi_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnKembali);
            Controls.Add(dgvInformasiSampah);
            Margin = new Padding(2);
            Name = "Informasi_Sampah";
            Text = "InTrash";
            ((System.ComponentModel.ISupportInitialize)dgvInformasiSampah).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvInformasiSampah;
        private Button btnKembali;
    }
}