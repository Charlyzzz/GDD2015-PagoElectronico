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

namespace PagoElectronico.UI.ABM_Rol
{
    public partial class ModRol : Form
    {
        private List<Funcionalidad> list;
       
        public ModRol()
        {
            InitializeComponent();
        }

        private void cRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rol unRol = (Rol)cRol.SelectedItem;
                   
            // Levanto las funcionalidades del rol
            listFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(unRol.funcionalidades), null);
            list = unRol.funcionalidades;
            checkHabilitado.Checked = unRol.estado;
        }
            
        private void cFuncionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (cFuncionalidad.SelectedItem != null)
            {
                Funcionalidad f = (Funcionalidad) cFuncionalidad.SelectedItem;
                if (!listFuncionalidad.Items.Contains(f))
                {
                    this.list.Add((Funcionalidad)cFuncionalidad.SelectedItem);
                    listFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(this.list),null);
                }
            }

           
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {

            Rol unRol = (Rol)cRol.SelectedItem;
            checkHabilitado.Checked = unRol.estado;
            this.list = new FuncionalidadRepository().getFuncionalidades(unRol.ID);
            this.listFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(this.list), null);

        }

        private void bQuitar_Click(object sender, EventArgs e)
        {
            this.list = list.Where(f => f.id != ((Funcionalidad)listFuncionalidad.SelectedItem).id).ToList();
            this.listFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(this.list), null);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            new RolRepository().updateRol((Rol)cRol.SelectedItem, listFuncionalidad.Items.Cast<Funcionalidad>().ToList(),checkHabilitado.Checked);
            MessageBox.Show("Se modificó el rol satisfactoriamente");
            Close();
        }

        private void ModRol_Load(object sender, EventArgs e)
        {
             llenarComboBox();
        }

        private void llenarComboBox()
        {
            RolRepository repo = new RolRepository();
            cRol.DataSource = new BindingSource(new BindingList<Rol>(repo.getRoles()),null);
            FuncionalidadRepository repoFuncionalidades = new FuncionalidadRepository();
            this.list = ((Rol)cRol.SelectedItem).funcionalidades;
            cFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(repoFuncionalidades.getAllFuncionalidades()),null);
        }
    }
}
