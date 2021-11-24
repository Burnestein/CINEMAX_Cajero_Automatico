﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class PanelAsiento : UserControl
    {
        private bool Toggle = false;
        private int NumAsiento;
        private CAsiento MiAsiento;
        //private bool Ocupado = false;
        public PanelAsiento(int NumAsiento)
        {
            InitializeComponent();
            this.NumAsiento = NumAsiento;
            MiAsiento = new CAsiento(this.NumAsiento);
        }

        private void PbxAsiento_Click(object sender, EventArgs e)
        {
            TogglePicture();
        }

        private void TogglePicture()
        {
            if (Toggle && MiAsiento.Ocupado==false)
            {
                Toggle = false;
                PbxAsiento.Image = Properties.Resources.Cinema_gray_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos++;
                MiAsiento.BorrarAsiento();
            }
            else if(DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos > 0 && MiAsiento.Ocupado == false)
            {
                Toggle = true;
                PbxAsiento.Image = Properties.Resources.Cinema_green_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos--;
                MiAsiento.GuardarAsiento();
            }
        }

        public bool GetToggle()
        {
            return Toggle;
        }

    }
}