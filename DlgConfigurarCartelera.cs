using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class DlgConfigurarCartelera : Form
    {
        public static DlgConfigurarCartelera ConfigurarCartelera;
        private int indice=-1;
        private List<CPelicula> Peliculas;
        //private string filepath = "C:\\Users\\burn_\\Desktop\\Test.txt";

        public DlgConfigurarCartelera(List<CPelicula> Peliculas)
        {
            InitializeComponent();
            ConfigurarCartelera = this;
            this.Peliculas = Peliculas;
        }
        private void BtnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            indice = -1;
            LimpiarFormulario();
        }

        //---------------------------------------------------------------------
        //Agrega una tabla con los detalles de la película.
        //---------------------------------------------------------------------
        private void BtnGuardarPelicula_Click(object sender, EventArgs e)
        {
            //string Horarios = "";
            int ConteoHorarios = LbxHorariosPelicula.Items.Count;
            //string[] Horarios = new string[ConteoHorarios];
            List<string> HorarioPelicula = new List<string>();

            for (int i = 0; i < ConteoHorarios; i++)
            {
                //Horarios = Horarios+LbxHorariosPelicula.Items[i].ToString()+"\n";
                HorarioPelicula.Add(LbxHorariosPelicula.Items[i].ToString());
            }
            //int indice = DgvPeliculas.Rows.Add();
            CPelicula Pelicula = new CPelicula(//"Title","Duration","Gender","Clasif","Sinopsis","Schedule"
                TbxTituloPelicula.Text,
                NudDuracionPelicula.Text,
                CbxGeneroPelicula.Text,
                CbxClasificacionPelicula.Text,
                RtbSinopsisPelicula.Text,
                HorarioPelicula
                );

            if (indice > -1)
            {
                Peliculas[indice] = Pelicula;
                indice = -1;
            }
            else
            {
                Peliculas.Add(Pelicula);
            }
            //Peliculas.Add(Pelicula);
            //List<string> lista = Peliculas.ToList();
            //File.WriteAllLines(filepath, Peliculas);
            DlgMenuPrincipal.MenuPrincipal.ListaPeliculas = Peliculas;
            LimpiarFormulario();
            ActualizarTabla();
        }

        //---------------------------------------------------------------------
        //Borra la informacion escrita en el formulario.
        //---------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            TbxTituloPelicula.Text = "";
            NudDuracionPelicula.Value = 0;
            CbxGeneroPelicula.Text = "";
            CbxClasificacionPelicula.Text = "";
            LbxHorariosPelicula.Items.Clear();
            PbxImagenPelicula.Image = null;
            RtbSinopsisPelicula.Text = "";
        }

        //---------------------------------------------------------------------
        //Agregar un horario en la configuración de cartelera.
        //---------------------------------------------------------------------
        private void BtnAgregarHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Add(DtpHorarioPelicula.Value.TimeOfDay.ToString());
        }

        //---------------------------------------------------------------------
        //Remover un horario selecionado en la configuracion de cartelera.
        //---------------------------------------------------------------------
        private void BtnRemoverHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Remove(LbxHorariosPelicula.SelectedItem);
        }

        //---------------------------------------------------------------------
        //Remover una película en la configuración de cartelera.
        //---------------------------------------------------------------------
        private void BtnRemoverPelicula_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Peliculas.RemoveAt(indice);
                indice = -1;
                LimpiarFormulario();
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione una película.");
            }
        }

        //---------------------------------------------------------------------
        //Carga una imagen de la película.
        //---------------------------------------------------------------------
        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                PbxImagenPelicula.Load(openFileDialog1.FileName);
            }
        }

        private void ActualizarTabla()
        { 
                DgvPeliculas.DataSource = null;
                DgvPeliculas.DataSource = Peliculas;
                DgvPeliculas.ClearSelection();
        }

        private void DgvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Seleccionada = DgvPeliculas.SelectedRows[0];
            int pos = DgvPeliculas.Rows.IndexOf(Seleccionada);
            CPelicula Pelicula = Peliculas[pos];
            indice = pos;
            TbxTituloPelicula.Text = Pelicula.Titulo;
            NudDuracionPelicula.Value = Int16.Parse(Pelicula.Duracion);
            CbxClasificacionPelicula.Text = Pelicula.Clasificacion;
            CbxGeneroPelicula.Text = Pelicula.Genero;
            RtbSinopsisPelicula.Text = Pelicula.Sinopsis;
            LbxHorariosPelicula.Items.Clear();
            for(int i=0;i< Pelicula.Horarios.Count; i++)
            {
                LbxHorariosPelicula.Items.Add(Pelicula.Horarios[i]);
            }
        }

        private void DlgConfigurarCartelera_Load(object sender, EventArgs e)
        {
            if (Peliculas.Count!=0)
            {
                ActualizarTabla();
            }
        }
    }
}
