using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio5_OperadoresLogicos
    {
        static void Main()
        {
            Console.Write("Ingresa tu calificación: ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 60 && calificacion <= 100)
            {
                Console.WriteLine("Calificación aprobatoria.");
            }
            else
            {
                Console.WriteLine("Calificación no aprobatoria.");
            }
        }
    }
}
