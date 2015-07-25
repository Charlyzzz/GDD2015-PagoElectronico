using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.Listados
{
    public partial class ListadoWindow : Form
    {
        public ListadoWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private DateTime parsearFechaInicial()
        {

            DateTime fecha;
            switch (cTrimestre.SelectedIndex)
            {
                case 0: fecha = Convert.ToDateTime("01/01/" + Convert.ToString(cAnio.Value)); break;
                case 1: fecha = Convert.ToDateTime("01/04/" + Convert.ToString(cAnio.Value)); break;
                case 2: fecha = Convert.ToDateTime("01/07/" + Convert.ToString(cAnio.Value)); break;
                default: fecha = Convert.ToDateTime("01/10/" + Convert.ToString(cAnio.Value)); break;
            }

            return fecha;
        
        }


        private DateTime parsearFechaFinal()
        {

            DateTime fecha;
            switch (cTrimestre.SelectedIndex)
            {
                case 0: fecha = Convert.ToDateTime("01/04/" + Convert.ToString(cAnio.Value)); break;
                case 1: fecha = Convert.ToDateTime("01/07/" + Convert.ToString(cAnio.Value)); break;
                case 2: fecha = Convert.ToDateTime("01/10/" + Convert.ToString(cAnio.Value)); break;
                default: fecha = Convert.ToDateTime("01/01/" + Convert.ToString(cAnio.Value +1)); break;
            }

            return fecha;

        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(cTrimestre, "trimestre") && !Validacion.estaVacio(cAnio, "año") && !Validacion.estaVacio(cConsulta, "consulta"))
            {

                DateTime fechaInicial = this.parsearFechaInicial();
                DateTime fechaFinal = this.parsearFechaFinal();

                switch (cConsulta.SelectedIndex)
                {
                    case 0:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("CLIENTES_CON_CUENTAS_INHABILITADAS_POR_AUSENCIA_DE_PAGO", fechaInicial, fechaFinal);
                            dataGridConsulta.DataSource = dt0;
                        } break;

                    case 1:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("CLIENTES_CON_MAYOR_CANTIDAD_DE_COMISIONES", fechaInicial, fechaFinal);
                            dataGridConsulta.DataSource = dt0;
                        } break;

                    case 2:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("CLIENTES_CON_MAYOR_CANTIDAD_DE_TRANSACCIONES_ENTRE_CUENTAS_PROPIAS", fechaInicial, fechaFinal);
                            dataGridConsulta.DataSource = dt0;
                        } break;

                    case 3:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("PAISES_CON_MAYOR_CANTIDAD_DE_MOVIMIENTOS", fechaInicial, fechaFinal);
                            dataGridConsulta.DataSource = dt0;
                        } break;

                    case 4:
                        {
                            DataTable dt0 = DBAdapter.retrieveDataTable("TOTAL_FACTURADO_PARA_DISTINTOS_TIPOS_DE_CUENTAS", fechaInicial, fechaFinal);
                            dataGridConsulta.DataSource = dt0;
                        } break;

                }

            }
        }


    }
}
