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
    public partial class DlgConfigurarCaja : Form
    {
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
            Fondo = 0;
            TotalTransacciones = 0;
            CajaAbierta = false;
        }

        private void DlgConfigurarCaja_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            ActualizarTabla();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblFecha.Text = DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss tt");
            LblTotalMonedasCant.Text = TotalPesosMonedas().ToString();
            LblTotalBilletesCant.Text = TotalPesosBilletes().ToString();
            LblFondoTotalCant.Text = TotalFondoCaja().ToString();
        }

        private void BtnAperturaCaja_Click(object sender, EventArgs e)
        {
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
                TotalTransacciones += Fondo;
                LimpiarFormulario();
                TablaCortes.Rows.Add(LblFecha.Text, "Corte Pendiente", Fondo.ToString(), "Corte Pendiente");
                DlgMenuPrincipal.MenuPrincipal.ActualizarTablaCortes(TablaCortes);
                CajaAbierta = true;
                MessageBox.Show("Apertura Realizada.");
            }
            
        }
        private double TotalPesosMonedas()
        {
            double Total = 0;
            Total += (double)NudUnPeso.Value * 1;
            Total += (double)NudDosPesos.Value * 2;
            Total += (double)NudCincoPesos.Value * 5;
            Total += (double)NudDiezPesos.Value * 10;
            return Total;
        }
        private double TotalPesosBilletes()
        {
            double Total = 0;
            Total += (double)NudVeintePesos.Value * 20;
            Total += (double)NudCincuentaPesos.Value * 50;
            Total += (double)NudCienPesos.Value * 100;
            Total += (double)NudDoscientosPesos.Value * 200;
            return Total;
        }
        private double TotalFondoCaja()
        {
            return TotalPesosMonedas() + TotalPesosBilletes();
        }
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
        private void ActualizarTabla()
        {
            DgvCortesRecientes.DataSource = null;
            DgvCortesRecientes.DataSource = TablaCortes;
            DgvCortesRecientes.ClearSelection();
        }
        public void AgregarTransaccion(double NuevaTransaccion)
        {
            TotalTransacciones += NuevaTransaccion;
        }

        private void BtnCorteCaja_Click(object sender, EventArgs e)
        {
            if (CajaAbierta)
            {
                indice = DgvCortesRecientes.FirstDisplayedScrollingRowIndex;
                DgvCortesRecientes.Rows[indice].Cells[1].Value = LblFecha.Text;
                DgvCortesRecientes.Rows[indice].Cells[3].Value = TotalTransacciones.ToString();
                CajaAbierta = false;
                indice = -1;
                TotalTransacciones = 0;
                Fondo = 0;
                DgvCortesRecientes.Sort(DgvCortesRecientes.Columns[0], ListSortDirection.Descending);
                MessageBox.Show("Corte Realizado con éxito.");
            }
            else
            {
                MessageBox.Show("Debe aperturar la caja primero.");
            }
        }
    }
}
