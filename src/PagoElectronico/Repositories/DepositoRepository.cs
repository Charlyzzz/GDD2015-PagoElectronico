using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Utils;
using PagoElectronico.Domain;

namespace PagoElectronico.Repositories
{
    class DepositoRepository
    {
        public static void realizarDeposito(long cuenta, int tarjeta, double importe, int moneda)
        {
            DBAdapter.executeProcedure("DEPOSITAR", cuenta, tarjeta, importe, moneda, CLC_SessionManager.getFecha());
        }
    }
}
