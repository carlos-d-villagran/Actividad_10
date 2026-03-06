using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            int count = 0;
            do
            {
                Console.Clear();
                count++;
                Console.WriteLine($"Ingrese el ID del estudiante ({count}) o 0 para finalizar: ");
                if (int.TryParse(Console.ReadLine(), out int id)&& !estudiantes.ContainsKey(id))
                {
                    if(id==0)
                    {
                        break;
                    }
                    Console.Write("Ingrese el nombre del estudiante "+ count +": ");
                    string nombre = Console.ReadLine();
                    estudiantes.Add(id, nombre);
                }
                else
                {
                    if(count>0)
                    {
                        count--;
                    }
                }
            }
            while (true);
            Console.WriteLine("\nListado de estudiantes ingresados:");
            foreach(var estudiante in estudiantes)
            {
                Console.WriteLine($"Carné: {estudiante.Key}  Nombre: {estudiante.Value}");
            }
        }
    }
}
