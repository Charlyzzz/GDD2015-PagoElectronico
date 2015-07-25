using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Repositories;
using PagoElectronico.Domain;
using PagoElectronico.Utils;

namespace PagoElectronico.Repositories
{
    class TipoCuentaRepository
    {
        public TipoCuenta getTipoCuenta(long idTipoCuenta)
        {
            DataRow fila = DBAdapter.retrieveDataTable("getTipoCuenta", idTipoCuenta).Rows[0];
            return parse(fila);
        }

        public List<TipoCuenta> getTiposCuenta()
        {
            return parseTiposCuenta(DBAdapter.retrieveDataTable("getTiposCuentas"));

        }

        private TipoCuenta parse(DataRow fila)
        {
            int? val;
            if (fila["Duracion"] == DBNull.Value)
            {
                val = null;
            }
            else
            {
                val = Convert.ToInt32(fila["Duracion"]);
            }
            return new TipoCuenta(Convert.ToInt32(fila["Id"]), fila["Descripcion"] as string, val, Convert.ToDecimal(fila["Costo_Subscripcion"]), Convert.ToDecimal(fila["Costo_Transferencia_A_Terceros"]));
        }

        private List<TipoCuenta> parseTiposCuenta(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(fila => parse(fila)).ToList();
        }
    }
}
