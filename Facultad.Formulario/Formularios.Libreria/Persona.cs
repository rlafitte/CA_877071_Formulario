using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Libreria
{
    public abstract class Persona

    {
        private string _nombre;
        private string _apellido;
        private bool _activo;
        private string _estadoCivil;
        private int _codigo;
        

        public Persona(string nombre, string apellido, string estado, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this.Activo = activo;
            this._estadoCivil = estado;
        }
        //public Persona()
        //{
        public Persona(int cod, string nombre, string apellido, string estado, bool activo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this.Activo = activo;
            this._estadoCivil = estado;
        }

        public bool Activo { get => _activo; set => _activo = value; }

        //}
        public override string ToString()
        {
            string act;
            if (this.Activo)
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
