using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Utils;
using System.Data;
using PagoElectronico.Domain;

namespace PagoElectronico.Repositories
{
    class FacturarRepository
    {

        internal List<PagoElectronico.Domain.Factura> getFacturas(PagoElectronico.Domain.Cliente cli)
        {
            if (cli == null)
            {
                return parseFacturas(DBAdapter.retrieveDataTable("getFacturasCli", DBNull.Value));
            }
            return parseFacturas(DBAdapter.retrieveDataTable("getFacturasCli", cli.ID));
        }

        internal DataTable getFacturasDT(Cliente cli)
        {
            if (cli == null)
            {
                return DBAdapter.retrieveDataTable("getFacturasCli",DBNull.Value);
            }
            return DBAdapter.retrieveDataTable("getFacturasCli",cli.ID);
        }

        private List<Factura> parseFacturas(DataTable facturas)
        {
            return facturas.AsEnumerable().Select(factura => parse(factura)).ToList();
        }

        private Factura parse(DataRow factura)
        {
            return new Factura(Convert.ToInt64(factura["Id"]), 
                                new ClienteRepository().getCliente(Convert.ToInt32(factura["Cliente"])), 
                                Convert.ToDateTime(factura["Fecha"])); 
        }

        internal Factura getFacturaById(long id)
        {
            return parse(DBAdapter.retrieveDataTable("getFacturaById", id).Rows[0]);
        }

        public long crearFactura()
        {
            return DBAdapter.executeProcedureWithLongReturnValue("crearFactura", CLC_SessionManager.currentUser.ID, CLC_SessionManager.getFecha());
        }

        public void agregarComisionPagada(long idFactura, int idComision)
        {
            DBAdapter.executeProcedure("agregarComisionPagada", idFactura, idComision);

        }
    }
}