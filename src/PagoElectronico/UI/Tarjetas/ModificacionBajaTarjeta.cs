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

namespace PagoElectronico.UI.Tarjetas
{
    public partial class ModificacionBajaTarjeta : Form
    {
        private Cliente cli;

        public ModificacionBajaTarjeta()
        {
            InitializeComponent();
        }

        public void ShowDialog(Cliente cli)
        {
            this.cli = cli;
            this.ShowDialog();
        }

        private void llenarTarjetaGrid(List<Tarjeta> list)
        {
            this.tarjetaDataGrid.DataSource = new BindingSource(new BindingList<Tarjeta>(list), null);
            tarjetaDataGrid.Columns["codigoDeSeguridad"].Visible = false;
            tarjetaDataGrid.Columns["numero"].Visible = false;
        }

        private void ModificacionBajaTarjeta_Load(object sender, EventArgs e)
        {
            llenarTarjetaGrid(new TarjetaRepository().getTarjetasByCliente(cli.ID));
            this.emisorCombo.DataSource = new BindingSource(new BindingList<Emisor>(new TarjetaRepository().getEmisores()), null);
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            List<Tarjeta> tarjetas = new TarjetaRepository().getTarjetasByCliente(cli.ID).Where(tarjeta => tarjeta.bancoEmisor.ID == ((Emisor) emisorCombo.SelectedItem).ID).ToList();
            llenarTarjetaGrid(tarjetas);
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            new RealizarModificacion().ShowDialog((Tarjeta) tarjetaDataGrid.SelectedRows[0].DataBoundItem);
        }
    }
}
