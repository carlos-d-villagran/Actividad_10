using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            productos.Add(1011, "Polvo mágico");
            productos.Add(1012, "Fabuloso");
            productos.Add(1013, "Galletas María");
            int id;
            string nombre;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un nuevo producto:");
                Console.Write("Ingrese el nombre del producto: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese su clave: ");
                id = int.Parse(Console.ReadLine());
                if(productos.ContainsKey(id))
                {
                    Console.WriteLine("Error, este producto ya existe");
                }
            }
            while (productos.ContainsKey(id));
            productos.Add(id, nombre);
            foreach(var item in productos)
            {
                Console.WriteLine($"Código: {item.Key}  Producto: {item.Value}");
            }
        }
    }
}
