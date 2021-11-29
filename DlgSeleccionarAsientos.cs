using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class DlgSeleccionarAsientos : Form
    {
        public static DlgSeleccionarAsientos SeleccionarAsientos;
        public int TotalAsientos;
        private string[] ColumnasAsientos;
        public List<int> AsientosSeleccionados;
        private int rows;
        private int cols;
        private TableLayoutPanel MiTabla;
        private CSala MiSala;
        private CPelicula Pelicula;
        private string Horario;
        private int indicePelicula;
        private int indiceFuncion;
        //private bool ocupado;

        public DlgSeleccionarAsientos(int TotalAsientos, CSala MiSala, CPelicula Pelicula, string Horario)
        {
            InitializeComponent();
            SeleccionarAsientos = this;
            this.TotalAsientos = TotalAsientos;
            this.MiSala = MiSala;
            this.Pelicula = Pelicula;
            LblAsientosDisponibles.Text = "Seleccione " + this.TotalAsientos.ToString() + " asientos.";
            //ColumnasAsientos = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
            AsientosSeleccionados = new List<int>();
            rows = 8;
            cols = 12;
            MiTabla = new TableLayoutPanel();
            this.Horario = Horario;
            indicePelicula = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula);
            indiceFuncion = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[indicePelicula].MiSala.ObtenerIndiceFuncion(Horario,Pelicula.Titulo);
        }

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
            MessageBox.Show("El indice de la funcion es: "+indiceFuncion);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    /*for(int i = 0; i < DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula.Count(); i++)
                    {
                        MiSala.ObtenerSala(DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].Sala)
                    }*/
                    //bool Ocupado = MiSala.Asientos[NumeroAsiento];
                    bool Ocupado = MiSala.Funciones[indiceFuncion].Asientos[NumeroAsiento];
                    /*string mensaje = "";
                    if (Ocupado)
                    {
                        mensaje = "ocupado";
                    }
                    else
                    {
                        mensaje = "desocupado;";
                    }
                    MessageBox.Show("El asiento "+NumeroAsiento+" esta "+mensaje);*/
                    PanelAsiento MiPanel = new PanelAsiento(NumeroAsiento, Ocupado /*ColumnasAsientos[col] + (row+1)*/);
                    MiTabla.Controls.Add(MiPanel, col, row);

                    NumeroAsiento++;
                }
            }

            PnlAsientos.Controls.Add(MiTabla);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //DlgMenuPrincipal.MenuPrincipal.AsientosSeleccionados = AsientosSeleccionados;
            int indice = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula)].MiSala.ObtenerIndiceFuncion(Horario, Pelicula.Titulo);
            DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula)].MiSala.Funciones[indice].AsientosSeleccionados = AsientosSeleccionados;
            //DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula)].MiSala.AsientosSeleccionados = AsientosSeleccionados;
            MessageBox.Show("Mi sala X tiene asientos seleccionados: "+ AsientosSeleccionados.Count());
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lista="";
            for (int i = 0; i < AsientosSeleccionados.Count; i++)
            {
                Lista = Lista + AsientosSeleccionados[i] + "\n";
            }
            MessageBox.Show(Lista);
        }

        public List<int> GetAsientosSeleccionados()
        {
            return AsientosSeleccionados;
        }
    }
}
