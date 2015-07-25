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

namespace PagoElectronico.UI.ABM_Cuenta
{
    public partial class ABMCuentaWindow : Form
    {
        public ABMCuentaWindow()
        {
            InitializeComponent();

        }

        private void ABMCuentaWindow_Load(object sender, EventArgs e)
        {
           
            dataGridView1.ReadOnly = true;
           if (!CLC_SessionManager.esAdministrador)
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
            }
            else
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentas()), null);
            }
            dataGridView1.ClearSelection();
            dataGridView1.Columns["Cliente"].DisplayIndex = 1;
            if (!CLC_SessionManager.esAdministrador)
            {
                label1.Hide();
                textBox1.Hide();
                dataGridView1.Columns["Cliente"].Visible = false;

            }
            
            textBox1.Enabled = hasRows();
            comboBox1.DataSource = new BindingSource(new BindingList<TipoCuenta>(new TipoCuentaRepository().getTiposCuenta()),null);            
            comboBox1.Enabled = hasRows();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
           
            
            
                      
           
        }

                          
        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (CLC_SessionManager.esAdministrador)
            {
                button2.Enabled = hasSelectedRows();
                button3.Enabled = hasSelectedRows();
                renovarSubscripcionButton.Enabled = hasSelectedRows();
            }
            else
            {
                button2.Enabled = hasSelectedRows() && cuentaSeleccionada().EstadoCuenta.Descripcion != "Cerrada" && cuentaSeleccionada().EstadoCuenta.Descripcion != "Deshabilitada";
                button3.Enabled = hasSelectedRows() && cuentaSeleccionada().EstadoCuenta.Descripcion != "Cerrada";
                renovarSubscripcionButton.Enabled = hasSelectedRows() && cuentaSeleccionada().EstadoCuenta.Descripcion != "Cerrada" &&
                                                    cuentaSeleccionada().TipoCuenta.Descripcion != "Gratuita";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form altaCuenta = new AltaCuenta();
            altaCuenta.ShowDialog(this);
            if (!CLC_SessionManager.esAdministrador)
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
            }
            else
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentas()), null);
            }           
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            if (!CLC_SessionManager.esAdministrador)
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserId(CLC_SessionManager.currentUser.ID)), null);
            }
            else
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentas()), null);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {                         
            if (CLC_SessionManager.getFecha() >= cuentaSeleccionada().FechaCreacion)
            {
                if (new CuentaRepository().tieneDeudas(cuentaSeleccionada()))
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
                            new CuentaRepository().darBajaCuenta(cuentaSeleccionada().ID);
                            MessageBox.Show("La cuenta fué dada de baja", "Eliminar");
                        }
                    }
                    
                }
                else
                {
                    new CuentaRepository().darBajaCuenta(cuentaSeleccionada().ID);
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
            if (CLC_SessionManager.getFecha() > cuentaSeleccionada().FechaCreacion)
            {

                EditarCuenta editarCuenta = new EditarCuenta();
                editarCuenta.setCuenta(cuentaSeleccionada());
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
            }

        }

     

        private void button5_Click(object sender, EventArgs e)
        {
            if (!CLC_SessionManager.esAdministrador)
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByUserIdAndType(CLC_SessionManager.currentUser.ID, (comboBox1.SelectedItem as TipoCuenta).ID)), null);
            }
            else
            {
                dataGridView1.DataSource = new BindingSource(new BindingList<Cuenta>(new CuentaRepository().getCuentasByNameLikeAndType(textBox1.Text, (comboBox1.SelectedItem as TipoCuenta).ID)), null);
            
            }

        }

        private void renovarSubscripcionButton_Click(object sender, EventArgs e)
        {
            if (new ComisionRepository().cantidadComisionesImpagas(cuentaSeleccionada().ID) >= 5)
            {
                MessageBox.Show("Tiene más de cinco comisiones impagas, su cuenta se deshabilita", "Error");
                if (cuentaSeleccionada().EstadoCuenta.Id != 2)
                {
                    new CuentaRepository().deshabilitarCuenta(cuentaSeleccionada());
                    new CuentaRepository().registrarDeshabilitacion(cuentaSeleccionada().ID);
                }


            }
            else
            {
                new CuentaRepository().renovarSubscripcion(cuentaSeleccionada().ID);
                MessageBox.Show("Se renovó con exito la subscripción","Subscripción");
            }
        }

        private Cuenta cuentaSeleccionada()
        {

            return dataGridView1.SelectedRows[0].DataBoundItem as Cuenta;

        }

      
     
      
    }
}
