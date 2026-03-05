using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            estudiantes.Add(1010, "Juan Pérez");
            estudiantes.Add(1011, "Carlos López");
            estudiantes.Add(1012, "Antonio Flores");
            Console.WriteLine("Indique el carné del estudiante a buscar: ");
            int carne = int.Parse(Console.ReadLine());
            Console.WriteLine(estudiantes[carne]);
        }
    }
}
