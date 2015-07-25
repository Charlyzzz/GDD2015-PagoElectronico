using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Utils;
using PagoElectronico.Repositories;

namespace PagoElectronico.UI.Login
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
              
        private void button1_Click(object sender, EventArgs e)
        {
            UserRepository repo = new UserRepository();
            if (!usuarioTextbox.Text.Equals("") && !passwordTextbox.Text.Equals("") && repo.exists(usuarioTextbox.Text))
            {
                if (repo.exists(usuarioTextbox.Text))
                {
                    if (repo.userLogin(usuarioTextbox.Text, passwordTextbox.Text))
                    {
                        new CuentaRepository().deshabilitarCuentasPorExpiracion(CLC_SessionManager.currentUser.ID);
                        MessageBox.Show("Bienvenido " + CLC_SessionManager.currentUser.nombre, "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        new SeleccionarRol().ShowDialog(this);
                        this.Close();                        
                    }
                    else
                    {
                        MessageBox.Show("Si ha olvido su contrase;a, acceda a la opcion de login por pregunta de seguridad\n Si usted esta seguro de sus datos, puede ser que su usuario halla sido inhabilitado, consulte a un administrador.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    usuarioTextbox.BackColor = Color.Red;
                    MessageBox.Show("El usuario no ha sido encontrado, revise los datos ingresados", "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("No se han completados datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usuarioTextbox.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new OlvidoPasswordWindow().ShowDialog();            
        }
                    
    }
}
