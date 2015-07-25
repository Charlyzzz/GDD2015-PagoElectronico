using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Estado
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Estado(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
