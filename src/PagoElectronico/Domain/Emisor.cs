using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    class Emisor
    {
        public int ID { get; set; }
        public string descripcion { get; set; }

        public Emisor(int ID, string Descripcion)
        {
            this.ID = ID;
            this.descripcion = Descripcion;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
