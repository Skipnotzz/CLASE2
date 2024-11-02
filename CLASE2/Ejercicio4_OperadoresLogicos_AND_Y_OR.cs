using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio4_OperadoresLogicos_AND_Y_OR
    {
        static void Main()
        {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 > 0 && num2 > 0) || (num1 > 0 && num3 > 0) || (num2 > 0 && num3 > 0))
            {
                Console.WriteLine("Al menos dos de los números son positivos.");
            }
            else
            {
                Console.WriteLine("Menos de dos números son positivos.");
            }
        }
    }
}
