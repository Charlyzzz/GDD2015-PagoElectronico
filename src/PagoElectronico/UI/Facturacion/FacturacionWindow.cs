using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;
using PagoElectronico.UI.ABM_Cuenta;

namespace PagoElectronico.UI.Facturacion
{
    public partial class FacturacionWindow : Form
    {

        private Cliente cli;
        public FacturacionWindow()
        {
            InitializeComponent();
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente form = new SeleccionarCliente();
            form.ShowDialog();
            this.cli = form.ClienteSeleccionado;
            this.clienteActualTextbox.Text = cli.apellido + " " + cli.nombre + " id: " + cli.ID.ToString();
        }

        private void FacturacionWindow_Load(object sender, EventArgs e)
        {
            this.detalleButton.Enabled = false;
            if (CLC_SessionManager.esAdministrador)
            {
                this.cli = null;
                this.clienteActualTextbox.Text = "Todos los clientes";
            }
            else
            {
                this.seleccionar.Enabled = false;
                this.cli = new ClienteRepository().getClienteByUserId(CLC_SessionManager.currentUser.ID);
                this.clienteActualTextbox.Text = cli.apellido + " " + cli.nombre + " id: " + cli.ID.ToString();
            }
        }

        private void limpiarCampos_Click(object sender, EventArgs e)
        {
            this.cli = null;
            this.clienteActualTextbox.Text = "Todos los clientes";
            this.dataGridView1.DataSource = null;
            this.detalleButton.Enabled = false;
        }

        private void verFacturasButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new FacturarRepository().getFacturasDT(cli);
            this.detalleButton.Enabled = true;
        }

        private void detalleButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                new MostrarDetalleFactura().ShowDialog(Convert.ToInt64(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevaFacturaButton_Click(object sender, EventArgs e)
        {
            if (this.cli != null)
            {
                new SeleccionarComisiones(this.cli).ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }
    }
}