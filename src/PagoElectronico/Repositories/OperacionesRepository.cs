using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PagoElectronico.Utils;
using PagoElectronico.Repositories;


namespace PagoElectronico.Repositories
{
    public class OperacionesRepository
    {
        public void realizarRetiro(long idCuenta,long idMoneda, long idBanco, Decimal monto)
        {
            DBAdapter.executeProcedure("altaRetiro",idCuenta,idMoneda,idBanco,monto,CLC_SessionManager.getFecha(),CLC_SessionManager.currentUser.ID);
        }

        public void realizarTransferencia(long idCuentaOrigen, long idCuentaDestino, int idMoneda, Decimal monto, Decimal costoOperacion )
        { 
            DBAdapter.executeProcedure("altaTransferencia",idCuentaOrigen,idCuentaDestino,idMoneda,monto,CLC_SessionManager.getFecha(),costoOperacion );
        }
    }
}
