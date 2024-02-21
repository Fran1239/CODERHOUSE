namespace CRM_UI
{
    public partial class FormMain : Form
    {
        Form FormActual;
        public FormMain()
        {
            InitializeComponent();
            AbrirFormEnPanel(new FormLogIn());
        }

        public void AbrirFormEnPanel(Form Formhijo)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = Formhijo;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(Formhijo);
            panelMain.Tag = Formhijo;
            Formhijo.BringToFront();
            Formhijo.Show();
        }

        public void AbrirFormCreateAccount()
        {
            AbrirFormEnPanel(new FormCreateAccount());
        }

        public void AbrirFormCRM()
        {
            AbrirFormEnPanel(new FormCRM());
        }
        public void AbrirFormLogIn()
        {
            AbrirFormEnPanel(new FormLogIn());
        }
    }
}