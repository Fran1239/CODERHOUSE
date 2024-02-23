using CRM_DAL.DTO.User_DTO;
using CRM_UI.Services;
using Newtonsoft.Json;
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
    public partial class FormCargarUsuario : Form
    {
        public FormCargarUsuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            UserWriteDTO userWriteDTO = new UserWriteDTO();
            userWriteDTO.Names = tBoxName.Text;
            userWriteDTO.UserNames = tBoxUsername.Text;
            userWriteDTO.Emails = tBoxEmal.Text;
            userWriteDTO.LastNames = tBoxLastName.Text;
            userWriteDTO.Passwords = tBoxPassword.Text;
            userWriteDTO.ConfirmPassword = tBoxConfirmPassword.Text;

            if (userWriteDTO.Names == string.Empty || userWriteDTO.UserNames == string.Empty || userWriteDTO.Emails == string.Empty || userWriteDTO.LastNames == string.Empty || userWriteDTO.Passwords == string.Empty || userWriteDTO.ConfirmPassword == string.Empty)
            {
                MessageBox.Show("THERE IS MISSING INFORMATION");
                return;
            }

            if (userWriteDTO.Passwords != userWriteDTO.ConfirmPassword)
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH");
            }
            else
            {
                string url = "https://localhost:7005/api/User/create-user";
                string Json = JsonConvert.SerializeObject(userWriteDTO);
                var data = await API_Connection.GetInstance().PostAsync(url, Json);

                if (data == "SUCCESSFULLY_USER_CREATION")
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
                else
                {
                    MessageBox.Show("FAIL CREATING USER");
                }

            }
        }
    }
}
