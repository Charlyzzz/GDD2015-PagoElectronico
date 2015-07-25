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
    public partial class DestinoWindow : Form
    {
        public DestinoWindow()
        {
            InitializeComponent();

        }

        public Cuenta CuentaSeleccionada { set; get; }

        private void ABMCuentaWindow_Load(object sender, EventArgs e)
        {
                                  
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ClearSelection();            
                                          
            comboBox1.DataSource = new BindingSource(new BindingList<TipoCuenta>(new TipoCuentaRepository().getTiposCuenta()),null);            
            comboBox1.Enabled = hasRows();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
            
            
                      
           
        }

                          
        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            seleccionar.Enabled = hasSelectedRows()&&(dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Cerrada" && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Deshabilitada"
                                && (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).EstadoCuenta.Descripcion != "Pendiente de Activacion";           
            
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
            dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {                         
            if (CLC_SessionManager.getFecha() >= (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).FechaCreacion)
            {
                if(new CuentaRepository().tieneDeudas((dataGridView1.SelectedRows[0].DataBoundItem as Cuenta)))
                {
                    if (!CLC_SessionManager.esAdministrador)
                    {
                        MessageBox.Show("Imposible elimar la cuenta seleccionada; presenta deudas","Error");
                    }
                    else 
                    {
                        DialogResult res = MessageBox.Show("La cuenta presenta deudas, ¿Desea eliminarla igual?", "Atención", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            new CuentaRepository().darBajaCuenta((dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).ID);
                        }
                    }
                    
                }
                else
                {
                    new CuentaRepository().darBajaCuenta((dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).ID);
                }
               
                if (!CLC_SessionManager.esAdministrador)
                {
                    dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
                }
                else
                {
                    dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentas()), null);
                }
            }
            else
            {
                MessageBox.Show("La fecha de hoy es anterior a la de creción de la cuenta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CLC_SessionManager.getFecha() >= (dataGridView1.SelectedRows[0].DataBoundItem as Cuenta).FechaCreacion)
            {
                /*
                                EditarCuenta editarCuenta = new EditarCuenta();
                                editarCuenta.setCuenta(dataGridView1.SelectedRows[0].DataBoundItem as Cuenta);
                                editarCuenta.ShowDialog(this);
                                if (!CLC_SessionManager.esAdministrador)
                                {
                                    dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
                                }
                                else
                                {
                                    dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentas()), null);
                                }
                            }
                            else 
                            {
                                MessageBox.Show("La fecha de hoy es anterior a la de creción de la cuenta");
                            }*/

            }
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            if (!CLC_SessionManager.esAdministrador)
            
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserIdAndType(CLC_SessionManager.currentUser.ID, (comboBox1.SelectedItem as TipoCuenta).ID)), null);
            
           

        }

      
     
      
    }
}
