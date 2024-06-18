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
using static Entidades.Ticket;

namespace VISTA
{
    public partial class formTicketDGV : Form
    {
        public formTicketDGV()
        {
            InitializeComponent();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvTicket.DataSource = null;
            dgvTicket.DataSource = ControladoraTicket.Instancia.RecuperarTicket();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formHistorialDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formTicketAM = new formTicketAM();
            formTicketAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTicket.Rows.Count > 0)
            {
                var ticketSelecionado = (Ticket)dgvTicket.CurrentRow.DataBoundItem;
                var respuesta = ControladoraTicket.Instancia.EliminarTicket(ticketSelecionado);
                MessageBox.Show(respuesta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
            else
            {
                MessageBox.Show("Seleccione un ticket para eliminarlo");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTicket.Rows.Count > 0)
            {
                var ticketSeleccionado = (Ticket)dgvTicket.CurrentRow.DataBoundItem;
                formTicketAM formTicketAM = new formTicketAM(ticketSeleccionado);
                formTicketAM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un ticket para modificarlo");
            }
            ActualizarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
