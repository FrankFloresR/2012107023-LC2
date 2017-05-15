using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.Entities
{
    public class EquipoCelular
    {
        public string Marca { get; private set; }
        public string Calidad { get; private set; }
        public Decimal Precio { get; private set; }
        public string Estado { get; set; }


        public EquipoCelular()
        {

        }

        public EquipoCelular(string marca, string calidad)
        {
            Marca = marca;
            Calidad = calidad;
            Precio = CalcularPrecio(marca, calidad);
        }

        private Decimal CalcularPrecio(string marca, string Calidad)
        {
            if (marca == "Huawei" && Calidad == "Alta")
                return 900.00m;
            else if (marca == "Huawei" && Calidad == "Media")
                return 550.00m;
            else
                return 200.00m;
        }
    }
}
