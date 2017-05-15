using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class AdministradorLinea
    {
        private List<LineaTelefonica> _Lineas;

        public List<LineaTelefonica> Lineas
        {
            get { return _Lineas; }
            private set { _Lineas = value; }
        }

        public AdministradorLinea()
        {
            Lineas = new List<LineaTelefonica>();
        }

        public void AgregarLinea(string numero)
        {
            Lineas.Add(new LineaTelefonica(numero));
        }
    }
}
