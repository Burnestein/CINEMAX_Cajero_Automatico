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
    public partial class DlgConfigurarProductos : Form
    {
        
        public List<CProducto> Productos = DlgMenuPrincipal.MenuPrincipal.ListaProductos;
        private int indice = -1;
        public DlgConfigurarProductos()
        {
            InitializeComponent();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CProducto MiProducto = new CProducto(
                Decimal.ToInt32(NudCodigoProducto.Value),
                TbxNombreProducto.Text,
                Decimal.ToDouble(NudPrecioProducto.Value),
                Decimal.ToInt32(NudStockProducto.Value),
                PbxImagenProducto.Image,
                CbxOcultar.Checked
                );

            if (indice > -1)
            {
                Productos[indice] = MiProducto;
                indice = -1;
            }
            else
            {
                Productos.Add(MiProducto);
            }
            //DlgMenuPrincipal.MenuPrincipal.CargarFuenteSodas();
            LimpiarFormulario();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = Productos;
            DgvProductos.ClearSelection();
        }

        private void LimpiarFormulario()
        {
            NudCodigoProducto.Value = 0;
            TbxNombreProducto.Text = "";
            NudPrecioProducto.Value = 0;
            NudStockProducto.Value = 0;
            PbxImagenProducto.Image = Properties.Resources.Cinemax_Logo;
            CbxOcultar.Checked = false;
        }

        private void DlgConfigurarProductos_Load(object sender, EventArgs e)
        {
            if (Productos.Count != 0)
            {
                ActualizarTabla();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Productos.RemoveAt(indice);
                indice = -1;
                LimpiarFormulario();
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione un producto.");
            }
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbxImagenProducto.Load(openFileDialog1.FileName);
            }
        }

        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Seleccionada = DgvProductos.SelectedRows[0];
            int pos = DgvProductos.Rows.IndexOf(Seleccionada);
            CProducto MiProducto = Productos[pos];
            indice = pos;
            NudCodigoProducto.Value = MiProducto.Codigo;
            TbxNombreProducto.Text = MiProducto.Producto;
            NudStockProducto.Value = MiProducto.Stock;
            NudPrecioProducto.Value = (int)MiProducto.Precio;
            CbxOcultar.Checked = MiProducto.Oculto;
            
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
