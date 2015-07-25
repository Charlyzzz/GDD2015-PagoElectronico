using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain.Exceptions;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;
using PagoElectronico.Domain;

namespace PagoElectronico.UI.ABM_Cliente
{
    public partial class NuevoUsuario : Form
    {
        protected static Dictionary<Type, Action<Control>> limpiadores = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = -1},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value = PagoElectronico.Utils.CLC_SessionManager.getFecha()},
            {typeof(Button), c => {}},
            {typeof(Label), c => {}},
            {typeof(GroupBox), c => LimpiarCampos(((GroupBox)c).Controls)},
        };

        internal Usuario usuarioCreado { get; set; }

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void _limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this.Controls);
        }

        public static void LimpiarCampos(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
                limpiadores[control.GetType()].Invoke(control);
        }

        private Boolean realizarValidacionesGenerales()
        {
            Boolean valorGeneral = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    valorGeneral = valorGeneral && !Validacion.estaVacio(control, control.Name) && !Validacion.longitudIncorrecta(control, control.Name, 35);
                }

                if (control is ComboBox)
                {
                    valorGeneral = valorGeneral && !Validacion.noTieneSeleccion(control as ComboBox, control.Name);
                }

            }
            return valorGeneral;
        }

        private void _aceptar_Click(object sender, EventArgs e)
        {
           if (realizarValidacionesGenerales())
               if (!new UserRepository().exists(usernameTB.Text))
               {
                   this.DialogResult = DialogResult.OK;
                   this.usuarioCreado = new Usuario(-1, usernameTB.Text, true, 0, null, CLC_SessionManager.getFecha(), CLC_SessionManager.getFecha(), preguntaTB.Text,new Encription().encryptToSHA256(respuestaTB.Text),new Encription().encryptToSHA256(passwordTB.Text));
                   this.Close();
               }
          
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
       }

    }
}
