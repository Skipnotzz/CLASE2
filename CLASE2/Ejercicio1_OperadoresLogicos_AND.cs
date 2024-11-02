using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio1_OperadoresLogicos_AND
    {
        static void Main()
        {
            Console.Write("Ingresa el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > 10 && num2 > 10)
            {
                Console.WriteLine("Ambos números son mayores a 10.");
            }
            else
            {
                Console.WriteLine("Al menos uno de los números no es mayor a 10.");
            }
            Console.ReadLine();
        }
    }
}
