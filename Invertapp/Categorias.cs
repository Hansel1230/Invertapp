using System;
namespace Invertapp
{
    public class Categorias
    {   
        public void  categorias()
        {
            Console.WriteLine("1-Agregar categoría\n2-Editar categoría\n3-Eliminar categoría\n4-Listar categorías\n5-Volver atrás\nIngrese opcion deseada:");
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;

                default:
                    Console.WriteLine("Debe ingresar una opcion valida. Pulse Enter");
                    Console.ReadKey();
                    Console.Clear();

                    break;
            }
        }
    }
}
