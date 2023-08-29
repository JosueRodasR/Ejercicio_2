using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar las cantidad de minutos: ");
            int minutos = int.Parse(Console.ReadLine());

            int horas = minutos / 60;
            int minutosRestantes = minutos % 60 ;

            Console.WriteLine($"{minutos} minutos son {horas} horas y {minutosRestantes} minutos.");
            Console.ReadKey();
        }
    }
}
