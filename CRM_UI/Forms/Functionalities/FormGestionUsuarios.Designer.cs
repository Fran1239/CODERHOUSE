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
            pictureBox2 = new PictureBox();
            labelHelp = new Label();
            pictureBoxHelp = new PictureBox();
            panel2 = new Panel();
            panelEditar = new Panel();
            textBoxEmail = new TextBox();
            textBoxLastName = new TextBox();
            textBoxUserName = new TextBox();
            tBoxName = new TextBox();
            buttonGuardarEdit = new Button();
            button1 = new Button();
            label1 = new Label();
            panelEliminar = new Panel();
            buttonEliminar = new Button();
            buttonCancelarDelete = new Button();
            labelDelete = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).BeginInit();
            panel2.SuspendLayout();
            panelEditar.SuspendLayout();
            panelEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(labelHelp);
            panel1.Controls.Add(pictureBoxHelp);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 661);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.help;
            pictureBox2.Location = new Point(1257, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // labelHelp
            // 
            labelHelp.Anchor = AnchorStyles.Top;
            labelHelp.AutoSize = true;
            labelHelp.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelp.ForeColor = SystemColors.ButtonHighlight;
            labelHelp.Location = new Point(93, 53);
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
            pictureBoxHelp.Location = new Point(1453, 10);
            pictureBoxHelp.Name = "pictureBoxHelp";
            pictureBoxHelp.Size = new Size(40, 40);
            pictureBoxHelp.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHelp.TabIndex = 4;
            pictureBoxHelp.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panelEditar);
            panel2.Controls.Add(panelEliminar);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 544);
            panel2.TabIndex = 3;
            // 
            // panelEditar
            // 
            panelEditar.Anchor = AnchorStyles.None;
            panelEditar.BorderStyle = BorderStyle.Fixed3D;
            panelEditar.Controls.Add(textBoxEmail);
            panelEditar.Controls.Add(textBoxLastName);
            panelEditar.Controls.Add(textBoxUserName);
            panelEditar.Controls.Add(tBoxName);
            panelEditar.Controls.Add(buttonGuardarEdit);
            panelEditar.Controls.Add(button1);
            panelEditar.Controls.Add(label1);
            panelEditar.Location = new Point(228, 72);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(692, 417);
            panelEditar.TabIndex = 6;
            panelEditar.Paint += panelEditar_Paint;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.BackColor = Color.Lavender;
            textBoxEmail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(382, 216);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email";
            textBoxEmail.Size = new Size(288, 31);
            textBoxEmail.TabIndex = 10;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.None;
            textBoxLastName.BackColor = Color.Lavender;
            textBoxLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(382, 151);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name";
            textBoxLastName.Size = new Size(288, 31);
            textBoxLastName.TabIndex = 9;
            textBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.None;
            textBoxUserName.BackColor = Color.Lavender;
            textBoxUserName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(22, 216);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Username";
            textBoxUserName.Size = new Size(288, 31);
            textBoxUserName.TabIndex = 8;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // tBoxName
            // 
            tBoxName.Anchor = AnchorStyles.None;
            tBoxName.BackColor = Color.Lavender;
            tBoxName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxName.Location = new Point(22, 151);
            tBoxName.Name = "tBoxName";
            tBoxName.PlaceholderText = "Name";
            tBoxName.Size = new Size(288, 31);
            tBoxName.TabIndex = 7;
            tBoxName.TextAlign = HorizontalAlignment.Center;
            tBoxName.TextChanged += tBoxName_TextChanged;
            // 
            // buttonGuardarEdit
            // 
            buttonGuardarEdit.Anchor = AnchorStyles.None;
            buttonGuardarEdit.BackColor = Color.Lavender;
            buttonGuardarEdit.FlatAppearance.BorderColor = Color.White;
            buttonGuardarEdit.FlatAppearance.BorderSize = 2;
            buttonGuardarEdit.FlatAppearance.MouseDownBackColor = Color.White;
            buttonGuardarEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonGuardarEdit.FlatStyle = FlatStyle.Flat;
            buttonGuardarEdit.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardarEdit.ForeColor = Color.SlateBlue;
            buttonGuardarEdit.Location = new Point(363, 283);
            buttonGuardarEdit.Name = "buttonGuardarEdit";
            buttonGuardarEdit.Size = new Size(200, 47);
            buttonGuardarEdit.TabIndex = 4;
            buttonGuardarEdit.Text = "Confirmar y Cerrar";
            buttonGuardarEdit.UseVisualStyleBackColor = false;
            buttonGuardarEdit.Click += buttonGuardarEdit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Lavender;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SlateBlue;
            button1.Location = new Point(126, 283);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 3;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(60, 85);
            label1.Name = "label1";
            label1.Size = new Size(574, 44);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos que quiera editar y haga click en \"Guardar\" \r\npara confirmar y cerrar los cambios deseados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelEliminar
            // 
            panelEliminar.Anchor = AnchorStyles.None;
            panelEliminar.BorderStyle = BorderStyle.Fixed3D;
            panelEliminar.Controls.Add(buttonEliminar);
            panelEliminar.Controls.Add(buttonCancelarDelete);
            panelEliminar.Controls.Add(labelDelete);
            panelEliminar.Location = new Point(228, 109);
            panelEliminar.Name = "panelEliminar";
            panelEliminar.Size = new Size(690, 324);
            panelEliminar.TabIndex = 1;
            panelEliminar.Paint += panelEliminar_Paint;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonEliminar.BackColor = Color.Lavender;
            buttonEliminar.FlatAppearance.BorderColor = Color.White;
            buttonEliminar.FlatAppearance.BorderSize = 2;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.White;
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.ForeColor = Color.SlateBlue;
            buttonEliminar.Location = new Point(364, 175);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(131, 53);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelarDelete
            // 
            buttonCancelarDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelarDelete.BackColor = Color.Lavender;
            buttonCancelarDelete.FlatAppearance.BorderColor = Color.White;
            buttonCancelarDelete.FlatAppearance.BorderSize = 2;
            buttonCancelarDelete.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCancelarDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            buttonCancelarDelete.FlatStyle = FlatStyle.Flat;
            buttonCancelarDelete.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelarDelete.ForeColor = Color.SlateBlue;
            buttonCancelarDelete.Location = new Point(178, 175);
            buttonCancelarDelete.Name = "buttonCancelarDelete";
            buttonCancelarDelete.Size = new Size(131, 53);
            buttonCancelarDelete.TabIndex = 1;
            buttonCancelarDelete.Text = "Cancelar";
            buttonCancelarDelete.UseVisualStyleBackColor = false;
            buttonCancelarDelete.Click += buttonCancelarDelete_Click;
            // 
            // labelDelete
            // 
            labelDelete.Anchor = AnchorStyles.None;
            labelDelete.AutoSize = true;
            labelDelete.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDelete.ForeColor = SystemColors.ButtonHighlight;
            labelDelete.Location = new Point(44, 71);
            labelDelete.Name = "labelDelete";
            labelDelete.Size = new Size(588, 66);
            labelDelete.TabIndex = 0;
            labelDelete.Text = "Estas seguro que deseas eliminar el usuario? \r\nAl realizar esta acción se elimina todo registro de el mismo en la \r\nbase de datos del sistema  y no podras recuerar su información";
            labelDelete.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Email, Username, Editar, Eliminar });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1147, 540);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += grid_CellPainting;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Eliminar.DataPropertyName = "X";
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 12);
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
            textBoxUsuario.Location = new Point(489, 12);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Buscar";
            textBoxUsuario.Size = new Size(230, 31);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            textBoxUsuario.KeyPress += tBoxUsuario_KeyPress;
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
            ClientSize = new Size(1171, 661);
            Controls.Add(panel1);
            Name = "FormGestionUsuarios";
            RightToLeft = RightToLeft.No;
            Text = " ";
            Load += FormGestionUsuarios_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHelp).EndInit();
            panel2.ResumeLayout(false);
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            panelEliminar.ResumeLayout(false);
            panelEliminar.PerformLayout();
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
        private Panel panelEliminar;
        private Panel panelEditar;
        private Label labelDelete;
        private Button buttonEliminar;
        private Button buttonCancelarDelete;
        private Label label1;
        private Button button1;
        private Button buttonGuardarDelete;
        private TextBox textBoxEmail;
        private TextBox textBoxLastName;
        private TextBox textBoxUserName;
        private TextBox tBoxName;
        private PictureBox pictureBox2;
        private Button buttonGuardarEdit;
    }
}