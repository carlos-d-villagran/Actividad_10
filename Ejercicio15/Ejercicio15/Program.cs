using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> empleados = new Dictionary<int, string>();
            empleados.Add(1012, "Alex Corleto");
            empleados.Add(1013, "Miguel Juarez");
            empleados.Add(1014, "Carlos Guzaman");
            empleados.Add(1015, "Rebeca Mazariegos");
            empleados.Add(1016, "Sara Perez");
            foreach(var empleado in empleados)
            {
                Console.WriteLine($"ID: {empleado.Key}  Nombre: {empleado.Value}");
            }

        }
    }
}
