using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.UI.ErrorBox
{
    class ErrorBoxHandler
    {
        /*
         * 
         * #Lanzador Genérico de errores
         *
         * 
         */

        private static void showError(string messageInfo, string windowTitle)
        {
            MessageBox.Show(windowTitle, messageInfo);

        }

        public static void showErrors(List<string> listaDeErrores, string windowTitle)
        {
            string erroresParseados ="";
            if (listaDeErrores.Count > 1)
            {
                 erroresParseados = "Se encontraron los siguientes errores: \n\n";
            }
            else
            {
                 erroresParseados = "Se encontro el siguiente error: \n\n";
            }
           
            foreach (string error in listaDeErrores)
            {
                erroresParseados = erroresParseados +"* "+ error + "\n";

            }

            MessageBox.Show(erroresParseados, windowTitle);

        }
    }
}
