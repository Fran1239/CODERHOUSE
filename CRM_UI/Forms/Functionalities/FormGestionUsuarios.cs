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
            dataGridView1.RowTemplate.Height = 40;
            panelEditar.Visible = false;
            panelEliminar.Visible = false;
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
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    panelEliminar.Visible = true;
                    panelEliminar.BringToFront();
                }
            }

            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    panelEditar.Visible = true;
                    panelEliminar.BringToFront();
                    //var users = await userService.ReadUserInfo(Username);
                    //tBoxName.Text = users.Name;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private async void tBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image buttonImage = Properties.Resources.borrar__1_;
                var imgX = e.CellBounds.Left + (e.CellBounds.Width - buttonImage.Width) / 2;
                var imgY = e.CellBounds.Top + (e.CellBounds.Height - buttonImage.Height) / 2;
                e.Graphics.DrawImage(buttonImage, new Rectangle(imgX, imgY, buttonImage.Width, buttonImage.Height));
                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Image buttonImage = Properties.Resources.editar;
                var imgX = e.CellBounds.Left + (e.CellBounds.Width - buttonImage.Width) / 2;
                var imgY = e.CellBounds.Top + (e.CellBounds.Height - buttonImage.Height) / 2;
                e.Graphics.DrawImage(buttonImage, new Rectangle(imgX, imgY, buttonImage.Width, buttonImage.Height));
                e.Handled = true;
            }
        }

        private void panelEliminar_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void panelEditar_Paint(object sender, PaintEventArgs e)
        {
            Color colorFondo = ColorTranslator.FromHtml("#b6b4da");
            using (SolidBrush brush = new SolidBrush(colorFondo))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelarDelete_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            labelHelp.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
        }
    }
}
