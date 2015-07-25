using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Repositories;
using PagoElectronico.Domain;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.Consulta_Saldos
{
    public partial class ConsultaSaldoWindow : Form
    {
        public Cliente cliente { get; set; }
        private Usuario usuarioActual { get; set; }

        public ConsultaSaldoWindow()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaSaldoWindow_Load(object sender, EventArgs e)
        {
            usuarioActual = CLC_SessionManager.currentUser;
            if (!CLC_SessionManager.esAdministrador)
            {
                ClienteRepository repo =  new ClienteRepository();
                bBuscarCliente.Visible = false;
                setearCliente(repo.getClienteByUserId(CLC_SessionManager.currentUser.ID));
            }
        }

        public void setearCliente(Cliente nuevoCliente)
        {
            this.cliente = nuevoCliente;
            tNombreChabon.Text = this.cliente.nombre + " " + this.cliente.apellido;

            CuentaRepository repo = new CuentaRepository();
            cCuenta.DataSource = new BindingSource(new BindingList<Cuenta>(repo.getCuentasByClienteId(cliente.ID)), null);

        }


        private void cCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtDepositos = DBAdapter.retrieveDataTable("Consulta_Saldos_Ultimos5Depositos", cCuenta.SelectedItem.ToString());
            gridDepositos.DataSource = dtDepositos;

            DataTable dtRetiros = DBAdapter.retrieveDataTable("Consulta_Saldos_Ultimos5Retiros", cCuenta.SelectedItem.ToString());
            gridRetiros.DataSource = dtRetiros;

            DataTable dtTransferencias = DBAdapter.retrieveDataTable("Consulta_Saldos_Ultimas10Transferencias", cCuenta.SelectedItem.ToString());
            gridTransferencias.DataSource = dtTransferencias;

            tSaldo.Text = ((Cuenta)cCuenta.SelectedItem).Saldo.ToString();

        }

        private void tSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridDepositos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bBuscarCliente_Click(object sender, EventArgs e)
        {
            SeleccionarCliente buscadorcito = new SeleccionarCliente(this);
            buscadorcito.Show();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
