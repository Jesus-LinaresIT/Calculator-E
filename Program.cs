using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string Seguir;
            int operacion;

            do
            {

                Console.WriteLine("Escriba la opcion que desee realizar: ");

                Console.WriteLine("1-Sumar");
                Console.WriteLine("2-Restar");
                Console.WriteLine("3-Multiplicar");
                Console.WriteLine("4-Dividir");
                Console.WriteLine(" ");

                operacion = int.Parse(Console.ReadLine());

                Calcular(operacion);

                Console.WriteLine("*******************************");
                Console.WriteLine("Desea realizar otro Calculo? ");
                Console.WriteLine("1-Si");
                Console.WriteLine("2-No");

                Console.WriteLine(" ");
                Seguir = Console.ReadLine();

                if (Seguir == "1" || Seguir == "Si")
                {
                    Console.Clear();

                }

            } while (Seguir == "1" || Seguir == "Si");

            Console.WriteLine("Programa terminado, presione cualquier tecla para salir...");
            Console.ReadKey();

        }

        private static void Calcular(int operacion)
        {

            Console.Clear();
            switch (operacion)
            {

                case 1:
                    {
                        Console.WriteLine("SUMAR");
                        Console.WriteLine(" ");
                        CalcularResult(operacion);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("RESTA");
                        Console.WriteLine(" ");
                        CalcularResult(operacion);
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("MULTIPLICACION");
                        Console.WriteLine(" ");
                        CalcularResult(operacion);
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("DIVISION");
                        Console.WriteLine(" ");
                        CalcularResult(operacion);
                        break;

                    }

                default:
                    break;

            }

        }

        private static void CalcularResult(int operacion)
        {

            Console.WriteLine("Escriba el primer Numero: ");
            Double Numero1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el primer Segundo: ");
            Double Numero2 = Double.Parse(Console.ReadLine());

            if (operacion == 1)
            {

                double resultado = Numero1 + Numero2;
                Console.WriteLine("Resultado {0} + {1} = {2}", Numero1, Numero2, resultado);
            }


            if (operacion == 2)
            {

                double resultado = Numero1 - Numero2;
                Console.WriteLine("Resultado {0} - {1} = {2}", Numero1, Numero2, resultado);
            }

            if (operacion == 3)
            {

                double resultado = Numero1 * Numero2;
                Console.WriteLine("Resultado {0} x {1} = {2}", Numero1, Numero2, resultado);
            }


            if (operacion == 4)
            {
                if (Numero2 != 0)
                {

                    double resultado = Numero1 / Numero2;
                    Console.WriteLine("Resultado {0} / {1} = {2}", Numero1, Numero2, resultado);
                }
                else
                {

                    Console.WriteLine("No se puede dividir entre {0}", Numero2);
                }
            }

            Console.WriteLine(" ");
        }

    }
}
