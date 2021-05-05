using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.Formulario.Consola
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);

            FrmPrincipal formulario = new FrmPrincipal(); //clase que representa una "ventana"
            Application.Run(formulario); //acá reemplazamos el valor original por nuestro nuevo Form1
        }
    }
}
