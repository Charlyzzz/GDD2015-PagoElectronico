using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;

namespace PagoElectronico.UI
{
    public partial class MenuPrincipalWindow : Form
    {
        public MenuPrincipalWindow()
        {
            InitializeComponent();
        }

        internal void ShowDialog(IWin32Window owner, PagoElectronico.Domain.Rol rol)
        {
            welcomeLabel.Text = "Bienvenido " + CLC_SessionManager.currentUser.ToString();
            rolLabel.Text = "Usted se encuentra logueado como " + rol.ToString();
            funcionalidadBox.DataSource = new BindingSource(new BindingList<Funcionalidad>(rol.funcionalidades),null);
            funcionalidadBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ShowDialog(owner);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcionalidadBox.SelectedItem != null)
            {
                var funcionalidad = (Funcionalidad)funcionalidadBox.SelectedItem;
                funcionalidad.Show();
            }
            else
            {
                MessageBox.Show("Debe elegir una funcionalidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que quiere cerrar su sesion?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.OK)
            {
                CLC_SessionManager.closeSession();
                //this.Close();
                this.Hide();
                new PagoElectronico.UI.Login.LoginWindow().ShowDialog(this);
                //CLC_SessionManager.ventanaPrincipal.Show();
            }
        }

       

    }
}
