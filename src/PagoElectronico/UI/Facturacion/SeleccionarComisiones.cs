using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;
using PagoElectronico.Domain;

namespace PagoElectronico.UI.Facturacion
{
    public partial class SeleccionarComisiones : Form
    {

        private Cliente cli;

        public SeleccionarComisiones(Cliente cliente)
        {
            InitializeComponent();
            cli = cliente;
        }

        private void SeleccionarComisiones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ComisionRepository().getComisionesById(cli.ID);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            textBox1.Enabled = false;
            chequearCuentas();
            foreach (DataGridViewColumn columna in dataGridView1.Columns) columna.ReadOnly = true;
        }

        private void chequearCuentas()
        {
            List<Cuenta> listaCuentas = new CuentaRepository().getCuentasByUserId(cli.ID);
            foreach (Cuenta cuenta in listaCuentas)
            {
                string id = cuenta.ID.ToString();
                if (cantidadOperacionesImpagas(cuenta.ToString()) > 5)
                {
                    if (new CuentaRepository().deshabilitarCuenta(cuenta))
                    {
                        new CuentaRepository().registrarDeshabilitacion(cuenta.ID);
                        MessageBox.Show("Se superaron las 5 comisiones, se inhabilitará la cuenta: " + cuenta + ". Debe abonar las comisiones adeudadas para rehabilitarla", "Demasiadas comisiones impagas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private int cantidadOperacionesImpagas(string cuenta)
        {
            int contador = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                string cuentaDeLaComision = fila.Cells["Cuenta"].Value.ToString();
                if (cuentaDeLaComision == cuenta) contador = contador + 1;
            }
            return contador;
        }

        private void aceptarSeleccion_Click(object sender, EventArgs e)
        {
            if (validacionCuentaElegida()) return;
            var listaIdentificacion = new List<int>();
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                listaIdentificacion.Add(Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["ID"].Value));
            }
            calcularTotal();
            facturar(listaIdentificacion);
            
        }

        private void facturar(List<int> listaIdentificacion)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea abonar las comisiones seleccionadas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                long numeroFactura = new FacturarRepository().crearFactura();
                foreach (int valor in listaIdentificacion)
                {
                    new FacturarRepository().agregarComisionPagada(numeroFactura, valor);

                }
                MessageBox.Show("Se ha facturado su solicitud con éxito!");
                chequearCuentasInhabilitadas();
                this.Close();
            }
        }

        private void chequearCuentasInhabilitadas()
        {
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                long cuenta = Convert.ToInt64(fila.Cells["Cuenta"].Value);

                if (!(new CuentaRepository().tieneDeudasByID(cuenta)))
                {
                    if (new CuentaRepository().cambiarEstadoCuentaHabilitando(cuenta))
                    {
                        MessageBox.Show("Se habilito la cuenta");
                    }
                }

            }
        }

        private void calcularTotal()
        {
            double total = 0;
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                total = total + Convert.ToDouble(fila.Cells["Monto"].Value);
            }
            textBox1.Text = total.ToString();
        }

        private bool validacionCuentaElegida()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una comisión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}