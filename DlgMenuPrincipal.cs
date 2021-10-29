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
    //---------------------------------------------------------------------
    //Diálogo principal del proyecto final.
    //NJSA. 08/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgProyectoFinal : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgProyectoFinal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MstPrincipal.Visible = false;
        }

        private void BtnCartelera_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            this.ControlBox = true;
            this.Text = "CINEMAX || Punto de venta automático";
            this.MstPrincipal.Visible = true;
            this.WindowState = FormWindowState.Normal;
            Size = new Size(1200, 800);
            CenterToScreen();

         

        }
        private void VolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MstPrincipal.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
