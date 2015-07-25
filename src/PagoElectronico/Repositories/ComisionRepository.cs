using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Utils;
using System.Data;

namespace PagoElectronico.Repositories
{
    class ComisionRepository
    {
        public int cantidadComisionesImpagas(long idCuenta)
        {
            return Convert.ToInt32((DBAdapter.retrieveDataTable("cantidadComisionesImpagas", idCuenta)).Rows[0][0]);
        }

        public DataTable getComisionesById(int id)
        {
            return DBAdapter.retrieveDataTable("getComisionesById", id);
        }

        public DataTable getComisionDeFactura(long facturaId)
        {
            return DBAdapter.retrieveDataTable("getComisionesFactura", facturaId);
        }

    }
}
