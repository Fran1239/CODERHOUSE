using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CRM_UI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();

            pb_eyeOpen.Visible = false;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
        }
        private void FormLogIn_Load(object sender, EventArgs e)
        {
            labelTitulo.Parent = pBoxFondo1;
            labelTitulo.BackColor = Color.Transparent;
            pb_eyeOpen.Parent = pBoxFondo1;
            pb_eyeOpen.BackColor = Color.Transparent;
            pb_eyeClosed.Parent = pBoxFondo1;
            pb_eyeClosed.BackColor = Color.Transparent;
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            formMain.AbrirFormEnPanel(new FormCRM());
            if (formMain != null)
            {
                formMain.Show();
                formMain.AbrirFormCRM();
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            formMain.AbrirFormEnPanel(new FormCreateAccount());
            if (formMain != null)
            {
                formMain.Show();
                formMain.AbrirFormCreateAccount();
            }
        }

        private void pb_eyeOpen_Click(object sender, EventArgs e)
        {
            pb_eyeOpen.Visible = false;
            pb_eyeClosed.Visible = true;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
        }

        private void pb_eyeClosed_Click(object sender, EventArgs e)
        {
            pb_eyeClosed.Visible = false;
            pb_eyeOpen.Visible = true;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
        }
    }
}
