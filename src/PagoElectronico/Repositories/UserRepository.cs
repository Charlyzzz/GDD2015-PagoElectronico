using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.Domain;
using PagoElectronico.Utils;
using System.Data;

namespace PagoElectronico.Repositories
{
    class UserRepository
    {
        public bool esDocumentoCorrectoParaElUsuarioLogeado(long numeroDocumento, long idTipoDocumento)
        {
            return (int)(DBAdapter.retrieveDataTable("esDocumentoCorrectoParaElUsuarioLogeado", numeroDocumento, idTipoDocumento, CLC_SessionManager.currentUser.ID)).Rows[0][0] == 1;
            
        }

        public long getUserIdByUsername(string usernameLike)
        {
            return DBAdapter.executeProcedureWithLongReturnValue("getUserIdByUsername",usernameLike);
        }

        public List<Usuario> getUsuariosConCuentasActivas()
        {
            return parseUsers(DBAdapter.retrieveDataTable("getUsuariosConCuentasActivas"));
        }

        public int getIdUsuarioByClientName(string nombreYApellido)
        {
            return DBAdapter.executeProcedureWithReturnValue("getIdUsuarioByClientName", nombreYApellido);
        }

        private DataRow _getUserByUsername(string username) {
            return DBAdapter.retrieveDataTable("getUsuario", username).Rows[0];
        }

        private Usuario parseUser(DataRow userRow) {
            return new Usuario(Convert.ToInt32(userRow["ID"]),
                               userRow["Username"] as string,
                               (bool) userRow["Estado"],
                               Convert.ToInt32(userRow["Intentos_Login"]),
                               new RolRepository().getRoles(Convert.ToInt32(userRow["ID"])));    
        }

        private List<Usuario> parseUsers(DataTable tabla)
        {
            return tabla.AsEnumerable().Select(row => parseUser(row)).ToList();
        }

        private void iniciarSesion(string userName) {
            CLC_SessionManager.currentUser = parseUser(_getUserByUsername(userName));
        }

        private Boolean valid(string procedure,string userName, string password)
        {
            return DBAdapter.executeProcedureWithReturnValue(procedure,userName,new Encription().encryptToSHA256(password)) != 0;
        }

        public Boolean userLogin(string userName, string password)
        {
            if (valid("validar_login", userName, password))
            {
                iniciarSesion(userName);
                return true;
            }
            return false;
        }

        internal bool exists(string p)
        {
            return DBAdapter.checkIfExists("getUsuario",p);
        }

        internal string getPregunta(string p)
        {
            return DBAdapter.retrieveDataTable("getPreguntaUsuario",p).Rows[0][0] as string;
        }

        internal bool userLoginPorPregunta(string username, string answer)
        {
            if (valid("validar_pregunta",username, answer))
            {
                iniciarSesion(username);
                return true;
            }
            return false;
        }

        internal void setPassword(string username, string nuevaPass)
        {
            DBAdapter.executeProcedure("setPassword",username,new Encription().encryptToSHA256(nuevaPass));
        }
    }
}
