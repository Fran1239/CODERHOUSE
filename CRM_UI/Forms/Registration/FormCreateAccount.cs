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

        private async void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            UserWriteDTO userWriteDTO = new UserWriteDTO();
            userWriteDTO.Names = tBoxName.Text;
            userWriteDTO.UserNames = tBoxUsername.Text;
            userWriteDTO.Emails = tBoxEmal.Text;
            userWriteDTO.LastNames = tBoxLastName.Text;
            userWriteDTO.Passwords = tBoxPassword.Text;
            userWriteDTO.ConfirmPassword = tBoxConfirmPassword.Text;

            if(userWriteDTO.Passwords != userWriteDTO.ConfirmPassword)
            {

            }
            else
            {
                string url = "https://localhost:7005/api/User";
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
            }
        }

        private async void FormCreateAccount_Load(object sender, EventArgs e)
        {
            labelTitulo2.Parent = pBoxFondo;
            labelTitulo2.BackColor = Color.Transparent;
            labelText1.Parent = pBoxFondo;
            labelText1.BackColor = Color.Transparent;

            pb_eyeOpen1.Parent = pBoxFondo;
            pb_eyeOpen1.BackColor = Color.Transparent;
            pb_eyeClosed1.Parent = pBoxFondo;
            pb_eyeClosed1.BackColor = Color.Transparent;

            pb_eyeOpen2.Parent = pBoxFondo;
            pb_eyeOpen2.BackColor = Color.Transparent;
            pb_eyeClosed2.Parent = pBoxFondo;
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

        private void pBoxFondo_Click(object sender, EventArgs e)
        {

        }

        private void tBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
