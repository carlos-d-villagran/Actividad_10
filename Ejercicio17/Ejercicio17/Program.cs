using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            int opcion;
            bool mensaje = false;
            do
            {
                Console.Clear();
                Console.WriteLine("++++ Inventario de productos ++++");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Productos en inventario");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el código del nuevo producto: ");
                            int codigo;
                            string nombre;
                            do
                            {
                                if(int.TryParse(Console.ReadLine(), out codigo))
                                if(productos.ContainsKey(codigo))
                                {
                                    Console.WriteLine("Error, ya existe un producto con este código\nPresione cualequer telca para continuar");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Ingrese el nombre del producto: ");
                                nombre = Console.ReadLine();
                            }
                            while (productos.ContainsKey(codigo));
                            productos.Add(codigo, nombre);
                            mensaje=true;
                            Console.WriteLine("Producto ingresado correctamente\nPresione cualquier tecla para continuar");
                            Console.ReadLine();
                            break;
                            case 2:
                            if(mensaje)
                            {
                                Console.Clear();
                                Console.WriteLine("Indique el código del producto a eliminar: ");
                                int codigoEliminar = int.Parse(Console.ReadLine());
                                Console.WriteLine("El producto que se eliminará es: " + productos[codigoEliminar]+ "  Presione enter para continuar");
                                Console.ReadLine();
                                productos.Remove(codigoEliminar);
                                Console.WriteLine("Producto eliminado correctamente\nPresione cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No hay elementos en el inventario\nPresione cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                                break;
                            case 3:
                            if(mensaje)
                            {
                                Console.Clear ();
                                Console.WriteLine("Listado de productos");
                                foreach(var item in productos)
                                {
                                    Console.WriteLine($"Código: {item.Key}  Descripción: {item.Value}");
                                }
                                Console.WriteLine("\nPresione Cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No hay elementos en el inventario\nPresione cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            break;
                        case 0:
                            Console.WriteLine("Grcias por usar el sistema");
                            break;
                        default:
                            Console.WriteLine("Error, debe ingresar una opcion válida.\nPresione cualquier tecla para continuar");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            while (opcion!=0);
        }
    }
}
