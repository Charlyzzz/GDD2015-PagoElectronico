using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using PagoElectronico.Domain;
using PagoElectronico.Domain.Exceptions;
using PagoElectronico.UI;
using System.Windows.Forms;

namespace PagoElectronico.Utils
{
    class CLC_SessionManager
    {
        private static Usuario _usuario;
        public static Usuario currentUser { get { if (_usuario == null) throw new NoSessionIsOpenException(); else  return _usuario;  } set { _usuario = value; } }
        public static string connectionString = ConfigurationManager.ConnectionStrings["GD1C2015"].ConnectionString;      
        public static bool esAdministrador = false;
        
        public static DateTime getFecha() {
            return DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static void setCurrentUser(Usuario u) {
            currentUser = u;
        }

        public static void closeSession()
        {
            currentUser = null;
        }

    }
}
