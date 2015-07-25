using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;
using PagoElectronico.Repositories;
using PagoElectronico.Domain;
using PagoElectronico.UI.ABM_Cuenta;

namespace PagoElectronico.UI.Depositos
{
    public partial class DepositosWindow : Form
    {
        public DepositosWindow()
        {
            InitializeComponent();
        }

        private void DepositosWindow_Load(object sender, EventArgs e)
        {
            this.clienteIDTextbox.Enabled = false;
            

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Id";

            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "Descripcion";

            comboBox3.ValueMember = "id";
            comboBox3.DisplayMember = "Ultimos_Digitos";
            comboBox3.Enabled = false;
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
            textBox1.Enabled = false;

            if (!CLC_SessionManager.esAdministrador)
            {
                seleccionarClienteButton.Enabled = false;
                textBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
                List<Tarjeta> tjHabilitadas = new TarjetaRepository().getTarjetasHabilitadas(CLC_SessionManager.currentUser.ID, CLC_SessionManager.getFecha());
                comboBox3.DataSource = new BindingSource(new BindingList<Tarjeta>(tjHabilitadas), null);
                clienteIDTextbox.Text = new ClienteRepository().getClienteByUserId(CLC_SessionManager.currentUser.ID).ID.ToString();
                comboBox2.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
                labelAdvertencia.Visible = false;
                comboBox1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasHabilitadasByUserID(CLC_SessionManager.currentUser.ID)), null);
                if (comboBox1.Items.Count == 0)
                {
                    comboBox1.Enabled = false;
                }
                else
                {
                }

                if (comboBox3.Items.Count == 0)
                {
                    comboBox3.Enabled = false;
                    labelAdvertencia.Visible = true;
                }
            }

      //      limpiarCampo();
        }

        private void guardarCampos_Click_1(object sender, EventArgs e)
        {
            if (!camposValidados())
            {
                MessageBox.Show("No están todos los campos obligatorios correctos");
                return;
            }

            DepositoRepository.realizarDeposito(Convert.ToInt64(comboBox1.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), Convert.ToDouble(textBox1.Text), Convert.ToInt32(comboBox2.SelectedValue));
            MessageBox.Show("Operación realizada con éxito!!");
            limpiarCampo();
        }

        private void limpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampo();
        }

        private void limpiarCampo()
        {
            foreach (var control in this.Controls.OfType<ComboBox>()) control.SelectedIndex = -1;
            textBox1.Text = "";
            this.ActiveControl = comboBox1;
        }

        private bool camposValidados()
        {
            if (comboBox3.Text != "" && Convert.ToDouble(textBox1.Text) > 0 && comboBox1.Text != "" && comboBox2.Text != "")
            {
                return true;
            }
            MessageBox.Show("El importe no es valido");
            return false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1)))
            {
                e.Handled = false;
            }

        }

        private void seleccionarClienteButton_Click(object sender, EventArgs e)
        {
            SeleccionarCliente seleccionar = new SeleccionarCliente();
            seleccionar.ShowDialog();
            Cliente cli = seleccionar.ClienteSeleccionado;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox3.DataSource = new BindingSource(new BindingList<Tarjeta>(new TarjetaRepository().getTarjetasHabilitadas(CLC_SessionManager.currentUser.ID, CLC_SessionManager.getFecha())), null);
            comboBox2.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
            labelAdvertencia.Visible = false;
            textBox1.Enabled = true;
            clienteIDTextbox.Text = cli.ID.ToString();
            comboBox1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByClienteId(cli.ID)), null);
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Enabled = false;
            }
            else
            {
            }

            if (comboBox3.Items.Count == 0)
            {
                comboBox3.Enabled = false;
                labelAdvertencia.Visible = true;
            }

        }

    }
}
