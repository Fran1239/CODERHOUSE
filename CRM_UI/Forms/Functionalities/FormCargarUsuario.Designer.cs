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
            labelHelp = new Label();
            pictureBoxHelp = new PictureBox();
            panel2 = new Panel();
            buttonCrearUsuario = new Button();
            tBoxConfirmPassword = new TextBox();
            tBoxUsername = new TextBox();
            tBoxPassword = new TextBox();
            tBoxLastName = new TextBox();
            tBoxEmal = new TextBox();
            tBoxName = new TextBox();
            pictureBoxClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelHelp);
            panel1.Controls.Add(pictureBoxHelp);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 613);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelHelp
            // 
            labelHelp.Anchor = AnchorStyles.Top;
            labelHelp.AutoSize = true;
            labelHelp.BackColor = Color.Transparent;
            labelHelp.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelp.ForeColor = SystemColors.ButtonHighlight;
            labelHelp.Location = new Point(131, 61);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(709, 48);
            labelHelp.TabIndex = 14;
            labelHelp.Text = "Ingrese los datos corresponfientes y presione el boton \"Crear Usuario\"\r\npara confirmar el registro del  mismo en la base de datos...";
            labelHelp.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxHelp
            // 
            pictureBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxHelp.BackColor = Color.Transparent;
            pictureBoxHelp.Image = Properties.Resources.help;
            pictureBoxHelp.Location = new Point(917, 10);
            pictureBoxHelp.Name = "pictureBoxHelp";
            pictureBoxHelp.Size = new Size(49, 40);
            pictureBoxHelp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHelp.TabIndex = 2;
            pictureBoxHelp.TabStop = false;
            pictureBoxHelp.Click += pictureBoxHelp_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonCrearUsuario);
            panel2.Controls.Add(tBoxConfirmPassword);
            panel2.Controls.Add(tBoxUsername);
            panel2.Controls.Add(tBoxPassword);
            panel2.Controls.Add(tBoxLastName);
            panel2.Controls.Add(tBoxEmal);
            panel2.Controls.Add(tBoxName);
            panel2.Location = new Point(12, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 469);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // buttonCrearUsuario
            // 
            buttonCrearUsuario.Anchor = AnchorStyles.None;
            buttonCrearUsuario.BackColor = Color.Lavender;
            buttonCrearUsuario.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCrearUsuario.Location = new Point(377, 329);
            buttonCrearUsuario.Name = "buttonCrearUsuario";
            buttonCrearUsuario.Size = new Size(200, 79);
            buttonCrearUsuario.TabIndex = 1;
            buttonCrearUsuario.Text = "Crear Usuario";
            buttonCrearUsuario.UseVisualStyleBackColor = false;
            buttonCrearUsuario.Click += buttonCrearUsuario_Click;
            // 
            // tBoxConfirmPassword
            // 
            tBoxConfirmPassword.Anchor = AnchorStyles.None;
            tBoxConfirmPassword.BackColor = Color.Lavender;
            tBoxConfirmPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxConfirmPassword.Location = new Point(515, 236);
            tBoxConfirmPassword.Name = "tBoxConfirmPassword";
            tBoxConfirmPassword.PlaceholderText = "Confirm Password";
            tBoxConfirmPassword.Size = new Size(288, 31);
            tBoxConfirmPassword.TabIndex = 13;
            tBoxConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Anchor = AnchorStyles.None;
            tBoxUsername.BackColor = Color.Lavender;
            tBoxUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(152, 236);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.PlaceholderText = "Username";
            tBoxUsername.Size = new Size(288, 31);
            tBoxUsername.TabIndex = 12;
            tBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Anchor = AnchorStyles.None;
            tBoxPassword.BackColor = Color.Lavender;
            tBoxPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(515, 123);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PlaceholderText = "Password";
            tBoxPassword.Size = new Size(288, 31);
            tBoxPassword.TabIndex = 11;
            tBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxLastName
            // 
            tBoxLastName.Anchor = AnchorStyles.None;
            tBoxLastName.BackColor = Color.Lavender;
            tBoxLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxLastName.Location = new Point(152, 123);
            tBoxLastName.Name = "tBoxLastName";
            tBoxLastName.PlaceholderText = "Last Name";
            tBoxLastName.Size = new Size(288, 31);
            tBoxLastName.TabIndex = 10;
            tBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxEmal
            // 
            tBoxEmal.Anchor = AnchorStyles.None;
            tBoxEmal.BackColor = Color.Lavender;
            tBoxEmal.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxEmal.Location = new Point(515, 23);
            tBoxEmal.Name = "tBoxEmal";
            tBoxEmal.PlaceholderText = "E-mail";
            tBoxEmal.Size = new Size(288, 31);
            tBoxEmal.TabIndex = 9;
            tBoxEmal.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxName
            // 
            tBoxName.Anchor = AnchorStyles.None;
            tBoxName.BackColor = Color.Lavender;
            tBoxName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxName.Location = new Point(152, 23);
            tBoxName.Name = "tBoxName";
            tBoxName.PlaceholderText = "Name";
            tBoxName.Size = new Size(288, 31);
            tBoxName.TabIndex = 7;
            tBoxName.TextAlign = HorizontalAlignment.Center;
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
            // FormCargarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 609);
            Controls.Add(panel1);
            Name = "FormCargarUsuario";
            Text = "FormCargarUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Button buttonCrearUsuario;
        private Panel panel2;
        private TextBox tBoxName;
        private TextBox tBoxEmal;
        private TextBox tBoxLastName;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private TextBox tBoxConfirmPassword;
        private Label labelHelp;
        private PictureBox pictureBoxHelp;
    }
}