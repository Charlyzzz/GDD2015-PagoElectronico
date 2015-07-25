using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.UI;

namespace PagoElectronico.Domain
{
    //TODO podriamos subclasificar para evitar ifs, en 'Cliente' 'Administrador' y 'Rol', o 'Rol' y 'Administrador'
    class Rol {
        public int ID { get; set; }
        public string nombre { get; set; }
        public Boolean estado { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }

        public Rol(int cod, string nombre, Boolean habilitado, List<Funcionalidad> funcionalidad)
        {
            this.ID = cod;
            this.nombre = nombre;
            this.estado = habilitado;
            this.funcionalidades = funcionalidad;
        }

        public override String ToString()
        {
            return nombre;
        }
        }
    }
