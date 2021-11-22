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
    public partial class DlgSeleccionarAsientos : Form
    {
        public static DlgSeleccionarAsientos SeleccionarAsientos;
        public int TotalAsientos;
        private string[] ColumnasAsientos;
        public List<string> AsientosSeleccionados;
        private int rows;
        private int cols;
        private TableLayoutPanel MiTabla;

        public DlgSeleccionarAsientos(int TotalAsientos)
        {
            InitializeComponent();
            SeleccionarAsientos = this;
            this.TotalAsientos = TotalAsientos;
            LblAsientosDisponibles.Text = "Seleccione " + this.TotalAsientos.ToString() + "asientos.";
            ColumnasAsientos = new string[] { "A", "B","C","D","E","F","G","H","I","J","K","L" };
            AsientosSeleccionados = new List<string>();
            rows = 8;
            cols = 12;
            MiTabla = new TableLayoutPanel();
        }

        private void DlgSeleccionarAsientos_Load(object sender, EventArgs e)
        {
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
                    PanelAsiento MiPanel = new PanelAsiento(ColumnasAsientos[col] + (row+1));
                    MiTabla.Controls.Add(MiPanel, col, row);
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
            PanelPeliculaGrande MiPanelGrande = new PanelPeliculaGrande();
            MiPanelGrande.ExtraerAsientosSeleccionados();
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

        public List<string> GetAsientosSeleccionados()
        {
            return AsientosSeleccionados;
        }
    }
}
