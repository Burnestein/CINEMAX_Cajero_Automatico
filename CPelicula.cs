using System.Collections.Generic;

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



        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CPelicula(string Titulo, string Duracion, string Genero, string Clasificacion, string Sinopsis, List<string> Horarios)
        {
            this.Titulo = Titulo;
            this.Duracion = Duracion;
            this.Clasificacion = Clasificacion;
            this.Genero = Genero;
            this.Sinopsis = Sinopsis;
            this.Horarios = Horarios;

        }

        //---------------------------------------------------------------------
        //Retorna el objeto en forma de lista.
        //---------------------------------------------------------------------
        public List<string> ToList()
        {
            List<string> lista = new List<string>();
            lista.Add(Titulo);
            lista.Add(Duracion);
            lista.Add(Clasificacion);
            lista.Add(Genero);
            lista.Add(Sinopsis);
            return lista;
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
            /*string Tipo;
            switch (Clasificacion)
            {
                case 0:
                    Tipo = "AA";
                    break;
                case 1:
                    Tipo = "A";
                    break;
                default:
                    Tipo = "";
                    break;

            }
            return Tipo;*/
        }

        //---------------------------------------------------------------------
        //Obtiene la sinópsis de la pelicula.
        //---------------------------------------------------------------------
        public string GetSinopsis()
        {
            return Sinopsis;
        }
    }
}
