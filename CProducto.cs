using System.Drawing;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa un producto en venta.
    //NJSA. 14/11/2021.
    //---------------------------------------------------------------------
    public class CProducto
    {
        //---------------------------------------------------------------------
        //Atributos.
        //Nota: Algunos atributos son utilizados para llenar los datos de la tabla de Productos
        //en DlgConfigurarProductos.
        //---------------------------------------------------------------------
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public bool Oculto;

        public Image Imagen;

        //---------------------------------------------------------------------
        //Constructor sin parámetros.
        //---------------------------------------------------------------------
        public CProducto()
        {

        }

        //---------------------------------------------------------------------
        //Constructor con parametros.
        //---------------------------------------------------------------------
        public CProducto(int Codigo, string Producto, double Precio, int Stock, Image Imagen, bool Oculto)
        {
            this.Codigo = Codigo;
            this.Producto = Producto;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Imagen = Imagen;
            this.Oculto = Oculto;
        }
    }
}
