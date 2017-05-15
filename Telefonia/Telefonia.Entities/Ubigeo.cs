using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class Ubigeo
    {
        private Departamento _Departamento;
        private Provincia _Provincia;
        private Distrito _Distrito;

        public Ubigeo(Departamento departamento,
                       Provincia provincia,
                        Distrito distrito)
        {
            _Departamento = departamento;
            _Provincia = provincia;
            _Distrito = distrito;
        }

        public Ubigeo()
        {

        }
    }
}
