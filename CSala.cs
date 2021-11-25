using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string[] ColumnasAsientos;
        public bool[] Asientos;
        public List<int> AsientosSeleccionados;
        public List<string> AsientosOcupados;

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
        }
        public void OcuparAsientos()
        {
            for (int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                DlgMenuPrincipal.MenuPrincipal.MiSala.Asientos[AsientosSeleccionados[i]] = true;
            }
        }
    }
}
