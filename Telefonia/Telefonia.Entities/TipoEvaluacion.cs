using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class TipoEvaluacion
    {
        public TipoEvaluacion(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoEvaluacion()
        {

        }

        public string Descripcion { get; set; }
    }
}
