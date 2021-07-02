using System.Collections.Generic;
using System;
namespace Invertapp

{
    public class Operaciones
    {
        List<Categorias> LisCategorias = new List<Categorias>();
        List<Productos> LisProductos = new List<Productos>();

        public Operaciones()
        {

        }

        public void AgregarCategoria(string nombreCategoria)
        {
            Categorias catego = new Categorias(nombreCategoria);
            LisCategorias.Add(catego);
        }

        public void EditarCategoria(int editindex, string editnombre)
        {
            LisCategorias[editindex - 1].Nombre = editnombre;
        }

        public void ListarCategoria()
        {
            int count = 0;
            foreach (Categorias catego in LisCategorias)
            {
                count++;
                Console.WriteLine(count + ":" + catego.Nombre);
            }
            //Console.ReadKey();
        }

        public void ElimiarCategoria(int editindex )
        {
            LisCategorias.RemoveAt(editindex - 1);
        }

        public void AgregarProducto(string nombreProducto,double precio, int indexCategoria)
        {
            Categorias catego = LisCategorias[indexCategoria - 1];
            Productos product = new Productos(nombreProducto,precio,catego.Nombre);
            LisProductos.Add(product);
        }

        public void EditarProducto(string nombreProducto, double precio, int indexCategoria)
        {
            ListarProducto();
            Categorias catego = LisCategorias[indexCategoria - 1];
            Productos product = new Productos(nombreProducto, precio, catego.Nombre);

            LisProductos[indexCategoria - 1].Nombre = nombreProducto;
        }

        public void ListarProducto()
        {
            int count = 0;
            foreach (Productos producto in LisProductos)
            {
                count++;
                Console.WriteLine(count + ":" + producto);
            }
            Console.ReadKey();
        }
    }
}