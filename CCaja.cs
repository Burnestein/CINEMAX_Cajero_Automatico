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
        private double TotalEfectivo;
        private double TotalTarjeta;
        private double TotalTransacciones;
        public bool CajaAbierta;

        //---------------------------------------------------------------------
        //Costructor.
        //---------------------------------------------------------------------
        public CCaja()
        {
            Fondo = 0;
            TotalTransacciones = 0;
            TotalEfectivo = 0;
            TotalTarjeta = 0;
            CajaAbierta = false;
        }

        //---------------------------------------------------------------------
        //Suma el monto de la venta al total de las transacciones.
        //---------------------------------------------------------------------
        public void AgregarAMontoTotal(double NuevaTransaccion)
        {
            TotalTransacciones += NuevaTransaccion;
        }

        //---------------------------------------------------------------------
        //Suma el monto de la venta en efictivo al total de las transacciones en efectivo.
        //---------------------------------------------------------------------
        public void AgregarEfectivo(double Efectivo)
        {
            TotalEfectivo += Efectivo;
        }

        //---------------------------------------------------------------------
        //Suma el monto de la venta con tarjeta al total de las transacciones con tarjeta.
        //---------------------------------------------------------------------
        public void AgregarTransaccionTarjeta(double Pago)
        {
            TotalTarjeta += Pago;
        }

        //---------------------------------------------------------------------
        //Asigna un nuevo valor al fondo de caja.
        //---------------------------------------------------------------------
        public void NuevoFondo(double Fondo)
        {
            this.Fondo = Fondo;
        }

        //---------------------------------------------------------------------
        //Retorna el fondo de caja.
        //---------------------------------------------------------------------
        public double GetFondo()
        {
            return Fondo;
        }

        //---------------------------------------------------------------------
        //Retorna el monto total de transacciones.
        //---------------------------------------------------------------------
        public double GetTotalTransacciones()
        {
            return TotalTransacciones;
        }

        //---------------------------------------------------------------------
        //Retorna el monto total en transacciones con efectivo.
        //---------------------------------------------------------------------
        public double GetTotalEfectivo()
        {
            return TotalEfectivo;
        }

        //---------------------------------------------------------------------
        //Retorna el monto total en transacciones con tarjeta.
        //---------------------------------------------------------------------
        public double GetTotalTarjeta()
        {
            return TotalTarjeta;
        }

        //---------------------------------------------------------------------
        //Reinicia todos los valores de la caja a cero.
        //---------------------------------------------------------------------
        public void VaciarCaja()
        {
            Fondo = 0;
            TotalEfectivo = 0;
            TotalTarjeta = 0;
            TotalTransacciones = 0;
        }
    }
}
