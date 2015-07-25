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

namespace PagoElectronico.UI.ABM_Cuenta
{
    public partial class SeleccionWindow : Form
    {
        public Pais PaisSeleccionado { get; set; }        

        public SeleccionWindow()
        {
            InitializeComponent();
        }

        private void SeleccionWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DataSource = new BindingSource(new BindingList<Pais>(new PaisRepository().getPaises()), null);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.ClearSelection();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource(new BindingList<Pais>(new PaisRepository().getPaisLikeName(textBox1.Text)), null); ;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = hasSelectedItem();
        }

        private bool hasSelectedItem() 
        {
            return dataGridView1.SelectedRows.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.PaisSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Pais;
            this.Close();
        }

       
    }
}
