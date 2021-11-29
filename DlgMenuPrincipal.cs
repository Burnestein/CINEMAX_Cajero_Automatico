using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        public static DlgMenuPrincipal MenuPrincipal; //esta instancia estática es accesible para todas las demás.
        public List<CPelicula> ListaPeliculas;
        public List<CProducto> ListaProductos;
        private int indice=0; //indice para el cambio de pestañas de la cartelera
        public CCanastaCompras Compras;
        private DataTable TablaCortes;
        public decimal ContadorCompras;
        public CCaja MiCaja;
        public List<CSala> ListaSalas;
        public CSala MiSala;

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
            TablaCortes = new DataTable();
            TablaCortes.Columns.Add("Fecha Apertura");
            TablaCortes.Columns.Add("Fecha Corte");
            TablaCortes.Columns.Add("Fondo inicial");
            TablaCortes.Columns.Add("Total Efectivo");
            TablaCortes.Columns.Add("Total Tarjeta");
            TablaCortes.Columns.Add("Monto Total");
            MiCaja = new CCaja();
            ListaSalas = new List<CSala>();
        }

        //---------------------------------------------------------------------
        //Carga la cartelera y regresa la pesataña al inicio.
        //---------------------------------------------------------------------
        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            indice = 0;
            CargarCartelera();
        }

        //---------------------------------------------------------------------
        //Carga la fuente de sodas y regresa la pestaña al inicio.
        //---------------------------------------------------------------------
        private void BtnFuenteSodas_Click(object sender, EventArgs e)
        {
            indice = 0; //NOTA: Este indice cambia la pestaña  de la cartelera, hay que hacer otro para productos.
            CargarFuenteSodas();
        }

        //---------------------------------------------------------------------
        //Carga el panel Pelicula Grande.
        //---------------------------------------------------------------------
        public void CargarPanelPelicula(CPelicula Pelicula)
        {
            PanelPeliculaGrande MiPanelGrande = new PanelPeliculaGrande(Pelicula);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanelGrande);
            MiPanelGrande.Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------
        //Dibuja una tabla para la fuente de sodas y agrega todas las instancias de los productos.
        //---------------------------------------------------------------------
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
            if (Cantidad > 6) PnlBtnDerecho.Visible = true; // Este boton sigue siendo de la cartelera debe tener uno para productos
            else PnlBtnDerecho.Visible = false;
            if (indice == 0) PnlBtnIzquierdo.Visible = false;
        }

        //---------------------------------------------------------------------
        //Dibuja una tabla para la cartelera y agrega todas las instancias de las peliculas.
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        //Simula un login de usuario.
        //---------------------------------------------------------------------
        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            PnlLogin.Visible = true;
        }

        //---------------------------------------------------------------------
        //Oculta el simulador de login.
        //---------------------------------------------------------------------
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PnlLogin.Visible = false;
        }

        //---------------------------------------------------------------------
        //Maximiza la pantalla a modo terminal.
        //---------------------------------------------------------------------
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnConfiguracion.Enabled = true;
            SspMenuPrincipal.Visible = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MstPrincipal.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        //---------------------------------------------------------------------
        //Abre el formulario DlgConfigurarCartelera.
        //---------------------------------------------------------------------
        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarCartelera MenuCartelera;

            MenuCartelera = new DlgConfigurarCartelera();
            MenuCartelera.Show();
        }

        //---------------------------------------------------------------------
        //Dibuja una tabla.
        //---------------------------------------------------------------------
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

        //---------------------------------------------------------------------
        //Evento que inicia al abrir el formulario.
        //---------------------------------------------------------------------
        private void DlgMenuPrincipal_Load(object sender, EventArgs e)
        {
            GenerarBoletos(); //Genera los productos de tipo boleto por defecto
            CargarCartelera();
            timer.Start();
        }

        //---------------------------------------------------------------------
        //Evento que se inicia a cada ciclo del reloj (1000ms).
        //---------------------------------------------------------------------
        private void timer_Tick(object sender, EventArgs e)
        {
            LblCurrentTime.Text = "Fecha, "+DateTime.Now.ToString("dddd dd/MMMM/yyyy hh:mm tt");
            if (Compras.Count() > 0)
            {
                LblContadorCompras.Visible = true;
                LblContadorCompras.Text = Compras.Count().ToString(); //Actualiza el indicador en el boton Compras
            }
            else
            {
                LblContadorCompras.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        //Abre el formulario DlgCOnfigurarProductos.
        //---------------------------------------------------------------------
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarProductos ConfigProductos;

            ConfigProductos = new DlgConfigurarProductos();
            ConfigProductos.Show();
        }

        //---------------------------------------------------------------------
        //Cambia la pestaña de la cartelera a las siguientes 6 peliculas.
        //---------------------------------------------------------------------
        private void BtnDerecho_Click(object sender, EventArgs e)
        {
            if (indice < ListaPeliculas.Count)
            {
                indice += 6;
                PnlBtnIzquierdo.Visible = true;
                CargarCartelera();
            }
        }

        //---------------------------------------------------------------------
        //Cambia la pestaña de la cartelera a las 6 peliculas anteriores.
        //---------------------------------------------------------------------
        private void BtnIzquierdo_Click(object sender, EventArgs e)
        {
            indice -= 6;
            CargarCartelera();
        }

        //---------------------------------------------------------------------
        //Carga el Panel de compras realizadas.
        //---------------------------------------------------------------------
        private void BtnCompras_Click(object sender, EventArgs e)
        {
            string ListaCompras = Compras.ConvertirAListaString();
            PanelCanastaCompras MiPanel = new PanelCanastaCompras(ListaCompras);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanel);
            MiPanel.Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------
        //Genera las instancias de los productos de tipo boleto, el producto principal.
        //---------------------------------------------------------------------
        private void GenerarBoletos()
        {
            CProducto BoletoNiño = new CProducto(1, "Boleto Niño", 50 , 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(BoletoNiño);
            CProducto BoletoAdulto = new CProducto(2, "Boleto Adulto", 75, 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(BoletoAdulto);
            CProducto Boleto3raEdad = new CProducto(3, "Boleto 3ra Edad", 55, 999, Properties.Resources.CinemaxWhite_Logo, true);
            ListaProductos.Add(Boleto3raEdad);
        }

        //---------------------------------------------------------------------
        //Abre el formulario DlgConfigurarCaja.
        //---------------------------------------------------------------------
        private void realizarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgConfigurarCaja configurarCaja;
            configurarCaja = new DlgConfigurarCaja(TablaCortes);
            configurarCaja.Show();
        }

        //---------------------------------------------------------------------
        //Actualiza la tabla de cortes realizados.
        //---------------------------------------------------------------------
        public void ActualizarTablaCortes(DataTable Tabla)
        {
            TablaCortes = Tabla;
        }

        //---------------------------------------------------------------------
        //Cambia el estado de la ventana y muestra la barra de herramientas.
        //---------------------------------------------------------------------
        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            BtnConfiguracion.Enabled = false;
            PnlLogin.Visible = false;
            this.ControlBox = true;
            this.Text = "CINEMAX || Punto de venta automático";
            this.MstPrincipal.Visible = true;
            this.WindowState = FormWindowState.Normal;
            Size = new Size(1200, 800);
            CenterToScreen();
            SspMenuPrincipal.Visible = true;
        }
    }
}
