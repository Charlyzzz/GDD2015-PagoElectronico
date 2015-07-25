using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Domain;
using PagoElectronico.Utils;


namespace PagoElectronico.Repositories
{
    class CuentaRepository
    {
        public void registrarDeshabilitacion(long idCuenta)
        {
            DBAdapter.executeProcedure("registrarInhabilitacion", idCuenta,CLC_SessionManager.getFecha());
        }
        public bool tieneDeudasByID(long idCuenta)
        {
            return DBAdapter.checkIfExists("tieneDeudasById", idCuenta);
        }

        public List<Estado> getEstados()
        {
            return parseEstados(DBAdapter.retrieveDataTable("getEstados"));
        }

        public void renovarSubscripcion(long idCuenta)
        {
            DBAdapter.executeProcedure("renovarSubscripcion", idCuenta, CLC_SessionManager.getFecha());
        }

        public void editCuenta(long idCuenta, long idMonedaVieja, long idMonedaNueva, long idPaisViejo, long idPaisNuevo,
            long idTipoCuentaVieja, long idTipoCuentaNueva)
        {


            DBAdapter.executeProcedure("editCuenta", idCuenta, idMonedaVieja, idMonedaNueva,
                           idPaisViejo, idPaisNuevo,
                           idTipoCuentaVieja, idTipoCuentaNueva, CLC_SessionManager.getFecha());
        }

        public void editCuentaAdmin(long idCuenta, long idMonedaVieja, long idMonedaNueva, long idPaisViejo, long idPaisNuevo,
           long idTipoCuentaVieja, long idTipoCuentaNueva, long idEstadoCuenta)
        {


            DBAdapter.executeProcedure("editCuentaAdmin", idCuenta, idMonedaVieja, idMonedaNueva,
                           idPaisViejo, idPaisNuevo,
                           idTipoCuentaVieja, idTipoCuentaNueva, CLC_SessionManager.getFecha(), idEstadoCuenta);
        }

        public Cuenta getCuentaById(long idCuenta)
        {
            return parse(DBAdapter.retrieveDataTable("getCuentaById", idCuenta).Rows[0]);
        }

        public Boolean tieneDeudas(Cuenta cuenta)
        {
            return DBAdapter.checkIfExists("tieneDeudas", cuenta.ID);
        }

        public List<Cuenta> getCuentasByNameLikeAndType(string nameLike, long idTipoCuenta)
        {
            IEnumerable<Cuenta> resultadoParcial = parseCuentas(DBAdapter.retrieveDataTable("getCuentasClientNameLike", nameLike));
            return (from cuenta in resultadoParcial where cuenta.TipoCuenta.ID == idTipoCuenta select cuenta).ToList();
        }

        public void darBajaCuenta(long idCuenta)
        {
            DBAdapter.executeProcedure("darBajaCuenta", idCuenta, CLC_SessionManager.getFecha());

        }


        public long darDeAltaCuenta(string pais, DateTime fechaDeCreacion, Moneda moneda, TipoCuenta tipoCuenta, int idUsuario)
        {
            return DBAdapter.executeProcedureWithLongReturnValue("darAltaCuenta", idUsuario, new PaisRepository().getPaisLikeName(pais)[0].Id, fechaDeCreacion, moneda.ID, tipoCuenta.ID);

        }

        public List<Cuenta> getCuentas()
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentas"));
        }


