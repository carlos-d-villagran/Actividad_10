using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> usuario = new Dictionary<int, string>();
            int codigo;
            do
            {
                Console.Write("Ingrese el código del nuevo usuario o 0 para finalizar: ");
                do
                {
                    codigo= int.Parse(Console.ReadLine());
                }
                while (usuario.ContainsKey(codigo));
                if(codigo!=0)
                {
                    Console.Write("Ingrese el nombre del usuario: ");
                    string nombre = Console.ReadLine();
                    usuario.Add(codigo, nombre);
                }
                else
                {
                    break;
                }

            }
            while (true);
            Console.WriteLine("\nListado de usuarios:\n");
            foreach(var item in usuario)
            {
                Console.WriteLine($"ID: {item.Key}  Nombre: {item.Value}");
            }
        }
    }
}
