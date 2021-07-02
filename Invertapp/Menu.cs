using System;
namespace Invertapp
{
    public class Menu
    {
        static Operaciones operacion = new Operaciones();

        public static void menuPrincipal()
        {
            Console.WriteLine("Bienvenido a su inventario preferido!!\n");
            Console.WriteLine("\n1-Mantenimiento de categorias\n2-Mantenimiento de productos\n3-Entrada de inventario\n4-Salida de inventario\n5-Salir\n\nIngrese opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    menuCategoria();
                    break;
                case 2:
                    menuProducto();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:
                    Console.WriteLine("Gracias por usar nustro inventario. Pulse Enter");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                    Console.ReadKey();
                    Console.Clear();
                    menuPrincipal();
                    break;
            }
        }
        private static void menuCategoria()
        {
            Console.Clear();
            Console.WriteLine("Menu Categorias\n");
            Console.WriteLine("\n1-Agregar categoría\n2-Editar categoría\n3-Eliminar categoría\n4-Listar categorías\n5-Volver atrás\n\nIngrese opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nAgregar Categorias\n\n");
                    Console.WriteLine("Ingrese el nombre de la categoria");
                    string nombre = Console.ReadLine();
                    operacion.AgregarCategoria(nombre);

                    Console.WriteLine("\nCategoria Agregada correctamente. Pulse Enter");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("\nEditar Categorias\n\n");
                    operacion.ListarCategoria();
                    Console.WriteLine("\nIngrese el indice de la categoria a editar:");
                    int editindex= Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nIngrese el Nombre de la nueva categoria:");
                    string editNombre = Console.ReadLine();
                    operacion.EditarCategoria(editindex,editNombre);

                    Console.WriteLine("\nCategoria editada correctamente. Pulse Enter");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("\n Eliminar Categorias\n\n");

                    operacion.ListarCategoria();

                    Console.WriteLine("\nIngrese el indice de la categoria a eliminar:");
                    editindex = Convert.ToInt16(Console.ReadLine());

                    operacion.ElimiarCategoria(editindex);
                    Console.WriteLine("\nCategoria eliminada correctamente. Pulse Enter");

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.WriteLine("\nCategorias\n\n");
                    operacion.ListarCategoria();
                    break;

                case 5:
                    menuPrincipal();
                    break;

                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                    Console.ReadKey();
                    Console.Clear();
                    menuCategoria();
                    break;
            }
            Console.Clear();
            menuPrincipal();
        }
        private static void menuProducto()
        {
            Console.WriteLine("Menu Productos\n");
            Console.WriteLine("\n1-Agregar producto\n2-Editar producto(\n3-Eliminar producto\n4-Listar productos\n5-Volver atrás\n\nIngrese opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nAgregar productos\n\n");

                    operacion.ListarCategoria();

                    Console.WriteLine("\nIngrese el indice de la categoria a seleccionar:");
                    int indexCategoria = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("\nIngrese el nombre del producto");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("\nIngrese el precio del producto");
                    double precio = Convert.ToInt32(Console.ReadLine());

                    operacion.AgregarProducto(nombre, precio,indexCategoria);
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("\nEditar productos\n\n");
                    operacion.ListarProducto();

                    Console.WriteLine("\nIngrese el indice del producto a editar:");
                    int editindex = Convert.ToInt16(Console.ReadLine());
                  
                    Console.WriteLine("\nIngrese el Nombre del nuevo Producto:");
                    string editNombre = Console.ReadLine();

                    Console.WriteLine("\nIngrese el Precio del nuevo Producto:");
                    double produtprecio = Convert.ToInt32(Console.ReadLine());

                    operacion.EditarProducto(editNombre, produtprecio,editindex);
                    Console.Clear();
                    break;

                case 3:
                    Console.WriteLine("\nEliminar productos\n\n");
                    break;

                case 4:
                    Console.WriteLine("\nListar productos\n\n");
                    break;

                case 5:
                    menuPrincipal();
                    break;

                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                    Console.ReadKey();
                    Console.Clear();
                    menuProducto();
                    break;
            }
            menuPrincipal();
        }

    }
}