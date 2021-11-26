using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public class CFuncion
    {
        public string Horario;
        public bool[] Asientos;
        public CFuncion(string Horario, bool[] Asientos)
        {
            this.Horario = Horario;
            this.Asientos = Asientos;
        }
    }
}
