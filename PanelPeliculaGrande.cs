using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Control de usuario que visualiza la pelicula en grande en menu principal.
    //NJSA. 06/11/2021.
    //---------------------------------------------------------------------
    public partial class PanelPeliculaGrande : UserControl
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private CPelicula Pelicula;
        private double Total;
        private int BoletosNiño;
        private int BoletosAdulto;
        private int Boletos3raEdad;
        private double PrecioNiño = DlgMenuPrincipal.MenuPrincipal.ListaProductos[0].Precio;
        private double PrecioAdulto = DlgMenuPrincipal.MenuPrincipal.ListaProductos[1].Precio;
        private double Precio3ra = DlgMenuPrincipal.MenuPrincipal.ListaProductos[2].Precio;
        public List<int> AsientosSeleccionados;
        int Asientos;
        private CSala MiSala;
        int indicePelicula;
        int indiceFuncion;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
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
            MiSala = Pelicula.MiSala;
            indiceFuncion = 0;
            indicePelicula = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas.IndexOf(Pelicula);
            AsientosSeleccionados = new List<int>();
        }

        //---------------------------------------------------------------------
        //Evento que se inicia al cargar el control de usuario.
        //---------------------------------------------------------------------
        private void PanelPeliculaGrande_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //---------------------------------------------------------------------
        //Agrega los boletos seleccionados a la canasta de compras.
        //---------------------------------------------------------------------
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if (BoletosNiño > 0)
            {
                for(int i = 0; i < BoletosNiño; i++)
                {
                    CProducto BoletosNi = new CProducto();
                    BoletosNi.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto Niño ";
                    BoletosNi.Precio = PrecioNiño;
                    DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(BoletosNi);
                }
            }
            if (BoletosAdulto > 0)
            {
                for(int i = 0; i < BoletosAdulto; i++)
                {
                    CProducto BoletosAd = new CProducto();
                    BoletosAd.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto Adulto ";
                    BoletosAd.Precio = PrecioAdulto;
                    DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(BoletosAd);
                }
            }
            if (Boletos3raEdad > 0)
            {
                for(int i = 0; i < Boletos3raEdad; i++)
                {
                    CProducto Boletos3r = new CProducto();
                    Boletos3r.Producto = Pelicula.Titulo + " " + CbxHorarios.Text + " Boleto 3ra Edad ";
                    Boletos3r.Precio = Precio3ra;
                    DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Boletos3r);
                }
            }
            DlgMenuPrincipal.MenuPrincipal.Compras.AddToCanasta(Pelicula);
            this.Parent.Controls.Remove(this); //Se cierra
            DlgMenuPrincipal.MenuPrincipal.CargarFuenteSodas(); //Carga la fuente de sodas
        }

        //---------------------------------------------------------------------
        //Boton + aumenta los boletos de niño.
        //---------------------------------------------------------------------
        private void BtnMasNiño_Click(object sender, EventArgs e)
        {
            BoletosNiño++;
            LblCantidadNiño.Text = "x" + BoletosNiño.ToString();
        }

        //---------------------------------------------------------------------
        //Boton - disminuye los boletos de niño.
        //---------------------------------------------------------------------
        private void BtnMenosNiño_Click(object sender, EventArgs e)
        {
            if (BoletosNiño > 0)
            {
                BoletosNiño--;
                LblCantidadNiño.Text = "x" + BoletosNiño.ToString();
            }
        }

        //---------------------------------------------------------------------
        //Boton + aumenta los boletos de adulto.
        //---------------------------------------------------------------------
        private void BtnMasAdulto_Click(object sender, EventArgs e)
        {
            BoletosAdulto++;
            LblCantidadAdulto.Text = "x" + BoletosAdulto.ToString();
        }

        //---------------------------------------------------------------------
        //Boton - disminuye los boletos de adulto.
        //---------------------------------------------------------------------
        private void BtnMenosAdulto_Click(object sender, EventArgs e)
        {
            if (BoletosAdulto > 0)
            {
                BoletosAdulto--;
                LblCantidadAdulto.Text = "x" + BoletosAdulto.ToString();
            }
        }

        //---------------------------------------------------------------------
        //Boton + aumenta los boletos de 3ra edad.
        //---------------------------------------------------------------------
        private void BtnMas3raEdad_Click(object sender, EventArgs e)
        {
            Boletos3raEdad++;
            LblCantidad3raEdad.Text = "x" + Boletos3raEdad.ToString();
        }

        //---------------------------------------------------------------------
        //Boton - disminuye los boletos de 3ra edad.
        //---------------------------------------------------------------------
        private void BtnMenos3raEdad_Click(object sender, EventArgs e)
        {
            if (Boletos3raEdad > 0)
            {
                Boletos3raEdad--;
                LblCantidad3raEdad.Text = "x" + Boletos3raEdad.ToString();
            }
        }

        //---------------------------------------------------------------------
        //Retorna el total por los boletos seleccionados.
        //---------------------------------------------------------------------
        private double GetTotal()
        {
            double TotalBoletosNiño = BoletosNiño * PrecioNiño;
            double TotalBoletosAdulto = BoletosAdulto * PrecioAdulto;
            double TotalBoletos3raEdad = Boletos3raEdad * Precio3ra;
            Total = TotalBoletosNiño + TotalBoletosAdulto + TotalBoletos3raEdad;
            LblTotalPesos.Text = "$" + Total.ToString();
            return Total;
        }

        //---------------------------------------------------------------------
        //Abre el formulario para seleccionar los asientos.
        //---------------------------------------------------------------------
        private void BtnAsientos_Click(object sender, EventArgs e)
        {
            string Horario = CbxHorarios.Text;
            int TotalAsientos = BoletosNiño + BoletosAdulto + Boletos3raEdad;
            DlgSeleccionarAsientos seleccionarAsientos;
            seleccionarAsientos = new DlgSeleccionarAsientos(TotalAsientos, MiSala, Pelicula, Horario);
            seleccionarAsientos.Show();
        }

        //---------------------------------------------------------------------
        //Evento que se inicia a cada ciclo del reloj (100ms).
        //Mantiene actualizados los valores de asientos y estado de botones.
        //---------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            indiceFuncion = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[indicePelicula].MiSala.ObtenerIndiceFuncion(CbxHorarios.Text,Pelicula.Titulo);
            AsientosSeleccionados = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[indicePelicula].MiSala.Funciones[indiceFuncion].AsientosSeleccionados;
            GetTotal();
            //Cambia el color del Boton Asientos si hay mas de un boleto seleccionado.
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

            //Cambia el color del botón Comprar si se han seleccionado los asientos
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

        //---------------------------------------------------------------------
        //Visualiza el panel de seleccion de boletos al seleccionar horario.
        //---------------------------------------------------------------------
        private void CbxHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxHorarios.SelectedIndex >= 0)
            {
                PnlSeleccionBoletos.Visible = true;
                CbxHorarios.Enabled = false;
            }
            else
            {
                PnlSeleccionBoletos.Visible = false;
            }
        }
    }
}
