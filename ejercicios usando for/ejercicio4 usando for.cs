using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero maximo:");
            int maximo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("seleccione la opcion que desees");
            Console.WriteLine("1.motrara numeros pares");
            Console.WriteLine("2.mostrar numeros impares");
            Console.WriteLine("3.calcular el factorial");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    for (int i = 2; i <= maximo1; i += 2)
                    {
                        Console.Write(i + ",");
                    }
                    break;
                case 2:
                    for (int i = 1; i <= maximo1; i += 2)
                    {
                        Console.Write(i + ",");
                    }
                    break;
                case 3:
                    int facto = 1;
                    for (int i = 1; i <= maximo1; i++)
                    {
                        facto *= i;
                        Console.Write(facto);
                    }
                  break;
            }
        }
    }
}
