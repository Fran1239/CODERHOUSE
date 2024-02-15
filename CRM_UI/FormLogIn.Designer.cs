namespace CRM_UI
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            panel1 = new Panel();
            pb_eyeOpen = new PictureBox();
            labelTitulo = new Label();
            tBoxPassword = new TextBox();
            tBoxUsername = new TextBox();
            labelTittle = new Label();
            buttonCreateAccount = new Button();
            buttonLogIn = new Button();
            pBoxFondo1 = new PictureBox();
            pb_eyeClosed = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFondo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_eyeClosed).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pb_eyeClosed);
            panel1.Controls.Add(pb_eyeOpen);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(tBoxPassword);
            panel1.Controls.Add(tBoxUsername);
            panel1.Controls.Add(labelTittle);
            panel1.Controls.Add(buttonCreateAccount);
            panel1.Controls.Add(buttonLogIn);
            panel1.Controls.Add(pBoxFondo1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 742);
            panel1.TabIndex = 0;
            // 
            // pb_eyeOpen
            // 
            pb_eyeOpen.Anchor = AnchorStyles.None;
            pb_eyeOpen.Image = Properties.Resources.ojo;
            pb_eyeOpen.Location = new Point(692, 406);
            pb_eyeOpen.Name = "pb_eyeOpen";
            pb_eyeOpen.Size = new Size(52, 39);
            pb_eyeOpen.SizeMode = PictureBoxSizeMode.Zoom;
            pb_eyeOpen.TabIndex = 1;
            pb_eyeOpen.TabStop = false;
            pb_eyeOpen.Click += pb_eyeOpen_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Century Gothic", 135F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(116, 63);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(853, 215);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "OPUNTIA";
            labelTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Anchor = AnchorStyles.None;
            tBoxPassword.BackColor = Color.Lavender;
            tBoxPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(398, 410);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PlaceholderText = "Password";
            tBoxPassword.Size = new Size(288, 31);
            tBoxPassword.TabIndex = 2;
            tBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Anchor = AnchorStyles.None;
            tBoxUsername.BackColor = Color.Lavender;
            tBoxUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(398, 353);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.PlaceholderText = "Username";
            tBoxUsername.Size = new Size(288, 31);
            tBoxUsername.TabIndex = 1;
            tBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // labelTittle
            // 
            labelTittle.Anchor = AnchorStyles.None;
            labelTittle.AutoSize = true;
            labelTittle.BackColor = Color.Transparent;
            labelTittle.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            labelTittle.Location = new Point(426, 173);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(0, 78);
            labelTittle.TabIndex = 1;
            labelTittle.TextAlign = ContentAlignment.TopCenter;
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
            buttonCreateAccount.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateAccount.ForeColor = Color.SlateBlue;
            buttonCreateAccount.Location = new Point(398, 574);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(288, 84);
            buttonCreateAccount.TabIndex = 1;
            buttonCreateAccount.Text = "Create Account";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.Lavender;
            buttonLogIn.Cursor = Cursors.Hand;
            buttonLogIn.FlatAppearance.BorderColor = Color.White;
            buttonLogIn.FlatAppearance.BorderSize = 2;
            buttonLogIn.FlatAppearance.MouseDownBackColor = Color.White;
            buttonLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogIn.ForeColor = Color.SlateBlue;
            buttonLogIn.Location = new Point(446, 500);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(193, 58);
            buttonLogIn.TabIndex = 1;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // pBoxFondo1
            // 
            pBoxFondo1.BackColor = Color.Transparent;
            pBoxFondo1.Dock = DockStyle.Fill;
            pBoxFondo1.Image = (Image)resources.GetObject("pBoxFondo1.Image");
            pBoxFondo1.Location = new Point(0, 0);
            pBoxFondo1.Name = "pBoxFondo1";
            pBoxFondo1.Size = new Size(1085, 742);
            pBoxFondo1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxFondo1.TabIndex = 0;
            pBoxFondo1.TabStop = false;
            // 
            // pb_eyeClosed
            // 
            pb_eyeClosed.Anchor = AnchorStyles.None;
            pb_eyeClosed.Image = Properties.Resources.esconder;
            pb_eyeClosed.Location = new Point(692, 406);
            pb_eyeClosed.Name = "pb_eyeClosed";
            pb_eyeClosed.Size = new Size(52, 39);
            pb_eyeClosed.SizeMode = PictureBoxSizeMode.Zoom;
            pb_eyeClosed.TabIndex = 3;
            pb_eyeClosed.TabStop = false;
            pb_eyeClosed.Click += pb_eyeClosed_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 742);
            Controls.Add(panel1);
            Name = "FormLogIn";
            Text = "FormLogIn";
            Load += FormLogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_eyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFondo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_eyeClosed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonLogIn;
        private Button buttonCreateAccount;
        private Label labelTittle;
        private PictureBox pBoxFondo1;
        private Label labelTitulo;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private PictureBox pb_eyeOpen;
        private PictureBox pb_eyeClosed;
    }
}