using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            productos.Add(1010, "Mayonesa");
            productos.Add(1011, "Galletas");
            productos.Add(1012, "Shampoo");
            productos.Add(1013, "Crema");
            productos.Add(1014, "Jamón");
            productos.Add(1015, "Papel de regalo");
            productos.Add(1016, "Chocolotes");
            foreach(var item in productos)
            {
                Console.WriteLine($"Código: {item.Key}  Producto: {item.Value}");
            }
        }
    }
}
