using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoElectronico.Domain
{
    class Usuario
    {
        public int ID;
        public string nombre;
        public Boolean estado;
        public int intentos_fallidos;
        public List<Rol> rol;
        public DateTime fechaCreacion;
        public DateTime fechaUltimaModificacion;
        public string preguntaSecreta;
        public string respuestaSecreta;
        public string password;
        

        public Usuario(int id, string nombre, Boolean estado, int intentos, List<Rol> rol) {
            this.ID = id;
            this.nombre = nombre;
            this.estado = estado;
            this.intentos_fallidos = intentos;
            this.rol = rol;
        }

        public Usuario(int id, string nombre, Boolean estado, int intentos, List<Rol> rol, DateTime fechaCreacion, DateTime fechaUltimaModificacion, string preguntaSecreta, string respuestaSecreta, string password)
        {
            this.ID = id;
            this.nombre = nombre;
            this.estado = estado;
            this.intentos_fallidos = intentos;
            this.rol = rol;
            this.fechaCreacion = fechaCreacion;
            this.fechaUltimaModificacion = fechaUltimaModificacion;
            this.preguntaSecreta = preguntaSecreta;
            this.respuestaSecreta = respuestaSecreta;
            this.password = password;
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}
