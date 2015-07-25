using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.UI.ABM_Cliente
{
    public class ABMClienteWindow : ABM_Form
    {
        public ABMClienteWindow()
            : base("cliente", "ABMCLiente",false)
        {
            InitializeComponent();
        }

        protected override void doAlta()
        {
            new AltaCliente().ShowDialog();
        }

        protected override void doModificacionBaja()
        {
            new SeleccionarCliente().ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ABMClienteWindow
            // 
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.ResumeLayout(false);

        }
    }
}
