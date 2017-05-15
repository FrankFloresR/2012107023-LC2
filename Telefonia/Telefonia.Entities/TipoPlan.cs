using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class TipoPlan
    {
        public string Descripcion { get; set; }

        //implementar prepago y postpago
        public TipoPlan()
        {

        }

        public TipoPlan(string descripcion)
        {
            Descripcion = descripcion;
        }

    }
}
