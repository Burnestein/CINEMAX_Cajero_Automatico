using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Diálogo de la pestaña configuración de caja.
    //NJSA. 01/10/2021.
    //---------------------------------------------------------------------
    public partial class DlgConfigurarProductos : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public List<CProducto> Productos;
        private int indice = -1; //indice del producto seleccionado en la tabla

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgConfigurarProductos()
        {
            InitializeComponent();
            Productos = DlgMenuPrincipal.MenuPrincipal.ListaProductos;
        }

        //---------------------------------------------------------------------
        //Crea una nueva instacia para CProducto, asigna sus valores.
        //---------------------------------------------------------------------
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
                Productos[indice] = MiProducto; //Sobre escribe el producto
                indice = -1;
            }
            else
            {
                Productos.Add(MiProducto); //crea uno nuevo
            }
            LimpiarFormulario();
            ActualizarTabla();
        }

        //---------------------------------------------------------------------
        //Actualiza la tabla de productos.
        //---------------------------------------------------------------------
        private void ActualizarTabla()
        {
            DgvProductos.DataSource = null;
            DgvProductos.DataSource = Productos;
            DgvProductos.ClearSelection();
        }

        //---------------------------------------------------------------------
        //Limpia el formulario y rogresa a sus valores iniciales.
        //---------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            NudCodigoProducto.Value = 0;
            TbxNombreProducto.Text = "";
            NudPrecioProducto.Value = 0;
            NudStockProducto.Value = 0;
            PbxImagenProducto.Image = Properties.Resources.Cinemax_Logo;
            CbxOcultar.Checked = false;
        }

        //---------------------------------------------------------------------
        //Evento que se inicia al abrir el formulario
        //---------------------------------------------------------------------
        private void DlgConfigurarProductos_Load(object sender, EventArgs e)
        {
            if (Productos.Count != 0)
            {
                ActualizarTabla();
            }
        }

        //---------------------------------------------------------------------
        //Remueve un producto seleccionado de la tabla.
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        //Abre una ventana para cargar imagen al producto.
        //---------------------------------------------------------------------
        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PbxImagenProducto.Load(openFileDialog1.FileName);
            }
        }

        //---------------------------------------------------------------------
        //Carga la informacion del producto en el formulario al hacer doble click en la tabla.
        //---------------------------------------------------------------------
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
            PbxImagenProducto.Image = MiProducto.Imagen;
        }

        //---------------------------------------------------------------------
        //Limpia el formulario al hacel click al boton.
        //---------------------------------------------------------------------
        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
