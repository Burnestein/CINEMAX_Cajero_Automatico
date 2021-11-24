using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class PanelPeliculaGrande : UserControl
    {
        private CPelicula Pelicula;
        private double Total;
        private int BoletosNiño;
        private int BoletosAdulto;
        private int Boletos3raEdad;
        private double PrecioNiño = DlgMenuPrincipal.MenuPrincipal.ListaProductos[0].Precio;
        private double PrecioAdulto = DlgMenuPrincipal.MenuPrincipal.ListaProductos[1].Precio;
        private double Precio3ra = DlgMenuPrincipal.MenuPrincipal.ListaProductos[2].Precio;
        public List<int> AsientosSeleccionados = DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados;
        int Asientos;
        public PanelPeliculaGrande()
        {
            InitializeComponent();
            Total = 0;
            BoletosNiño = 0;
            BoletosAdulto = 0;
            Boletos3raEdad = 0;
        }
        public PanelPeliculaGrande(CPelicula Pelicula)
        {
            InitializeComponent();
            this.Pelicula = Pelicula;
            PbxPortadaGrande.Image = Pelicula.Portada;
            LblNombrePelicula.Text = Pelicula.Titulo;
            LblClasificacionPelicula.Text = "Clasificación " + Pelicula.Clasificacion;
            LblDuracionPelicula.Text = Pelicula.Duracion + " Minutos";
            LblGenero.Text = Pelicula.Genero;
            LblContSinopsis.Text = Pelicula.Sinopsis;
            for(int i = 0; i < Pelicula.Horarios.Count; i++)
            {
                CbxHorarios.Items.Add(Pelicula.Horarios[i]);
            }
            LblPrecioNiño.Text = "$" + PrecioNiño;
            LblPrecioAdulto.Text = "$" + PrecioAdulto;
            LblPrecio3raEdad.Text = "$" + Precio3ra;
            LblTotalPesos.Text = "$" + Total;
            LblCantidadNiño.Text = "x" + BoletosNiño.ToString();
            LblCantidadAdulto.Text = "x" + BoletosAdulto.ToString();
            LblCantidad3raEdad.Text = "x" + Boletos3raEdad.ToString();
            AsientosSeleccionados = new List<int>();
        }

        private void PanelPeliculaGrande_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if (BoletosNiño > 0)
            {
                CProducto BoletosNi = new CProducto();
                BoletosNi.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto Niño x" + BoletosNiño;
                BoletosNi.Precio = BoletosNiño * PrecioNiño;
                DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(BoletosNi);
            }
            if (BoletosAdulto > 0)
            {
                CProducto BoletosAd = new CProducto();
                BoletosAd.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto Adulto x" + BoletosAdulto;
                BoletosAd.Precio = BoletosAdulto * PrecioNiño;
                DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(BoletosAd);
            }
            if (Boletos3raEdad > 0)
            {
                CProducto Boletos3r = new CProducto();
                Boletos3r.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto 3ra Edad x" + Boletos3raEdad;
                Boletos3r.Precio = Boletos3raEdad * PrecioNiño;
                DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Boletos3r);
            }

            this.Parent.Controls.Remove(this);
            DlgMenuPrincipal.MenuPrincipal.CargarFuenteSodas();
        }

        private void BtnMasNiño_Click(object sender, EventArgs e)
        {

            BoletosNiño++;
            LblCantidadNiño.Text = "x" + BoletosNiño.ToString();

        }

        private void BtnMenosNiño_Click(object sender, EventArgs e)
        {
            if (BoletosNiño > 0)
            {
                BoletosNiño--;
                LblCantidadNiño.Text = "x" + BoletosNiño.ToString();
            }
        }

        private void BtnMasAdulto_Click(object sender, EventArgs e)
        {
            BoletosAdulto++;
            LblCantidadAdulto.Text = "x" + BoletosAdulto.ToString();
        }

        private void BtnMenosAdulto_Click(object sender, EventArgs e)
        {
            if (BoletosAdulto > 0)
            {
                BoletosAdulto--;
                LblCantidadAdulto.Text = "x" + BoletosAdulto.ToString();
            }
        }

        private void BtnMas3raEdad_Click(object sender, EventArgs e)
        {
            Boletos3raEdad++;
            LblCantidad3raEdad.Text = "x" + Boletos3raEdad.ToString();
        }

        private void BtnMenos3raEdad_Click(object sender, EventArgs e)
        {
            if (Boletos3raEdad > 0)
            {
                Boletos3raEdad--;
                LblCantidad3raEdad.Text = "x" + Boletos3raEdad.ToString();
            }
        }
        private double GetTotal()
        {
            double TotalBoletosNiño = BoletosNiño * PrecioNiño;
            double TotalBoletosAdulto = BoletosAdulto * PrecioAdulto;
            double TotalBoletos3raEdad = Boletos3raEdad * Precio3ra;
            Total = TotalBoletosNiño + TotalBoletosAdulto + TotalBoletos3raEdad;
            LblTotalPesos.Text = "$" + Total.ToString();
            return Total;
        }

        private void BtnAsientos_Click(object sender, EventArgs e)
        {
            int TotalAsientos = BoletosNiño + BoletosAdulto + Boletos3raEdad;
            DlgSeleccionarAsientos seleccionarAsientos;
            seleccionarAsientos = new DlgSeleccionarAsientos(TotalAsientos);
            seleccionarAsientos.Show();
        }
        public void ExtraerAsientosSeleccionados(List<int> Asientos)
        {
            AsientosSeleccionados = Asientos;
            string mensaje = "";
            for(int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                mensaje = mensaje + AsientosSeleccionados[i] + "\n";
            }
            MessageBox.Show(mensaje);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            for(int i = 0; i < AsientosSeleccionados.Count(); i++)
            {
                mensaje = mensaje + AsientosSeleccionados[i] + "\n";
            }
            MessageBox.Show(mensaje);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            AsientosSeleccionados = DlgMenuPrincipal.MenuPrincipal.MiSala.AsientosSeleccionados;
            GetTotal();
            if (Total > 0)
            {
                BtnAsientos.Enabled = true;
                BtnAsientos.BackColor = Color.Khaki;
                BtnAsientos.FlatAppearance.BorderColor = Color.Gold;
                
            }
            else
            {
                BtnAsientos.Enabled = false;
                BtnAsientos.BackColor = Color.DarkGray;
                BtnAsientos.FlatAppearance.BorderColor = Color.DimGray;
                
            }
            
            if (AsientosSeleccionados == null)
            {
                Asientos = 0;
            }
            else
            {
                Asientos = AsientosSeleccionados.Count();
            }
            if (Asientos == (BoletosNiño + BoletosAdulto + Boletos3raEdad) && Asientos > 0)
            {
                BtnComprar.Enabled = true;
                BtnComprar.BackColor = Color.Khaki;
                BtnComprar.FlatAppearance.BorderColor = Color.Gold;
            }
            else
            {
                BtnComprar.Enabled = false;
                BtnComprar.BackColor = Color.DarkGray;
                BtnComprar.FlatAppearance.BorderColor = Color.DimGray;
            }
        }

        private void CbxHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxHorarios.SelectedIndex > 0)
            {
                PnlSeleccionBoletos.Visible = true;
            }
            else
            {
                PnlSeleccionBoletos.Visible = false;
            }
        }

        
    }
}
