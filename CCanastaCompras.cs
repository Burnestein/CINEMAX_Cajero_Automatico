using System.Collections.Generic;
using System.Linq;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public class CCanastaCompras
    {
        public List<CProducto> Productos = new List<CProducto>();
        public List<CPelicula> Pelicula = new List<CPelicula>(); 

        public CCanastaCompras()
        {

        }
        public CCanastaCompras(List<CProducto> Productos)
        {
            this.Productos = Productos;
        }
        public CCanastaCompras(List<CPelicula> Pelicula)
        {
            this.Pelicula = Pelicula;
        }

        public List<CProducto> AddToCanasta(CProducto Producto)
        {
            Productos.Add(Producto);
            return Productos;
        }
        public List<CPelicula> AddToCanasta(CPelicula Pelicula)
        {
            this.Pelicula.Add(Pelicula);
            return this.Pelicula;
        }
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
        public int Count()
        {
            int Items=0;
            Items += Productos.Count() /*+ Pelicula.Count()*/;
            return Items;
        }
        public List<string> ConvertirAListaProductos()
        {
            List<string> MiLista = new List<string>();
            for(int i = 0; i < Pelicula.Count; i++)
            {
                MiLista.Add(Pelicula[i].Titulo);
            }
            for(int i = 0; i < Productos.Count; i++)
            {
                MiLista.Add(Productos[i].Producto);
            }
            return MiLista;
        }
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
        public void VaciarCanasta()
        {
            Pelicula.Clear();
            Productos.Clear();
        }
    }
}
