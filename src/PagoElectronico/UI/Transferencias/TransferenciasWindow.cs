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

namespace PagoElectronico.UI.Transferencias
{
    public partial class TransferenciasWindow : Form
    {
        public TransferenciasWindow()
        {
            InitializeComponent();
        }


        private void TransferenciasWindow_Load(object sender, EventArgs e)
        {
            moneda.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
            moneda.DropDownStyle = ComboBoxStyle.DropDownList;
            
            origen.Enabled = false;
            destino.Enabled = false;
            fechaTransferencia.Text = Convert.ToDateTime(CLC_SessionManager.getFecha()).ToShortDateString();

            if (CLC_SessionManager.esAdministrador)
            {
                MessageBox.Show("Debe estar en modo CLIENTE para usar esta feature", "Alerta!");
                button2.Enabled = false;
                button3.Enabled = false;
                realizar.Enabled = false;
                moneda.Enabled = false;
                monto.Enabled = false;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionCuenta seleccionCuenta = new SeleccionCuenta();
            seleccionCuenta.cuentaPropia = false;
            seleccionCuenta.ShowDialog(this);
            if (seleccionCuenta.CuentaSeleccionada != null)
            {
                destino.Text = Convert.ToString(seleccionCuenta.CuentaSeleccionada);
            }            

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            SeleccionCuenta seleccionCuenta = new SeleccionCuenta();
            seleccionCuenta.cuentaPropia = true;
            seleccionCuenta.ShowDialog(this);           
            if (seleccionCuenta.CuentaSeleccionada != null)
            {
                origen.Text = Convert.ToString(seleccionCuenta.CuentaSeleccionada);
            }
        }

      
        

       
        private void realizar_Click(object sender, EventArgs e)
        {
             List<string> listaDeErrores = new List<string>();
            if(origen.Text == "")
            {
                listaDeErrores.Add("No se seleccionó cuenta de origen");
            }
             if(destino.Text == "")
            {
                 listaDeErrores.Add("No se seleccionó cuenta de destino");
            }
             if (destino.Text == origen.Text && destino.Text != "")
             {
                 listaDeErrores.Add("No se pueden realizar transferencias a la misma cuenta!");
             }
            bool errorMonto=false;
            Decimal montoParseado;
            try
            {
                montoParseado = Decimal.Parse(monto.Text);
                if(origen.Text != "")
                {
                    Cuenta cuentaOrigen = new CuentaRepository().getCuentaById(Convert.ToInt64(origen.Text));
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
                  Decimal costoOperacion = 0;
                  montoParseado = Decimal.Parse(monto.Text);
                  Cuenta cuentaOrigen = new CuentaRepository().getCuentaById(Convert.ToInt64(origen.Text));
                  Cuenta cuentaDestino = new CuentaRepository().getCuentaById(Convert.ToInt64(destino.Text));
                  if(cuentaDestino.Cliente.ID != cuentaOrigen.Cliente.ID)
                  {
                      costoOperacion = cuentaOrigen.TipoCuenta.CostoTransferencia;
                  }
                  new OperacionesRepository().realizarTransferencia(Convert.ToInt64(origen.Text), Convert.ToInt64(destino.Text),(moneda.SelectedItem as Moneda).ID,
                      montoParseado,costoOperacion);
                  MessageBox.Show("Se transfirieron exitosamente "+monto.Text+" del tipo " + moneda.Text + " a la cuenta " + destino.Text);
                  this.Close();
              }
                                 
        }
    }
}
