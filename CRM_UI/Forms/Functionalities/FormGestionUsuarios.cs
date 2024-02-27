using CRM_DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI.Forms.Functionalities
{
    public partial class FormGestionUsuarios : Form
    {
        private UserService userService;
        public FormGestionUsuarios()
        {
            InitializeComponent();
            labelHelp.Visible = false;
            userService = new UserService();
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            labelHelp.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = textBoxUsuario.Text.Trim();
                var users = await userService.GetUsers(filterText);
                dataGridView1.Rows.Clear();

                if (users != null)
                {
                    foreach (var item in users)
                    {
                        dataGridView1.Rows.Add(item.Names, item.LastNames, item.Emails, item.UserNames);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FINDING USER");
            }
        }

        private async void FormGestionUsuarios_Load_2(object sender, EventArgs e)
        {
            try
            {
                var users = await userService.GetUsers(null);
                foreach (var item in users)
                {
                    dataGridView1.Rows.Add(item.Names, item.LastNames, item.Emails, item.UserNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR FINDING USER");
            }
        }
    }
}
