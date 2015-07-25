using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    class Tarjeta
    {
        public long? id {get; set;}
        public string numero {get; set;}
        public string ultimosCuatroDigitos {get;set;}
        public Emisor bancoEmisor {get; set;}
        public Cliente cliente {get; set;}
        public DateTime fechaEmision { get; set; }
        public DateTime fechaVencimiento {get; set;}
        public string codigoDeSeguridad { get; set; }
        public Boolean estado { get; set; }
        public string Titular { get; set; }

        public Tarjeta(long? id, string ultimosCuatro, string numero,Emisor bancoEmisor, Cliente cliente, DateTime fechaEmision, DateTime fechaVencimiento, string codigoDeSeguridad, Boolean estado, string Titular)
        {
            this.id = id;
            this.ultimosCuatroDigitos = ultimosCuatro;
            this.numero = numero;
            this.bancoEmisor = bancoEmisor;
            this.cliente = cliente;
            this.fechaEmision = fechaEmision;
            this.fechaVencimiento = fechaVencimiento;
            this.codigoDeSeguridad = codigoDeSeguridad;
            this.Titular = Titular;
            this.estado = estado;
        }

        public static Tarjeta Clone(Tarjeta t)
        {
            Boolean estadoCopy = t.estado;
            Tarjeta tj = new Tarjeta(t.id, String.Copy(t.ultimosCuatroDigitos), null, new Emisor(t.bancoEmisor.ID,t.bancoEmisor.descripcion),
                Cliente.Copy(t.cliente), t.fechaEmision, t.fechaVencimiento, null, estadoCopy, String.Copy(t.Titular));
            return tj;
        }

        public override string ToString()
        {
            return ultimosCuatroDigitos;
        }
    }
}
