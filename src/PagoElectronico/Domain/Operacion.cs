using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Operacion
    {
        public long Id { set; get; }
        public Cuenta Cuenta { set; get; }
        public DateTime Fecha { set; get; }
        public Decimal Importe { set; get; }

        public Operacion(long id, Cuenta cuenta, DateTime fecha, Decimal importe)
        {
            this.Id = id;
            this.Cuenta = cuenta;
            this.Fecha = fecha;
            this.Importe = importe;
        }
    }
}
