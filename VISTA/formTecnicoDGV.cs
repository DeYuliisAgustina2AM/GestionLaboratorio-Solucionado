using Controladora;
using Entidades;
using System.Data;

namespace VISTA
{
    public partial class formTecnicoDGV : Form
    {
        public formTecnicoDGV()
        {
            InitializeComponent();
        }

        private void ActualizarGrilla()
        {
            dgvTecnico.DataSource = null;
            dgvTecnico.DataSource = ControladoraTecnico.Instancia.RecuperarTecnicos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formTecnicoAM = new formTecnicoAM();
            formTecnicoAM.ShowDialog();
            ActualizarGrilla();
        }

        private void formTecnicoDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTecnico.Rows.Count > 0)
            {
                var tecnicoSeleccionado = (Tecnico)dgvTecnico.CurrentRow.DataBoundItem;
                var mensaje = ControladoraTecnico.Instancia.EliminarTecnico(tecnicoSeleccionado);
                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un tecnico para eliminarlo");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTecnico.Rows.Count > 0)
            {
                var tecnicoSeleccionado = (Tecnico)dgvTecnico.CurrentRow.DataBoundItem;
                formTecnicoAM formTecnicoAM = new formTecnicoAM(tecnicoSeleccionado);
                formTecnicoAM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un tecnico para modificarlo");
            }
            ActualizarGrilla();
        }
    }
}
