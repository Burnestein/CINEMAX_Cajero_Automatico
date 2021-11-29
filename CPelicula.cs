using System.Collections.Generic;
using System.Drawing;

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
        //Nota: Algunos atributos son utilizados para llenar los datos de la tabla de peliculas
        //en DlgConfigurarCartelera. get {return Titulo;} y set{name = Titulo} es igual a
        //Titulo { get; set; }
        //---------------------------------------------------------------------
        public string Titulo { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
        public string Genero { get; set; }
        public List<string> Horarios { get; set; }
        public string Sinopsis { get; set; }
        public Image Portada { get; set; }
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
            Image Portada,
            CSala MiSala
            )
        {
            this.Titulo = Titulo;
            this.Duracion = Duracion;
            this.Clasificacion = Clasificacion;
            this.Genero = Genero;
            this.Sinopsis = Sinopsis;
            this.Portada = Portada;
            this.MiSala = MiSala;
        }
    }
}
