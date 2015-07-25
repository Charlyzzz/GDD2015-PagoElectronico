using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Moneda
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public Moneda( int id , string descripcion) 
        {
            this.ID = id;
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
