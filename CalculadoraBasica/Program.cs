using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DominioCalc;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-------------------------------------\n");
            Console.Write("                MENÚ                 \n");
            Console.Write("-------------------------------------\n");
            
            int opcion = 0;
            int num1=0;
            int num2=0;
            AritmeticaBasica aritmeticaBasica = new AritmeticaBasica();
            do
            {
                Console.WriteLine("Operaciones Básicas");
                Console.Write("-------------------------------------\n");
                Console.WriteLine("1.Suma");
                Console.WriteLine("2.Resta");
                Console.WriteLine("3.Multiplicación");
                Console.WriteLine("4.División");
                Console.WriteLine("5.Salir");
                Console.Write("-------------------------------------\n");
                Console.Write("Elija una opción: ");
                Console.Write(" ");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion < 5)
                    {
                        Console.Write("Introduzca primer número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introduzca segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Error debe introducir un número correcto.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                switch (opcion)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El resutado es: {0}", aritmeticaBasica.Sumar(num1, num2));
                        Console.Write("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El resutado es: {0}", aritmeticaBasica.Restar(num1, num2));
                        Console.Write("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("El resutado es: {0}", aritmeticaBasica.Multiplicar(num1, num2));
                        Console.Write("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 4:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El resutado es: {0}", aritmeticaBasica.Dividir(num1, num2));
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.Write("\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("No existe la operación.");
                        Console.Write("\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (opcion != 5);

        }
    }
}
