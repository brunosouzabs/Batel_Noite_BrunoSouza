using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02082018.Modelos
{
    class Carro : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Carro: Bomba no pedal...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Carro: Bomba no pedal (Freio)...");
            Velocidade -= 3;
        }
    }
}