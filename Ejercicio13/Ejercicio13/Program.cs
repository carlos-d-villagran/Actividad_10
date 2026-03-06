using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> estudiantes = new Dictionary<string, double>();
            estudiantes.Add("Hernesto Valverde", 45.5);
            estudiantes.Add("Miguel Martinez", 100 );
            estudiantes.Add("Julio Hernandez", 78.4);
            estudiantes.Add("Pedro Sanchez", 45.1);
            estudiantes.Add("Farid Jimenez", 67.1);
            double suma = 0;
            
            foreach(var notas in estudiantes)
            {
                Console.WriteLine($"Nombre: {notas.Key}  Nota: {notas.Value}");
                suma += notas.Value;
            }
            Console.WriteLine("\nEl promedio de las notas es: "+ suma/estudiantes.Count);

        }
    }
}
