using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Domain;
using PagoElectronico.Utils;
using System.Data;

namespace PagoElectronico.Repositories
{
    class MonedaRepositoy
    {

        public Moneda getMoneda(int idMoneda)
        {
            DataRow fila = DBAdapter.retrieveDataTable("getMoneda", idMoneda).Rows[0];
            return parse(fila);
        }

        public List<Moneda> getMonedas()
        {
            return parseMonedas(DBAdapter.retrieveDataTable("getMonedas"));
            
        }

        private Moneda parse(DataRow fila)
        {
            return new Moneda(Convert.ToInt32(fila["Id"]), fila["Descripcion"] as string);
        }

        private List<Moneda> parseMonedas(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(fila => parse(fila)).ToList();
        }

    }
}
