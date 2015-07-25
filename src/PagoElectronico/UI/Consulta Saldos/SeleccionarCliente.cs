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
using PagoElectronico.Repositories;

namespace PagoElectronico.UI.Consulta_Saldos
{
    public partial class SeleccionarCliente : Form
    {

        ConsultaSaldoWindow formPadre;

        protected static Dictionary<Type, Action<Control>> limpiadores = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = 0},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value = PagoElectronico.Utils.CLC_SessionManager.getFecha()},
            {typeof(Button), c => {}},
            {typeof(Label), c => {}},
            {typeof(GroupBox), c => LimpiarCampos(((GroupBox)c).Controls)},
            {typeof(DataGridView), c => ((DataGridView)c).DataSource=null},
        };
        
        public SeleccionarCliente(ConsultaSaldoWindow formularioPadre)
        {
            InitializeComponent();
            formPadre = formularioPadre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                LimpiarCampos(this.Controls);
        }

        public static void LimpiarCampos(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
                limpiadores[control.GetType()].Invoke(control);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.seleccionarButton.Enabled = true;

        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            this.seleccionarButton.Enabled = false;
            this.tipoDocComboBox.DataSource = new BindingSource(new BindingList<TipoDocumento>(new ClienteRepository().getTipoDocumentos()), null);
            this.dataGridView1.DataSource = new BindingSource(new BindingList<Cliente>(new ClienteRepository().getClientes()), null);
        }


        private void buscarGrilla_Click(object sender, EventArgs e)
        {
            if (nroDocTextBox.Text != "")
            {
                this.dataGridView1.DataSource = new BindingSource(new BindingList<Cliente>(new ClienteRepository().findClientes(nombreTextBox.Text, apellidoTextBox.Text, (TipoDocumento)tipoDocComboBox.SelectedItem, emailTextBox.Text, Convert.ToInt32(nroDocTextBox.Text))), null);
            }
            else
            {
                this.dataGridView1.DataSource = new BindingSource(new BindingList<Cliente>(new ClienteRepository().findClientes(nombreTextBox.Text, apellidoTextBox.Text, (TipoDocumento)tipoDocComboBox.SelectedItem, emailTextBox.Text, null)), null);
            }
        }

        private void tipoDocComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            this.formPadre.setearCliente((Cliente)dataGridView1.SelectedRows[0].DataBoundItem);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}



