using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Factura
    {
        public long Id { set; get; }
        public Cliente Cliente { set; get; }
        public DateTime Fecha { set; get; }

        public Factura(long id,Cliente cliente,DateTime fecha)
        {
            this.Id = id;
            this.Cliente = cliente;
            this.Fecha = fecha;
        }

    }

}
