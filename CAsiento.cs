using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa un asiento de cine.
    //NJSA. 23/11/2021.
    //---------------------------------------------------------------------
    public class CAsiento
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int NumAsiento;
        public bool Ocupado = false;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CAsiento(int NumAsiento)
        {
            this.NumAsiento = NumAsiento;
        }

        public void GuardarAsiento()
        {
            
            DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Add(NumAsiento);
            //DlgMenuPrincipal.MenuPrincipal.MiSala.Asientos[NumAsiento] = true;
            
        }

        public void BorrarAsiento()
        {
            if (DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Contains(NumAsiento))
            {
                int indice;
                indice = DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.IndexOf(NumAsiento);
                DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.RemoveAt(indice);
                //DlgMenuPrincipal.MenuPrincipal.MiSala.Asientos[NumAsiento] = false;
            }
            else
            {
                MessageBox.Show("El asiento no existe.");
            }
        }
        /* public void OcuparAsientos(List<int> AsientosSeleccionados)
        {
            for(int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                DlgMenuPrincipal.MenuPrincipal.MiSala.Asientos[AsientosSeleccionados[i]] = true;
            }
        }*/
        public int GetNumAsiento()
        {
            return NumAsiento;
        }

    }
}
