using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Diálogo de la ventana configuración de cartelera de cine.
    //NJSA. 13/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgConfigurarCartelera : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        private int indice=-1; //posicion de la tabla de peliculas
        public List<CPelicula> Peliculas = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas;
        private DataSet ds = new DataSet("tbl");
        public CSala NuevaSala;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgConfigurarCartelera()
        {
            InitializeComponent();
            NuevaSala = new CSala();
        }

        //---------------------------------------------------------------------
        //Quita la seleccion del indice de la tabla y limpia el formulario.
        //---------------------------------------------------------------------
        private void BtnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            indice = -1;
            LimpiarFormulario();
        }

        //---------------------------------------------------------------------
        //Crea una nueva instacia para CPelicula, asigna sus valores, sala, funciones, etc.
        //---------------------------------------------------------------------
        private void BtnGuardarPelicula_Click(object sender, EventArgs e)
        {
            bool SalaExiste = false;
            if (DlgMenuPrincipal.MenuPrincipal.ListaSalas.Count() > 0) //determina si una sala ya fue creada
            {
                for(int i=0;i< DlgMenuPrincipal.MenuPrincipal.ListaSalas.Count(); i++)
                {
                    if(DlgMenuPrincipal.MenuPrincipal.ListaSalas[i].NumSala==CbxSala.SelectedIndex + 1)
                    {
                        SalaExiste = true;
                    }
                }
            }    
            if (!SalaExiste) //Si no existe crea la nueva sala
            {
                CSala NuevaSala = new CSala();
                NuevaSala.NumSala = CbxSala.SelectedIndex + 1;
                DlgMenuPrincipal.MenuPrincipal.ListaSalas.Add(NuevaSala);
            }
            else
            {
                //MessageBox.Show("La sala ya existe");
            }

            List<string> HorarioPelicula = new List<string>();
            int ConteoHorarios = LbxHorariosPelicula.Items.Count;

            for (int i = 0; i < ConteoHorarios; i++) //Agrega los horarios al control
            {
                HorarioPelicula.Add(LbxHorariosPelicula.Items[i].ToString());
            }

            CPelicula Pelicula = new CPelicula( //Crea nueva pelicula
                TbxTituloPelicula.Text,
                NudDuracionPelicula.Text,
                CbxGeneroPelicula.Text,
                CbxClasificacionPelicula.Text,
                RtbSinopsisPelicula.Text,
                PbxImagenPelicula.Image,
                NuevaSala
                );

            if (indice > -1) // Si hay seleccion en la tabla, cambia la pelicula seleccionada.
            {
                Peliculas[indice] = Pelicula;
                indice = -1;
            }
            else // Si no hay pelicula seleccionada en la tabla, la añade a la lista de peliculas
            {
                Peliculas.Add(Pelicula);
            }

            for(int i = 0; i < HorarioPelicula.Count(); i++)
            {
                NuevaSala.AgregarHorariosOcupados(HorarioPelicula[i]);
            }

            Pelicula.Horarios = HorarioPelicula; 
            for(int i = 0; i < Pelicula.Horarios.Count(); i++)
            {
                NuevaSala.AgregarFuncion(Pelicula.Horarios[i], Pelicula); //Crea funciones para la sala para esta pelicula y por cada horario.
            }
            
            DlgMenuPrincipal.MenuPrincipal.CargarCartelera();
            LimpiarFormulario();
            ActualizarTabla();
        }

        //---------------------------------------------------------------------
        //Borra la informacion en el formulario.
        //---------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            TbxTituloPelicula.Text = "";
            NudDuracionPelicula.Value = 0;
            CbxGeneroPelicula.Text = "";
            CbxClasificacionPelicula.Text = "";
            LbxHorariosPelicula.Items.Clear();
            PbxImagenPelicula.Image = Properties.Resources.Cinemax_Logo;
            RtbSinopsisPelicula.Text = "";
        }

        //---------------------------------------------------------------------
        //Agrega un horario en la configuración de cartelera.
        //---------------------------------------------------------------------
        private void BtnAgregarHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Add(DtpHorarioPelicula.Value.ToString("hh:mm tt"));
        }

        //---------------------------------------------------------------------
        //Remueve un horario selecionado en la configuracion de cartelera.
        //---------------------------------------------------------------------
        private void BtnRemoverHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Remove(LbxHorariosPelicula.SelectedItem);
        }

        //---------------------------------------------------------------------
        //Remueve una película en la configuración de cartelera.
        //---------------------------------------------------------------------
        private void BtnRemoverPelicula_Click(object sender, EventArgs e)
        {
            if (indice > -1)
            {
                Peliculas.RemoveAt(indice);
                indice = -1;
                LimpiarFormulario();
                ActualizarTabla();
                DlgMenuPrincipal.MenuPrincipal.CargarCartelera();
            }
            else
            {
                MessageBox.Show("Seleccione una película.");
            }
        }

        //---------------------------------------------------------------------
        //Carga una imagen para la portada de la película.
        //---------------------------------------------------------------------
        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                PbxImagenPelicula.Load(openFileDialog1.FileName);
            }
        }

        //---------------------------------------------------------------------
        //Actualiza los datos de la tabla de peliculas.
        //---------------------------------------------------------------------
        private void ActualizarTabla()
        { 
                DgvPeliculas.DataSource = null;
                DgvPeliculas.DataSource = Peliculas;
                DgvPeliculas.Columns["Portada"].Visible = false;
                DgvPeliculas.Columns["Sinopsis"].Visible = false;
                DgvPeliculas.ClearSelection();
        }

        //---------------------------------------------------------------------
        //Carga la informacion de la pelicula en el formulario al hacer doble click en la tabla.
        //---------------------------------------------------------------------
        private void DgvPeliculas_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Seleccionada = DgvPeliculas.SelectedRows[0];
            int pos = DgvPeliculas.Rows.IndexOf(Seleccionada);
            CPelicula Pelicula = Peliculas[pos];
            indice = pos;
            TbxTituloPelicula.Text = Pelicula.Titulo;
            NudDuracionPelicula.Value = Int16.Parse(Pelicula.Duracion);
            CbxClasificacionPelicula.Text = Pelicula.Clasificacion;
            CbxGeneroPelicula.Text = Pelicula.Genero;
            RtbSinopsisPelicula.Text = Pelicula.Sinopsis;
            LbxHorariosPelicula.Items.Clear();
            PbxImagenPelicula.Image = Pelicula.Portada;
            for(int i=0;i< Pelicula.Horarios.Count(); i++)
            {
                LbxHorariosPelicula.Items.Add(Pelicula.Horarios[i].ToString());
            }
        }

        //---------------------------------------------------------------------
        //Evento que se inicia al cargar el formulario.
        //---------------------------------------------------------------------
        private void DlgConfigurarCartelera_Load(object sender, EventArgs e)
        {
            CbxSala.SelectedIndex = 0; //Fuerza el inicio a Sala 1

            if (Peliculas.Count!=0)
            {
                ActualizarTabla();
            }
        }
    }
}
