using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class Provincia
    {
        private List<Distrito> _Distritos;

        public Provincia()
        {
            _Distritos = new List<Distrito>();
        }
    }
}
