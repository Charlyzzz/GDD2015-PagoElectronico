using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;
using PagoElectronico.Domain;

namespace PagoElectronico.UI.Tarjetas
{
    public partial class TarjetasWindow : ABM_Form
    {

        public TarjetasWindow()
            : base("tarjeta", "Tarjetas",true)
        {
        }

        protected override void doAlta()
        {
            new AltaTarjeta().ShowDialog(cli);
        }

        protected override void doModificacionBaja()
        {
            new ModificacionBajaTarjeta().ShowDialog(cli);
        }

        internal void ShowFor(Cliente cli) {
            this.cli = cli;
            this.ShowDialog();
            this.Close();
        }


    }
}
