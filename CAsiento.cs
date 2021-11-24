﻿using System;
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
            if (DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Contains(NumAsiento))
            {
                MessageBox.Show("El Asiento ya está guardado.");
            }
            else
            {
                DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Add(NumAsiento);
            }
        }

        public void BorrarAsiento()
        {
            if (DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Contains(NumAsiento))
            {
                int indice;
                indice = DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.IndexOf(NumAsiento);
                DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("El asiento no existe.");
            }
        }

        public int GetNumAsiento()
        {
            return NumAsiento;
        }

    }
}