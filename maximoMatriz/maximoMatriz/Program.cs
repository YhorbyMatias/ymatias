﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            int n, m;
            int mayor, menor;

            Console.WriteLine("VISITE WWW.YMATIAS.COM");
            Console.WriteLine( "NUMEROS MAYOR Y MENOR DE UNA MATRIZ");
            Console.WriteLine("INDIQUE EL NUMERO DE FILAS");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("INDIQUE EL NUMERO DE COLUMNAS");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESA EL ELEMENTO[" +i + ","+j +"]");
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            Console.Clear();
            Console.WriteLine("Los elementos que conforman la matriz son:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("  ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write("  "+a[i, j]);
                }
            }
            Console.WriteLine(" ");
            mayor = menor = a[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < menor)
                    {
                        menor = a[i, j];
                    }
                    else
                        if (a[i, j] > mayor)
                    {
                        mayor = a[i, j];
                    }
                }
            }
            Console.WriteLine("MAXIMO elemento de la Matriz:" +mayor);
            Console.WriteLine("MINIMO elemento de la Matriz:" + menor);
            Console.ReadLine();
        }
    }
}
