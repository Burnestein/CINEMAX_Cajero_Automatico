using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa una pelicula en cartelera.
    //NJSA. 29/10/2021.
    //---------------------------------------------------------------------
    public class CPelicula
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public string Titulo { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }
        public List<string> Horarios { get; set; }
        public string Sinopsis { get; set; }
        public Image Portada { get; set; }
        private string HorarioSeleccionado;
        public CSala MiSala;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPelicula(
            string Titulo,
            string Duracion, 
            string Genero, 
            string Clasificacion, 
            string Sinopsis, 
            //List<string> Horarios, 
            Image Portada,
            CSala MiSala
            )
        {
            this.Titulo = Titulo;
            this.Duracion = Duracion;
            this.Clasificacion = Clasificacion;
            this.Genero = Genero;
            this.Sinopsis = Sinopsis;
            this.Horarios = Horarios;
            this.Portada = Portada;
            //this.Sala = Sala;
            this.MiSala = MiSala;
        }

        //---------------------------------------------------------------------
        //Retorna el objeto CPelicula en forma de lista.
        //---------------------------------------------------------------------
        public List<string> ToList()
        {
            List<string> lista = new List<string>();
            lista.Add(Titulo);
            lista.Add(Clasificacion);
            lista.Add(Duracion);
            lista.Add(Genero);
            lista.Add(Sinopsis);
            return lista;
        }

        public void AgregarHorario(string NuevoHorario)
        {
            if (Horarios.Contains(NuevoHorario))
            {
                MessageBox.Show("El horario ya existe en la pelicula.");
            }
            else
            {
                Horarios.Add(NuevoHorario);
            }
        }
        //---------------------------------------------------------------------
        //Obtiene el titulo de la Pelicula.
        //---------------------------------------------------------------------
        public string GetTitulo()
        {
            return Titulo;
        }

        //---------------------------------------------------------------------
        //Obtiene el género de la pelicula.
        //---------------------------------------------------------------------
        public string GetGenero()
        {
            return Genero;
        }

        //---------------------------------------------------------------------
        //Obtiene la clasificacion de la Pelicula.
        //---------------------------------------------------------------------
        public string GetClasificacion()
        {
            return Clasificacion;
        }

        //---------------------------------------------------------------------
        //Obtiene la sinópsis de la pelicula.
        //---------------------------------------------------------------------
        public string GetSinopsis()
        {
            return Sinopsis;
        }
        public string CambiarHorarioSeleccionado(string NuevoHorario)
        {
            HorarioSeleccionado = NuevoHorario;
            return HorarioSeleccionado;
        }
        public string GetHorarioSeleccionado()
        {
            return HorarioSeleccionado;
        }
    }
}
