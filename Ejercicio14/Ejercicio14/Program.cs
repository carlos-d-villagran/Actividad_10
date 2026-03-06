using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ciudades = new Dictionary<int, string>();
            ciudades.Add(9001, "Quetzaltenango");
            ciudades.Add(9002, "Salcajá");
            ciudades.Add(9003, "Olintepeque");
            ciudades.Add(9004, "San Carlos Sija");
            ciudades.Add(9005, "Sibilia");
            ciudades.Add(9006, "Cabricán");
            foreach(var codigo in ciudades)
            {
                Console.WriteLine("Codigo:" + codigo.Key);
            }
            foreach(var ciudad in ciudades)
            {
                Console.WriteLine("Ciudad: "+ ciudad.Value);
            }
        }
    }
}
