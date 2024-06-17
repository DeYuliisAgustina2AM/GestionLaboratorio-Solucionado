using Controladora;
using Entidades;
using static Entidades.Computadora; //se importan enums de Computadora para acceder a ellos directamente en el código sin tener que escribir Computadora.EstadoComputadora o Computadora.CondicionComputadora. 

namespace VISTA
{
    public partial class formComputadoraAM : Form
    {
        private Computadora computadora; // variable de tipo Sede para almacenar la sede que se va a modificar
        private bool modificar = false;

        public formComputadoraAM()
        {
            InitializeComponent();
            computadora = new Computadora();
            ActualizarCb();
        }

        public formComputadoraAM(Computadora computadoraModificar)
        {
            InitializeComponent();
            computadora = computadoraModificar;
            modificar = true;
            ActualizarCb();
            ModificarCb();
        }

        private void ActualizarCb()
        {
            foreach (Laboratorio laboratorio in ControladoraLaboratorio.Instancia.RecuperarLaboratorios()) //se recorren los laboratorios y se agregan al cmb
            {
                cbLaboratorio.Items.Add(laboratorio.NombreLaboratorio.ToString());
            }
            foreach (EstadoComputadora estado in Enum.GetValues(typeof(EstadoComputadora))) //se recorren los valores del enum de EstadoComputadora y se agregan al combobox de estados
            {
                cbEstado.Items.Add(estado.ToString()); 
            }
            foreach (CondicionComputadora condicion in Enum.GetValues(typeof(CondicionComputadora))) 
            {
                cbCondicion.Items.Add(condicion.ToString());
            }          
        }

        public void ModificarCb()
        {
            if (computadora.Laboratorio != null) //si la computadora tiene un laboratorio asignado, se selecciona en el combobox de laboratorios
            {
                cbLaboratorio.SelectedItem = computadora.Laboratorio.ToString();
            }
            txtDescripcion.Text = computadora.DescripcionComputadora.ToString();
            cbEstado.SelectedItem = computadora.estado.ToString();
            cbCondicion.SelectedItem = computadora.condicion.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formComputadoraAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Computadora";

                txtCodigoComputadora.Text = computadora.CodigoComputadora;
                txtDescripcion.Text = computadora.DescripcionComputadora;
                cbLaboratorio.SelectedValue = computadora.Laboratorio;
                cbEstado.SelectedValue = computadora.estado;
                cbCondicion.SelectedValue = computadora.condicion; //se asignan los valores de la computadora a los campos del formulario
            }
            else lblAgregaroModificar.Text = "Agregar Computadora";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    string NombreLaboratorio = cbLaboratorio.Text; // se recupera el nombre de la sede seleccionada del combobox de sedes
                    Laboratorio laboratorio = ControladoraLaboratorio.Instancia.RecuperarLaboratorios().FirstOrDefault(s => s.NombreLaboratorio.ToLower() == NombreLaboratorio.ToLower()); //se recupera los laboratorios para asignarlos a la computadora que se va a modificar
                    computadora.LaboratorioId = laboratorio.LaboratorioId;

                    computadora.CodigoComputadora = txtCodigoComputadora.Text;
                    computadora.DescripcionComputadora = txtDescripcion.Text;

                    string estado = cbEstado.Text; //se recupera el estado seleccionado del combobox de estados
                    string condicion = cbCondicion.Text;
                    computadora.estado = (EstadoComputadora)Enum.Parse(typeof(EstadoComputadora), estado); //se convierte el string a enum el type of es para obtener el tipo de dato de la variable
                    computadora.condicion = (CondicionComputadora)Enum.Parse(typeof(CondicionComputadora), condicion); 

                    var mensaje = ControladoraComputadora.Instancia.ModificarComputadora(computadora);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string NombreLaboratorio = cbLaboratorio.Text; // se recupera el nombre de la sede seleccionada del combobox de sedes
                    Laboratorio laboratorio = ControladoraLaboratorio.Instancia.RecuperarLaboratorios().FirstOrDefault(s => s.NombreLaboratorio.ToLower() == NombreLaboratorio.ToLower()); //se recupera los laboratorios para asignarlos a la computadora que se va a modificar
                    computadora.LaboratorioId = laboratorio.LaboratorioId;

                    computadora.CodigoComputadora = txtCodigoComputadora.Text;
                    computadora.DescripcionComputadora = txtDescripcion.Text;

                    string estado = cbEstado.Text;
                    string condicion = cbCondicion.Text;
                    computadora.estado = (EstadoComputadora)Enum.Parse(typeof(EstadoComputadora), estado);
                    computadora.condicion = (CondicionComputadora)Enum.Parse(typeof(CondicionComputadora), condicion); //computadora.condicion hace referencia al enum de la clase computadora

                    var mensaje = ControladoraComputadora.Instancia.AgregarComputadora(computadora);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();  
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCodigoComputadora.Text))
            {
                MessageBox.Show("El campo Código de Computadora no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("El campo Descripción no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbLaboratorio.SelectedItem == null)
            {
                MessageBox.Show("El campo Laboratorio no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbEstado.SelectedItem == null)
            {
                MessageBox.Show("El campo Estado no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbCondicion.SelectedItem == null)
            {
                MessageBox.Show("El campo Condición no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
