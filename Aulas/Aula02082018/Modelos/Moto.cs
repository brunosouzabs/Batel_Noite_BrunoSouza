﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02082018.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Moto: Pisando no pedal...");
            Velocidade += 4;
        }

        public void Frenar()
        {
            Console.WriteLine("Moto: Pisando no pedal (Freio)...");
            Velocidade -= 2;
        }
    }
}
