using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class formLaboratorioAM : Form
    {
        private Laboratorio laboratorio; // variable de tipo Sede para almacenar la sede que se va a modificar
        private bool modificar = false;

        public formLaboratorioAM()
        {
            InitializeComponent();
            laboratorio = new Laboratorio();
            ActualizarCb();
        }

        public formLaboratorioAM(Laboratorio laboratorioModificar)
        {
            InitializeComponent();
            laboratorio = laboratorioModificar;
            modificar = true;
            ActualizarCb();
        }

        public void ActualizarCb()
        {
            foreach (Sede sede in ControladoraSede.Instancia.RecuperarSedes()) // se recorren las sedes para agregarlas al combobox de sedes para que el usuario pueda seleccionar una sede para el laboratorio que se va a modificar
            {
                cbSedes.Items.Add(sede.NombreSede.ToString());
            }

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

        private void formLaboratorioAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Laboratorio";

                txtNombreLaboratorio.Text = laboratorio.NombreLaboratorio;
                cbSedes.SelectedValue = laboratorio.Sede;
                numCapacidad.Value = laboratorio.CapacidadMaxima;

            }
            else lblAgregaroModificar.Text = "Agregar Laboratorio";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    string NombreSede = cbSedes.Text; // se recupera el nombre de la sede seleccionada del combobox de sedes
                    Sede sede = ControladoraSede.Instancia.RecuperarSedes().FirstOrDefault(s => s.NombreSede.ToLower() == NombreSede.ToLower()); // se recupera la sede seleccionada del combobox de sedes para asignarla al laboratorio que se va a modificar
                    laboratorio.SedeId = sede.SedeId;
                    laboratorio.NombreLaboratorio = txtNombreLaboratorio.Text;
                    laboratorio.CapacidadMaxima = (int)numCapacidad.Value; // se asigna la capacidad máxima de computadoras al laboratorio que se va a modificar
                    var mensaje = ControladoraLaboratorio.Instancia.ModificarLaboratorio(laboratorio);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string NombreSede = cbSedes.Text;
                    Sede sede = ControladoraSede.Instancia.RecuperarSedes().FirstOrDefault(s => s.NombreSede.ToLower() == NombreSede.ToLower()); // se recupera la sede seleccionada del combobox de sedes para asignarla al laboratorio que se va a modificar
                    laboratorio.SedeId = sede.SedeId;
                    laboratorio.NombreLaboratorio = txtNombreLaboratorio.Text;
                    laboratorio.CapacidadMaxima = (int)numCapacidad.Value; // se asigna la capacidad máxima de computadoras al laboratorio que se va a modificar

                    var mensaje = ControladoraLaboratorio.Instancia.AgregarLaboratorio(laboratorio);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreLaboratorio.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de laboratorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbSedes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una sede para agregar el laboratorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numCapacidad.Value == 0)
            {
                MessageBox.Show("Debe ingresar un número de capacidad máxima de computadoras para el laboratorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
