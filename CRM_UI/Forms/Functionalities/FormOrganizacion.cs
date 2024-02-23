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
    public partial class FormOrganizacion : Form
    {
        public FormOrganizacion()
        {
            InitializeComponent();
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
