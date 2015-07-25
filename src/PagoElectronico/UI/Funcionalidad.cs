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
    public class Funcionalidad
    {
        public Form formDeFuncionalidad;
        public String descripcion;
        public int id;

        public override String ToString() {
            return descripcion;
        }

        public Funcionalidad(Form form, String desc, int id)
        {
            this.formDeFuncionalidad = form;
            this.descripcion = desc;
            this.id = id;
        }

        internal void Show()
        {
            formDeFuncionalidad.ShowDialog();
        }
    }
}
