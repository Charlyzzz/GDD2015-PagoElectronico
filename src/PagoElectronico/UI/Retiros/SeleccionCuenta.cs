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

namespace PagoElectronico.UI.Retiros
{
    public partial class SeleccionCuenta : Form
    {
        public SeleccionCuenta()
        {
            InitializeComponent();
            
        }

        public Cuenta CuentaSeleccionada { set; get; }

        private void SeleccionCuenta_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;            
            tipoDeCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoDeCuenta.DataSource = new BindingSource(new BindingList<TipoCuenta>(new TipoCuentaRepository().getTiposCuenta()), null);    
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
            dataGridView1.ClearSelection();
            dataGridView1.Columns["Cliente"].Visible = false;
            dataGridView1.ClearSelection();    

           

                   
                                          
                      
            
            
                      
           
        }

                          
        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            seleccionar.Enabled = hasSelectedRows() && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion == "Habilitada" &&
                               (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).Saldo > 0;
            
            
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
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserIdAndType(CLC_SessionManager.currentUser.ID,
                (tipoDeCuenta.SelectedItem as TipoCuenta).ID)), null);
                       
        }
              

        private void button2_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.getFecha() >= (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).FechaCreacion)
            {
                CuentaSeleccionada = dataGridView1.SelectedRows[0].DataBoundItem as Cuenta;
                this.Close();
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
        }

     

      

     

      
     
      
    }
}
