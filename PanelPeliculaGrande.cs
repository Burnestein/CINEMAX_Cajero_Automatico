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
    public partial class PanelPeliculaGrande : UserControl
    {
        private CPelicula Pelicula;
        public PanelPeliculaGrande()
        {
            InitializeComponent();
        }
        public PanelPeliculaGrande(CPelicula Pelicula)
        {
            InitializeComponent();
            this.Pelicula = Pelicula;
            PbxPortadaGrande.Image = Pelicula.Portada;
            LblNombrePelicula.Text = Pelicula.Titulo;
            LblClasificacionPelicula.Text = "Clasificación " + Pelicula.Clasificacion;
            LblDuracionPelicula.Text = Pelicula.Duracion + " Minutos";
            LblGenero.Text = Pelicula.Genero;
            LblContSinopsis.Text = Pelicula.Sinopsis;
            for(int i = 0; i < Pelicula.Horarios.Count; i++)
            {
                CbxHorarios.Items.Add(Pelicula.Horarios[i]);
            }
        }

        private void PanelPeliculaGrande_Load(object sender, EventArgs e)
        {

        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {

        }

        private void CbxHorarios_SelectedValueChanged(object sender, EventArgs e)
        {
            if(CbxHorarios.SelectedIndex > 0)
            {
                
                BtnComprar.Enabled = true;
                BtnComprar.BackColor = Color.Khaki;
                BtnComprar.FlatAppearance.BorderColor = Color.Gold;
            }
            else
            {
                BtnComprar.Enabled = false;
                BtnComprar.BackColor = Color.DarkGray;
                BtnComprar.FlatAppearance.BorderColor = Color.DimGray;
            }
        }
    }
}
