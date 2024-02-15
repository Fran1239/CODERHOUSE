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
            labelTitulo2.Parent = pBoxFondo2;
            labelTitulo2.BackColor = Color.Transparent;
            labelText1.Parent = pBoxFondo2;
            labelText1.BackColor = Color.Transparent;

        }
    }
}
