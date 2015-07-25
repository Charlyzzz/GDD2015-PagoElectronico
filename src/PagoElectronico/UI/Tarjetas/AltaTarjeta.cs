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

namespace PagoElectronico.UI.Tarjetas
{
    public partial class AltaTarjeta : Form
    {
        private Cliente cli;

        protected static Dictionary<Type, Action<Control>> limpiadores = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = 0},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value = PagoElectronico.Utils.CLC_SessionManager.getFecha()},
            {typeof(Button), c => {}},
            {typeof(Label), c => {}},
            {typeof(GroupBox), c => LimpiarCampos(((GroupBox)c).Controls)},
        };

        public static void LimpiarCampos(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
                limpiadores[control.GetType()].Invoke(control);
        }


        private Boolean realizarValidacionesGenerales()
        {
            Boolean valorGeneral = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    valorGeneral = valorGeneral && !Validacion.estaVacio(control, control.Name) && !Validacion.longitudIncorrecta(control, control.Name, 16);
                }

                if (control is ComboBox)
                {
                    valorGeneral = valorGeneral && !Validacion.noTieneSeleccion(control as ComboBox, control.Name);
                }

            }
            return valorGeneral;
        }

        private Boolean realizarValidacionesParticulares()
        {
            return Validacion.fechaMenorAlDiaDeHoy(FechaEmision,"emision") && Validacion.fechaMayorAlDiaDeHoy(FechaVenciento,"vencimiento") && Validacion.soloNumeros(NumeroTarjeta,"Numero de Tarjeta") && Validacion.soloNumeros(CodigoSeguridad,"Codigo de seguridad")
                && Validacion.fechaMenorAFecha(FechaEmision,FechaVenciento,"emision","vencimiento") && Validacion.longitudDe(NumeroTarjeta,"Numero de Tarjeta",16)
                && Validacion.soloLetras(Titular,"Titular") && Validacion.longitudDe(CodigoSeguridad,"Codigo de Seguridad",3);
        }


        public AltaTarjeta()
        {
            InitializeComponent();
        }

        public void ShowDialog(Cliente cli)
        {
            this.cli = cli;
            this.ShowDialog();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this.Controls);
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (realizarValidacionesGenerales() && realizarValidacionesParticulares())
            {
                DialogResult result = MessageBox.Show("Esta seguro que los datos son correctos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (new TarjetaRepository().coincideTarjeta(NumeroTarjeta.Text))
                    {
                        MessageBox.Show("Ya hay una tarjeta asociada con ese número");
                    }
                    else 
                    {
                        new TarjetaRepository().asociar(new Tarjeta(0, NumeroTarjeta.Text.Substring(12, 4), NumeroTarjeta.Text, (Emisor)Emisor.SelectedItem, cli, FechaEmision.Value, FechaVenciento.Value, CodigoSeguridad.Text, true, Titular.Text));
                        MessageBox.Show("Tarjeta asociada correctamente");
                        this.Close();
                    }
                    
                }
            }
        }

        private void AltaTarjeta_Load(object sender, EventArgs e)
        {
            this.Emisor.DataSource = new BindingSource(new BindingList<Emisor>(new TarjetaRepository().getEmisores()), null);
        }
    }
}
