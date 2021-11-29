using System.Collections.Generic;
using System.Linq;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa una canasta de compras.
    //NJSA. 20/11/2021.
    //---------------------------------------------------------------------
    public class CCanastaCompras
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public List<CProducto> Productos;
        public List<CPelicula> Pelicula;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CCanastaCompras()
        {
            Productos = new List<CProducto>();
            Pelicula = new List<CPelicula>();
        }

        //---------------------------------------------------------------------
        //Agrega un producto a la lista de productos de la cansata y retorna la nueva lista.
        //---------------------------------------------------------------------
        public List<CProducto> AddToCanasta(CProducto Producto)
        {
            Productos.Add(Producto);
            return Productos;
        }

        //---------------------------------------------------------------------
        //Agrega una pelicula a la lista de peliculas de la cansata y retorna la nueva lista.
        //---------------------------------------------------------------------
        public List<CPelicula> AddToCanasta(CPelicula Pelicula)
        {
            this.Pelicula.Add(Pelicula);
            return this.Pelicula;
        }

        //---------------------------------------------------------------------
        //Retorna el total de los productos en la canasta.
        //---------------------------------------------------------------------
        public double GetTotalCompras()
        {
            double Total=0;
            int Cantidad = Productos.Count();
            for(int i=0; i<Cantidad; i++)
            {
                Total += Productos[i].Precio;
            }
            return Total;
        }

        //---------------------------------------------------------------------
        //Cuenta los productos de la canasta, retorna un entero.
        //---------------------------------------------------------------------
        public int Count()
        {
            int Items=0;
            Items += Productos.Count() /*+ Pelicula.Count()*/;
            return Items;
        }

        //---------------------------------------------------------------------
        //Convierte la lista de productos a un string.
        //---------------------------------------------------------------------
        public string ConvertirAListaString()
        {
            string Lista = "";
            for (int i = 0; i < Pelicula.Count; i++)
            {
                Lista = Lista + Pelicula[i].Titulo + "\n";
            }
            for (int i = 0; i < Productos.Count; i++)
            {
                Lista = Lista + Productos[i].Producto + "\n";
            }
            return Lista;
        }

        //---------------------------------------------------------------------
        //Limpia todos los elementos de la canasta.
        //---------------------------------------------------------------------
        public void VaciarCanasta()
        {
            Pelicula.Clear();
            Productos.Clear();
        }
    }
}
