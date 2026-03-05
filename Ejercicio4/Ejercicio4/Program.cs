using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ciudad = new Dictionary<int, string>();
            ciudad.Add(9001, "Quetzaltenango");
            ciudad.Add(9002, "Salcajá");
            ciudad.Add(9003, "Olintepeque");
            ciudad.Add(9004, "San Carlos Sija");
            ciudad.Add(9032, "La Esperanza");
            Console.WriteLine("Indique el codigo postal y se desplegará la ciudad: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"El código: {codigo} pertenece a:  {ciudad[codigo]}");
            //El diccionario no toma en cuenta el cero a la izquierda
        }
    }
}
