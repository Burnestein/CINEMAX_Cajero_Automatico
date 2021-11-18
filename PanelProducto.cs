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
        public PanelProducto(CProducto Producto)
        {
            InitializeComponent();
            this.Producto = Producto;
            LblNombreProducto.Text = Producto.Producto;
            PbxProducto.Image = Producto.Imagen;
            LblPrecio.Text = "$ " + Producto.Precio.ToString();
        }

        private void PnlSala_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregarCarrito_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Producto);
        }
    }
}
