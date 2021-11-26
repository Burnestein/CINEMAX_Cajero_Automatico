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
        
        public List<CPelicula> ListaPeliculas;
        public List<CProducto> ListaProductos;
        private int indice=0;
        public CCanastaCompras Compras;
        public List<string> AsientosNoDisponibles;
        private DataTable TablaCortes;
        public decimal ContadorCompras;
        //public List<string> AsientosSeleccionados;
        public CCaja MiCaja;
        public CSala MiSala;
        public CSala Sala1;
        public CSala Sala2;
        public CSala Sala3;
        public CSala Sala4;
        public CSala Sala5;
        public CSala Sala6;


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
            ListaPeliculas = new List<CPelicula>();
            ListaProductos = new List<CProducto>();
            Label Date = new Label();
            Date = LblCurrentTime;
            Compras = new CCanastaCompras();
            AsientosNoDisponibles = new List<string>();
            TablaCortes = new DataTable();
            TablaCortes.Columns.Add("Fecha Apertura");
            TablaCortes.Columns.Add("Fecha Corte");
            TablaCortes.Columns.Add("Fondo inicial");
            TablaCortes.Columns.Add("Total Efectivo");
            TablaCortes.Columns.Add("Total Tarjeta");
            TablaCortes.Columns.Add("Monto Total");
            MiCaja = new CCaja();
            MiSala = new CSala();
            Sala1 = new CSala();
            Sala2 = new CSala();
            Sala3 = new CSala();
            Sala4 = new CSala();
            Sala5 = new CSala();
            Sala6 = new CSala();
        }
        
        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            indice = 0;
            CargarCartelera();
        }

        private void BtnFuenteSodas_Click(object sender, EventArgs e)
        {
            indice = 0;
            CargarFuenteSodas();
        }

        public void CargarPanelPelicula(CPelicula Pelicula)
        {
            PanelPeliculaGrande MiPanelGrande = new PanelPeliculaGrande(Pelicula);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanelGrande);
            MiPanelGrande.Dock = DockStyle.Fill;
        }

        public void CargarFuenteSodas()
        {
            TableLayoutPanel TablaFuenteSodas;
            TablaFuenteSodas = DibujarTabla(2, 3);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(TablaFuenteSodas);

            int n = 0;
            int rows;
            int cols;
            int ocultos=0;
            for(int i = 0; i < ListaProductos.Count; i++)
            {
                if (ListaProductos[i].Oculto)
                {
                    ocultos++;
                }
            }
            //MessageBox.Show("Hay " + ocultos + " en la lista de productos.");
            int Cantidad = ListaProductos.Count - indice - ocultos;
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
                        if (!(ListaProductos[n + indice].Oculto))
                        {
                            PanelProducto MiPanelProducto = new PanelProducto(ListaProductos[n + indice]);
                            TablaFuenteSodas.Controls.Add(MiPanelProducto, col, row);
                        }
                        else
                        {
                            col--;
                        }
                        n++;
                    }
                }
                cols = Cantidad - 3;
            }
            if (Cantidad > 6) PnlBtnDerecho.Visible = true;
            else PnlBtnDerecho.Visible = false;
            if (indice == 0) PnlBtnIzquierdo.Visible = false;
        }
        public void CargarCartelera()
        {

            TableLayoutPanel TablaCartelera;
            TablaCartelera = DibujarTabla(2, 3);
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
            MiTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            MiTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            MiTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            MiTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            MiTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            return MiTabla;
        }

        private void DlgMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            
            GenerarBoletos();
            CargarCartelera();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblCurrentTime.Text = DateTime.Now.ToString("dddd dd/MMM/yyyy hh:mm tt");
            if (Compras.Count() > 0)
            {
                LblContadorCompras.Visible = true;
                LblContadorCompras.Text = Compras.Count().ToString();
            }
            else
            {
                LblContadorCompras.Visible = false;
            }
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

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("Tienes " + Compras.Count() + " compras, y son:");
            string Mensaje = "";
            List<string> MiLista = Compras.ConvertirAListaProductos();
            for (int i = 0; i < Compras.Count(); i++)
            {
                Mensaje = Mensaje + MiLista[i] + "\n";
            }
            MessageBox.Show(Mensaje);*/
            string ListaCompras = Compras.ConvertirAListaString();
            PanelCanastaCompras MiPanel = new PanelCanastaCompras(ListaCompras);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanel);
            MiPanel.Dock = DockStyle.Fill;
            /*string mensaje = "";
            for(int i = 0; i < MiSala.AsientosSeleccionados.Count(); i++)
            {
                mensaje = mensaje + MiSala.AsientosSeleccionados[i].ToString() + ", ";
            }
            
            MessageBox.Show("Los asientos seleccionados son: " + mensaje);*/
        }

        private void GenerarBoletos()
        {
            CProducto BoletoNiño = new CProducto(1, "Boleto Niño", 50 , 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(BoletoNiño);
            CProducto BoletoAdulto = new CProducto(2, "Boleto Adulto", 75, 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(BoletoAdulto);
            CProducto Boleto3raEdad = new CProducto(3, "Boleto 3ra Edad", 55, 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(Boleto3raEdad);
        }

        private void realizarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarCaja configurarCaja;
            configurarCaja = new DlgConfigurarCaja(TablaCortes);
            configurarCaja.Show();
        }
        public void ActualizarTablaCortes(DataTable Tabla)
        {
            TablaCortes = Tabla;
        }
    }
}
