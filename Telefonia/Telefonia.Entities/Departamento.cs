using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class Departamento
    {
        private List<Provincia> _Provincias;
        public Departamento()
        {
            _Provincias = new List<Provincia>();
        }
    }
}
