using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.Login
{
    public partial class SeleccionarRol : Form
    {
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        private void setAdministrador(Rol rol)
        {
            if (rol.ID == 0)
            {
                CLC_SessionManager.esAdministrador = true;
            }
            else
            {
                CLC_SessionManager.esAdministrador = false;
            };
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            if (rolCombo.SelectedItem != null)
            {
                setAdministrador((Rol)rolCombo.SelectedItem);
                this.Hide();
                new MenuPrincipalWindow().ShowDialog(this,(Rol) rolCombo.SelectedItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarRol_Load(object sender, EventArgs e)
        {
            if (CLC_SessionManager.currentUser.rol.Count() > 1)
            {
                rolCombo.DataSource = new BindingSource(new BindingList<Rol>(CLC_SessionManager.currentUser.rol), null);
            }
            else
            {
                setAdministrador(CLC_SessionManager.currentUser.rol.First());
                new MenuPrincipalWindow().ShowDialog(this,CLC_SessionManager.currentUser.rol.First());
                this.Close();
            }
        }


    }
}
