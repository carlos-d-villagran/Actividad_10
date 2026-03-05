using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            productos.Add(1010, "Mayonesa B&B");
            productos.Add(1011, "Shampoo Lagrimitas");
            productos.Add(1012, "Galletas Maria");
            foreach (var item in productos)
            {
                Console.WriteLine($"Código: {item.Key}  Nombre: {item.Value}");
            }
        }
    }
}
