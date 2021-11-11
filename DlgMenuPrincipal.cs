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
            //ListaPeliculas = null;
        }
        
        private void BtnCartelera_Click(object sender, EventArgs e)
        {
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
            Mitabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //List<string> Lista=ListaPeliculas[0].ToList();
            //MessageBox.Show(Lista[0]);
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
            for(int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    List<string> Lista = ListaPeliculas[n].ToList();
                    PanelPelicula MiPanel = new PanelPelicula();
                    //CPelicula[] arreglo = ListaPeliculas.ToArray();
                    MiPanel.Lbl.Text = Lista[0];
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

            MenuCartelera = new DlgConfigurarCartelera(ListaPeliculas);
            MenuCartelera.Show();
            //DlgConfigurarCartelera Miobjeto = new DlgConfigurarCartelera();
            //ListaPeliculas = Miobjeto.ValorLIsta();
            //MessageBox.Show(ListaPeliculas[0].ToString());
        }
    }
}
