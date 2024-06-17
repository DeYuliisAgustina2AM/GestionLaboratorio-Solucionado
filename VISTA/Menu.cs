namespace VISTA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnLaboratorioMenu_Click(object sender, EventArgs e)
        {
            Form formLaboratorioDGV = new formLaboratorioDGV();
            formLaboratorioDGV.ShowDialog();
        }

        private void btnComputadoraMenu_Click(object sender, EventArgs e)
        {
            Form formComputadoraDGV = new formComputadoraDGV();
            formComputadoraDGV.ShowDialog();
        }

        private void btnSedeMenu_Click(object sender, EventArgs e)
        {
            Form formSedeDGV = new formSedeDGV();
            formSedeDGV.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnTicketMenu_Click(object sender, EventArgs e)
        {
            Form formHistorialDGV = new formTicketDGV();
            formHistorialDGV.ShowDialog();
        }

        private void btnTecnicosMenu_Click(object sender, EventArgs e)
        {
            Form formTecnicoDGV = new formTecnicoDGV();
            formTecnicoDGV.ShowDialog();
        }
    }
}
