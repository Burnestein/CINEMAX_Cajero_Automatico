using System;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Control de usuario que crea el panel de la canasta de compras en el menu principal.
    //NJSA. 20/11/2021.
    //---------------------------------------------------------------------
    public partial class PanelCanastaCompras : UserControl
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private string ListaCompras;
        private double TotalCompras;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public PanelCanastaCompras(string ListaCompras)
        {
            InitializeComponent();
            this.ListaCompras = ListaCompras;
            TotalCompras = DlgMenuPrincipal.MenuPrincipal.Compras.GetTotalCompras();
            LblTotal.Text = "Total $ " + TotalCompras.ToString();
        }

        //---------------------------------------------------------------------
        //Evento que inicia al cargar el control de usuario.
        //---------------------------------------------------------------------
        private void PanelCanastaCompras_Load(object sender, EventArgs e)
        {
            RtbListaCompras.Text = ListaCompras;
        }

        //---------------------------------------------------------------------
        //Visualiza la ventana de forma de pago.
        //---------------------------------------------------------------------
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if(ListaCompras != "")
            {
                PnlFormaPago.Visible = true;
            }
        }

        //---------------------------------------------------------------------
        //Efectúa el pago en forma de efectivo y se guarda la transacción.
        //---------------------------------------------------------------------
        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarEfectivo(TotalCompras);
            EfectuarPago();
        }

        //---------------------------------------------------------------------
        //Efectúa el pago en forma de tarjeta y se guarda la transacción.
        //---------------------------------------------------------------------
        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarTransaccionTarjeta(TotalCompras);
            EfectuarPago();
        }

        //---------------------------------------------------------------------
        //Asegura los asientos seleccionados como ocupados, agrega el monto al monto total de
        //compras, vacía la canasta de compras para la siguiente transacción.
        //---------------------------------------------------------------------
        private void EfectuarPago()
        {
            DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarAMontoTotal(TotalCompras);
            for(int i = 0; i < DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula.Count(); i++)
            {
                for (int j = 0; j < DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala.Funciones.Count(); j++)
                {
                    DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i].MiSala.Funciones[j].OcuparAsientos();
                    DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(DlgMenuPrincipal.MenuPrincipal.Compras.Pelicula[i])].MiSala.Funciones[j].AsientosSeleccionados.Clear();
                }
            }
            
            DlgMenuPrincipal.MenuPrincipal.Compras.VaciarCanasta();
            CambiarVisibilidad();
        }

        //---------------------------------------------------------------------
        //Cambia el panel dependiendo si ya pagó o no.
        //---------------------------------------------------------------------
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
                BtnBorrarCanasta.Visible = true;
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
                BtnBorrarCanasta.Visible = false;
            }
        }

        //---------------------------------------------------------------------
        //Actualiza el monto total de la etiqueta.
        //---------------------------------------------------------------------
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

        private void BtnBorrarCanasta_Click(object sender, EventArgs e)
        {
            DlgMenuPrincipal.MenuPrincipal.Compras.VaciarCanasta();
            RtbListaCompras.Clear();
            LblTotal.Text = "Total $0";
        }
    }
}
