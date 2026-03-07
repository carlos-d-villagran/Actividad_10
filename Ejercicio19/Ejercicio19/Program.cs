using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> notas = new Dictionary<string, double>();
            int opcion;
            bool mensaje = false;
            do
            {
                Console.Clear();
                Console.WriteLine("+++ Notas +++");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Modificar nota");
                Console.WriteLine("3. Desplegar notas actuales");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                if(int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch(opcion)
                    {
                        case 1:
                            Console.Clear();
                            string nombre;
                            do
                            {
                                Console.Write("Ingrese el nombre del estudiante 0 para finalizar: ");
                                do
                                {
                                    nombre = Console.ReadLine();
                                }
                                while (notas.ContainsKey(nombre));
                                if (nombre != "0")
                                {
                                    Console.Write("Ingrese la nota del estudiante: ");
                                    double nota = double.Parse(Console.ReadLine());
                                    notas.Add(nombre, nota);
                                    mensaje = true;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            while (true);
                            break;
                            case 2:
                            if(mensaje)
                            {
                                Console.Clear();
                                Console.WriteLine("Indique el nombre del nombre del estudiante");
                                string estudiante = Console.ReadLine();
                                Console.WriteLine("Indique la nueva nota: ");
                                double nuevaNota = double.Parse(Console.ReadLine());
                                notas[estudiante] = nuevaNota;
                                Console.WriteLine("\nNota modificada correctamente\nPresione cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No hay notas para modificar\nPresione Cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                                break;
                            case 3:
                            if(mensaje)
                            {
                                Console.Clear();
                                Console.WriteLine("++ NOTAS DISPONIBLES ++\n");
                                foreach (var item in notas)
                                {
                                    Console.WriteLine($"Alumno: {item.Key}  Nota: {item.Value}");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No hay notas para mostrar\nPresione Cualquier tecla para continuar");
                                Console.ReadKey();
                            }
                                break;
                        case 0:
                            Console.WriteLine("Saliendo");
                            break;
                        default:
                            Console.WriteLine("Error, debe ingresar una opcion válida");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error debe ingresar un número");
                }
            }
            while (opcion!=0);
        }
    }
}
