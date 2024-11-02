using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio3_OperadorLogico_NOT
    {
        static void Main()
        {
            Console.Write("Ingresa tu contraseña: ");
            string password = Console.ReadLine();

            if (!string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Contraseña aceptada.");
            }
            else
            {
                Console.WriteLine("Error: La contraseña no puede estar vacía.");
            }
        }
    }
}
