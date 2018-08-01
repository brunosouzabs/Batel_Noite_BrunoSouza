using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
        public static int nun1 { get; set; }
        public static int nun2 { get; set; }
        public static int op { get; set; }
        private int id;
        static void Main(string[] args)
        {
            
        Console.WriteLine("Digite o Primeiro Número:");
            nun1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número:");
            nun2 = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Em Soma: " + (nun1+nun2));
            Console.WriteLine("Em Subtração: " + (nun1 - nun2));
            Console.WriteLine("Em Divisão: " + (nun1 / nun2));
            Console.WriteLine("Em Multiplicação: " +(nun1 * nun2));


            Console.ReadKey();           

            
        }
        
    }
}
