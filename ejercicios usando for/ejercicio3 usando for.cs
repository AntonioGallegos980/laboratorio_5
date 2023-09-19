using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            double sumaNotas = 0;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese la nota:");
                double nota = double.Parse(Console.ReadLine());
                sumaNotas += nota;
            }

            double promedio = sumaNotas / cantidad;

            Console.WriteLine("El promedio es:" + promedio);
        }
    }

}
