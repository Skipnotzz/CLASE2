using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio2_OperadoresLogicos_OR
    {
        static void Main()
        {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18 || edad > 65)
            {
                Console.WriteLine("Eres menor de edad o adulto mayor.");
            }
            else
            {
                Console.WriteLine("Estás en el rango de edad laboral (18-65 años).");
            }
            Console.ReadLine();
        }
    }
}
