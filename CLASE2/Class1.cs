using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CLASE2
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una cadena para validar:");
            string input = Console.ReadLine();

            // Expresión regular que requiere al menos una letra minúscula y entre 1 y 50 caracteres
            string pattern = @"^(?=.*[a-z]).{1,50}$";

            // Crear la instancia de Regex
            Regex regex = new Regex(pattern);

            // Verificar si la entrada coincide con el patrón
            if (regex.IsMatch(input))
            {
                Console.WriteLine("La cadena es válida.");
            }
            else
            {
                Console.WriteLine("La cadena no es válida.");
            }
            Console.ReadLine();

        }
    }
}
