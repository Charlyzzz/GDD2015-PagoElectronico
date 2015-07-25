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
using PagoElectronico.UI.ErrorBox;

namespace PagoElectronico.UI.ABM_Cuenta
{
    public partial class AltaCuenta : Form
    {
        public AltaCuenta()
        {
            InitializeComponent();
        }

        public Cliente ClienteSeleccionado { set; get; }

        private void AltaCuenta_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DataSource = new BindingSource(new BindingList<TipoCuenta>(new TipoCuentaRepository().getTiposCuenta()), null);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox3.Enabled = false;
            textBox3.Text = CLC_SessionManager.getFecha().ToShortDateString();
            textBox1.Enabled = false;
                        
            if (!CLC_SessionManager.esAdministrador)
            {
                label6.Hide();
                textBox1.Hide();
                button3.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionWindow seleccionPais = new SeleccionWindow();
            seleccionPais.ShowDialog(this);
            if (!(seleccionPais.PaisSeleccionado == null))
            {
                textBox2.Text = Convert.ToString(seleccionPais.PaisSeleccionado);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listaDeErrores = new List<string>();

            if (textBox2.Text == "" || textBox2.Text == "null")
            {
                listaDeErrores.Add("Pais no seleccionado, por favor elija uno");
            }
            if (CLC_SessionManager.esAdministrador)
            {
                if (textBox1.Text == "" || textBox1.Text == "null")
                {
                    listaDeErrores.Add("Cliente no seleccionado, por favor elija uno");
                }
            }
            if (listaDeErrores.Count > 0)
            {
                ErrorBoxHandler.showErrors(listaDeErrores, "Problemas de validación");
            }
            else
            {
                if (CLC_SessionManager.esAdministrador)
                {
                    MessageBox.Show("El número de la nueva cuenta del cliente "+ textBox1.Text +" es: " + Convert.ToString(new CuentaRepository().darDeAltaCuenta(textBox2.Text, CLC_SessionManager.getFecha(),
                   comboBox1.SelectedItem as Moneda, comboBox2.SelectedItem as TipoCuenta, new UserRepository().getIdUsuarioByClientName(textBox1.Text))));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El número de su nueva cuenta es: " + Convert.ToString(new CuentaRepository().darDeAltaCuenta(textBox2.Text, CLC_SessionManager.getFecha(),
                    comboBox1.SelectedItem as Moneda, comboBox2.SelectedItem as TipoCuenta, CLC_SessionManager.currentUser.ID)));
                    this.Close();
                }
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionarCliente seleccionCliente = new SeleccionarCliente();
            seleccionCliente.ShowDialog(this);
            if (seleccionCliente.ClienteSeleccionado != null)
            {
                textBox1.Text = Convert.ToString(seleccionCliente.ClienteSeleccionado);
            }
        }



    }
}
