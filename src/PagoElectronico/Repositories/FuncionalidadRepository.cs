using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.UI;
using PagoElectronico.Utils;
using System.Data;
using System.Collections;
using PagoElectronico.UI.ABM_Cliente;
using PagoElectronico.UI.ABM_Cuenta;
using PagoElectronico.UI.ABM_de_Usuario;
using PagoElectronico.UI.ABM_Rol;
using PagoElectronico.UI.Consulta_Saldos;
using PagoElectronico.UI.Depositos;
using PagoElectronico.UI.Facturacion;
using PagoElectronico.UI.Listados;
using PagoElectronico.UI.Retiros;
using PagoElectronico.UI.Transferencias;
using PagoElectronico.UI.Tarjetas;
using PagoElectronico.Domain.Exceptions;

namespace PagoElectronico.Repositories
{
    class FuncionalidadRepository
    {
        private Funcionalidad parse(DataRow dr)
        {
            switch (Convert.ToInt32(dr["ID"]))
            {
                case 0: return new Funcionalidad(new ABMRolWindow(),dr["Descripcion"] as string,0);
                case 1: return new Funcionalidad(new ABMUsuarioWindow(), dr["Descripcion"] as string,1);
                case 2: return new Funcionalidad(new ABMClienteWindow(), dr["Descripcion"] as string,2);
                case 3: return new Funcionalidad(new ABMCuentaWindow(),dr["Descripcion"] as string,3);
                case 4: return new Funcionalidad(new DepositosWindow(),dr["Descripcion"] as string,4);
                case 5: return new Funcionalidad(new RetirosWindow(),dr["Descripcion"] as string,5);
                case 6: return new Funcionalidad(new TransferenciasWindow(), dr["Descripcion"] as string,6);
                case 7: return new Funcionalidad(new FacturacionWindow(), dr["Descripcion"] as string,7);
                case 8: return new Funcionalidad(new ConsultaSaldoWindow(), dr["Descripcion"] as string,8);
                case 9: return new Funcionalidad(new ListadoWindow(), dr["Descripcion"] as string,9);
                case 10: return new Funcionalidad(new TarjetasWindow(),dr["Descripcion"] as string,10);

                default:
                    throw new NoSuchFunctionality();
            }
        }

        private List<Funcionalidad> parseFuncionalidades(DataTable dt)
        {
            return dt.AsEnumerable().Select(dr => parse(dr)).ToList();
        }

        public List<Funcionalidad> getFuncionalidades(int rol) {

            return parseFuncionalidades(DBAdapter.retrieveDataTable("funcionalidadDeRol",rol));
        }

        public List<Funcionalidad> getAllFuncionalidades()
        {
            return parseFuncionalidades(DBAdapter.retrieveDataTable("funcionalidades"));
        }
    }
}
