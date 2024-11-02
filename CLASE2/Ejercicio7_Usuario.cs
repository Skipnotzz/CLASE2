using System;
using System.Collections.Generic;

namespace ProyectoConsola // Cambia "ProyectoConsola" por el nombre de tu namespace
{
    // Clase Usuario para almacenar datos del usuario
    class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
        }
    }

    class Program
    {
        // Lista para almacenar los usuarios registrados
        private static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            bool ejecutando = true;

            while (ejecutando)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Iniciar sesión");
                Console.WriteLine("3. Mostrar usuarios");
                Console.WriteLine("4. Editar usuario");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearUsuario();
                        break;
                    case "2":
                        IniciarSesion();
                        break;
                    case "3":
                        MostrarUsuarios();
                        break;
                    case "4":
                        EditarUsuario();
                        break;
                    case "5":
                        ejecutando = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void CrearUsuario()
        {
            Console.Write("\nIngrese el nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();

            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    Console.WriteLine("Este nombre de usuario ya existe. Intente con otro.");
                    return;
                }
            }

            usuarios.Add(new Usuario(nombreUsuario, contraseña));
            Console.WriteLine("Usuario creado exitosamente.");
        }

        static void IniciarSesion()
        {
            Console.Write("\nIngrese el nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese la contraseña: ");
            string contraseña = Console.ReadLine();

            Usuario usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);

            if (usuarioEncontrado != null)
            {
                Console.WriteLine($"Inicio de sesión exitoso. Bienvenido, {nombreUsuario}.");
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
            }
        }

        static void MostrarUsuarios()
        {
            Console.WriteLine("\n--- Lista de Usuarios ---");

            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
            }
            else
            {
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine($"Usuario: {usuario.NombreUsuario}");
                }
            }
        }

        static void EditarUsuario()
        {
            Console.Write("\nIngrese el nombre de usuario que desea editar: ");
            string nombreUsuario = Console.ReadLine();

            Usuario usuarioEncontrado = usuarios.Find(u => u.NombreUsuario == nombreUsuario);

            if (usuarioEncontrado != null)
            {
                Console.Write("Ingrese el nuevo nombre de usuario: ");
                string nuevoNombreUsuario = Console.ReadLine();

                Console.Write("Ingrese la nueva contraseña: ");
                string nuevaContraseña = Console.ReadLine();

                usuarioEncontrado.NombreUsuario = nuevoNombreUsuario;
                usuarioEncontrado.Contraseña = nuevaContraseña;

                Console.WriteLine("Usuario editado exitosamente.");
            }
            else
            {
                Console.WriteLine("Usuario no encontrado.");
            }
        }
    }
}
