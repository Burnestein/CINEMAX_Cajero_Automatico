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
        public PanelCanastaCompras(string ListaCompras)
        {
            InitializeComponent();
            this.ListaCompras = ListaCompras;
        }

        private void PanelCanastaCompras_Load(object sender, EventArgs e)
        {
            RtbListaCompras.Text = ListaCompras;

        }
    }
}
