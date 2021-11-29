using System.Collections.Generic;
using System.Linq;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa una funcion de cine.
    //NJSA. 26/11/2021.
    //---------------------------------------------------------------------
    public class CFuncion
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public string Horario;
        public bool[] Asientos;
        public CPelicula Pelicula;
        public List<int> AsientosSeleccionados;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CFuncion(string Horario, CPelicula Pelicula)
        {
            this.Horario = Horario;
            this.Pelicula = Pelicula;
            AsientosSeleccionados = new List<int>();
            Asientos = new bool[96];
            for (int i = 0; i < 96; i++)
            {
                Asientos[i] = false;
            }
        }

        //---------------------------------------------------------------------
        //Marca los asientos que fueron seleccionados como ocupados en el arreglo de asientos.
        //---------------------------------------------------------------------
        public void OcuparAsientos()
        {
            for (int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                Asientos[AsientosSeleccionados[i]] = true;
            }
        }
    }
}
