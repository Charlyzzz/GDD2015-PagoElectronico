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
using System.Text.RegularExpressions;
using PagoElectronico.Utils;


namespace PagoElectronico.UI.Retiros
{
    public partial class RetirosWindow : Form
    {
        public RetirosWindow()
        {
            InitializeComponent();
        }

        private void RetirosWindow_Load(object sender, EventArgs e)
        {
            if (CLC_SessionManager.esAdministrador)
            {
                MessageBox.Show("No se pueden realizar retiros en modo administrador", "Violación de seguridad");

                tipoDocumento.Enabled = false;
                numeroDocumento.Enabled = false;
                validarButton.Enabled = false;

            }
            else 
            {
                this.label1.Text = "Va a ser necesario que se verifique" + Environment.NewLine + " completando sus siguientes datos:";
                numeroDocumento.Text = "";
                tipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
                tipoDocumento.DataSource = new BindingSource(new BindingList<TipoDocumento>(new ClienteRepository().getTipoDocumentosPosta()), null);

            }
          

        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            if (!numeroDocumento.Text.ToCharArray().ToList().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Formato incorrecto. Ingrese todos los números de corrido", "Error");
            }
            else
            { 
                if( new UserRepository().esDocumentoCorrectoParaElUsuarioLogeado(Convert.ToInt64(numeroDocumento.Text),
                    (tipoDocumento.SelectedItem as TipoDocumento).ID))
                {
                    this.Hide();
                    RetirosSeleccionWindow pantallaDeRetiro = new RetirosSeleccionWindow();
                    pantallaDeRetiro.ShowDialog(this);
                    pantallaDeRetiro.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verificación incorrecta, se cierra la ventana", "Alerta");
                    this.Close();
                }

            }

        }
    }
}
