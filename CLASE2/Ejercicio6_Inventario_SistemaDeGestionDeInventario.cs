using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE2
{
    class Ejercicio6_Inventario_SistemaDeGestionDeInventario
    {
        private List<Ejercicio6_Producto_SistemaDeGestionDeInventario> productos = new List<Ejercicio6_Producto_SistemaDeGestionDeInventario>();

        // Método para agregar un producto al inventario
        public void AgregarProducto(Ejercicio6_Producto_SistemaDeGestionDeInventario producto)
        {
            productos.Add(producto);
            Console.WriteLine($"Producto {producto.Nombre} agregado al inventario.");
        }

        // Método sobrecargado para agregar varios productos a la vez
        public void AgregarProducto(List<Ejercicio6_Producto_SistemaDeGestionDeInventario> nuevosProductos)
        {
            foreach (var producto in nuevosProductos)
            {
                AgregarProducto(producto);  // Llamada al método anterior
            }
        }

        // Método para mostrar todos los productos en el inventario
        public void MostrarInventario()
        {
            Console.WriteLine("Inventario:");
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }

        // Método para calcular el precio total de todos los productos en el inventario
        public double CalcularPrecioTotal()
        {
            return CalcularPrecioTotalRecursivo(0);  // Llamada al método recursivo
        }

        // Método recursivo para calcular el precio total
        private double CalcularPrecioTotalRecursivo(int index)
        {
            if (index >= productos.Count)  // Condición base
                return 0;
            else
                return (productos[index].Precio * productos[index].Cantidad) + CalcularPrecioTotalRecursivo(index + 1);
        }
    }
}
