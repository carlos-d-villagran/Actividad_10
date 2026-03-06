using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> inventario = new Dictionary<int, string>();
            inventario.Add(1010, "Crema");
            inventario.Add(1011, "Shmapoo");
            inventario.Add(1012, "Galleta");
            inventario.Add(1013, "Cocacola");
            inventario.Add(1014, "Servilletas");
            Console.WriteLine("PRODUCTOS DISPONIBLES: ");
            foreach (var item in inventario)
            {
                Console.WriteLine($"Código: {item.Key}  Producto: {item.Value}");
            }
            Console.Write("\nIngrese el código del producto a eliminar: ");
            int codigo = int.Parse(Console.ReadLine());
            inventario.Remove(codigo);
            Console.WriteLine("\nProdcuto eliminado correctamente\n Listado actualizado:\n");
            foreach (var item in inventario)
            {
                Console.WriteLine($"Código: {item.Key}  Producto: {item.Value}");
            }

        }
    }
}
