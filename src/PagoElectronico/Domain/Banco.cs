using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Banco
    {
        public int ID { get; set; }
        public string direccion { get; set; }
        public string nombre { get; set; }

        public Banco(int id, string direccion, string nombre)
        {
            this.ID = id;
            this.direccion = direccion;
            this.nombre = nombre;
        }

        public Banco()
        {
           
        }

        public override string ToString()
        {
            return "Banco: " + nombre + " Direccion: " + direccion;
        }
    }
}
