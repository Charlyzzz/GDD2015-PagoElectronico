using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Utils;
using PagoElectronico.Domain;
using PagoElectronico.UI;
using PagoElectronico.Domain.Exceptions;
using System.Data;

namespace PagoElectronico.Repositories
{
    class RolRepository
    {
        private Rol parseRol(DataRow dr)
        {
            return new Rol(Convert.ToInt32(dr["ID"]),
                          dr["Descripcion"] as string,
                          (bool)dr["Estado"],
                          new FuncionalidadRepository().getFuncionalidades(Convert.ToInt32(dr["ID"])));
        }

        private List<Rol> parseRoles(DataTable rolTable) {
            return rolTable.AsEnumerable().Select(dr => parseRol(dr) ).ToList();   
        }

        public List<Rol> getRoles(int userId) {
            return parseRoles(DBAdapter.retrieveDataTable("getRolesById", userId));
        }

        public List<Rol> getRoles()
        {
            return parseRoles(DBAdapter.retrieveDataTable("getRoles"));
        }

        internal void updateRol(Rol rol, List<Funcionalidad> list,Boolean check)
        {
            rol.funcionalidades.ForEach(f => DBAdapter.executeProcedure("ABMROL_bajaRolFuncionalidad", rol.ID, f.id));
            list.ForEach(f => DBAdapter.executeProcedure("ABMROL_AltaRolFuncionalidad", rol.ID, f.id));
            if (check)
            {
                DBAdapter.executeProcedure("ABMROL_habilitarRol", rol.ID);
            }
            else
            {
                DBAdapter.executeProcedure("ABMROL_inhabilitarRol", rol.ID);
            }

        }
    }
}
