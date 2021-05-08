using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Libreria
{
    public class Persona

    {
        private string _nombre;
        private string _apellido;
        private bool _activo;
        private string _estadoCivil;


        public Persona(string nombre, string apellido, string estado, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._activo = activo;
            this._estadoCivil = estado;
        }
        public Persona()
        {

        }
        public override string ToString()
        {
            string act;
            if (this._activo)
            {
                act = "Activo";
            }
            else
            {
                act = "Inactivo";
            }
                return $"{this._apellido}, {this._nombre}, {act}, {this._estadoCivil}";
            

            
        }
    }
}
