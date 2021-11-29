namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa un asiento de cine.
    //NJSA. 23/11/2021.
    //---------------------------------------------------------------------
    public class CAsiento
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int NumAsiento;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CAsiento(int NumAsiento)
        {
            this.NumAsiento = NumAsiento;
        }

        //---------------------------------------------------------------------
        //Agrega el asiento en la lista de asientos seleccionados de DlgSeleccionarAsientos.
        //---------------------------------------------------------------------
        public void GuardarAsiento()
        {
            DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Add(NumAsiento);
        }

        //---------------------------------------------------------------------
        //Remueve el asiento en la lista de asientos seleccionados de DlgSeleccionarAsientos.
        //---------------------------------------------------------------------
        public void BorrarAsiento()
        {
            if (DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.Contains(NumAsiento))
            {
                int indice;
                indice = DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.IndexOf(NumAsiento);
                DlgSeleccionarAsientos.SeleccionarAsientos.AsientosSeleccionados.RemoveAt(indice);
            }
        }
    }
}
