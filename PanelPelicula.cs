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
    public partial class PanelPelicula : UserControl
    {

        public Label Titulo;
        public Label Clasificacion;
        public Label Duracion;
        public Label Genero;
        public TableLayoutPanel Horarios;
        public PictureBox Portada;
        private CPelicula Pelicula;
        public PanelPelicula(CPelicula Pelicula)
        {
            InitializeComponent();
            this.Pelicula = Pelicula;

            LblNombrePelicula.Text = Pelicula.Titulo;
            LblClasificacionPelicula.Text = "Clasificación " + Pelicula.Clasificacion;
            LblDuracionPelicula.Text = Pelicula.Duracion + " Mins";
            LblGenero.Text = Pelicula.Genero;
            PbxPelicula.Image = Pelicula.Portada;
            int ConteoHorarios = Pelicula.Horarios.Count;
            for (int i = 0; i < ConteoHorarios; i++)
            {
                Label Hora = new Label();
                Hora.Text = Pelicula.Horarios[i];
                TlpHorariosPelicula.Controls.Add(Hora);
            }
            
        }

        private void PbxPelicula_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.CargarPanelPelicula(Pelicula);
        }

        private void PbxPelicula_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
