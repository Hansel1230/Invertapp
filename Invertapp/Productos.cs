using System;
namespace Invertapp
{
    public class Productos
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string NombreCategoria { get; set; }

        public Productos(string Nombre, double Precio, String NombreCategoria)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.NombreCategoria = NombreCategoria;
        }
    }
}