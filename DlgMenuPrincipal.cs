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
        private TableLayoutPanel Mitabla;
        public List<CPelicula> ListaPeliculas;

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
            this.Mitabla = new TableLayoutPanel();
            ListaPeliculas = new List<CPelicula>();
            //ListaHorarios = new List<string>();
            Label Date = new Label();
            Date = LblCurrentTime;

        }
        
        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            CargarCartelera();
        }

        public void CargarPanelPelicula(CPelicula Pelicula)
        {
            PanelPeliculaGrande MiPanelGrande = new PanelPeliculaGrande(Pelicula);
            PnlCartelera.Controls.Clear();
            PnlCartelera.Controls.Add(MiPanelGrande);
            MiPanelGrande.Dock = DockStyle.Fill;
            //MessageBox.Show(ListaPeliculas.IndexOf(""));
        }
        public void CargarCartelera()
        {
            PnlCartelera.Controls.Clear();
            Mitabla.Controls.Clear();
            PnlCartelera.Controls.Add(Mitabla);
            Mitabla.Location = new System.Drawing.Point(0, 0);
            Mitabla.RowCount = 2;
            Mitabla.ColumnCount = 3;
            Mitabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            Mitabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            Mitabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            Mitabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Mitabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Mitabla.Dock = DockStyle.Fill;
            Mitabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            int n = 0;
            int rows;
            int cols;
            if (ListaPeliculas.Count <= 3)
            {
                rows = 1;
                cols = ListaPeliculas.Count;
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
                    //List<string> Lista = ListaPeliculas[n].ToList();
                    PanelPelicula MiPanel = new PanelPelicula(ListaPeliculas[n]);
                    //DlgConfigurarCartelera MiConfPeli = new DlgConfigurarCartelera;
                    //MiPanel.Titulo.Text = ListaPeliculas[n].Titulo;
                    //MiPanel.Clasificacion.Text = "Clasificación " + ListaPeliculas[n].Clasificacion;
                    //MiPanel.Duracion.Text = ListaPeliculas[n].Duracion + " Mins";
                    //MiPanel.Genero.Text = ListaPeliculas[n].Genero;
                    //MiPanel.Portada.Image = ListaPeliculas[n].Portada;
                    //MiPanel.Portada.Image = 
                    //MiPanel.Titulo.Text = Lista[0];
                    //MiPanel.Clasificacion.Text = "Clasificación " + Lista[1];
                    //MiPanel.Duracion.Text = Lista[2] + " Mins";
                    //MiPanel.Genero.Text = Lista[3];
                    /*int ConteoHorarios = ListaPeliculas[n].Horarios.Count;
                    for (int i = 0; i < ConteoHorarios; i++)
                    {
                        Label Hora = new Label();
                        Hora.Text = ListaPeliculas[n].Horarios[i];
                        MiPanel.Horarios.Controls.Add(Hora);
                    }*/
                    Mitabla.Controls.Add(MiPanel, col, row);
                    n++;
                }
                cols = ListaPeliculas.Count - 3;
            }
        }
        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;
            this.Text = "CINEMAX || Punto de venta automático";
            this.MstPrincipal.Visible = true;
            this.WindowState = FormWindowState.Normal;
            Size = new Size(1200, 800);
            CenterToScreen();
        }
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void DlgMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarCartelera();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblCurrentTime.Text = DateTime.Now.ToString("dddd dd/MMM/yyyy hh:mm tt");
        }
    }
}
