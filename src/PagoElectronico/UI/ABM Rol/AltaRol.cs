using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.ABM_Rol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void AltaRol_Load_1(object sender, EventArgs e)
        {
            llenarComboBox();
        }

        private void llenarComboBox()
        {
            FuncionalidadRepository repo = new FuncionalidadRepository();
            cFuncionalidad.DataSource = new BindingSource(new BindingList<Funcionalidad>(repo.getAllFuncionalidades()),null);
        }

        private void bLimpiarFuncLista_Click(object sender, EventArgs e)
        {
            listFuncionalidad.Items.Clear();
        }

        private void bQuitarFuncLista_Click(object sender, EventArgs e)
        {
            int index = listFuncionalidad.SelectedIndex;
            if (index != -1)
                listFuncionalidad.Items.RemoveAt(index);
        }

        private void bAgregarFuncLista_Click(object sender, EventArgs e)
        {
            if (cFuncionalidad.SelectedItem != null)
            {
                String funcionalidad = cFuncionalidad.SelectedItem.ToString();
                if (!listFuncionalidad.Items.Contains(funcionalidad))
                    listFuncionalidad.Items.Add(funcionalidad);

            }

        }

        private void bAlta_Click(object sender, EventArgs e)
        {
            if (!Validacion.estaVacio(tNombre, "nombre") || Validacion.longitudIncorrecta(tNombre, "nombre", 25))
            {
                int idRol = DBAdapter.executeProcedureWithReturnValue("ABMROL_AltaRol", tNombre.Text.ToString());

                if (idRol == 0)
                {
                    MessageBox.Show("Ocurrió un error");
                    return;
                }

                for (int i = listFuncionalidad.Items.Count - 1; i >= 0; i--)
                {

                    DBAdapter.executeProcedure("ABMROL_AltaRolFuncionalidad", idRol, listFuncionalidad.Items[i].ToString());
                  
                }

                MessageBox.Show("Se creo el rol satisfactoriamente");

                Close();



            }
        }
    }
}
