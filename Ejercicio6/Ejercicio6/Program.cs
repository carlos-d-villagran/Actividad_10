using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            Console.WriteLine("Ingrese 3 estudiantes con sus respectivos carnés");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Ingrese el carné {i}: ");
                int carne = int.Parse(Console.ReadLine());
                Console.Write($"Ingrese el nombre {i}: ");
                string nombre = Console.ReadLine();
                estudiantes.Add(carne, nombre);
            }
            Console.WriteLine("\nEstudiantes ingresados correctamente:");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"Carné: {item.Key}  Nombre: {item.Value}");
            }
            Console.WriteLine("Indeque el carné del estudiante que desea eliminar: ");
            int carneEliminar = int.Parse(Console.ReadLine());
            estudiantes.Remove(carneEliminar);
            Console.WriteLine("\nEstudiantes restantes: ");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"Carné: {item.Key}  Nombre: {item.Value}");
            }
        }
    }
}
