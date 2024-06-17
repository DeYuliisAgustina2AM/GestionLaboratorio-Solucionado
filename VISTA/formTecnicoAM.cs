using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class formTecnicoAM : Form
    {
        private Tecnico tecnico; // variable de tipo Sede para almacenar la sede que se va a modificar
        private bool modificar = false;

        public formTecnicoAM()
        {
            InitializeComponent();
            tecnico = new Tecnico();
        }

        public formTecnicoAM(Tecnico tecnicoModificar)
        {
            InitializeComponent();
            tecnico = tecnicoModificar;
            modificar = true;
        }

        private void formTecnicoAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Tecnico";

                txtNombreyApellido.Text = tecnico.NombreyApellido;
                txtDni.Text = tecnico.Dni.ToString();
                txtLegajo.Text = tecnico.Legajo.ToString();
            }
            else lblAgregaroModificar.Text = "Agregar Tecnico";
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
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    tecnico.NombreyApellido = txtNombreyApellido.Text;
                    tecnico.Dni = Convert.ToInt32(txtDni.Text);
                    tecnico.Legajo = Convert.ToInt32(txtLegajo.Text);
                    
                    var mensaje = ControladoraTecnico.Instancia.ModificarTecnico(tecnico);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    tecnico.NombreyApellido = txtNombreyApellido.Text;
                    tecnico.Dni = Convert.ToInt32(txtDni.Text);
                    tecnico.Legajo = Convert.ToInt32(txtLegajo.Text);

                    var mensaje = ControladoraTecnico.Instancia.AgregarTecnico(tecnico);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreyApellido.Text))
            {
                MessageBox.Show("Ingrese el nombre y apellido del tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreyApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Ingrese el DNI del tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLegajo.Text))
            {
                MessageBox.Show("Ingrese el legajo del tecnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLegajo.Focus();
                return false;
            }
            return true;
        }
    }
}
