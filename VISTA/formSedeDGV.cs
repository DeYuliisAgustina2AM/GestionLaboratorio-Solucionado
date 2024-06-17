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
    public partial class formSedeDGV : Form
    {

        public formSedeDGV()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvSede.DataSource = null;
            dgvSede.DataSource = ControladoraSede.Instancia.RecuperarSedes();
            dgvSede.Columns["Universidad"].Visible = false; //lo oculto para prolijidad
            dgvSede.Columns["Laboratorios"].Visible = false; 
        }

        private void formSedeDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formSedeAM = new formSedeAM();
            formSedeAM.ShowDialog();
            ActualizarGrilla();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSede.Rows.Count > 0)
            {
                var sede = (Sede)dgvSede.CurrentRow.DataBoundItem;
                var mensaje = ControladoraSede.Instancia.EliminarSede(sede);
                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un sede para eliminarla");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSede.Rows.Count > 0)
            {
                var sedeSeleccionada = (Sede)dgvSede.CurrentRow.DataBoundItem;
                formSedeAM formSedeAM = new formSedeAM(sedeSeleccionada);
                formSedeAM.ShowDialog();
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione una sede para modificarla");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarSede.Text != "")
            {
                dgvSede.DataSource = ControladoraSede.Instancia.RecuperarSedes().Where(s => s.NombreSede.ToLower().Contains(txtBuscarSede.Text.ToLower())).ToList();
            }
            else
            {
                ActualizarGrilla(); 
            }
        }
    }
}  

