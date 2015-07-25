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

namespace PagoElectronico.UI.ABM_Cuenta
{
    public partial class SeleccionarCliente : Form
    {
        public Cliente ClienteSeleccionado { set; get; }

        protected static Dictionary<Type, Action<Control>> limpiadores = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = 0},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value = PagoElectronico.Utils.CLC_SessionManager.getFecha()},
            {typeof(Button), c => {}},
            {typeof(Label), c => {}},
            {typeof(GroupBox), c => LimpiarCampos(((GroupBox)c).Controls)},
            {typeof(DataGridView), c => ((DataGridView)c).DataSource=null},
        };
        
        public SeleccionarCliente()
        {
            InitializeComponent();
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
            this.modificarButton.Enabled = true;
            this.darDeBajaButton.Enabled = true;

        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
                        
            this.modificarButton.Hide();
            this.darDeBajaButton.Hide();
            this.tipoDocComboBox.DataSource = new BindingSource(new BindingList<TipoDocumento>(new ClienteRepository().getTipoDocumentos()), null);
            this.dataGridView1.DataSource = new BindingSource(new BindingList<Cliente>(new ClienteRepository().getClientes()), null);
        }

        private void darDeBajaButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente) dataGridView1.SelectedRows[0].DataBoundItem;
            DialogResult result = MessageBox.Show("Esta seguro que quiere eliminar este Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                new ClienteRepository().darDeBaja(cliente);
                MessageBox.Show("Cuenta eliminada con exito");
                this.dataGridView1.DataSource = new BindingSource(new BindingList<Cliente>(new ClienteRepository().getClientes()), null);
            }
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
           // new ModificarCliente().ShowDialog((Cliente) dataGridView1.SelectedRows[0].DataBoundItem);
            
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

    

        private void button2_Click(object sender, EventArgs e)
        {
            this.ClienteSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;            
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = hasSelectedItem();
        }
        private bool hasSelectedItem()
        {
            return dataGridView1.SelectedRows.Count > 0;
        }
        }

    }

