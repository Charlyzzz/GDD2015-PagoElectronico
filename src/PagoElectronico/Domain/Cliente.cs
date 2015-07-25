using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Documento documento { get; set; }
        public string mail { get; set; }
        public Domicilio domicilio { get; set; }
        public Pais pais { get; set; }
        public DateTime fechaNacimimento { get; set; }
        public Boolean estado {get; set;}

        public Cliente(int ID,string nombre, string apellido, Documento doc, string mail, Domicilio dom, Pais pais, DateTime fechaNac,Boolean estado)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = doc;
            this.mail = mail;
            this.domicilio = dom;
            this.pais = pais;
            this.fechaNacimimento = fechaNac;
            this.estado = estado;
        }

        public override string ToString()
        {
            return nombre + " " + apellido;
        }

        public static Cliente Copy(Cliente c)
        {
            Boolean copyEstdo = c.estado;
            return new Cliente(c.ID, String.Copy(c.nombre), String.Copy(c.apellido), new Documento(c.documento.tipo,c.documento.ID), String.Copy(c.mail), new Domicilio(String.Copy(c.domicilio.calle),c.domicilio.numero,String.Copy(c.domicilio.departamento),c.domicilio.piso,String.Copy(c.domicilio.localidad),new Pais(c.domicilio.nacionalidad.Descripcion,c.domicilio.nacionalidad.Id)),
                    new Pais(c.pais.Descripcion,c.pais.Id), c.fechaNacimimento, copyEstdo);
        }
    }
}
