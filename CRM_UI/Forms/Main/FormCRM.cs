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

        }

    }
}
