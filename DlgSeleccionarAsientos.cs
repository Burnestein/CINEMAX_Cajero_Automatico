using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Diálogo de la ventana seleccion de asientos.
    //NJSA. 13/11/2021.
    //---------------------------------------------------------------------
    public partial class DlgSeleccionarAsientos : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public static DlgSeleccionarAsientos SeleccionarAsientos;
        public int TotalAsientos;
        public List<int> AsientosSeleccionados;
        private int rows;
        private int cols;
        private TableLayoutPanel MiTabla;
        private CSala MiSala;
        private CPelicula Pelicula;
        private string Horario;
        private int indicePelicula;
        private int indiceFuncion;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgSeleccionarAsientos(int TotalAsientos, CSala MiSala, CPelicula Pelicula, string Horario)
        {
            InitializeComponent();
            SeleccionarAsientos = this;
            this.TotalAsientos = TotalAsientos;
            this.MiSala = MiSala;
            this.Pelicula = Pelicula;
            LblAsientosDisponibles.Text = "Seleccione " + this.TotalAsientos.ToString() + " asientos.";
            AsientosSeleccionados = new List<int>();
            rows = 8;
            cols = 12;
            MiTabla = new TableLayoutPanel();
            this.Horario = Horario;
            indicePelicula = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula);
            indiceFuncion = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[indicePelicula].MiSala.ObtenerIndiceFuncion(Horario,Pelicula.Titulo);
        }

        //---------------------------------------------------------------------
        //Crea una tabla y dibuja los asientos ocupados o desocupados.
        //---------------------------------------------------------------------
        private void DlgSeleccionarAsientos_Load(object sender, EventArgs e)
        {
            int NumeroAsiento = 0;
            MiTabla.Controls.Clear();
            MiTabla.Location = new System.Drawing.Point(0, 0);
            MiTabla.RowCount = rows;
            MiTabla.ColumnCount = cols;
            MiTabla.Dock = DockStyle.Fill;
            MiTabla.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            for(int i = 0; i < cols; i++)
            {
                MiTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.33333333F));
            }
            for (int i = 0; i < rows; i++)
            {
                MiTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    bool Ocupado = MiSala.Funciones[indiceFuncion].Asientos[NumeroAsiento];
                    PanelAsiento MiPanel = new PanelAsiento(NumeroAsiento, Ocupado);
                    MiTabla.Controls.Add(MiPanel, col, row);
                    NumeroAsiento++;
                }
            }
            PnlAsientos.Controls.Add(MiTabla);
        }

        //---------------------------------------------------------------------
        //Cierra el formulario.
        //---------------------------------------------------------------------
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //---------------------------------------------------------------------
        //Envia los asientos seleccionados a la funcion, de la sala, de la pelicula, cierra el formulario.
        //---------------------------------------------------------------------
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int indice = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula)].MiSala.ObtenerIndiceFuncion(Horario, Pelicula.Titulo);
            DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula)].MiSala.Funciones[indice].AsientosSeleccionados = AsientosSeleccionados;
            Close();
        }

        //---------------------------------------------------------------------
        //Muestra una lista con los asientos seleccionados.
        //---------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            string Lista="";
            for (int i = 0; i < AsientosSeleccionados.Count; i++)
            {
                Lista = Lista + AsientosSeleccionados[i] + "\n";
            }
            MessageBox.Show(Lista);
        }
    }
}
