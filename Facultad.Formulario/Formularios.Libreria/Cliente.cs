using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Libreria
{
    public class Cliente : Persona
    {

        private int _codigo;
        public int Codigo => _codigo;
        public Cliente(int cod, string nombre, string apellido, string estado, bool activo) : base(nombre, apellido, estado, activo)
        {
            _codigo = cod;
        }
    }
}
