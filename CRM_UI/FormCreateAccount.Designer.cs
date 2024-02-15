namespace CRM_UI
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
            labelTitulo2 = new Label();
            pBoxFondo2 = new PictureBox();
            labelText1 = new Label();
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
            buttonCreateAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            buttonCreateAccount.FlatStyle = FlatStyle.Flat;
            buttonCreateAccount.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateAccount.ForeColor = Color.SlateBlue;
            buttonCreateAccount.Location = new Point(438, 551);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(201, 82);
            buttonCreateAccount.TabIndex = 1;
            buttonCreateAccount.Text = "Sign In";
            buttonCreateAccount.UseVisualStyleBackColor = false;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelText1);
            panel1.Controls.Add(labelTitulo2);
            panel1.Controls.Add(buttonCreateAccount);
            panel1.Controls.Add(pBoxFondo2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 700);
            panel1.TabIndex = 2;
            // 
            // labelTitulo2
            // 
            labelTitulo2.Anchor = AnchorStyles.None;
            labelTitulo2.AutoSize = true;
            labelTitulo2.BackColor = Color.Transparent;
            labelTitulo2.FlatStyle = FlatStyle.Flat;
            labelTitulo2.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo2.ForeColor = Color.White;
            labelTitulo2.Location = new Point(311, 39);
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
            pBoxFondo2.Size = new Size(1078, 700);
            pBoxFondo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxFondo2.TabIndex = 2;
            pBoxFondo2.TabStop = false;
            // 
            // labelText1
            // 
            labelText1.Anchor = AnchorStyles.None;
            labelText1.AutoSize = true;
            labelText1.BackColor = Color.Transparent;
            labelText1.FlatStyle = FlatStyle.Flat;
            labelText1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelText1.ForeColor = Color.White;
            labelText1.Location = new Point(143, 163);
            labelText1.Name = "labelText1";
            labelText1.Size = new Size(794, 30);
            labelText1.TabIndex = 4;
            labelText1.Text = "Ingrese los datos correspondientes para la creación de su cuenta";
            labelText1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormCreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 700);
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
    }
}