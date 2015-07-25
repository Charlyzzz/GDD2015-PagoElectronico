using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.UI.ABM_Rol
{
    public partial class ABMRolWindow : ABM_Form
    {
        public ABMRolWindow() : base("rol","ABMRol",false)
        {
           // InitializeComponent();
        }

        protected override void  doAlta()
         {
 	        new AltaRol().ShowDialog();
         }

        protected override void  doModificacionBaja()
        {
 	        new ModRol().ShowDialog();
        }



        }
    }

