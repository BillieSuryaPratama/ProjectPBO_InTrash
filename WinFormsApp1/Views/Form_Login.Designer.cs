﻿namespace WinFormsApp1.Views
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSignUp = new Button();
            gbLoginSebagai = new GroupBox();
            rbKurir = new RadioButton();
            rbNasabah = new RadioButton();
            rbAdmin = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            btnLupaPassword = new Button();
            gbLoginSebagai.SuspendLayout();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackgroundImage = Properties.Resources.Wireframe___56;
            btnSignUp.Location = new Point(341, 292);
            btnSignUp.Margin = new Padding(2, 3, 2, 3);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 41);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // gbLoginSebagai
            // 
            gbLoginSebagai.BackColor = Color.Transparent;
            gbLoginSebagai.Controls.Add(rbKurir);
            gbLoginSebagai.Controls.Add(rbNasabah);
            gbLoginSebagai.Controls.Add(rbAdmin);
            gbLoginSebagai.ForeColor = Color.White;
            gbLoginSebagai.Location = new Point(190, 20);
            gbLoginSebagai.Margin = new Padding(2, 3, 2, 3);
            gbLoginSebagai.Name = "gbLoginSebagai";
            gbLoginSebagai.Padding = new Padding(2, 3, 2, 3);
            gbLoginSebagai.Size = new Size(240, 132);
            gbLoginSebagai.TabIndex = 7;
            gbLoginSebagai.TabStop = false;
            gbLoginSebagai.Text = "Login Sebagai";
            // 
            // rbKurir
            // 
            rbKurir.AutoSize = true;
            rbKurir.Location = new Point(27, 91);
            rbKurir.Name = "rbKurir";
            rbKurir.Size = new Size(61, 24);
            rbKurir.TabIndex = 10;
            rbKurir.TabStop = true;
            rbKurir.Text = "Kurir";
            rbKurir.UseVisualStyleBackColor = true;
            // 
            // rbNasabah
            // 
            rbNasabah.AutoSize = true;
            rbNasabah.Location = new Point(27, 61);
            rbNasabah.Margin = new Padding(2, 3, 2, 3);
            rbNasabah.Name = "rbNasabah";
            rbNasabah.Size = new Size(88, 24);
            rbNasabah.TabIndex = 9;
            rbNasabah.TabStop = true;
            rbNasabah.Text = "Nasabah";
            rbNasabah.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(27, 33);
            rbAdmin.Margin = new Padding(2, 3, 2, 3);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(74, 24);
            rbAdmin.TabIndex = 8;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 167);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(187, 204);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(273, 165);
            tbUsername.Margin = new Padding(2, 3, 2, 3);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(156, 27);
            tbUsername.TabIndex = 10;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(273, 204);
            tbPassword.Margin = new Padding(2, 3, 2, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(156, 27);
            tbPassword.TabIndex = 11;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Red;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(190, 292);
            btnLogIn.Margin = new Padding(2, 3, 2, 3);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(90, 41);
            btnLogIn.TabIndex = 12;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // btnLupaPassword
            // 
            btnLupaPassword.BackColor = Color.Transparent;
            btnLupaPassword.Location = new Point(191, 240);
            btnLupaPassword.Margin = new Padding(2, 3, 2, 3);
            btnLupaPassword.Name = "btnLupaPassword";
            btnLupaPassword.Size = new Size(240, 47);
            btnLupaPassword.TabIndex = 13;
            btnLupaPassword.Text = "Lupa Password";
            btnLupaPassword.UseVisualStyleBackColor = false;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Wireframe___55;
            ClientSize = new Size(640, 360);
            Controls.Add(btnLupaPassword);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbLoginSebagai);
            Controls.Add(btnSignUp);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form_Login";
            Text = "InTrash";
            Load += Form1_Load;
            gbLoginSebagai.ResumeLayout(false);
            gbLoginSebagai.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignUp;
        private GroupBox gbLoginSebagai;
        private RadioButton rbNasabah;
        private RadioButton rbAdmin;
        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogIn;
        private RadioButton rbKurir;
        private Button btnLupaPassword;
    }
}