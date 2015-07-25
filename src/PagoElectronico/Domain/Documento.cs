using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Documento
    {
        public TipoDocumento tipo;
        public long ID;

        public Documento(TipoDocumento tipo, long ID)
        {
            this.tipo = tipo;
            this.ID = ID;
        }

        public override string ToString()
        {
            return "Tipo: " + tipo.ToString() + " Nro: " + ID;
        }
    }
}
