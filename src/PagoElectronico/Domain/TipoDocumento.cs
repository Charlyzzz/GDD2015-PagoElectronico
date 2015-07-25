using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class TipoDocumento
    {
        public long ID { get; set; }
        public string Descripcion { get; set; }

        public TipoDocumento(int ID, string descripcion)
        {
            this.ID = ID;
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }

       
    }
}
