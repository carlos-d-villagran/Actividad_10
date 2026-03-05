using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> notas = new Dictionary<string, double>();
            notas.Add("Pedro", 66.5);
            notas.Add("Salvador", 34.3);
            notas.Add("Miguel", 96.7);
            Console.WriteLine("Indique el nombre del estudiante y se desplegará su nota: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"La nota de: {nombre} es {notas[nombre]}");
        }
    }
}
