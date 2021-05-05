using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Libreria
{
    public class CodigoDescripcion
    {
        private string _descripcion;
        private int _cod;
        public CodigoDescripcion(int cod, string desc)
        {
            this._cod = cod;
            this._descripcion = desc;
        }

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Cod { get => _cod; set => _cod = value; }
    }
}
