using System;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Control de usuario que visualiza la pelicula en cartelera en menu principal.
    //NJSA. 15/10/2021.
    //---------------------------------------------------------------------
    public partial class PanelPelicula : UserControl
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private CPelicula Pelicula;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public PanelPelicula(CPelicula Pelicula)
        {
            InitializeComponent();
            this.Pelicula = Pelicula;
            LblNombrePelicula.Text = Pelicula.Titulo;
            LblClasificacionPelicula.Text = "Clasificación " + Pelicula.Clasificacion;
            LblDuracionPelicula.Text = Pelicula.Duracion + " Mins";
            LblGenero.Text = Pelicula.Genero;
            PbxPelicula.Image = Pelicula.Portada;
            int ConteoHorarios = Pelicula.Horarios.Count();
            for (int i = 0; i < ConteoHorarios; i++)
            {
                LbxHorariosPelicula.Items.Add(Pelicula.Horarios[i]);
            }
        }

        //---------------------------------------------------------------------
        //Abre el panel grande de la pelicula al hacer click en la imagen.
        //---------------------------------------------------------------------
        private void PbxPelicula_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.CargarPanelPelicula(Pelicula);
        }
    }
}
