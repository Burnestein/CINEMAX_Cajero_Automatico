using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa una sala de cine.
    //NJSA. 23/11/2021.
    //---------------------------------------------------------------------
    public class CSala
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public int NumSala;
        public string[] ColumnasAsientos;
        public bool[] Asientos;
        public List<int> AsientosSeleccionados;
        public List<int> AsientosOcupados;
        public List<string> HorariosOcupados;
        public List<CFuncion> Funciones;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CSala()
        {
            ColumnasAsientos = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
            Asientos = new bool[96];
            for(int i = 0; i < 96; i++)
            {
                Asientos[i] = false;
            }
            HorariosOcupados = new List<string>();
            AsientosSeleccionados = new List<int>();
            Funciones = new List<CFuncion>();
        }

        //---------------------------------------------------------------------
        //Agrega un horario a la lista de horarios ocupados de la sala.
        //---------------------------------------------------------------------
        public void AgregarHorariosOcupados(string Horario)
        {
            if (HorariosOcupados.Contains(Horario))
            {
                //MessageBox.Show("Este horario esta ocupado: " + Horario);
            }
            else
            {
                HorariosOcupados.Add(Horario);
            }
        }

        //---------------------------------------------------------------------
        //Agrega una nueva funcion a la sala de cine.
        //---------------------------------------------------------------------
        public void AgregarFuncion(string Horario, CPelicula Pelicula)
        {
            CFuncion MiFuncion = new CFuncion(Horario, Pelicula);
            Funciones.Add(MiFuncion);
        }

        //---------------------------------------------------------------------
        //Retorna el indice de la funcion de la sala que coincida en pelicula y horario indicado.
        //---------------------------------------------------------------------
        public int ObtenerIndiceFuncion(string Horario, string Pelicula)
        {
            int value = 0;
            for (int i = 0; i < Funciones.Count(); i++)
            {
                if(Funciones[i].Pelicula.Titulo==Pelicula && Funciones[i].Horario == Horario)
                {
                    value = i;
                }
            }
            return value;
        }
    }
}
