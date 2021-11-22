using System;
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
        private string NumAsiento;
        public PanelAsiento(string NumAsiento)
        {
            InitializeComponent();
            this.NumAsiento = NumAsiento;
        }

        private void PbxAsiento_Click(object sender, EventArgs e)
        {
            TogglePicture();
        }

        private void TogglePicture()
        {
            if (Toggle)
            {
                Toggle = false;
                PbxAsiento.Image = Properties.Resources.Cinema_gray_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos++;
                BorrarAsiento();
            }
            else if(DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos > 0)
            {
                Toggle = true;
                PbxAsiento.Image = Properties.Resources.Cinema_green_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos--;
                GuardarAsiento();
            }
        }
        public string GetNumAsiento()
        {
            return NumAsiento;
        }
        public bool GetToggle()
        {
            return Toggle;
        }
        private void GuardarAsiento()
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
        private void BorrarAsiento()
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
    }
}
