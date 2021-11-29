using System;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Control de usuario que agrega un asiento de cine.
    //NJSA. 13/11/2021.
    //---------------------------------------------------------------------
    public partial class PanelAsiento : UserControl
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private bool Toggle = false;
        private int NumAsiento;
        private CAsiento MiAsiento;
        private bool Ocupado = false;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public PanelAsiento(int NumAsiento, bool Ocupado)
        {
            InitializeComponent();
            this.NumAsiento = NumAsiento;
            this.Ocupado = Ocupado;
            MiAsiento = new CAsiento(NumAsiento);
            if (Ocupado)
            {
                PbxAsiento.Image = Properties.Resources.Cinema_red_chair;
            }
        }

        //---------------------------------------------------------------------
        //Cambia el estado de seleccion del asiento al hacer click sobre él.
        //---------------------------------------------------------------------
        private void PbxAsiento_Click(object sender, EventArgs e)
        {
            TogglePicture();
        }

        //---------------------------------------------------------------------
        //Cambia el estado de seleccion del asiento.
        //---------------------------------------------------------------------
        private void TogglePicture()
        {
            if (Toggle && Ocupado == false)
            {
                Toggle = false;
                PbxAsiento.Image = Properties.Resources.Cinema_gray_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos++;
                MiAsiento.BorrarAsiento();
            }
            else if(DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos > 0 && Ocupado == false)
            {
                Toggle = true;
                PbxAsiento.Image = Properties.Resources.Cinema_green_chair;
                DlgSeleccionarAsientos.SeleccionarAsientos.TotalAsientos--;
                MiAsiento.GuardarAsiento();
            }
        }
    }
}
