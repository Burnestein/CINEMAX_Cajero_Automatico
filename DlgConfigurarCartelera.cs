using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    public partial class DlgConfigurarCartelera : Form
    {
        //public static DlgConfigurarCartelera ConfigurarCartelera;
        private int indice=-1;
        public List<CPelicula> Peliculas = DlgMenuPrincipal.MenuPrincipal.ListaPeliculas;
        private DataSet ds = new DataSet("tbl");
        public CSala NuevaSala;
        

        public DlgConfigurarCartelera()
        {
            InitializeComponent();
            //ConfigurarCartelera = this;
            NuevaSala = new CSala();

        }
        private void BtnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            indice = -1;
            LimpiarFormulario();
        }

        //---------------------------------------------------------------------
        //Agrega una tabla con los detalles de la película.
        //---------------------------------------------------------------------
        private void BtnGuardarPelicula_Click(object sender, EventArgs e)
        {
            bool SalaExiste = false;
            if (DlgMenuPrincipal.MenuPrincipal.ListaSalas.Count() > 0)
            {
                for(int i=0;i< DlgMenuPrincipal.MenuPrincipal.ListaSalas.Count(); i++)
                {
                    if(DlgMenuPrincipal.MenuPrincipal.ListaSalas[i].NumSala==CbxSala.SelectedIndex + 1)
                    {
                        SalaExiste = true;
                    }
                }
            }    
            if (!SalaExiste)
            {
                CSala NuevaSala = new CSala();
                NuevaSala.NumSala = CbxSala.SelectedIndex + 1;
                DlgMenuPrincipal.MenuPrincipal.ListaSalas.Add(NuevaSala);
            }
            else
            {
                MessageBox.Show("La sala ya existe");
            }
            List<string> HorarioPelicula = new List<string>();
            int ConteoHorarios = LbxHorariosPelicula.Items.Count;
            //MessageBox.Show("Numero de Horarios: " + ConteoHorarios.ToString());

            for (int i = 0; i < ConteoHorarios; i++)
            {
                HorarioPelicula.Add(LbxHorariosPelicula.Items[i].ToString());
       
                //MessageBox.Show(HorarioPelicula[i].ToString());
            }
            CPelicula Pelicula = new CPelicula(
                TbxTituloPelicula.Text,
                NudDuracionPelicula.Text,
                CbxGeneroPelicula.Text,
                CbxClasificacionPelicula.Text,
                RtbSinopsisPelicula.Text,
                //HorarioPelicula,
                PbxImagenPelicula.Image,
                //CbxSala.SelectedIndex+1
                NuevaSala
                );

            if (indice > -1)
            {
                Peliculas[indice] = Pelicula;
                indice = -1;
            }
            else
            {
                Peliculas.Add(Pelicula);
            }
            //CSala MiSala = new CSala();
            //MessageBox.Show("Sala seleccionada: "+ CbxSala.SelectedItem.ToString());
            /*for(int i = 0; i < HorarioPelicula.Count(); i++)
            {
                
                if (!MiSala.ObtenerSala(int.Parse(CbxSala.SelectedItem.ToString())).HorariosOcupados.Contains(HorarioPelicula[i]))
                {
                    MiSala.ObtenerSala(int.Parse(CbxSala.SelectedItem.ToString())).HorariosOcupados.Add(HorarioPelicula[i]);
                }
                else
                {
                    MessageBox.Show("Horario repetido");
                }
                
            }*/
            //Pelicula.Horarios.Clear();
            for(int i = 0; i < HorarioPelicula.Count(); i++)
            {
                NuevaSala.AgregarHorariosOcupados(HorarioPelicula[i]);
            }
            Pelicula.Horarios = HorarioPelicula;
            for(int i = 0; i < Pelicula.Horarios.Count(); i++)
            {
                NuevaSala.AgregarFuncion(Pelicula.Horarios[i], Pelicula);
            }
            
            //ObtenerSala(int.Parse(CbxSala.SelectedItem.ToString())).HorariosOcupados.Add();


            DlgMenuPrincipal.MenuPrincipal.CargarCartelera();
            
            LimpiarFormulario();
            /*string mensaje = "";
            for (int i = 0; i < DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[0].Horarios.Count(); i++)
            {
                mensaje = mensaje + DlgMenuPrincipal.MenuPrincipal.ListaPeliculas[0].Horarios[i].ToString() + "\n";
            }
            MessageBox.Show("Los horarios de la pelicula son: \n" + mensaje);*/
            ActualizarTabla();
            
        }

        

        //---------------------------------------------------------------------
        //Borra la informacion escrita en el formulario.
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
            //HorarioPelicula.Clear();
        }

        //---------------------------------------------------------------------
        //Agregar un horario en la configuración de cartelera.
        //---------------------------------------------------------------------
        private void BtnAgregarHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Add(DtpHorarioPelicula.Value.ToString("hh:mm tt"));
        }

        //---------------------------------------------------------------------
        //Remover un horario selecionado en la configuracion de cartelera.
        //---------------------------------------------------------------------
        private void BtnRemoverHorario_Click(object sender, EventArgs e)
        {
            LbxHorariosPelicula.Items.Remove(LbxHorariosPelicula.SelectedItem);
        }

        //---------------------------------------------------------------------
        //Remover una película en la configuración de cartelera.
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

        private void ActualizarTabla()
        { 
                DgvPeliculas.DataSource = null;
                DgvPeliculas.DataSource = Peliculas;
                DgvPeliculas.Columns["Portada"].Visible = false;
                DgvPeliculas.Columns["Sinopsis"].Visible = false;
                DgvPeliculas.ClearSelection();
        }

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
            /*string mensaje = "";
            for (int i = 0; i < Pelicula.Horarios.Count(); i++)
            {
                mensaje = mensaje + Pelicula.Horarios[i].ToString() + "\n";
            }
            MessageBox.Show("Los horarios de la pelicula son: \n" + mensaje);*/
        }

        private void DlgConfigurarCartelera_Load(object sender, EventArgs e)
        {
            CbxSala.SelectedIndex = 0;
            if (Peliculas.Count!=0)
            {
                ActualizarTabla();
                
            }
        }

        private void LblExportarXML_Click(object sender, EventArgs e)
        {
            //This line of code creates a text file for the data export.
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\burn_\Desktop\\Test.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= DgvPeliculas.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= DgvPeliculas.Columns.Count - 1; c++)
                    {
                        sLine = sLine + DgvPeliculas.Rows[r].Cells[c].Value;
                        if (c != DgvPeliculas.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + ",";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ds.Tables[0].WriteXml(sfd.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }*/
        }
    }
}
