using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;

namespace PagoElectronico.UI.Facturacion
{
    public partial class MostrarDetalleFactura : Form
    {
        private Factura fact;
        public MostrarDetalleFactura()
        {
            InitializeComponent();
        }

        internal void ShowDialog(long facturaId)
        {
            this.fact = new PagoElectronico.Repositories.FacturarRepository().getFacturaById(facturaId);
            this.nyATextbox.Text = fact.Cliente.nombre + " " + fact.Cliente.apellido + " id: " + fact.Cliente.ID.ToString(); 
            this.dataGridView1.DataSource = new PagoElectronico.Repositories.ComisionRepository().getComisionDeFactura(facturaId);
            this.ShowDialog();
        }

        private void MostrarDetalleFactura_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
