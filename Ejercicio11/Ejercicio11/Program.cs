using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            estudiantes.Add(1010, "Juan Renato");
            estudiantes.Add(1011, "Carlos Villagran");
            estudiantes.Add(1012, "Daniel Sanchez");
            estudiantes.Add(1013, "Antonio Florez");
            estudiantes.Add(1014, "Joel Sac");
            foreach(var item in estudiantes)
            {
                Console.WriteLine($"Carné: {item.Key}  Nombre: {item.Value}");
            }
        }
    }
}
