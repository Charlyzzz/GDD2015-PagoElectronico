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

namespace PagoElectronico.UI.Retiros
{
    public partial class RetirosSeleccionWindow : Form
    {
        public RetirosSeleccionWindow()
        {
            InitializeComponent();
        }


        private void RetirosSeleccionWindow_Load(object sender, EventArgs e)
        {
            moneda.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
            moneda.DropDownStyle = ComboBoxStyle.DropDownList;            
            cuenta.Enabled = false;            

            fechaTransferencia.Text = CLC_SessionManager.getFecha().ToShortDateString();
            bancoSeleccionado.DataSource = new BindingSource(new BindingList<BancoSoloNombre>(new TarjetaRepository().getBancosSoloNombre()), null);

            if (CLC_SessionManager.esAdministrador)
            {
                MessageBox.Show("Debe estar en modo CLIENTE para usar esta feature", "Alerta!");
                
                seleccionarCuenta.Enabled = false;
                retirar.Enabled = false;
                moneda.Enabled = false;
                monto.Enabled = false;
            }
            

        }
              

       

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionCuenta seleccionCuenta = new SeleccionCuenta();
            seleccionCuenta.ShowDialog(this);
            if (seleccionCuenta.CuentaSeleccionada != null)
            {
                cuenta.Text = Convert.ToString(seleccionCuenta.CuentaSeleccionada);
            }
        }     
        

       
        private void realizar_Click(object sender, EventArgs e)
        {
             List<string> listaDeErrores = new List<string>();
            if(cuenta.Text == "")
            {
                listaDeErrores.Add("No se seleccionó cuenta para realizar el retiro");
            }
            
            bool errorMonto=false;
            Decimal montoParseado;
            try
            {
                montoParseado = Decimal.Parse(monto.Text);
                if(cuenta.Text != "")
                {
                    Cuenta cuentaOrigen = new CuentaRepository().getCuentaById(Convert.ToInt64(cuenta.Text));
                    if( montoParseado > cuentaOrigen.Saldo)
                    {
                        listaDeErrores.Add("El monto supera el saldo disponible en su cuenta");
                    }
                    if(montoParseado < 0 )
                    {
                        listaDeErrores.Add("El monto es menor que cero");
                    }

                    if (montoParseado == 0)
                    {
                        listaDeErrores.Add("El monto no puede ser cero");
                    } 
                }
                
            
            }
            catch (Exception)
            {
                errorMonto = !errorMonto;
            }
              if(errorMonto)
            {
                 listaDeErrores.Add("Error en el formato del monto");
            }

              if (listaDeErrores.Count > 0)
              {
                  ErrorBoxHandler.showErrors(listaDeErrores, "Errores");
              }
              else 
              {                   
                  montoParseado = Decimal.Parse(monto.Text);
                  Cuenta cuentaOrigen = new CuentaRepository().getCuentaById(Convert.ToInt64(cuenta.Text));

                  new OperacionesRepository().realizarRetiro(cuentaOrigen.ID, (moneda.SelectedItem as Moneda).ID,
                      (bancoSeleccionado.SelectedItem as Banco).ID, montoParseado);
                  MessageBox.Show("Se procesó correctamente el retiro por "+monto.Text+", del tipo " + moneda.Text + ", a la cuenta " + cuenta.Text);
                  this.Close();
              }
                                 
        }
        
    }
}
