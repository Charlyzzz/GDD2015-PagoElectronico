using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class TipoCuenta
    {
        
        public long ID { get; set; }
        public string Descripcion { get; set; }
        public int? Duracion { get; set; }
        public decimal CostoSubscripcion { get; set; }
        public decimal CostoTransferencia { get; set; }

        public TipoCuenta(int id, string descripcion, int? duracion, decimal costoSubscripcion, decimal costoTransferencia)
        {
            this.ID = id;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
            this.CostoSubscripcion = costoSubscripcion;
            this.CostoTransferencia = costoTransferencia;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
