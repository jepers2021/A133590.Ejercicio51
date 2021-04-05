using System;
using System.IO;
namespace A133590.Ejercicio51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 51");
            Console.Write("Por favor, ingrese una ruta de un archivo de texto: ");
            string ruta = Console.ReadLine();

            if(!File.Exists(ruta))
            {
                using (StreamWriter sw = File.CreateText(ruta))
                {
                    string cadena = "";
                    while (true)
                    {
                        Console.Write("Ingrese una cadena para agregarla al archivo: ");
                        cadena = Console.ReadLine();
                        if (cadena.Equals("fin")) break;
                        sw.WriteLine(cadena);
                        Console.WriteLine("Cadena agregada exitosamente.");
                    }
                }
                    
            }
            else
            {
                Console.WriteLine("El archivo ya existe.");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();

        }
    }
}
