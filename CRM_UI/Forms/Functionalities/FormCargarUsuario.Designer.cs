namespace CRM_UI.Forms.Functionalities
{
    partial class FormCargarUsuario
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonEditarUsuario = new Button();
            buttonCrearUsuario = new Button();
            pictureBoxClose = new PictureBox();
            tBoxName = new TextBox();
            tBoxEmal = new TextBox();
            tBoxLastName = new TextBox();
            tBoxPassword = new TextBox();
            tBoxUsername = new TextBox();
            tBoxConfirmPassword = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonEditarUsuario);
            panel1.Controls.Add(buttonCrearUsuario);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 523);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tBoxConfirmPassword);
            panel2.Controls.Add(tBoxUsername);
            panel2.Controls.Add(tBoxPassword);
            panel2.Controls.Add(tBoxLastName);
            panel2.Controls.Add(tBoxEmal);
            panel2.Controls.Add(tBoxName);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 420);
            panel2.TabIndex = 1;
            // 
            // buttonEditarUsuario
            // 
            buttonEditarUsuario.Anchor = AnchorStyles.Top;
            buttonEditarUsuario.BackColor = Color.Lavender;
            buttonEditarUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditarUsuario.Location = new Point(592, 10);
            buttonEditarUsuario.Name = "buttonEditarUsuario";
            buttonEditarUsuario.Size = new Size(200, 40);
            buttonEditarUsuario.TabIndex = 2;
            buttonEditarUsuario.Text = "Editar Usuario";
            buttonEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonCrearUsuario
            // 
            buttonCrearUsuario.Anchor = AnchorStyles.Top;
            buttonCrearUsuario.BackColor = Color.Lavender;
            buttonCrearUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCrearUsuario.Location = new Point(317, 10);
            buttonCrearUsuario.Name = "buttonCrearUsuario";
            buttonCrearUsuario.Size = new Size(200, 40);
            buttonCrearUsuario.TabIndex = 1;
            buttonCrearUsuario.Text = "Crear Usuario";
            buttonCrearUsuario.UseVisualStyleBackColor = false;
            buttonCrearUsuario.Click += buttonCrearUsuario_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.Transparent;
            pictureBoxClose.Image = Properties.Resources.cruz;
            pictureBoxClose.Location = new Point(10, 10);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(40, 40);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // tBoxName
            // 
            tBoxName.Anchor = AnchorStyles.None;
            tBoxName.BackColor = Color.Lavender;
            tBoxName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxName.Location = new Point(64, 97);
            tBoxName.Name = "tBoxName";
            tBoxName.PlaceholderText = "Name";
            tBoxName.Size = new Size(288, 31);
            tBoxName.TabIndex = 7;
            tBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxEmal
            // 
            tBoxEmal.Anchor = AnchorStyles.None;
            tBoxEmal.BackColor = Color.Lavender;
            tBoxEmal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmal.Location = new Point(649, 97);
            tBoxEmal.Name = "tBoxEmal";
            tBoxEmal.PlaceholderText = "E-mail";
            tBoxEmal.Size = new Size(288, 31);
            tBoxEmal.TabIndex = 9;
            tBoxEmal.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxLastName
            // 
            tBoxLastName.Anchor = AnchorStyles.None;
            tBoxLastName.BackColor = Color.Lavender;
            tBoxLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxLastName.Location = new Point(64, 186);
            tBoxLastName.Name = "tBoxLastName";
            tBoxLastName.PlaceholderText = "Last Name";
            tBoxLastName.Size = new Size(288, 31);
            tBoxLastName.TabIndex = 10;
            tBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Anchor = AnchorStyles.None;
            tBoxPassword.BackColor = Color.Lavender;
            tBoxPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(649, 199);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PlaceholderText = "Password";
            tBoxPassword.Size = new Size(288, 31);
            tBoxPassword.TabIndex = 11;
            tBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Anchor = AnchorStyles.None;
            tBoxUsername.BackColor = Color.Lavender;
            tBoxUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(64, 268);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.PlaceholderText = "Username";
            tBoxUsername.Size = new Size(288, 31);
            tBoxUsername.TabIndex = 12;
            tBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxConfirmPassword
            // 
            tBoxConfirmPassword.Anchor = AnchorStyles.None;
            tBoxConfirmPassword.BackColor = Color.Lavender;
            tBoxConfirmPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxConfirmPassword.Location = new Point(649, 277);
            tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            tBoxConfirmPassword.PlaceholderText = "Confirm Password";
            tBoxConfirmPassword.Size = new Size(288, 31);
            tBoxConfirmPassword.TabIndex = 13;
            tBoxConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // FormCargarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 523);
            Controls.Add(panel1);
            Name = "FormCargarUsuario";
            Text = "FormCargarUsuario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Button buttonEditarUsuario;
        private Button buttonCrearUsuario;
        private Panel panel2;
        private TextBox tBoxName;
        private TextBox tBoxEmal;
        private TextBox tBoxLastName;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private TextBox tBoxConfirmPassword;
    }
}