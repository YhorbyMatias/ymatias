using System;
using System.Linq;

namespace contains01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos la cadena
            string cadena = "HOLA PROGRAMADORES .NET EN ESPANOL";
            Console.WriteLine(" \n TRABAJANDO CON CADENAS (CONTAINS) \n") ;
            //imprimimos la cadena
            Console.WriteLine(" \n Nuestra cadena es: " + cadena + "\n");
           
            //buscamos en  la cadena
            Console.WriteLine(" \n La cadena contiene la letra P ?:{0}", cadena.Contains('P'));
            Console.ReadKey();
        }
    }
}