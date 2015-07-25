using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.UI.ABM_Cuenta;

namespace PagoElectronico.UI
{
    public abstract partial class ABM_Form : Form
    {
        protected Cliente cli {get;set;}
        private Boolean administratorDifference {get;set;}

        public ABM_Form(String abmCosa, String titulo,Boolean administratorDifference)
        {
            InitializeComponent();
            this.Text = titulo;
            this.administratorDifference = administratorDifference;
            this.altaRadioButton.Text = "Dar de alta un " + abmCosa;
            this.modificarDarDeBajaRadioButton.Text = "Modificar/Dar de baja un " + abmCosa;
        }

        private void button1_Click(object sender, EventArgs e) {
         if (altaRadioButton.Checked)
            {
                doAlta();
            }
            else
            {
                doModificacionBaja();
            }
        }

        protected abstract void doAlta();
        protected abstract void doModificacionBaja();

        private void ABM_Form_Load(object sender, EventArgs e)
        {
            if (administratorDifference && PagoElectronico.Utils.CLC_SessionManager.esAdministrador && this.cli == null)
            {
                SeleccionarCliente seleccionCliente = new SeleccionarCliente();
                seleccionCliente.ShowDialog();
                this.cli = seleccionCliente.ClienteSeleccionado;
            }
            else
            {
                if (!PagoElectronico.Utils.CLC_SessionManager.esAdministrador && this.cli == null)
                {
                    this.cli = new PagoElectronico.Repositories.ClienteRepository().getClienteByUserId(PagoElectronico.Utils.CLC_SessionManager.currentUser.ID);
                }
            }
        }

    }
}
