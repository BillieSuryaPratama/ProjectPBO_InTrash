﻿namespace WinFormsApp1
{
    partial class Setor_Sampah
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnBerikutnya = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            btnKembali = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 51);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 27);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 81);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 27);
            textBox3.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(255, 112);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 33;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(255, 22);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 37;
            // 
            // btnBerikutnya
            // 
            btnBerikutnya.Location = new Point(539, 322);
            btnBerikutnya.Margin = new Padding(2);
            btnBerikutnya.Name = "btnBerikutnya";
            btnBerikutnya.Size = new Size(90, 27);
            btnBerikutnya.TabIndex = 40;
            btnBerikutnya.Text = "Berikutnya";
            btnBerikutnya.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(382, 154);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(134, 27);
            button4.TabIndex = 42;
            button4.Text = "Tambah Sampah";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 185);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(394, 99);
            dataGridView1.TabIndex = 43;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(11, 322);
            btnKembali.Margin = new Padding(2);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(90, 27);
            btnKembali.TabIndex = 44;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 27);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 45;
            label2.Text = "Tanggal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 54);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 46;
            label3.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 84);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 47;
            label4.Text = "Deskripsi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 115);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 48;
            label1.Text = "Metode Pencairan";
            // 
            // Setor_Sampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnKembali);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(btnBerikutnya);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Margin = new Padding(2);
            Name = "Setor_Sampah";
            Text = "InTrash";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnBerikutnya;
        private Button button4;
        private DataGridView dataGridView1;
        private Button btnKembali;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}