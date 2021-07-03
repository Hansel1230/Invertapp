using System.Collections.Generic;
using System;
namespace Invertapp

{
    public class Operaciones
    {
        //listas
        List<Categorias> LisCategorias = new List<Categorias>();
        List<Productos> LisProductos = new List<Productos>();
         
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
        
        public void Entradainventario(int indice, int cantidad)
        {
            Productos product = LisProductos[indice - 1];
            product.Cantidad += cantidad;
        }

        public void Salidainventario(int indice, int cantidad)
        {
            Productos product =LisProductos[indice - 1];
            product.Cantidad -= cantidad;
            
        }

        public void Impresorinventario()
        {
            int count = 0;
            Console.WriteLine("Ejemplo Estructura: (Indice:Producto:Cantidad) \n");
            foreach (Productos producto in LisProductos)
            {
                count++;
                Console.WriteLine(count + ":" + producto.Nombre + ":" + producto.Cantidad);
            }
        }

        public bool isvalidindexProduct(int opcion   )
        {
            return (opcion > 0 && opcion <= LisProductos.Count);
        }

        public bool isvalidindexCatego(int opcion)
        {
            return (opcion > 0 && opcion <= LisCategorias.Count);
        }
    }
}
/*Hansel De Los Santos Ramirez (202010355)*/