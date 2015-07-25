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
    public partial class OlvidoPasswordWindow : Form
    {
        public OlvidoPasswordWindow()
        {
            InitializeComponent();
        }

        private void OlvidoPasswordWindow_Load(object sender, EventArgs e)
        {
            this.respuestaTextbox.Enabled = false;
            this.respuestaButton.Enabled = false;
            this.buscarPreguntaButton.Focus();
        }

        private void repuestaButton_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            if(!respuestaTextbox.Text.Equals("") && repo.userLoginPorPregunta(usernameTextbox.Text,respuestaTextbox.Text)) {
                this.Hide();
                    repo.setPassword(usernameTextbox.Text, "nuevaPassword");
                    MessageBox.Show("Bienvenido " + CLC_SessionManager.currentUser.nombre + ".\n Su nueva password es 'nuevaPassword'. Cambiela cuanto antes.", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    new SeleccionarRol().ShowDialog();
                } else {
                    MessageBox.Show("Respuesta incorrecta","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        private void buscarPreguntaButton_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            if (!usernameTextbox.Text.Equals("") && repo.exists(usernameTextbox.Text))
            {
                    PreguntaSecreta.Text = repo.getPregunta(usernameTextbox.Text);
                    respuestaTextbox.Enabled = true;
                    respuestaButton.Enabled = true;
            }
            else { MessageBox.Show("Usuario invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            PreguntaSecreta.Text = "PreguntaSecreta";
            respuestaTextbox.Enabled = false;
            respuestaButton.Enabled = false;
        }

    }
}
