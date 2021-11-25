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
    public partial class PanelCanastaCompras : UserControl
    {
        private string ListaCompras;
        private double TotalCompras;
        
        public PanelCanastaCompras(string ListaCompras)
        {
            InitializeComponent();
            this.ListaCompras = ListaCompras;
            TotalCompras = DlgMenuPrincipal.MenuPrincipal.Compras.GetTotalCompras();
            LblTotal.Text = "Total $ " + TotalCompras.ToString();
        }

        private void PanelCanastaCompras_Load(object sender, EventArgs e)
        {
            RtbListaCompras.Text = ListaCompras;

        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if(ListaCompras != "")
            {
                PnlFormaPago.Visible = true;
            }
        }

        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarEfectivo(TotalCompras);
            EfectuarPago();
        }
        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarTransaccionTarjeta(TotalCompras);
            EfectuarPago();
        }
        private void EfectuarPago()
        {   
            
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarAMontoTotal(TotalCompras);
            DlgMenuPrincipal.MenuPrincipal.MiSala.OcuparAsientos();
            DlgMenuPrincipal.MenuPrincipal.Compras.VaciarCanasta();
            DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados.Clear();
            CambiarVisibilidad();
            string mensaje = "";
            for(int i = 0; i<DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados.Count(); i++)
            {
                mensaje = mensaje + DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados[i]+", ";
            }
            //MessageBox.Show("Los Asientos Seleccionados son: " + mensaje);
            //MessageBox.Show("El total de compras fue: " + MiCanasta.GetTotalCompras().ToString());
        }
        private void CambiarVisibilidad()
        {
            if (LblTuCanasta.Visible)
            {
                LblTuCanasta.Visible = false;
                LblGracias.Visible = true;
                LblDisfrute.Visible = true;
                LblTotal.Visible = false;
                PnlFormaPago.Visible = false;
                BtnPagar.Visible = false;
                RtbListaCompras.Visible = false;
            }
            else
            {
                LblTuCanasta.Visible = true;
                LblGracias.Visible = false;
                LblDisfrute.Visible = false;
                LblTotal.Visible = true;
                PnlFormaPago.Visible = true;
                BtnPagar.Visible = true;
                RtbListaCompras.Visible = true;
            }
            
        }
    }
}
