using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> estudiantes = new Dictionary<string, double>();
            estudiantes.Add("juan", 65);
            estudiantes.Add("carlos", 43.2);
            estudiantes.Add("esteban", 12.3);
            estudiantes.Add("marcos", 79.5);
            estudiantes.Add("steven", 59);
            Console.WriteLine("Buscar la nota del estudiante: ");
            string nombre  = Console.ReadLine();
            if(estudiantes.ContainsKey(nombre))
            {
                Console.WriteLine($"La nota de {nombre} es:  {estudiantes[nombre]}");
            }
            else
            {
                Console.WriteLine("Error, no existe el estudiante ingresado");
            }
        }
    }
}
