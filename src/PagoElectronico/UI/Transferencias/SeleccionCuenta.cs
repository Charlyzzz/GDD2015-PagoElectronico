using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;
using System.Data.SqlClient;
using PagoElectronico.Repositories;
using PagoElectronico.Domain;

namespace PagoElectronico.UI.Transferencias
{
    public partial class SeleccionCuenta : Form
    {
        public SeleccionCuenta()
        {
            InitializeComponent();
            
        }

        public Cuenta CuentaSeleccionada { get; set; }
        public bool cuentaPropia { get; set; }

        private void SeleccionCuenta_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cuentaPropia)
            {
                comboBox1.Hide();
                label2.Hide();
                buscar.Hide();
                buscar.Hide();
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
                dataGridView1.ClearSelection();
                dataGridView1.Columns["Cliente"].Visible = false;
                dataGridView1.ClearSelection();    

            }
            else
            {
                comboBox1.DataSource = new BindingSource(new BindingList<Usuario>(new UserRepository().getUsuariosConCuentasActivas()), null);
              
            }

                   
                                          
                      
            
            
                      
           
        }

                          
        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (cuentaPropia)
            {
                seleccionar.Enabled = hasSelectedRows() && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Cerrada" && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Deshabilitada"
                               && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Pendiente de Activacion" &&
                               (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).Saldo > 0;
            }
            else 
            {
                seleccionar.Enabled = hasSelectedRows() && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Cerrada" && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Deshabilitada"
                                   && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Pendiente de Activacion";
            }
            
        }

        private bool hasSelectedRows()
        {
            return dataGridView1.SelectedRows.Count > 0;
        }

        private bool hasRows()
        {
            return dataGridView1.Rows.Count > 0;
        }

         

        private void button4_Click(object sender, EventArgs e)
        {            
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(new UserRepository().getUserIdByUsername(comboBox1.Text))), null);
                       
        }
              

        private void button2_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.getFecha() >= (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).FechaCreacion)
            {
                CuentaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as Cuenta;
                this.Close();
            }

        }

     

      

     

      
     
      
    }
}
