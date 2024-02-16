using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
            pb_eyeOpen1.Visible = false;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
            pb_eyeOpen2.Visible = false;
            tBoxConfirmPassword.UseSystemPasswordChar = !tBoxConfirmPassword.UseSystemPasswordChar;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
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

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {
            labelTitulo2.Parent = pictureBoxFondo;
            labelTitulo2.BackColor = Color.Transparent;
            labelText1.Parent = ;
            labelText1.BackColor = Color.Transparent;

            pb_eyeOpen1.Parent = ;
            pb_eyeOpen1.BackColor = Color.Transparent;
            pb_eyeClosed1.Parent = ;
            pb_eyeClosed1.BackColor = Color.Transparent;

            pb_eyeOpen2.Parent = ;
            pb_eyeOpen2.BackColor = Color.Transparent;
            pb_eyeClosed2.Parent = ;
            pb_eyeClosed2.BackColor = Color.Transparent;

        }

        private void pb_eyeOpen1_Click(object sender, EventArgs e)
        {
            pb_eyeOpen1.Visible = false;
            pb_eyeClosed1.Visible = true;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
        }

        private void pb_eyeClosed1_Click(object sender, EventArgs e)
        {
            pb_eyeClosed1.Visible = false;
            pb_eyeOpen1.Visible = true;
            tBoxPassword.UseSystemPasswordChar = !tBoxPassword.UseSystemPasswordChar;
        }

        private void pb_eyeOpen2_Click(object sender, EventArgs e)
        {
            pb_eyeOpen2.Visible = false;
            pb_eyeClosed2.Visible = true;
            tBoxConfirmPassword.UseSystemPasswordChar = !tBoxConfirmPassword.UseSystemPasswordChar;
        }

        private void pb_eyeClosed2_Click(object sender, EventArgs e)
        {
            pb_eyeClosed2.Visible = false;
            pb_eyeOpen2.Visible = true;
            tBoxConfirmPassword.UseSystemPasswordChar = !tBoxConfirmPassword.UseSystemPasswordChar;
        }

        private void labelTitulo2_Click(object sender, EventArgs e)
        {

        }

    }
}
