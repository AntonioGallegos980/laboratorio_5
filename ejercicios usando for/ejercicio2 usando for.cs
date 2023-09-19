using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la base: ");
        float base1 = float.Parse(Console.ReadLine());

        Console.Write("Ingresa el exponente: ");
        int potencia = int.Parse(Console.ReadLine());

        double resultado = 1;

        for (int i = 0; i < potencia; i++)
        {
            resultado *= base1;
        }

        Console.WriteLine("La potencia es:" + resultado);
        Console.ReadKey();
    }
}