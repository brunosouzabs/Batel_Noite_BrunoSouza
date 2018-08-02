using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02082018.Modelos
{
    class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }


        }
    }
}
