using System;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Control de usuario que crea el panel del producto en el menu principal.
    //NJSA. 06/10/2021.
    //---------------------------------------------------------------------
    public partial class PanelProducto : UserControl
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private CProducto Producto;
        private int CantidadProducto;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public PanelProducto(CProducto Producto)
        {
            InitializeComponent();
            this.Producto = Producto;
            LblNombreProducto.Text = Producto.Producto;
            PbxProducto.Image = Producto.Imagen;
            LblPrecio.Text = "$ " + Producto.Precio.ToString();
            CantidadProducto = 0;
        }

        //---------------------------------------------------------------------
        //Agrega los productos al carrito de compras.
        //---------------------------------------------------------------------
        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CantidadProducto; i++)
            {
                DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Producto);
                LblNumCantidad.Text = "x0";
            }
        }

        //---------------------------------------------------------------------
        //Botón + incrementa el numero de productos seleccionados.
        //---------------------------------------------------------------------
        private void BtnMasProducto_Click(object sender, EventArgs e)
        {
            CantidadProducto++;
            LblNumCantidad.Text = "x" + CantidadProducto;
        }

        //---------------------------------------------------------------------
        //Botón - reduce el numero de productos seleccionados.
        //---------------------------------------------------------------------
        private void BtnMenosProducto_Click(object sender, EventArgs e)
        {
            if (CantidadProducto > 0)
            {
                CantidadProducto--;
                LblNumCantidad.Text = "x" + CantidadProducto;
            }
        }
    }
}
