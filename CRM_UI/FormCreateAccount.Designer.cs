﻿namespace CRM_UI
{
    partial class FormCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateAccount));
            buttonCreateAccount = new Button();
            panel1 = new Panel();
            labelText1 = new Label();
            labelTitulo2 = new Label();
            pBoxFondo2 = new PictureBox();
            tBoxUsername = new TextBox();
            tBoxName = new TextBox();
            tBoxLastName = new TextBox();
            tBoxEmal = new TextBox();
            tBoxPassword = new TextBox();
            tBoxConfirmPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxFondo2).BeginInit();
            SuspendLayout();
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Anchor = AnchorStyles.None;
            buttonCreateAccount.BackColor = Color.Lavender;
            buttonCreateAccount.Cursor = Cursors.Hand;
            buttonCreateAccount.FlatAppearance.BorderColor = Color.White;
            buttonCreateAccount.FlatAppearance.BorderSize = 2;
            buttonCreateAccount.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCreateAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonCreateAccount.FlatStyle = FlatStyle.Flat;
            buttonCreateAccount.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateAccount.ForeColor = Color.SlateBlue;
            buttonCreateAccount.Location = new Point(482, 551);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(201, 82);
            buttonCreateAccount.TabIndex = 1;
            buttonCreateAccount.Text = "Sign In";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tBoxConfirmPassword);
            panel1.Controls.Add(tBoxPassword);
            panel1.Controls.Add(tBoxEmal);
            panel1.Controls.Add(tBoxLastName);
            panel1.Controls.Add(tBoxName);
            panel1.Controls.Add(tBoxUsername);
            panel1.Controls.Add(labelText1);
            panel1.Controls.Add(labelTitulo2);
            panel1.Controls.Add(buttonCreateAccount);
            panel1.Controls.Add(pBoxFondo2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 700);
            panel1.TabIndex = 2;
            // 
            // labelText1
            // 
            labelText1.Anchor = AnchorStyles.None;
            labelText1.AutoSize = true;
            labelText1.BackColor = Color.Transparent;
            labelText1.FlatStyle = FlatStyle.Flat;
            labelText1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelText1.ForeColor = Color.White;
            labelText1.Location = new Point(187, 163);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(794, 30);
            labelText1.TabIndex = 4;
            labelText1.Text = "Ingrese los datos correspondientes para la creación de su cuenta";
            labelText1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTitulo2
            // 
            labelTitulo2.Anchor = AnchorStyles.None;
            labelTitulo2.AutoSize = true;
            labelTitulo2.BackColor = Color.Transparent;
            labelTitulo2.FlatStyle = FlatStyle.Flat;
            labelTitulo2.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo2.ForeColor = Color.White;
            labelTitulo2.Location = new Point(355, 39);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(457, 115);
            labelTitulo2.TabIndex = 3;
            labelTitulo2.Text = "OPUNTIA";
            labelTitulo2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pBoxFondo2
            // 
            pBoxFondo2.Dock = DockStyle.Fill;
            pBoxFondo2.Image = (Image)resources.GetObject("pBoxFondo2.Image");
            pBoxFondo2.Location = new Point(0, 0);
            pBoxFondo2.Name = "pBoxFondo2";
            pBoxFondo2.Size = new Size(1167, 700);
            pBoxFondo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxFondo2.TabIndex = 2;
            pBoxFondo2.TabStop = false;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Anchor = AnchorStyles.None;
            tBoxUsername.BackColor = Color.Lavender;
            tBoxUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(217, 462);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.PlaceholderText = "Username";
            tBoxUsername.Size = new Size(288, 31);
            tBoxUsername.TabIndex = 5;
            tBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxName
            // 
            tBoxName.Anchor = AnchorStyles.None;
            tBoxName.BackColor = Color.Lavender;
            tBoxName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxName.Location = new Point(217, 272);
            tBoxName.Name = "tBoxName";
            tBoxName.PlaceholderText = "Name";
            tBoxName.Size = new Size(288, 31);
            tBoxName.TabIndex = 6;
            tBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxLastName
            // 
            tBoxLastName.Anchor = AnchorStyles.None;
            tBoxLastName.BackColor = Color.Lavender;
            tBoxLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxLastName.Location = new Point(217, 367);
            tBoxLastName.Name = "tBoxLastName";
            tBoxLastName.PlaceholderText = "Last Name";
            tBoxLastName.Size = new Size(288, 31);
            tBoxLastName.TabIndex = 7;
            tBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxEmal
            // 
            tBoxEmal.Anchor = AnchorStyles.None;
            tBoxEmal.BackColor = Color.Lavender;
            tBoxEmal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmal.Location = new Point(662, 272);
            tBoxEmal.Name = "tBoxEmal";
            tBoxEmal.PlaceholderText = "E-mail";
            tBoxEmal.Size = new Size(288, 31);
            tBoxEmal.TabIndex = 8;
            tBoxEmal.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Anchor = AnchorStyles.None;
            tBoxPassword.BackColor = Color.Lavender;
            tBoxPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(662, 367);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PlaceholderText = "Password";
            tBoxPassword.Size = new Size(288, 31);
            tBoxPassword.TabIndex = 9;
            tBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxConfirmPassword
            // 
            tBoxConfirmPassword.Anchor = AnchorStyles.None;
            tBoxConfirmPassword.BackColor = Color.Lavender;
            tBoxConfirmPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxConfirmPassword.Location = new Point(662, 462);
            tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            tBoxConfirmPassword.PlaceholderText = "Confirm Password";
            tBoxConfirmPassword.Size = new Size(288, 31);
            tBoxConfirmPassword.TabIndex = 10;
            tBoxConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // FormCreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 700);
            Controls.Add(panel1);
            Name = "FormCreateAccount";
            Text = "FormCreateAccount";
            Load += FormCreateAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxFondo2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonCreateAccount;
        private Panel panel1;
        private PictureBox pBoxFondo2;
        private Label labelTitulo2;
        private Label labelText1;
        private TextBox tBoxLastName;
        private TextBox tBoxName;
        private TextBox tBoxUsername;
        private TextBox tBoxConfirmPassword;
        private TextBox tBoxPassword;
        private TextBox tBoxEmal;
    }
}