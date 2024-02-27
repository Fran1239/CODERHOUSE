namespace CRM_UI.Forms.Functionalities
{
    partial class FormGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionUsuarios));
            panel1 = new Panel();
            labelHelp = new Label();
            pictureBoxHelp = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            textBoxUsuario = new TextBox();
            pictureBoxClose = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(labelHelp);
            panel1.Controls.Add(pictureBoxHelp);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 633);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelHelp
            // 
            labelHelp.Anchor = AnchorStyles.Top;
            labelHelp.AutoSize = true;
            labelHelp.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelp.ForeColor = SystemColors.ButtonHighlight;
            labelHelp.Location = new Point(86, 53);
            labelHelp.Name = "labelHelp";
            labelHelp.Size = new Size(1056, 44);
            labelHelp.TabIndex = 5;
            labelHelp.Text = resources.GetString("labelHelp.Text");
            labelHelp.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxHelp
            // 
            pictureBoxHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxHelp.BackColor = Color.Transparent;
            pictureBoxHelp.Image = Properties.Resources.help;
            pictureBoxHelp.Location = new Point(1184, 10);
            pictureBoxHelp.Name = "pictureBoxHelp";
            pictureBoxHelp.Size = new Size(40, 40);
            pictureBoxHelp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHelp.TabIndex = 4;
            pictureBoxHelp.TabStop = false;
            pictureBoxHelp.Click += pictureBoxHelp_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(1212, 515);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Username, Editar, Eliminar });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1206, 509);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.DataPropertyName = "X";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(471, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top;
            textBoxUsuario.BackColor = Color.Lavender;
            textBoxUsuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(503, 12);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Buscar";
            textBoxUsuario.Size = new Size(230, 31);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
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
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 632);
            Controls.Add(panel1);
            Name = "FormGestionUsuarios";
            Text = " ";
            Load += FormGestionUsuarios_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private DataGridView dataGridView1;
        private TextBox textBoxUsuario;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxHelp;
        private Label labelHelp;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}