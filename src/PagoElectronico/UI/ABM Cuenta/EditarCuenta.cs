using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Repositories;
using PagoElectronico.Domain;
using PagoElectronico.Utils;


namespace PagoElectronico.UI.ABM_Cuenta
{
    public partial class EditarCuenta : Form
    {
        private Cuenta CuentaAntigua { set; get; }
        private Cuenta CuentaEditada { set; get; }
       
        public EditarCuenta()
        {
            InitializeComponent();
        }

        public void setCuenta(Cuenta cuenta)
        {
            CuentaAntigua = cuenta;
            CuentaEditada = cuenta.Clone() as Cuenta;
        }
        private void EditarCuenta_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = Convert.ToString(CuentaEditada.ID);
            textBox2.Enabled = false;
            textBox2.Text = CuentaEditada.Pais.ToString();
            comboBox1.DataSource = new BindingSource(new BindingList<Moneda>(new MonedaRepositoy().getMonedas()), null);
            comboBox1.SelectedItem = CuentaEditada.Moneda;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DataSource = new BindingSource(new BindingList<TipoCuenta>(new TipoCuentaRepository().getTiposCuenta()), null);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Text = CuentaEditada.TipoCuenta.ToString();
            adminEstadoCuenta.DataSource = new BindingSource(new BindingList<Estado>(new CuentaRepository().getEstados()), null);
            adminEstadoCuenta.Text = CuentaAntigua.EstadoCuenta.Descripcion;
            if(!CLC_SessionManager.esAdministrador)
            {
                adminEstadoCuenta.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaEditada.Pais = new PaisRepository().getPaisLikeName(textBox2.Text)[0];
            CuentaEditada.Moneda = comboBox1.SelectedItem as Moneda;
            CuentaEditada.TipoCuenta = comboBox2.SelectedItem as TipoCuenta;
            CuentaEditada.EstadoCuenta = adminEstadoCuenta.SelectedItem as Estado;

            if (CLC_SessionManager.esAdministrador)
            {
                new CuentaRepository().editCuentaAdmin(CuentaAntigua.ID, CuentaAntigua.Moneda.ID, CuentaEditada.Moneda.ID,
                           CuentaAntigua.Pais.Id, CuentaEditada.Pais.Id,
                           CuentaAntigua.TipoCuenta.ID, CuentaEditada.TipoCuenta.ID,CuentaEditada.EstadoCuenta.Id);                                
            }
            else
            {
                new CuentaRepository().editCuenta(CuentaAntigua.ID, CuentaAntigua.Moneda.ID, CuentaEditada.Moneda.ID,
                           CuentaAntigua.Pais.Id, CuentaEditada.Pais.Id,
                           CuentaAntigua.TipoCuenta.ID, CuentaEditada.TipoCuenta.ID);
                
            }
            MessageBox.Show("La cuenta fué editada con exito", "Success");
            this.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionWindow seleccionPais = new SeleccionWindow();
            seleccionPais.ShowDialog(this);
            if (!(seleccionPais.PaisSeleccionado == null))
            {
                textBox2.Text = Convert.ToString(seleccionPais.PaisSeleccionado);
            }
        }
    }
}
