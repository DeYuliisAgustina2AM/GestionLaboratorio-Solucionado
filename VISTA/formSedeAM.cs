using Controladora;
using Entidades;

namespace VISTA
{
    public partial class formSedeAM : Form
    {
        private Sede sede; // variable de tipo Sede para almacenar la sede que se va a modificar
        private bool modificar = false;

        public formSedeAM()
        {
            InitializeComponent();
            sede = new Sede();
        }

        public formSedeAM(Sede sedeModificar)
        {
            InitializeComponent();
            sede = sedeModificar;
            modificar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formSedeAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Sede";

                txtNombreSede.Text = sede.NombreSede;
                txtDireccionSede.Text = sede.DireccionSede;
            }
            else lblAgregaroModificar.Text = "Agregar Sede";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    sede.Universidad = ControladoraSede.Instancia.RecuperarUniversidad();
                    sede.NombreSede = txtNombreSede.Text;
                    sede.DireccionSede = txtDireccionSede.Text;

                    var mensaje = ControladoraSede.Instancia.ModificarSede(sede);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sede.Universidad = ControladoraSede.Instancia.RecuperarUniversidad();
                    sede.NombreSede = txtNombreSede.Text;
                    sede.DireccionSede = txtDireccionSede.Text;

                    var mensaje = ControladoraSede.Instancia.AgregarSede(sede);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreSede.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la sede", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccionSede.Text))
            {
                MessageBox.Show("Debe ingresar una direccion de la sede", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
