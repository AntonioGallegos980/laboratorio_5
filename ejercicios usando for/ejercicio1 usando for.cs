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
            Console.Write("ingrese el numero 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese el numero 2 :");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 0; i < num1; i++)
            {
                resultado = resultado + num2;
            }
            Console.WriteLine("el resultado es :" + resultado);
            Console.ReadKey();
        }
    }
}