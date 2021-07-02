using System.Collections.Generic;
using System;
namespace Invertapp

{
    public class Operaciones
    {
        //listas
        List<Categorias> LisCategorias = new List<Categorias>();
        List<Productos> LisProductos = new List<Productos>();
        List<int> LisCantidades = new List<int>();
        
        //Categorias
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
         }

        public void ElimiarCategoria(int editindex )
        {
            LisCategorias.RemoveAt(editindex - 1);
        }

        // productos

        public void AgregarProducto(string nombreProducto,double precio, int indexCategoria)
        {
            Categorias catego = LisCategorias[indexCategoria - 1];
            Productos product = new Productos(nombreProducto,precio,catego.Nombre);
            LisProductos.Add(product);
        }

        public void EditarProducto(string nombreProducto, double precio, int produtindex , int indexCategoria)
        {
            Categorias catego = LisCategorias[indexCategoria - 1];
 
            LisProductos[produtindex - 1].Nombre = nombreProducto;
            LisProductos[produtindex - 1].Precio = precio;
            LisProductos[produtindex - 1].NombreCategoria = catego.Nombre;
        }

        public void ListarProducto()
        {
            int count = 0;
            foreach (Productos producto in LisProductos)
            {
                count++;
                Console.WriteLine(count + ":" + producto.Nombre);
            }
        }

        public void ElimiarProductos(int produtindex)
        {
            LisProductos.RemoveAt(produtindex - 1);
        }

        // Inventario
        
        public void Entradainventario()
        {
            Impresorinventario();
        }

        public void Salidainventario()
        {
            Impresorinventario();
        }

        public void Impresorinventario()
        {
            int count = 0;
            foreach (Productos producto in LisProductos)
            {
                count++;
                Console.WriteLine(count + ":" + producto.Nombre + ":" + producto.Cantidad);
            }
        }
    }
}