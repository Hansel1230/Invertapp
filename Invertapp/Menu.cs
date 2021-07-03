using System;
namespace Invertapp
{
    public class Menu
    {
        static Operaciones operacion = new Operaciones();

        public static void menuPrincipal()
        {
            int cantidad;
            int inventarioindex;
            Console.Clear();
            Console.WriteLine("Bienvenido a su inventario preferido!!\n");
            Console.WriteLine("\n1-Mantenimiento de categorias\n2-Mantenimiento de productos\n3-Entrada de inventario\n4-Salida de inventario\n5-Salir\n\nIngrese opcion deseada:");

            try 
            {
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

                        Console.WriteLine("\nEntrada inventario\n\n");
                        operacion.Impresorinventario();

                        Console.WriteLine("\nIngrese el indice del producto a actualizar:");
                        inventarioindex = Convert.ToInt16(Console.ReadLine());

                        if (operacion.isvalidindexProduct(inventarioindex))
                        {
                            Console.WriteLine("\nCantidad a ingresar:");
                            cantidad = Convert.ToInt32(Console.ReadLine());

                            operacion.Entradainventario(inventarioindex, cantidad);

                            Console.WriteLine("Inventario actualizado Correctamente. Pulse Enter");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un indice valido. Pulse Enter");
                            Console.ReadKey();
                        }
                        menuPrincipal();
                        break;

                    case 4:

                        Console.WriteLine("\nSalida inventario\n\n");
                        operacion.Impresorinventario();

                        Console.WriteLine("\nIngrese el indice del producto a actualizar:");
                        inventarioindex = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\nCantidad a sacar:");
                        cantidad = Convert.ToInt32(Console.ReadLine());

                        operacion.Salidainventario(inventarioindex, cantidad);

                        Console.WriteLine("Inventario actualizado Correctamente. Pulse Enter");
                        Console.ReadKey();

                        menuPrincipal();
                        break;

                    case 5:
                        Console.WriteLine("Gracias por usar nustro inventario. Pulse Enter");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                        Console.ReadKey();

                        menuPrincipal();
                        break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                Console.ReadKey();

                menuPrincipal();
            }
        }
        //Categorias
        private static void menuCategoria()
        {
            Console.Clear();
            Console.WriteLine("Menu Categorias\n");
            Console.WriteLine("\n1-Agregar categoría\n2-Editar categoría\n3-Eliminar categoría\n4-Listar categorías\n5-Volver atrás\n\nIngrese opcion deseada:");

            try
            {
                int opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //Agregar Categorias
                        Console.WriteLine("\nAgregar Categorias\n\n");
                        Console.WriteLine("Ingrese el nombre de la categoria");
                        string nombre = Console.ReadLine();
                        operacion.AgregarCategoria(nombre);

                        Console.WriteLine("\nCategoria Agregada correctamente. Pulse Enter");
                        Console.ReadKey();
                        menuCategoria();
                        break;

                    case 2:
                        //Editar Categorias
                        Console.WriteLine("\nEditar Categorias\n\n");
                        operacion.ListarCategoria();

                        Console.WriteLine("\nIngrese el indice de la categoria a editar:");
                        int editindex = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\nIngrese el Nombre de la nueva categoria:");
                        string editNombre = Console.ReadLine();
                        operacion.EditarCategoria(editindex, editNombre);

                        Console.WriteLine("\nCategoria editada correctamente. Pulse Enter");
                        Console.ReadKey();
                        menuCategoria();
                        break;

                    case 3:
                        //Eliminar Categorias
                        Console.WriteLine("\n Eliminar Categorias\n\n");

                        operacion.ListarCategoria();

                        Console.WriteLine("\nIngrese el indice de la categoria a eliminar:");
                        editindex = Convert.ToInt16(Console.ReadLine());

                        operacion.ElimiarCategoria(editindex);
                        Console.WriteLine("\nCategoria eliminada correctamente. Pulse Enter");

                        Console.ReadKey();
                        Console.Clear();
                        menuCategoria();
                        break;

                    case 4:
                        //ListarCategoria
                        Console.WriteLine("\nCategorias\n\n");
                        operacion.ListarCategoria();
                        Console.WriteLine("\n\nPulse Enter\n");
                        Console.ReadKey();
                        menuCategoria();
                        break;

                    case 5:
                        Console.WriteLine("\nPulse Enter");
                        Console.ReadKey();
                        Console.Clear();
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
            catch (Exception e)
            {
                Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                Console.ReadKey();
                menuCategoria();
            }
        }
        // productos
        private static void menuProducto()
        {
            string produtNombre;
            double produtprecio;
            int produtindex;
            Console.WriteLine("\nMenu Productos\n");
            Console.WriteLine("\n1-Agregar producto\n2-Editar producto(\n3-Eliminar producto\n4-Listar productos\n5-Volver atrás\n\nIngrese opcion deseada:");
            Console.Clear();
            try
            {
                int opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //Agregar productos
                        Console.WriteLine("\nAgregar productos\n\n");

                        operacion.ListarCategoria();

                        Console.WriteLine("\nIngrese el indice de la categoria a seleccionar:");
                        int indexCatego = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\nIngrese el nombre del producto");
                        produtNombre = Console.ReadLine();

                        Console.WriteLine("\nIngrese el precio del producto");
                        produtprecio = Convert.ToInt32(Console.ReadLine());

                        operacion.AgregarProducto(produtNombre, produtprecio, indexCatego);
                        Console.WriteLine("\nProducto agregado correctamente. Pulse Enter");
                        Console.ReadKey();
                        Console.Clear();
                        menuProducto();
                        break;

                    case 2:
                        //Editar productos
                        Console.WriteLine("\nEditar productos\n\n");
                        operacion.ListarProducto();

                        Console.WriteLine("\nIngrese el indice del producto a editar:");
                        produtindex = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\nIngrese el Nombre del nuevo Producto:");
                        produtNombre = Console.ReadLine();

                        Console.WriteLine("\nIngrese el Precio del nuevo Producto:");
                        produtprecio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n");
                        operacion.ListarCategoria();

                        Console.WriteLine("\nIngrese el indice de la nueva categoria:");
                        int categoindex = Convert.ToInt16(Console.ReadLine());

                        operacion.EditarProducto(produtNombre, produtprecio, produtindex, categoindex);
                        Console.WriteLine("\nProducto editado correctamente. Pulse Enter");
                        Console.ReadKey();
                        Console.Clear();
                        menuProducto();
                        break;

                    case 3:
                        //Eliminar productos
                        Console.WriteLine("\nEliminar productos\n\n");
                        operacion.ListarProducto();

                        Console.WriteLine("\nIngrese el indice de la categoria a eliminar:");
                        produtindex = Convert.ToInt16(Console.ReadLine());

                        operacion.ElimiarProductos(produtindex);
                        Console.WriteLine("\nProducto eliminado correctamente. Pulse Enter");
                        Console.ReadKey();
                        Console.Clear();
                        menuProducto();
                        break;

                    case 4:
                        Console.WriteLine("\nProductos\n\n");
                        operacion.ListarProducto();
                        Console.WriteLine("\n\nPulse Enter\n");
                        Console.ReadKey();
                        menuProducto();
                        break;

                    case 5:
                        Console.WriteLine("\nPulse Enter");
                        Console.ReadKey();
                        Console.Clear();
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
            catch (Exception e)
            {
                Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                Console.ReadKey();
                menuProducto();
            }
        }
    }
}