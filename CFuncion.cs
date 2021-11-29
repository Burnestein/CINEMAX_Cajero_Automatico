using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public class CFuncion
    {
        public string Horario;
        public bool[] Asientos;
        public CPelicula Pelicula;
        public List<int> AsientosSeleccionados;
        public CFuncion(string Horario/*, bool[] Asientos*/, CPelicula Pelicula)
        {
            this.Horario = Horario;
            //this.Asientos = Asientos;
            this.Pelicula = Pelicula;
            AsientosSeleccionados = new List<int>();
            Asientos = new bool[96];
            for (int i = 0; i < 96; i++)
            {
                Asientos[i] = false;
            }
        }
        public void OcuparAsientos()
        {
            //MessageBox.Show("El asiento seleccionado es: " + AsientosSeleccionados[0].ToString());
            //MessageBox.Show("Asientos Seleccionados Count: " + AsientosSeleccionados.Count().ToString());
            //MessageBox.Show("...de la sala " );
            MessageBox.Show("OcuparAsientos()= " + AsientosSeleccionados.Count());
            for (int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                //MessageBox.Show("OcuparAsientos()= "+AsientosSeleccionados.Count());
                //MessageBox.Show("La funcion " + Funciones[j].Pelicula + " " + Funciones[j].Horario + " asiento " + Funciones[j].AsientosSeleccionados[i] + " tiene indice " + Funciones[j].AsientosSeleccionados[i]);
                Asientos[AsientosSeleccionados[i]] = true;
            }


        }
    }
}
