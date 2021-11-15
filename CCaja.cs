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
        private double BoletoNiño;
        private double BoletoAdulto;
        private double Boleto3raEdad;


        //---------------------------------------------------------------------
        //Costructor.
        //---------------------------------------------------------------------
        public CCaja()
        {
            BoletoNiño = 57;
            BoletoAdulto = 75;
            Boleto3raEdad = 57;
        }

        public double GetBoletoNiño()
        {
            return BoletoNiño;
        }
        public double GetBoletoAdulto()
        {
            return BoletoAdulto;
        }

        public double GetBoleto3raEdad()
        {
            return Boleto3raEdad;
        }
    }
}
