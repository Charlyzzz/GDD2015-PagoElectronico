using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Domain;
using PagoElectronico.Utils;


namespace PagoElectronico.Repositories
{
    class PaisRepository
    {
        public List<Pais> getPaisLikeName(string nameLike)
        { 
            IEnumerable<Pais> resultadoFiltrado =
                from pais in getPaises()
                where pais.Descripcion.ToUpper().Contains(nameLike.ToUpper())
                select pais;

            return resultadoFiltrado.ToList<Pais>();
                 
        }

        public Pais getPais(int idPais)
        {
            return parsePais(DBAdapter.retrieveDataTable("getPais", idPais).Rows[0]);
            
        }

        public List<Pais> getPaises()
        {
            return parsePaises(DBAdapter.retrieveDataTable("getPaises"));
        }

        private List<Pais> parsePaises(DataTable tabla)
        { 
            return tabla.AsEnumerable().Select(row => parsePais(row)).ToList();
        }

        private Pais parsePais(DataRow fila)
        {
            return new Pais(fila["Descripcion"] as string, Convert.ToInt32(fila["ID"]));
        }



    }
}