        public List<Cuenta> getCuentasByUserId(long IdUser)
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentasByUserId", IdUser));
        }

        public List<Cuenta> getCuentasByClienteId(long IdCliente)
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentasByClienteId", IdCliente, null));
        }

        public List<Cuenta> getCuentasHabilitadasByUserID(int IdUser)
        {
            if (CLC_SessionManager.esAdministrador)
            {
                return parseCuentas(DBAdapter.retrieveDataTable("getCuentasHabilitadas"));
            }
            return _getCuentasHabilitadasByUserID(IdUser);
        }

        private List<Cuenta> _getCuentasHabilitadasByUserID(int IdUser)
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentasHabilitadasByUserID", IdUser));
        }

        public List<Cuenta> getCuentasHabilitadasByClientId(int cli)
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentasByClienteId", cli, 1));
        }

        public List<Cuenta> getCuentasByUserIdAndType(long IdUser, long IdTipoCuenta)
        {
            return parseCuentas(DBAdapter.retrieveDataTable("getCuentasByUserIdAndType", IdUser, IdTipoCuenta));
        }



        /*Métodos privados*/

        private Estado parseEstado(DataRow fila)
        {
            return new Estado(Convert.ToInt32(fila["Id"]), fila["Descripcion"] as string);
        }

        private List<Estado> parseEstados(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(fila => parseEstado(fila)).ToList();
        }

        private List<Cuenta> parseCuentas(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(fila => parse(fila)).ToList();
        }



        private Cuenta parse(DataRow fila)
        {
            DateTime? val;
            if (fila["Fecha_Cierre"] == DBNull.Value)
            {
                val = null;
            }
            else
            {
                val = Convert.ToDateTime(fila["Fecha_Cierre"]);
            }
            DateTime? fechaExpiracion;

            if (fila["Fecha_Expiracion"] == DBNull.Value)
            {
                fechaExpiracion = null;
            }
            else
            {
                fechaExpiracion = Convert.ToDateTime(fila["Fecha_Expiracion"]);
            }

            return new Cuenta(Convert.ToInt64(fila["Id"]),
                               new TipoCuentaRepository().getTipoCuenta(Convert.ToInt32(fila["Tipo_Cuenta"])),
                                   new MonedaRepositoy().getMoneda(Convert.ToInt32(fila["Moneda"])),
                                   new PaisRepository().getPais(Convert.ToInt32(fila["Pais"])),
                                   new ClienteRepository().getCliente(Convert.ToInt32(fila["Cliente"])),
                                   getEstado(Convert.ToInt32(fila["Estado"])),
                                   Convert.ToDateTime(fila["Fecha_Creacion"]),
                                   val,
                                   Convert.ToDecimal(fila["Saldo"]), fechaExpiracion);
        }

        private Estado getEstado(int idEstado)
        {
            DataRow fila = DBAdapter.retrieveDataTable("getEstado", idEstado).Rows[0];
            return new Estado(idEstado, fila["Descripcion"] as string);
        }


        private TipoDocumento getTipoDoc(int idTipoDoc)
        {
            DataRow fila = DBAdapter.retrieveDataTable("getTipoDoc", idTipoDoc).Rows[0];
            return new TipoDocumento(idTipoDoc, fila["Descripcion"] as string);
        }

        public Boolean cambiarEstadoCuenta(Cuenta c)
        {
            int value = DBAdapter.executeProcedureWithReturnValue("cambiarEstadoCuenta", c.ID, c.EstadoCuenta.Id);
            return value == 1;
        }

        public Boolean cambiarEstadoCuentaHabilitando(long id)
        {
            int value = DBAdapter.executeProcedureWithReturnValue("cambiarEstadoCuenta", id, 1);
            return value == 1;
        }

        public Boolean deshabilitarCuenta(Cuenta c)
        {
            c.EstadoCuenta = new Estado(2, "Deshabilitada");
            return cambiarEstadoCuenta(c);
        }

        internal void deshabilitarCuentasPorExpiracion(int userId)
        {
            List<Cuenta> cuentas = _getCuentasHabilitadasByUserID(userId);
            if (cuentas.Count > 0)
            {
                cuentas.Where(cuenta => cuenta.FechaExpiracion < CLC_SessionManager.getFecha()).ToList().
                     ForEach(cuenta =>
                     {
                         if (deshabilitarCuenta(cuenta))
                         {
                             System.Windows.Forms.MessageBox.Show("Su cuenta " + cuenta.ID + "( " + cuenta.TipoCuenta + ") fue deshabilitada por haberse vencido el plazo de uso");
                         }
                     });
            }
        }


    }
}
