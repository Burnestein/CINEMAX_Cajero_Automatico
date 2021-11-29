using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Diálogo de la pestaña configuración de caja.
    //NJSA. 19/11/2021.
    //---------------------------------------------------------------------
    public partial class DlgConfigurarCaja : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public static DlgConfigurarCaja ConfigurarCaja;
        private decimal UnPeso;
        private decimal DosPesos;
        private decimal CincoPesos;
        private decimal DiezPesos;
        private decimal VeintePesos;
        private decimal CincuentaPesos;
        private decimal CienPesos;
        private decimal DoscientosPesos;
        private double Fondo;
        private double TotalTransacciones;
        private int indice = -1;
        private DataTable TablaCortes;
        private bool CajaAbierta;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgConfigurarCaja(DataTable TablaCortes)
        {
            InitializeComponent();
            ConfigurarCaja = this;
            this.TablaCortes = TablaCortes;
            UnPeso = NudUnPeso.Value;
            DosPesos = NudDosPesos.Value;
            CincoPesos = NudCincoPesos.Value;
            DiezPesos = NudDiezPesos.Value;
            VeintePesos = NudVeintePesos.Value;
            CincuentaPesos = NudCincuentaPesos.Value;
            CienPesos = NudCienPesos.Value;
            DoscientosPesos = NudDoscientosPesos.Value;
            Fondo = DlgMenuPrincipal.MenuPrincipal.MiCaja.GetFondo();
            TotalTransacciones = DlgMenuPrincipal.MenuPrincipal.MiCaja.GetTotalTransacciones();
            bool CajaAbierta = DlgMenuPrincipal.MenuPrincipal.MiCaja.CajaAbierta;
        }

        //---------------------------------------------------------------------
        //Evento que se inicia al cargar el formulario.
        //---------------------------------------------------------------------
        private void DlgConfigurarCaja_Load(object sender, EventArgs e)
        {
            timer1.Start(); //inicia contador

            ActualizarTabla();
        }

        //---------------------------------------------------------------------
        //Evento que se inicia a cada ciclo del reloj (100ms).
        //---------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            LblTotalMonedasCant.Text = TotalPesosMonedas().ToString();
            LblTotalBilletesCant.Text = TotalPesosBilletes().ToString();
            LblFondoTotalCant.Text = TotalFondoCaja().ToString();
            CajaAbierta = DlgMenuPrincipal.MenuPrincipal.MiCaja.CajaAbierta;
            TotalTransacciones = DlgMenuPrincipal.MenuPrincipal.MiCaja.GetTotalTransacciones();
        }

        //---------------------------------------------------------------------
        //Método que apertura la caja.
        //---------------------------------------------------------------------
        private void BtnAperturaCaja_Click(object sender, EventArgs e)
        {
            bool CajaAbierta = DlgMenuPrincipal.MenuPrincipal.MiCaja.CajaAbierta;
            if (CajaAbierta)
            {
                MessageBox.Show("Debe realizar el corte antes de aperturar caja.");
            }
            else
            {
                UnPeso = NudUnPeso.Value;
                DosPesos = NudDosPesos.Value;
                CincoPesos = NudCincoPesos.Value;
                DiezPesos = NudDiezPesos.Value;
                VeintePesos = NudVeintePesos.Value;
                CincuentaPesos = NudCincuentaPesos.Value;
                CienPesos = NudCienPesos.Value;
                DoscientosPesos = NudDoscientosPesos.Value;
                Fondo = TotalFondoCaja();
                DlgMenuPrincipal.MenuPrincipal.MiCaja.NuevoFondo(Fondo);
                DlgMenuPrincipal.MenuPrincipal.MiCaja.AgregarAMontoTotal(Fondo);
                LimpiarFormulario();
                TablaCortes.Rows.Add(LblFecha.Text, "Corte Pendiente", Fondo.ToString(), "Corte Pendiente", "Corte Pendiente", "Corte Pendiente");
                DlgMenuPrincipal.MenuPrincipal.ActualizarTablaCortes(TablaCortes);
                DlgMenuPrincipal.MenuPrincipal.MiCaja.CajaAbierta = true;
                MessageBox.Show("Apertura Realizada.");
            }
            
        }

        //---------------------------------------------------------------------
        //Obtiene el total en monedas..
        //---------------------------------------------------------------------
        private double TotalPesosMonedas()
        {
            double Total = 0;
            Total += (double)NudUnPeso.Value * 1;
            Total += (double)NudDosPesos.Value * 2;
            Total += (double)NudCincoPesos.Value * 5;
            Total += (double)NudDiezPesos.Value * 10;
            return Total;
        }

        //---------------------------------------------------------------------
        //Obtiene el total en Billetes.
        //---------------------------------------------------------------------
        private double TotalPesosBilletes()
        {
            double Total = 0;
            Total += (double)NudVeintePesos.Value * 20;
            Total += (double)NudCincuentaPesos.Value * 50;
            Total += (double)NudCienPesos.Value * 100;
            Total += (double)NudDoscientosPesos.Value * 200;
            return Total;
        }

        //---------------------------------------------------------------------
        //Obtiene la cantidad total del fondo de caja.
        //---------------------------------------------------------------------
        private double TotalFondoCaja()
        {
            return TotalPesosMonedas() + TotalPesosBilletes();
        }

        //---------------------------------------------------------------------
        //Limpia el formulario.
        //---------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            NudUnPeso.Value = 0;
            NudDosPesos.Value = 0;
            NudCincoPesos.Value = 0;
            NudDiezPesos.Value = 0;
            NudVeintePesos.Value = 0;
            NudCincuentaPesos.Value = 0;
            NudCienPesos.Value = 0;
            NudDoscientosPesos.Value = 0;
        }

        //---------------------------------------------------------------------
        //Actualiza la tabla de cortes.
        //---------------------------------------------------------------------
        private void ActualizarTabla()
        {
            DgvCortesRecientes.DataSource = null;
            DgvCortesRecientes.DataSource = TablaCortes;
            DgvCortesRecientes.ClearSelection();
        }

        //---------------------------------------------------------------------
        //Realiza el corte de la caja.
        //---------------------------------------------------------------------
        private void BtnCorteCaja_Click(object sender, EventArgs e)
        {
            double TotalEfectivo = DlgMenuPrincipal.MenuPrincipal.MiCaja.GetTotalEfectivo();
            double TotalTarjeta = DlgMenuPrincipal.MenuPrincipal.MiCaja.GetTotalTarjeta();

            if (CajaAbierta) 
            {
                indice = DgvCortesRecientes.FirstDisplayedScrollingRowIndex;
                DgvCortesRecientes.Rows[indice].Cells[1].Value = LblFecha.Text;
                DgvCortesRecientes.Rows[indice].Cells[3].Value = TotalEfectivo.ToString();
                DgvCortesRecientes.Rows[indice].Cells[4].Value = TotalTarjeta.ToString();
                DgvCortesRecientes.Rows[indice].Cells[5].Value = TotalTransacciones.ToString();
                
                indice = -1;
                TotalTransacciones = 0;
                Fondo = 0;
                DgvCortesRecientes.Sort(DgvCortesRecientes.Columns[0], ListSortDirection.Descending);
                DlgMenuPrincipal.MenuPrincipal.MiCaja.CajaAbierta = false;
                DlgMenuPrincipal.MenuPrincipal.MiCaja.VaciarCaja();
                MessageBox.Show("Corte Realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Debe aperturar la caja primero.");
            }
        }
    }
}
