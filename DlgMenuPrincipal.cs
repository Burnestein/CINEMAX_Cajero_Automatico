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
    //---------------------------------------------------------------------
    //Diálogo principal del proyecto final.
    //NJSA. 08/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgMenuPrincipal : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public static DlgMenuPrincipal MenuPrincipal;
        //private TableLayoutPanel TablaCartelera;
        public List<CPelicula> ListaPeliculas;
        public List<CProducto> ListaProductos;
        private int indice=0;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgMenuPrincipal()
        {
            InitializeComponent();
            MenuPrincipal = this;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MstPrincipal.Visible = false;
            //this.TablaCartelera = new TableLayoutPanel();
            ListaPeliculas = new List<CPelicula>();
            Label Date = new Label();
            Date = LblCurrentTime;

        }
        
        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            CargarCartelera();
        }

        private void BtnFuenteSodas_Click(object sender, EventArgs e)
        {

        }

        public void CargarPanelPelicula(CPelicula Pelicula)
        {
            PanelPeliculaGrande MiPanelGrande = new PanelPeliculaGrande(Pelicula);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanelGrande);
            MiPanelGrande.Dock = DockStyle.Fill;
        }
        public void CargarCartelera()
        {
            TableLayoutPanel TablaCartelera;
            TablaCartelera = DibujarTabla(2, 3);
            TablaCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            TablaCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            TablaCartelera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            TablaCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            TablaCartelera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));

            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(TablaCartelera);
            
            int n = 0;
            int rows;
            int cols;
            int Cantidad = ListaPeliculas.Count-indice;
            if (Cantidad <= 3)
            {
                rows = 1;
                cols = Cantidad;
            }
            else
            {
                rows = 2;
                cols = 3;
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    
                    if (n < 6)
                    {
                        PanelPelicula MiPanel = new PanelPelicula(ListaPeliculas[n+indice]);
                        TablaCartelera.Controls.Add(MiPanel, col, row);
                        n++;
                    }
                }
                cols = Cantidad - 3;
            }
            if (Cantidad > 6) PnlBtnDerecho.Visible = true;
            else PnlBtnDerecho.Visible = false;

            if (indice == 0) PnlBtnIzquierdo.Visible = false;
        }
        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;
            this.Text = "CINEMAX || Punto de venta automático";
            this.MstPrincipal.Visible = true;
            this.WindowState = FormWindowState.Normal;
            Size = new Size(1200, 800);
            CenterToScreen();
            SspMenuPrincipal.Visible = true;
        }
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SspMenuPrincipal.Visible = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MstPrincipal.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarCartelera MenuCartelera;

            MenuCartelera = new DlgConfigurarCartelera();
            MenuCartelera.Show();
        }

        private TableLayoutPanel DibujarTabla(int Filas, int Columnas)
        {
            TableLayoutPanel MiTabla = new TableLayoutPanel();
            MiTabla.Controls.Clear();
            MiTabla.Location = new System.Drawing.Point(0, 0);
            MiTabla.RowCount = Filas;
            MiTabla.ColumnCount = Columnas;
            MiTabla.Dock = DockStyle.Fill;
            MiTabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            MiTabla.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            return MiTabla;
        }

        private void DlgMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarCartelera();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblCurrentTime.Text = DateTime.Now.ToString("dddd dd/MMM/yyyy hh:mm tt");
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarProductos ConfigProductos;

            ConfigProductos = new DlgConfigurarProductos();
            ConfigProductos.Show();
        }

        private void BtnDerecho_Click(object sender, EventArgs e)
        {
            if (indice < ListaPeliculas.Count)
            {
                indice += 6;
                PnlBtnIzquierdo.Visible = true;
                CargarCartelera();
            }
            
        }

        private void BtnIzquierdo_Click(object sender, EventArgs e)
        {
            indice -= 6;
            CargarCartelera();
        }
    }
}
