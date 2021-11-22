using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class PanelProducto : UserControl
    {
        private CProducto Producto;
        private int CantidadProducto;
        private double Total;
        public PanelProducto(CProducto Producto)
        {
            InitializeComponent();
            this.Producto = Producto;
            LblNombreProducto.Text = Producto.Producto;
            PbxProducto.Image = Producto.Imagen;
            LblPrecio.Text = "$ " + Producto.Precio.ToString();
            CantidadProducto = 0;
            Total = 0;
        }

        private void PnlSala_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CantidadProducto; i++)
            {
                DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Producto);
            }
        }

        private void BtnMasProducto_Click(object sender, EventArgs e)
        {
            CantidadProducto++;
            LblNumCantidad.Text = "x" + CantidadProducto;
        }

        private void BtnMenosProducto_Click(object sender, EventArgs e)
        {
            CantidadProducto--;
            LblNumCantidad.Text = "x" + CantidadProducto;
        }

        private void LblNumCantidad_TextChanged(object sender, EventArgs e)
        {
            LblNumCantidad.Text = "x" + CantidadProducto;
        }
    }
}
