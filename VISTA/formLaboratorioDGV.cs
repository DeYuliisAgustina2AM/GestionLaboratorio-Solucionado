using Controladora;
using Entidades;
using System.Data;


namespace VISTA
{
    public partial class formLaboratorioDGV : Form
    {
        public formLaboratorioDGV()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvLaboratorio.DataSource = null;
            dgvLaboratorio.DataSource = ControladoraLaboratorio.Instancia.RecuperarLaboratorios();
            dgvLaboratorio.Columns["Sede"].Visible = false; // lo oculto para prolijidad del dgv
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formLaboratorioDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formLaboratorioAM = new formLaboratorioAM();
            formLaboratorioAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorio.Rows.Count > 0)
            {
                var laboratorioSeleccionado = (Laboratorio)dgvLaboratorio.CurrentRow.DataBoundItem;
                var mensaje = ControladoraLaboratorio.Instancia.EliminarLaboratorio(laboratorioSeleccionado);
                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un laboratorio para eliminarlo");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLaboratorio.Rows.Count > 0)
            {
                var laboratorioSeleccionado = (Laboratorio)dgvLaboratorio.CurrentRow.DataBoundItem;
                formLaboratorioAM formLaboratorioAM = new formLaboratorioAM(laboratorioSeleccionado);
                formLaboratorioAM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un laboratorio para modificarlo");
            }
            ActualizarGrilla();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarLaboratorio.Text != "")
            {
                dgvLaboratorio.DataSource = ControladoraLaboratorio.Instancia.RecuperarLaboratorios().Where(l => l.NombreLaboratorio.ToLower().Contains(txtBuscarLaboratorio.Text.ToLower())).ToList();
            }
            else
            {
                ActualizarGrilla();
            }
        }
    }
}
