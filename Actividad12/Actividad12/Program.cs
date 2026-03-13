// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Collections.Generic;

List<Dispositivo> dispositivos = new List<Dispositivo>();
Console.WriteLine("Indique cuantos dispositivos ingresará: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i<=n; i++)
{
    Dispositivo dis = new Dispositivo();
    Console.Write($"\nIndique el nombre del dispositivo {i}: ");
    dis.nombreDispositivo = Console.ReadLine();
    Console.Write("Indique el resultado de la prueba 1: ");
    dis.prueba1= double.Parse(Console.ReadLine());
    Console.Write("Indique el resultado de la prueba 2: ");
    dis.prueba2 = double.Parse(Console.ReadLine());
    Console.Write("Indique el resultado de la prueba 3: ");
    dis.prueba3 = double.Parse(Console.ReadLine());
    dispositivos.Add(dis);
}
double sumaPromedios = 0;
Dispositivo mejor = dispositivos[0];
foreach(Dispositivo dis in dispositivos)
{
    dis.MostrarInformacion();
    sumaPromedios += dis.PromedioRendimiento();
    if(dis.PromedioRendimiento() > mejor.PromedioRendimiento())
    {
        mejor =  dis;
    }
}
Console.WriteLine($"Promedio de rendimiento: {sumaPromedios/dispositivos.Count:F2}");
Console.WriteLine("El mejor dispositivo: ");
mejor.MostrarInformacion();
public class Dispositivo
{
    public string nombreDispositivo;
    public double prueba1;
    public double prueba2;
    public double prueba3;
    public double PromedioRendimiento()
    {
        return (prueba1 + prueba2 + prueba3) / 3;
    }
    public string DeterminarEstado()
    {
        if(PromedioRendimiento() >= 80)  return "Óptimo";
        else return "Necesita Mantenimiento" ;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre del dispositivo {nombreDispositivo} | Promedio: {PromedioRendimiento():F2} | Estado: {DeterminarEstado()}");
    }
}