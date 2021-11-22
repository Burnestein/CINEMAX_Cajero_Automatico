using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa una caja de cobro.
    //NJSA. 14/11/2021.
    //---------------------------------------------------------------------
    public class CCaja
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private double Fondo;
        private double TotalCaja;
        private int UnPeso;
        private int DosPesos;
        private int CincoPesos;
        private int DiezPesos;
        private int VeintePesos;
        private int CincuentaPesos;
        private int CienPesos;
        private int DoscientosPesos;

        //---------------------------------------------------------------------
        //Costructor.
        //---------------------------------------------------------------------
        public CCaja()
        {
            
        }
        public CCaja(double Fondo)
        {
            this.Fondo = Fondo;
            UnPeso = 0;
            DosPesos = 0;
            CincoPesos = 0;
            DiezPesos = 0;
            VeintePesos = 0;
            CincuentaPesos = 0;
            CienPesos = 0;
            DoscientosPesos = 0;

        }
        public double TotalUnPeso()
        {
            return UnPeso * 1;
        }
        public double TotalDosPesos()
        {
            return DosPesos * 2;
        }
        public double TotalCincoPesos()
        {
            return CincoPesos * 5;
        }
        public double TotalDiezPesos()
        {
            return DiezPesos * 10;
        }
        public double TotalVeintePesos()
        {
            return VeintePesos * 20;
        }
        public double TotalCincuentaPesos()
        {
            return CincuentaPesos * 50;
        }
        public double TotalCienPesos()
        {
            return CienPesos * 100;
        }
        public double TotalDoscientosPesos()
        {
            return DoscientosPesos * 200;
        }
        public double GetTotalCaja()
        {
            double Total;
            Total = TotalUnPeso() + TotalDosPesos() + TotalCincoPesos() + TotalDiezPesos() + TotalVeintePesos() + TotalCincuentaPesos() + TotalCienPesos() + TotalDoscientosPesos();
            Total += Fondo;
            return Total;
        }
    }
}
