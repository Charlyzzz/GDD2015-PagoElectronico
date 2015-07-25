using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    public class Cuenta : ICloneable
    {
        [System.ComponentModel.DisplayName("Id")]
        public long ID {get; set;}
        [System.ComponentModel.DisplayName("Tipo")]
        public TipoCuenta TipoCuenta {get; set;}
        public Moneda Moneda {get; set;}
        public Pais Pais {get; set;}
        public Cliente Cliente {get; set;}
        [System.ComponentModel.DisplayName("Estado")]
        public Estado EstadoCuenta {get; set;}
        [System.ComponentModel.DisplayName("Fecha de creacion")]
        public DateTime FechaCreacion {get; set;}
        [System.ComponentModel.DisplayName("Fecha de cierre")]
        public DateTime? FechaCierre {get; set;}
        public decimal Saldo {get; set;}
        [System.ComponentModel.DisplayName("Fecha de expiracion")]
        public DateTime? FechaExpiracion { get; set; }

        public Cuenta(long id, TipoCuenta tipoCuenta, Moneda moneda, Pais pais,
            Cliente cliente,Estado estadoCuenta,DateTime fechaCreacion,DateTime? fechaCierre, decimal saldo,DateTime? fechaExp  )
        {
            this.ID = id;
            this.TipoCuenta = tipoCuenta;
            this.Moneda= moneda;
            this.Pais = pais;
            this.Cliente = cliente;
            this.EstadoCuenta = estadoCuenta;
            this.FechaCreacion = fechaCreacion;
            this.FechaCierre = fechaCierre;
            this.Saldo = saldo;
            this.FechaExpiracion = fechaExp;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool CustomEqualsEditarCuenta(Cuenta cuenta)
        {         
            if (cuenta == null)
                return false;
            else
                return  this.Moneda.ID.Equals(cuenta.Moneda.ID) &&
                        this.EstadoCuenta.Id == cuenta.EstadoCuenta.Id&&
                        this.Pais.Id.Equals(cuenta.Pais.Id);
        }

        public override string ToString()
        {
            return Convert.ToString(ID);
        }
    }
}
