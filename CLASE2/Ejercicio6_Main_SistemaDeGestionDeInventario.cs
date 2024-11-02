using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{

    //Definición de clases y métodos.
    //Uso de parámetros y retorno de valores.
    //Métodos sobrecargados.
    //Recursividad.
    //Creación y uso de objetos en un entorno de varias clases.

    class Ejercicio6_Main_SistemaDeGestionDeInventario
    {
        static void Main()
        {
            // Crear algunos productos
            Ejercicio6_Producto_SistemaDeGestionDeInventario producto1 = new Ejercicio6_Producto_SistemaDeGestionDeInventario("Laptop", 1500.00, 2);
            Ejercicio6_Producto_SistemaDeGestionDeInventario producto2 = new Ejercicio6_Producto_SistemaDeGestionDeInventario("Smartphone", 800.00, 5);
            Ejercicio6_Producto_SistemaDeGestionDeInventario producto3 = new Ejercicio6_Producto_SistemaDeGestionDeInventario("Tablet", 300.00, 10);

            // Crear el inventario y agregar productos
            Ejercicio6_Inventario_SistemaDeGestionDeInventario inventario = new Ejercicio6_Inventario_SistemaDeGestionDeInventario();
            inventario.AgregarProducto(producto1);
            inventario.AgregarProducto(producto2);

            // Agregar varios productos a la vez usando el método sobrecargado
            List<Ejercicio6_Producto_SistemaDeGestionDeInventario> listaProductos = new List<Ejercicio6_Producto_SistemaDeGestionDeInventario> { producto3, producto3, producto3 };
            inventario.AgregarProducto(listaProductos);

            // Mostrar todos los productos en el inventario
            inventario.MostrarInventario();

            // Calcular y mostrar el precio total
            double precioTotal = inventario.CalcularPrecioTotal();
            Console.WriteLine($"El precio total de los productos en el inventario es: ${precioTotal}");
            Console.ReadLine();
        }
    }
}
