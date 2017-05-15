using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class TipoLinea
    {

        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        public TipoLinea(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoLinea()
        {
            Descripcion = "";
        }
    }
}
