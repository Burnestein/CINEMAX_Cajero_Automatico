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
    public partial class PanelPelicula : UserControl
    {
        public static PanelPelicula PanelPeli;
        public Label Lbl;
        public PanelPelicula()
        {
            InitializeComponent();
            PanelPeli = this;
            Lbl = LblNombrePelicula;
        }
    }
}
