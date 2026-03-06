using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> empleados = new Dictionary<int, string>();
            empleados.Add(1011, "Renato Pelicó");
            empleados.Add(1012, "Miguel Martinez");
            empleados.Add(1013, "Rosa Celeste");
            empleados.Add(1014, "Maria Josefina");
            Console.WriteLine("\nListado de empleados:");
            foreach(var item in empleados)
            {
                Console.WriteLine($"Código: {item.Key}  Nombre: {item.Value}");
            }
            Console.WriteLine("\nIntroduzca el código de empleado a eliminar:");
            int codigo = int.Parse( Console.ReadLine() );
            empleados.Remove( codigo );
            foreach (var item in empleados)
            {
                Console.WriteLine($"Código: {item.Key}  Nombre: {item.Value}");
            }
        }
    }
}
