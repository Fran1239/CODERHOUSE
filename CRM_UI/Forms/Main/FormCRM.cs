using CRM_UI.Forms.Functionalities;
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
    public partial class FormCRM : Form
    {
        public FormCRM()
        {
            InitializeComponent();
            panelButtonsVentas.Visible = false;
            panelButtonsProductos.Visible = false;
            panelButtonsUsuarios.Visible = false;
        }

        private void hideMenue()
        {
            if (panelButtonsVentas.Visible == true)
            {
                panelButtonsVentas.Visible = false;
            }
            if (panelButtonsProductos.Visible == true)
            {
                panelButtonsProductos.Visible = false;
            }
            if (panelButtonsUsuarios.Visible == true)
            {
                panelButtonsUsuarios.Visible = false;
            }
        }

        private void showSubMenue(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenue();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void pBoxFondo1_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#8474ce");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#8474ce");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            showSubMenue(panelButtonsVentas);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            showSubMenue(panelButtonsProductos);
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenue(panelButtonsUsuarios);
        }

        private void pictureBoxCerrarSesion_Click(object sender, EventArgs e)
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

        private void buttonOrganizacion_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrganizacion());
            hideMenue();
        }

        private void buttonGenerarVenta_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCrearVenta());
            hideMenue();
        }

        private void buttonConsultarVentas_Click(object sender, EventArgs e)
        {
            hideMenue();
        }

        private void buttonCargarProductos_Click(object sender, EventArgs e)
        {
            hideMenue();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            hideMenue();
        }

        private void buttonCargarUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCargarUsuario());
            hideMenue();
        }

        private void buttonGestiondeUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionUsuarios());
            hideMenue();
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            hideMenue();
        }

        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            hideMenue();
        }

        private Form? activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFunctionalities.Controls.Add(childForm);
            panelFunctionalities.Tag = childForm;
            panelFunctionalities.BringToFront();
            childForm.BringToFront();
            childForm.Show();


        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
