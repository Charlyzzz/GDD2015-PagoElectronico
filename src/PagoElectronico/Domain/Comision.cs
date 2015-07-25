using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Comision
    {
        public long Id { set; get; }
        public Cuenta Cuenta { set; get; }
        public Factura Factura{ set; get; }
        public Operacion Operacion { set; get; }
        public TipoCuenta TipoCuenta { set; get; }
        public string Descripcion { set; get; }
        public Decimal Monto { set; get; }


         public Comision(long id, Cuenta cuenta, Factura factura, Operacion operacion, TipoCuenta tipoCuenta, string descripcion, decimal monto)
        {
             this.Id = id;
             this.Cuenta = cuenta;
             this.Factura = factura;
             this.Operacion = operacion;
             this.TipoCuenta = tipoCuenta;
             this.Descripcion = descripcion;
             this.Monto = monto;

        }
    }
}
