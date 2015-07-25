using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain;
using PagoElectronico.Domain.Exceptions;
using PagoElectronico.Repositories;
using PagoElectronico.Utils;

namespace PagoElectronico.UI.ABM_Cliente
{
    public partial class AltaCliente : Form
    {
        protected string nombre, apellido, nroId, mail, telefono, calle, altura, piso = "-1", depto = "-", localidad;
        protected TipoDocumento tipoId;
        protected Pais pais,nacionalidad;
        protected DateTime fechaNacimiento = PagoElectronico.Utils.CLC_SessionManager.getFecha();
        internal Usuario newUser { get; set; }

        protected static Dictionary<Type, Action<Control>> limpiadores = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(ComboBox), c => ((ComboBox)c).SelectedIndex = 0},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value = PagoElectronico.Utils.CLC_SessionManager.getFecha()},
            {typeof(Button), c => {}},
            {typeof(Label), c => {}},
            {typeof(GroupBox), c => LimpiarCampos(((GroupBox)c).Controls)},
        };

        public AltaCliente()
        {
            InitializeComponent();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
          if (newUser != null) {

          if (realizarValidacionesGenerales() && validarCamposParticulares())
             {
                   int cuentaNro = new ClienteRepository().darDeAlta(new Cliente(0, _nombre.Text, apellido, new Documento((TipoDocumento)tipo.SelectedValue, Convert.ToInt64(nroId)), mail, new Domicilio(calle, Convert.ToInt32(altura), depto, Convert.ToInt32(piso), localidad, (Pais)_nacionalidad.SelectedValue), pais, fechaNacimiento, true),
                                                      newUser);
                   MessageBox.Show("Cliente creado con exito, su numero de cliente es: " + cuentaNro);
                   this.Close();
                    
             }
          } else {
              MessageBox.Show("Debe crear un usuario primero");
          }
        }

        public Boolean validarCamposParticulares()
        {
            Boolean valid = true;
            if (_telefono.Text.Contains("-"))
            {
                valid = false;
                errorProvider1.SetError(_telefono, "El teléfono ingresado no debe contener guiones");
            }

            valid = valid && !existeDocumento() && Validacion.soloNumeros(_nroIdentificacion, "Nro Identificacion") && Validacion.emailValido(email)
                && Validacion.soloNumeros(_altura, "Altura") && Validacion.soloNumeros(_piso, "Piso") && Validacion.fechaMenorAlDiaDeHoy(fechadenacimiento, "Fecha de nacimiento") && !Validacion.longitudIncorrecta(_piso, "Piso", 2) && !Validacion.longitudIncorrecta(_Depto,"Departamento", 10);
            return valid;

        }

        private void LimpiarCeldas_Click(object sender, EventArgs e)
        {
            newUser = null;
            LimpiarCampos(this.Controls);
        }

        public static void LimpiarCampos(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
                limpiadores[control.GetType()].Invoke(control);
        }

        private void _ingresarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario form = new NuevoUsuario();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                newUser = form.usuarioCreado;
            }
            

        }

        private Boolean realizarValidacionesGenerales()
        {
            Boolean valorGeneral = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) {
                    valorGeneral = valorGeneral && !Validacion.estaVacio(control, control.Name) && !Validacion.longitudIncorrecta(control,control.Name,35);
                }

                if (control is ComboBox)
                {
                    valorGeneral = valorGeneral && !Validacion.noTieneSeleccion(control as ComboBox, control.Name);
                }

            }
            return valorGeneral;
        }

        private Boolean existeDocumento()
        {
            if (ClienteRepository.coincideDocumento(((TipoDocumento)tipo.SelectedValue).ID, _nroIdentificacion.Text))
            {
                MessageBox.Show("El numero y tipo de documento ingresado ya existen en nuestra base de datos");
                return true;
            };
            return false;
        }

        //================================Cosas randoms================================
        private void _nombre_TextChanged(object sender, EventArgs e)
        {
            nombre = _nombre.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            apellido = _apellido.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            nroId = _nroIdentificacion.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoId = (PagoElectronico.Domain.TipoDocumento) tipo.SelectedItem;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            mail = email.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            telefono = _telefono.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pais = (PagoElectronico.Domain.Pais)país.SelectedItem;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaNacimiento = fechadenacimiento.Value;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nacionalidad = (PagoElectronico.Domain.Pais)_nacionalidad.SelectedItem; 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calle = _calle.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            localidad = _localidad.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            altura = _altura.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            piso = _piso.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            depto = _Depto.Text;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            BindingSource p =  new BindingSource(new BindingList<Pais>(new PaisRepository().getPaises()), null);
            this.país.DataSource = p;
            BindingSource s = new BindingSource(new BindingList<Pais>(new PaisRepository().getPaises()), null);
            this._nacionalidad.DataSource = s;
            this.tipo.DataSource = new BindingSource(new BindingList<TipoDocumento>(new ClienteRepository().getTipoDocumentos().Where(tipoDoc => tipoDoc.ID != -1).ToList()), null);
        }
        
    }
}
