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
        public static DlgConfigurarProductos ConfigurarProductos;
        public List<CProducto> Productos = DlgMenuPrincipal.MenuPrincipal.ListaProductos;
        private int indice = -1;
        public DlgConfigurarProductos()
        {
            InitializeComponent();
            Productos = new List<CProducto>();
            ConfigurarProductos = this;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CProducto MiProducto = new CProducto(
                Decimal.ToInt32(NudCodigoProducto.Value),
                TbxNombreProducto.Text,
                Decimal.ToDouble(NudPrecioProducto.Value),
                Decimal.ToInt32(NudStockProducto.Value),
                PbxImagenProducto.Image            
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
                MessageBox.Show("Seleccione una producto.");
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
            
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        /*private void BtnLimpiarFormulario_Click(object sender, EventArgs e)
{
indice = -1;
LimpiarFormulario();
}

//---------------------------------------------------------------------
//Agrega una tabla con los detalles de la película.
//---------------------------------------------------------------------
private void BtnGuardarPelicula_Click(object sender, EventArgs e)
{
CPelicula Pelicula = new CPelicula(//"Title","Duration","Gender","Clasif","Sinopsis","Schedule"
TbxTituloPelicula.Text,
NudDuracionPelicula.Text,
CbxGeneroPelicula.Text,
CbxClasificacionPelicula.Text,
RtbSinopsisPelicula.Text,
HorarioPelicula,
PbxImagenPelicula.Image
);

if (indice > -1)
{
Peliculas[indice] = Pelicula;
indice = -1;
}
else
{
Peliculas.Add(Pelicula);
}
//DlgMenuPrincipal.MenuPrincipal.ListaPeliculas = Peliculas;
//DlgMenuPrincipal.MenuPrincipal.ListaHorarios = HorarioPelicula;
DlgMenuPrincipal.MenuPrincipal.CargarCartelera();
LimpiarFormulario();
ActualizarTabla();
}

//---------------------------------------------------------------------
//Borra la informacion escrita en el formulario.
//---------------------------------------------------------------------
private void LimpiarFormulario()
{
TbxTituloPelicula.Text = "";
NudDuracionPelicula.Value = 0;
CbxGeneroPelicula.Text = "";
CbxClasificacionPelicula.Text = "";
LbxHorariosPelicula.Items.Clear();
PbxImagenPelicula.Image = Properties.Resources.Cinemax_Logo;
RtbSinopsisPelicula.Text = "";

}

//---------------------------------------------------------------------
//Agregar un horario en la configuración de cartelera.
//---------------------------------------------------------------------
private void BtnAgregarHorario_Click(object sender, EventArgs e)
{
LbxHorariosPelicula.Items.Add(DtpHorarioPelicula.Value.ToString("hh:mm tt"));
}

//---------------------------------------------------------------------
//Remover un horario selecionado en la configuracion de cartelera.
//---------------------------------------------------------------------
private void BtnRemoverHorario_Click(object sender, EventArgs e)
{
LbxHorariosPelicula.Items.Remove(LbxHorariosPelicula.SelectedItem);
}

//---------------------------------------------------------------------
//Remover una película en la configuración de cartelera.
//---------------------------------------------------------------------
private void BtnRemoverPelicula_Click(object sender, EventArgs e)
{
if (indice > -1)
{
Peliculas.RemoveAt(indice);
indice = -1;
LimpiarFormulario();
ActualizarTabla();
DlgMenuPrincipal.MenuPrincipal.CargarCartelera();
}
else
{
MessageBox.Show("Seleccione una película.");
}
}

//---------------------------------------------------------------------
//Carga una imagen para la portada de la película.
//---------------------------------------------------------------------
private void BtnCargarImagen_Click(object sender, EventArgs e)
{
if (openFileDialog1.ShowDialog() == DialogResult.OK) 
{
PbxImagenPelicula.Load(openFileDialog1.FileName);
}
}

private void ActualizarTabla()
{ 
DgvPeliculas.DataSource = null;
DgvPeliculas.DataSource = Peliculas;
DgvPeliculas.Columns["Portada"].Visible = false;
DgvPeliculas.Columns["Sinopsis"].Visible = false;
DgvPeliculas.ClearSelection();
}

private void DgvPeliculas_DoubleClick(object sender, EventArgs e)
{
DataGridViewRow Seleccionada = DgvPeliculas.SelectedRows[0];
int pos = DgvPeliculas.Rows.IndexOf(Seleccionada);
CPelicula Pelicula = Peliculas[pos];
indice = pos;
TbxTituloPelicula.Text = Pelicula.Titulo;
NudDuracionPelicula.Value = Int16.Parse(Pelicula.Duracion);
CbxClasificacionPelicula.Text = Pelicula.Clasificacion;
CbxGeneroPelicula.Text = Pelicula.Genero;
RtbSinopsisPelicula.Text = Pelicula.Sinopsis;
LbxHorariosPelicula.Items.Clear();
PbxImagenPelicula.Image = Pelicula.Portada;
for(int i=0;i< Pelicula.Horarios.Count; i++)
{
LbxHorariosPelicula.Items.Add(Pelicula.Horarios[i]);
}
}

private void DlgConfigurarCartelera_Load(object sender, EventArgs e)
{
if (Peliculas.Count!=0)
{
ActualizarTabla();

}
}*/
    }
}
