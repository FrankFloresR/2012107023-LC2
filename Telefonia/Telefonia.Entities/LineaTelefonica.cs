using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class LineaTelefonica
    {
        private TipoLinea _TipoLinea;

        public TipoLinea TipoLinea
        {
            get { return _TipoLinea; }
            set { _TipoLinea = value; }
        }

        private string _Numero;

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }

        public LineaTelefonica()
        {
            TipoLinea = new TipoLinea();
        }

        public LineaTelefonica(string numero)
        {
            Numero = numero;
            TipoLinea = AsignarTipo(numero);
        }

        public TipoLinea AsignarTipo(string numero)
        {
            if (numero[0] == '9')
                return new TipoLinea("Fijo");
            else
                return new TipoLinea("Celular");
        }

       
        public string Estado { get; set; }


    }
}
