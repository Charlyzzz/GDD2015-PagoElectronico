using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.Tarjetas
{
    public partial class RealizarModificacion : Form
    {
        private Tarjeta tj;

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

        private bool fechaEmisionMenorFechaVencimiento()
        {
            if (tj.fechaEmision > tj.fechaVencimiento)
            {
                MessageBox.Show("La fecha de emision debe ser menor a la fecha de vencimiento");
                return false;
            }
            return true;
        }

        private Boolean realizarValidacionesParticulares()
        {
            Boolean value = true;
            if(this.NumeroDeTarjeta.Text != "" || this.NumeroDeTarjeta.Text != null) {
                value = value && Validacion.soloNumeros(this.NumeroDeTarjeta, "Numero de Tarjeta") && Validacion.longitudDe(this.NumeroDeTarjeta, "Numero de Tarjeta", 16);
            }
            if (this.CodigoDeSeguridad.Text != "" || this.CodigoDeSeguridad.Text != null)
            {
                value = value && Validacion.soloNumeros(this.CodigoDeSeguridad,"Codigo de Seguridad") && Validacion.longitudDe(this.CodigoDeSeguridad, "Codigo de seguridad", 3);
            }
            return value && fechaEmisionMenorFechaVencimiento();
        }


        public RealizarModificacion()
        {
            InitializeComponent();
        }


        private void fillGrid()
        {
            List<Tarjeta> list = new List<Tarjeta>();
            list.Add(tj);
            this.dataGridView1.DataSource = new BindingSource(new BindingList<Tarjeta>(list), null);
            this.dataGridView1.Columns["numero"].Visible = false;
            this.dataGridView1.Columns["codigoDeSeguridad"].Visible = false;
            this.dataGridView1.Columns["bancoEmisor"].Visible = false;
            this.dataGridView1.Columns["cliente"].Visible = false;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["ultimosCuatroDigitos"].ReadOnly = true;
            
        }

        internal void ShowDialog(Tarjeta t)
        {
            this.tj = Tarjeta.Clone(t);
            fillGrid();
            this.Emisores.DataSource = new BindingSource(new BindingList<Emisor>(new TarjetaRepository().getEmisores()), null);
            this.Emisores.ValueMember = "descripcion";
            this.Emisores.SelectedValue = tj.bancoEmisor.descripcion;
            this.Emisores.DataBindings.Add(new Binding("SelectedItem", tj, "bancoEmisor", false));
            this.NumeroDeTarjeta.DataBindings.Add(new Binding("Text", tj, "numero", false));
            this.CodigoDeSeguridad.DataBindings.Add(new Binding("Text", tj, "codigoDeSeguridad", false));
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (realizarValidacionesGenerales() && realizarValidacionesParticulares())
            {
                DialogResult r = MessageBox.Show("Esta seguro que los datos son correctos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    if (this.NumeroDeTarjeta.Text != "" && this.NumeroDeTarjeta != null)
                    {
                        ((Tarjeta)this.dataGridView1.Rows[0].DataBoundItem).ultimosCuatroDigitos = this.NumeroDeTarjeta.Text.Substring(12, 4);
                    }
                   new TarjetaRepository().modificar(tj);
                   MessageBox.Show("Modificaciones realizadas con exito");
                   this.Close();
                }
            }
        }

        private void addDateTimePicker(int columnIndex,int rowIndex,DateTime date) {
            var dtp = new DateTimePicker();
            dataGridView1.Controls.Add(dtp);
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Value = date;
            Rectangle dtpRectangle = dataGridView1.GetCellDisplayRectangle(columnIndex,rowIndex,true);
            dtp.Size = new Size(dtpRectangle.Width,dtpRectangle.Height);
            dtp.Location = new Point(dtpRectangle.X,dtpRectangle.Y);
            dtp.CloseUp += new EventHandler(dtp_OnCloseUp);
            dtp.TextChanged += new EventHandler(dtp_OnTextChanged);
            dtp.Visible = true;
        }

        private void dtp_OnTextChanged(object send, EventArgs e) {
            dataGridView1.CurrentCell.Value = ((DateTimePicker) send).Text.ToString();
        }

        private void dtp_OnCloseUp(object send, EventArgs e) {
            ((DateTimePicker) send ).Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["fechaVencimiento"].Index == e.ColumnIndex || dataGridView1.Columns["fechaEmision"].Index == e.ColumnIndex)
            {
                if (dataGridView1.SelectedCells[0].Value != null && e.RowIndex != -1 )
                {
                    addDateTimePicker(e.ColumnIndex, e.RowIndex, ((DateTime)dataGridView1.SelectedCells[0].Value));
                }
            }
        }
    }
}
