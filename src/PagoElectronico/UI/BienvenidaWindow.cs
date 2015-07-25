using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Domain.Exceptions;
using PagoElectronico.UI.ErrorBox;

namespace PagoElectronico.UI
{
    public partial class BienvenidaWindow : Form
    {
        public BienvenidaWindow()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form pantallaLogin = new Login.LoginWindow();
            this.Hide();
            pantallaLogin.ShowDialog(this);
            this.Close();
         
        }

    
    }
}
