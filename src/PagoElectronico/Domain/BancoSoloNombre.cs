using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class BancoSoloNombre:Banco
    {
        public BancoSoloNombre(int id, string direccion, string nombre)
        {
            this.ID = id;
            this.direccion = direccion;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
