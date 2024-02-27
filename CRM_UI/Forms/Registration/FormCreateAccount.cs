using CRM_DAL.DTO.User_DTO;
using CRM_UI.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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


                if (data.Contains("SUCCESSFULLY_USER_CREATION"))
                {
                    MessageBox.Show("SUCCESSFULLY USER CREATION");
                    this.Close();
                    FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
                    formMain.AbrirFormEnPanel(new FormCRM());
                    if (formMain != null)
                    {
                        formMain.Show();
                        formMain.AbrirFormCRM();
                    }
                }
                else if (data.Contains("USERNAME_ALREADY_EXISTS"))
                {
                    MessageBox.Show("USERNAME ALREADY EXISTS");
                }
                else
                {
                    MessageBox.Show("FAIL CREATING USER");
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

            pictureBoxReturn.Parent = pBoxFondo;
            pictureBoxReturn.BackColor = Color.Transparent;

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

        private void tBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = Application.OpenForms.OfType<FormMain>().FirstOrDefault();
            formMain.AbrirFormEnPanel(new FormLogIn());
            if (formMain != null)
            {
                formMain.Show();
                formMain.AbrirFormLogIn();
            }
        }
    }
}
