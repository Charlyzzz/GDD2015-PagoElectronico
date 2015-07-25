using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Pais
    {
        public string Descripcion { get; set; }
        public int Id { get; set; }

        public Pais(string nombre, int id)
        {
            this.Descripcion = nombre;
            this.Id = id;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
