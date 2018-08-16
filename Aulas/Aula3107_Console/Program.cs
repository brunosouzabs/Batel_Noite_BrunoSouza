using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
       
        static void Main(string[] args)
        {

            string resp = "";

            do

            {

                int num1 = 0; //Primeiro Numero.

                int num2 = 0; //Segundo número.

                int R = 0; //resposta. 


                Console.WriteLine("### Precione o código da operação que deseja realizar ###5");
                Console.WriteLine(" __________________________");
                Console.WriteLine("|                          |");
                Console.WriteLine("| + para Somar             |");
                Console.WriteLine("| - para Diminuir          |");
                Console.WriteLine("| * para Multiplicar       |");
                Console.WriteLine("| / para Dividir           |");
                Console.WriteLine("|__________________________|");
                Console.Write("Digite a operação Desejada:  ");

                resp = Console.ReadLine();
                string op = Convert.ToString(resp);


                Console.WriteLine("Insira os valores a calcular: ");

                Console.Write("Número 1: ");

                num1 = int.Parse(Console.ReadLine());

                Console.Write("Número 2: ");

                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine();


                switch (op)

                {

                    case "+":

                        Console.WriteLine("O resultado da soma é:");

                        R = num1 + num2;

                        Console.WriteLine("{0} + {1} = {2}", num1, num2, R);

                        break;

                    case "-":

                        Console.WriteLine("O resultado da subtração é:");

                        R = num1 - num2;

                        Console.WriteLine("{0} - {1} = {2}", num1, num2, R);

                        break;

                    case "*":

                        Console.WriteLine("O resultado da multiplicação é:");

                        R = num1 * num2;

                        Console.WriteLine("{0} * {1} = {2}", num1, num2, R);

                        break;

                    case "/":

                        Console.WriteLine("O resultado da divisão é:");

                        R = num1 / num2;

                        Console.WriteLine("{0} / {1} = {2}", num1, num2, R);

                        break;
                    default:
                        {
                            Console.WriteLine("Digite um operador válido(+|-|*|/)");
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                            break;
                        }

                }

                Console.Write("Deseja realizar outro calculo? s/n: ");

                resp = Console.ReadLine();

            }

            while (resp == "s" || resp == "s");


        }
        
    }
}
