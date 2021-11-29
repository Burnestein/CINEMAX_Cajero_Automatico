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
            //CSala MiSala = new CSala();
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarAMontoTotal(TotalCompras);
            MessageBox.Show("DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula.Count()="+ DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula.Count().ToString());
            for(int i = 0; i < DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula.Count(); i++)
            {
                MessageBox.Show("La sala a ocupar asientos es "+ DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala);
                //DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala.OcuparAsientos();
                for (int j = 0; j < DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala.Funciones.Count(); j++)
                {
                    DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala.Funciones[j].OcuparAsientos();
                    DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i])].MiSala.Funciones[j].AsientosSeleccionados.Clear();
                }
                //DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i])].MiSala.AsientosSeleccionados.Clear();
                //DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados.Clear();
            }
            
            DlgMenuPrincipal.MenuPrincipal.Compras.VaciarCanasta();
            
            CambiarVisibilidad();
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

        private void LblTotal_TextChanged(object sender, EventArgs e)
        {
            if (TotalCompras > 0)
            {
                BtnPagar.Visible = true;
            }
            else
            {
                BtnPagar.Visible = false;
            }
            
        }
    }
}
