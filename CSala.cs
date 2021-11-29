using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //public List<string> AsientosOcupados;
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
        public void OcuparAsientos()
        {
            //MessageBox.Show("El asiento seleccionado es: " + AsientosSeleccionados[0].ToString());
            MessageBox.Show("Asientos Seleccionados Count: "+AsientosSeleccionados.Count().ToString());
            //MessageBox.Show("...de la sala " );
            for(int j = 0; j < Funciones.Count(); j++)
            {
                for (int i = 0; i < Funciones[j].AsientosSeleccionados.Count(); i++)
                {
                    MessageBox.Show("La funcion " + Funciones[j].Pelicula + " " + Funciones[j].Horario + " asiento " + Funciones[j].AsientosSeleccionados[i] + " tiene indice " + Funciones[j].AsientosSeleccionados[i]);
                    Funciones[j].Asientos[Funciones[j].AsientosSeleccionados[i]] = true;
                }
            }
            
        }
        public CSala ObtenerSala(int NumSala)
        {
            CSala MiSala = new CSala();
            switch (NumSala)
            {
                case 1:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala1;
                    break;
                case 2:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala2;
                    break;
                case 3:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala3;
                    break;
                case 4:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala4;
                    break;
                case 5:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala5;
                    break;
                case 6:
                    MiSala = DlgMenuPrincipal.MenuPrincipal.Sala6;
                    break;
                default:
                    break;
            }
            return MiSala;
        }
        public void AgregarHorariosOcupados(string Horario)
        {
            if (HorariosOcupados.Contains(Horario))
            {
                MessageBox.Show("Este horario esta ocupado: " + Horario);
            }
            else
            {
                HorariosOcupados.Add(Horario);
            }
        }
        public void AgregarFuncion(string Horario, CPelicula Pelicula)
        {
            CFuncion MiFuncion = new CFuncion(Horario/*, Asientos*/, Pelicula);
            Funciones.Add(MiFuncion);
            
        }
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
