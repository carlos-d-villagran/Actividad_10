using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contraseña = new Dictionary<string, string>();
            contraseña.Add("carlos", "Admin");
            contraseña.Add("juan", "Admin");
            contraseña.Add("renato", "Admin");
            Console.WriteLine("Ingrese el usuario y se desplegará el usuario: ");
            string user = Console.ReadLine();
            Console.WriteLine($"El usuario: {user} tiene la contraseña: {contraseña[user]}");
        }
    }
}
