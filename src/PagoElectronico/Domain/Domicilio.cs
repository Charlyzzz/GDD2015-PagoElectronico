using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Domicilio
    {
        public string calle {get; set;}
        public int numero { get; set; }
        public string departamento {get;set;}
        public int piso { get; set; }
        public string localidad { get; set; }
        public Pais nacionalidad { get; set; }

        public Domicilio(string calle, int numero, string departamento, int piso, string localidad, Pais nacionalidad)
        {
            this.calle = calle;
            this.numero = numero;
            this.departamento = departamento;
            this.piso = piso;
            this.localidad = localidad;
            this.nacionalidad = nacionalidad;
        }

        public override string ToString()
        {
            if (departamento.Equals(""))
            {
                return "Domicilio: " + calle + " Numero: " + numero + " Localidad: " + localidad + " Nacionalidad" + nacionalidad.ToString();
            }
            return "Domicilio: " + calle + " Numero: " + numero + " Departamento: " + departamento + " Piso: " + piso + " Localidad: " + localidad + " Nacionalidad" + nacionalidad.ToString();
        }

    }
}
