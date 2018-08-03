using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02082018.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Barco: Grau no pedal...");
            Velocidade += 2;
        }

        public void Frenar()
        {
            Console.WriteLine("Barco: Grau no pedal (Freio)...");
            Velocidade -= 1;
        }
    }
}
