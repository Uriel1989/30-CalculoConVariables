using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30_CalculoConVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            double num2, suma, resta;

            char letra;


            Console.WriteLine("Ingrese un valor entero para la varible int: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese un valor decimal para la variable double: ");

            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un unico carater para la varible char: ");

            letra = Convert.ToChar(Console.ReadLine());

            suma = num1 + num2;

            resta = num2 - num1;

            Console.WriteLine("La suma de las varibles num es: " + suma);

            Console.WriteLine("La resta de las varibles num es: " + resta);

            Console.WriteLine("El valor de la variable letra es: " + letra);

            Console.ReadKey();
        }
    }
}
