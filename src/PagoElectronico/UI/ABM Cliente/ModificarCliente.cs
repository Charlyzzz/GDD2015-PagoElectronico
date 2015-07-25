using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;
using PagoElectronico.UI.Tarjetas;

namespace PagoElectronico.UI.ABM_Cliente
{
    public partial class ModificarCliente : Form
    {
        private Cliente cli;

        public ModificarCliente()
        {
            InitializeComponent();
        }

        internal void ShowDialog(Cliente cli)
        {
            this.cli = Cliente.Copy(cli);
            this.ShowDialog();
        }

        private void bindPaisCombo(ComboBox combo, Pais defaultValue)
        {
            combo.DataSource = new BindingSource(new BindingList<Pais>(new PaisRepository().getPaises()), null);
            combo.ValueMember = "Descripcion";
            combo.SelectedValue = defaultValue.Descripcion;
        }

        private Boolean realizarValidacionesGenerales()
        {
            Boolean valorGeneral = true;
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                {
                    valorGeneral = valorGeneral && !Validacion.noTieneSeleccion(control as ComboBox, control.Name);
                }

            }
            return valorGeneral;
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> list = new List<Cliente>();
            list.Add(this.cli);
            BindingSource ds = new BindingSource(new BindingList<Cliente>(list), null);
            this.clienteGrid.DataSource = ds;
            clienteGrid.Columns["documento"].Visible = false;
            clienteGrid.Columns["Pais"].Visible = false;
            clienteGrid.Columns["domicilio"].Visible = false;
            clienteGrid.Columns["ID"].Visible = false;
            this.domicilioGrid.DataSource = new BindingSource(new BindingList<Domicilio>(list.Select(c => c.domicilio).ToList()),null);
            this.domicilioGrid.Columns["nacionalidad"].Visible = false;
            bindPaisCombo(pais, cli.pais);
            bindPaisCombo(nacionalidad, cli.domicilio.nacionalidad);
            numeroDocumento.Text = cli.documento.ID.ToString();
            List<TipoDocumento> tipos = new ClienteRepository().getTipoDocumentos().Where(t => t.ID != -1).ToList();
            tipoDocumento.DataSource = new BindingSource(new BindingList<TipoDocumento>(tipos), null);
            tipoDocumento.ValueMember = "Descripcion";
            tipoDocumento.SelectedValue = cli.documento.tipo.ToString();
        }

        private void asociarDesacociarButton_Click(object sender, EventArgs e)
        {
            new TarjetasWindow().ShowFor(cli);
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            if (realizarValidacionesGenerales() && realizarValidacionesParticulares())
            {

                DialogResult consulta = MessageBox.Show("Esta seguro que quiere modificar el usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (consulta == DialogResult.Yes)
                {
                    new ClienteRepository().modificar(cli);
                    MessageBox.Show("Modificacion realizada con exito.");
                    this.Close();
                }
            }
        }

        private bool realizarValidacionesParticulares()
        {
            bool value = true;
            if (this.numeroDocumento.Text != "" || this.numeroDocumento.Text != null)
            {
                value = value && Validacion.soloNumeros(numeroDocumento, "Numero de documento");
            }
            return value && fechaNacimientoNoNula();
        }

        private bool fechaNacimientoNoNula()
        {
            if (cli.fechaNacimimento == null)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser nula");
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cli.pais = (Pais)pais.SelectedItem;
        }

        private void nacionalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cli.domicilio.nacionalidad = (Pais) nacionalidad.SelectedItem;
        }

        private void numeroDocumento_TextChanged(object sender, EventArgs e)
        {
            if (numeroDocumento.Text != "" && numeroDocumento.Text != null) {
                cli.documento.ID = Convert.ToInt64(numeroDocumento.Text);
            }
        }
    }
}
