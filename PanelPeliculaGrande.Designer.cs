
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class PanelPeliculaGrande
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPeliculaGrande));
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblDuracionPelicula = new System.Windows.Forms.Label();
            this.LblClasificacionPelicula = new System.Windows.Forms.Label();
            this.LblNombrePelicula = new System.Windows.Forms.Label();
            this.LblSinopsis = new System.Windows.Forms.Label();
            this.LblContSinopsis = new System.Windows.Forms.Label();
            this.LblSelecHorario = new System.Windows.Forms.Label();
            this.CbxHorarios = new System.Windows.Forms.ComboBox();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.PnlSeleccionBoletos = new System.Windows.Forms.Panel();
            this.LblPrecio3raEdad = new System.Windows.Forms.Label();
            this.LblPrecioAdulto = new System.Windows.Forms.Label();
            this.LblPrecioNiño = new System.Windows.Forms.Label();
            this.LblCantidad3raEdad = new System.Windows.Forms.Label();
            this.LblCantidadAdulto = new System.Windows.Forms.Label();
            this.LblCantidadNiño = new System.Windows.Forms.Label();
            this.BtnMenos3raEdad = new System.Windows.Forms.Button();
            this.BtnMenosAdulto = new System.Windows.Forms.Button();
            this.BtnMenosNiño = new System.Windows.Forms.Button();
            this.BtnMas3raEdad = new System.Windows.Forms.Button();
            this.BtnMasAdulto = new System.Windows.Forms.Button();
            this.BtnMasNiño = new System.Windows.Forms.Button();
            this.LblBoleto3raEdad = new System.Windows.Forms.Label();
            this.LblBoletoAdulto = new System.Windows.Forms.Label();
            this.LblBoletoNiño = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTotalPesos = new System.Windows.Forms.Label();
            this.BtnAsientos = new System.Windows.Forms.Button();
            this.PbxPortadaGrande = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlSeleccionBoletos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPortadaGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGenero
            // 
            this.LblGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(576, 108);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(57, 20);
            this.LblGenero.TabIndex = 12;
            this.LblGenero.Text = "Genero";
            // 
            // LblDuracionPelicula
            // 
            this.LblDuracionPelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDuracionPelicula.AutoSize = true;
            this.LblDuracionPelicula.BackColor = System.Drawing.Color.Transparent;
            this.LblDuracionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionPelicula.Location = new System.Drawing.Point(576, 85);
            this.LblDuracionPelicula.Name = "LblDuracionPelicula";
            this.LblDuracionPelicula.Size = new System.Drawing.Size(60, 23);
            this.LblDuracionPelicula.TabIndex = 9;
            this.LblDuracionPelicula.Text = "-- min";
            // 
            // LblClasificacionPelicula
            // 
            this.LblClasificacionPelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblClasificacionPelicula.AutoSize = true;
            this.LblClasificacionPelicula.BackColor = System.Drawing.Color.Transparent;
            this.LblClasificacionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasificacionPelicula.Location = new System.Drawing.Point(576, 62);
            this.LblClasificacionPelicula.Name = "LblClasificacionPelicula";
            this.LblClasificacionPelicula.Size = new System.Drawing.Size(112, 23);
            this.LblClasificacionPelicula.TabIndex = 8;
            this.LblClasificacionPelicula.Text = "Clasificación";
            // 
            // LblNombrePelicula
            // 
            this.LblNombrePelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNombrePelicula.AutoEllipsis = true;
            this.LblNombrePelicula.AutoSize = true;
            this.LblNombrePelicula.BackColor = System.Drawing.Color.Transparent;
            this.LblNombrePelicula.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNombrePelicula.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePelicula.Location = new System.Drawing.Point(574, 31);
            this.LblNombrePelicula.Name = "LblNombrePelicula";
            this.LblNombrePelicula.Size = new System.Drawing.Size(79, 31);
            this.LblNombrePelicula.TabIndex = 7;
            this.LblNombrePelicula.Text = "Titulo";
            // 
            // LblSinopsis
            // 
            this.LblSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSinopsis.AutoEllipsis = true;
            this.LblSinopsis.AutoSize = true;
            this.LblSinopsis.BackColor = System.Drawing.Color.Transparent;
            this.LblSinopsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblSinopsis.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSinopsis.Location = new System.Drawing.Point(574, 150);
            this.LblSinopsis.Name = "LblSinopsis";
            this.LblSinopsis.Size = new System.Drawing.Size(107, 31);
            this.LblSinopsis.TabIndex = 13;
            this.LblSinopsis.Text = "Sinopsis";
            // 
            // LblContSinopsis
            // 
            this.LblContSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblContSinopsis.BackColor = System.Drawing.Color.Transparent;
            this.LblContSinopsis.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContSinopsis.Location = new System.Drawing.Point(576, 181);
            this.LblContSinopsis.Name = "LblContSinopsis";
            this.LblContSinopsis.Size = new System.Drawing.Size(606, 286);
            this.LblContSinopsis.TabIndex = 14;
            this.LblContSinopsis.Text = resources.GetString("LblContSinopsis.Text");
            // 
            // LblSelecHorario
            // 
            this.LblSelecHorario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblSelecHorario.AutoEllipsis = true;
            this.LblSelecHorario.AutoSize = true;
            this.LblSelecHorario.BackColor = System.Drawing.Color.Transparent;
            this.LblSelecHorario.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblSelecHorario.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelecHorario.Location = new System.Drawing.Point(574, 477);
            this.LblSelecHorario.Name = "LblSelecHorario";
            this.LblSelecHorario.Size = new System.Drawing.Size(262, 31);
            this.LblSelecHorario.TabIndex = 15;
            this.LblSelecHorario.Text = "Seleccione un horario";
            // 
            // CbxHorarios
            // 
            this.CbxHorarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbxHorarios.BackColor = System.Drawing.Color.White;
            this.CbxHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxHorarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxHorarios.FormattingEnabled = true;
            this.CbxHorarios.Location = new System.Drawing.Point(580, 511);
            this.CbxHorarios.Name = "CbxHorarios";
            this.CbxHorarios.Size = new System.Drawing.Size(256, 31);
            this.CbxHorarios.TabIndex = 16;
            this.CbxHorarios.SelectedIndexChanged += new System.EventHandler(this.CbxHorarios_SelectedIndexChanged);
            // 
            // BtnComprar
            // 
            this.BtnComprar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnComprar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnComprar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnComprar.FlatAppearance.BorderSize = 5;
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnComprar.Location = new System.Drawing.Point(1044, 711);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(131, 66);
            this.BtnComprar.TabIndex = 17;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // PnlSeleccionBoletos
            // 
            this.PnlSeleccionBoletos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PnlSeleccionBoletos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.PnlSeleccionBoletos.Controls.Add(this.LblPrecio3raEdad);
            this.PnlSeleccionBoletos.Controls.Add(this.LblPrecioAdulto);
            this.PnlSeleccionBoletos.Controls.Add(this.LblPrecioNiño);
            this.PnlSeleccionBoletos.Controls.Add(this.LblCantidad3raEdad);
            this.PnlSeleccionBoletos.Controls.Add(this.LblCantidadAdulto);
            this.PnlSeleccionBoletos.Controls.Add(this.LblCantidadNiño);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMenos3raEdad);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMenosAdulto);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMenosNiño);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMas3raEdad);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMasAdulto);
            this.PnlSeleccionBoletos.Controls.Add(this.BtnMasNiño);
            this.PnlSeleccionBoletos.Controls.Add(this.LblBoleto3raEdad);
            this.PnlSeleccionBoletos.Controls.Add(this.LblBoletoAdulto);
            this.PnlSeleccionBoletos.Controls.Add(this.LblBoletoNiño);
            this.PnlSeleccionBoletos.Location = new System.Drawing.Point(580, 558);
            this.PnlSeleccionBoletos.Name = "PnlSeleccionBoletos";
            this.PnlSeleccionBoletos.Size = new System.Drawing.Size(386, 220);
            this.PnlSeleccionBoletos.TabIndex = 19;
            this.PnlSeleccionBoletos.Visible = false;
            // 
            // LblPrecio3raEdad
            // 
            this.LblPrecio3raEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrecio3raEdad.AutoEllipsis = true;
            this.LblPrecio3raEdad.AutoSize = true;
            this.LblPrecio3raEdad.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecio3raEdad.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPrecio3raEdad.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio3raEdad.ForeColor = System.Drawing.Color.White;
            this.LblPrecio3raEdad.Location = new System.Drawing.Point(154, 155);
            this.LblPrecio3raEdad.Name = "LblPrecio3raEdad";
            this.LblPrecio3raEdad.Size = new System.Drawing.Size(28, 31);
            this.LblPrecio3raEdad.TabIndex = 30;
            this.LblPrecio3raEdad.Text = "$";
            // 
            // LblPrecioAdulto
            // 
            this.LblPrecioAdulto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrecioAdulto.AutoEllipsis = true;
            this.LblPrecioAdulto.AutoSize = true;
            this.LblPrecioAdulto.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioAdulto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPrecioAdulto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioAdulto.ForeColor = System.Drawing.Color.White;
            this.LblPrecioAdulto.Location = new System.Drawing.Point(154, 93);
            this.LblPrecioAdulto.Name = "LblPrecioAdulto";
            this.LblPrecioAdulto.Size = new System.Drawing.Size(28, 31);
            this.LblPrecioAdulto.TabIndex = 29;
            this.LblPrecioAdulto.Text = "$";
            // 
            // LblPrecioNiño
            // 
            this.LblPrecioNiño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrecioNiño.AutoEllipsis = true;
            this.LblPrecioNiño.AutoSize = true;
            this.LblPrecioNiño.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioNiño.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPrecioNiño.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioNiño.ForeColor = System.Drawing.Color.White;
            this.LblPrecioNiño.Location = new System.Drawing.Point(154, 29);
            this.LblPrecioNiño.Name = "LblPrecioNiño";
            this.LblPrecioNiño.Size = new System.Drawing.Size(28, 31);
            this.LblPrecioNiño.TabIndex = 28;
            this.LblPrecioNiño.Text = "$";
            // 
            // LblCantidad3raEdad
            // 
            this.LblCantidad3raEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCantidad3raEdad.AutoEllipsis = true;
            this.LblCantidad3raEdad.AutoSize = true;
            this.LblCantidad3raEdad.BackColor = System.Drawing.Color.Transparent;
            this.LblCantidad3raEdad.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCantidad3raEdad.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad3raEdad.ForeColor = System.Drawing.Color.White;
            this.LblCantidad3raEdad.Location = new System.Drawing.Point(236, 155);
            this.LblCantidad3raEdad.Name = "LblCantidad3raEdad";
            this.LblCantidad3raEdad.Size = new System.Drawing.Size(40, 31);
            this.LblCantidad3raEdad.TabIndex = 27;
            this.LblCantidad3raEdad.Text = "x0";
            // 
            // LblCantidadAdulto
            // 
            this.LblCantidadAdulto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCantidadAdulto.AutoEllipsis = true;
            this.LblCantidadAdulto.AutoSize = true;
            this.LblCantidadAdulto.BackColor = System.Drawing.Color.Transparent;
            this.LblCantidadAdulto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCantidadAdulto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadAdulto.ForeColor = System.Drawing.Color.White;
            this.LblCantidadAdulto.Location = new System.Drawing.Point(236, 93);
            this.LblCantidadAdulto.Name = "LblCantidadAdulto";
            this.LblCantidadAdulto.Size = new System.Drawing.Size(40, 31);
            this.LblCantidadAdulto.TabIndex = 26;
            this.LblCantidadAdulto.Text = "x0";
            // 
            // LblCantidadNiño
            // 
            this.LblCantidadNiño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCantidadNiño.AutoEllipsis = true;
            this.LblCantidadNiño.AutoSize = true;
            this.LblCantidadNiño.BackColor = System.Drawing.Color.Transparent;
            this.LblCantidadNiño.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCantidadNiño.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadNiño.ForeColor = System.Drawing.Color.White;
            this.LblCantidadNiño.Location = new System.Drawing.Point(236, 29);
            this.LblCantidadNiño.Name = "LblCantidadNiño";
            this.LblCantidadNiño.Size = new System.Drawing.Size(40, 31);
            this.LblCantidadNiño.TabIndex = 25;
            this.LblCantidadNiño.Text = "x0";
            // 
            // BtnMenos3raEdad
            // 
            this.BtnMenos3raEdad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenos3raEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenos3raEdad.Location = new System.Drawing.Point(291, 153);
            this.BtnMenos3raEdad.Name = "BtnMenos3raEdad";
            this.BtnMenos3raEdad.Size = new System.Drawing.Size(36, 36);
            this.BtnMenos3raEdad.TabIndex = 24;
            this.BtnMenos3raEdad.Text = "-";
            this.BtnMenos3raEdad.UseVisualStyleBackColor = false;
            this.BtnMenos3raEdad.Click += new System.EventHandler(this.BtnMenos3raEdad_Click);
            // 
            // BtnMenosAdulto
            // 
            this.BtnMenosAdulto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenosAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenosAdulto.Location = new System.Drawing.Point(291, 91);
            this.BtnMenosAdulto.Name = "BtnMenosAdulto";
            this.BtnMenosAdulto.Size = new System.Drawing.Size(36, 36);
            this.BtnMenosAdulto.TabIndex = 23;
            this.BtnMenosAdulto.Text = "-";
            this.BtnMenosAdulto.UseVisualStyleBackColor = false;
            this.BtnMenosAdulto.Click += new System.EventHandler(this.BtnMenosAdulto_Click);
            // 
            // BtnMenosNiño
            // 
            this.BtnMenosNiño.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenosNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenosNiño.Location = new System.Drawing.Point(291, 27);
            this.BtnMenosNiño.Name = "BtnMenosNiño";
            this.BtnMenosNiño.Size = new System.Drawing.Size(36, 36);
            this.BtnMenosNiño.TabIndex = 22;
            this.BtnMenosNiño.Text = "-";
            this.BtnMenosNiño.UseVisualStyleBackColor = false;
            this.BtnMenosNiño.Click += new System.EventHandler(this.BtnMenosNiño_Click);
            // 
            // BtnMas3raEdad
            // 
            this.BtnMas3raEdad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMas3raEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMas3raEdad.Location = new System.Drawing.Point(333, 153);
            this.BtnMas3raEdad.Name = "BtnMas3raEdad";
            this.BtnMas3raEdad.Size = new System.Drawing.Size(36, 36);
            this.BtnMas3raEdad.TabIndex = 21;
            this.BtnMas3raEdad.Text = "+";
            this.BtnMas3raEdad.UseVisualStyleBackColor = false;
            this.BtnMas3raEdad.Click += new System.EventHandler(this.BtnMas3raEdad_Click);
            // 
            // BtnMasAdulto
            // 
            this.BtnMasAdulto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMasAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasAdulto.Location = new System.Drawing.Point(333, 91);
            this.BtnMasAdulto.Name = "BtnMasAdulto";
            this.BtnMasAdulto.Size = new System.Drawing.Size(36, 36);
            this.BtnMasAdulto.TabIndex = 20;
            this.BtnMasAdulto.Text = "+";
            this.BtnMasAdulto.UseVisualStyleBackColor = false;
            this.BtnMasAdulto.Click += new System.EventHandler(this.BtnMasAdulto_Click);
            // 
            // BtnMasNiño
            // 
            this.BtnMasNiño.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMasNiño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasNiño.Location = new System.Drawing.Point(333, 27);
            this.BtnMasNiño.Name = "BtnMasNiño";
            this.BtnMasNiño.Size = new System.Drawing.Size(36, 36);
            this.BtnMasNiño.TabIndex = 19;
            this.BtnMasNiño.Text = "+";
            this.BtnMasNiño.UseVisualStyleBackColor = false;
            this.BtnMasNiño.Click += new System.EventHandler(this.BtnMasNiño_Click);
            // 
            // LblBoleto3raEdad
            // 
            this.LblBoleto3raEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBoleto3raEdad.AutoEllipsis = true;
            this.LblBoleto3raEdad.AutoSize = true;
            this.LblBoleto3raEdad.BackColor = System.Drawing.Color.Transparent;
            this.LblBoleto3raEdad.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblBoleto3raEdad.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoleto3raEdad.ForeColor = System.Drawing.Color.White;
            this.LblBoleto3raEdad.Location = new System.Drawing.Point(13, 153);
            this.LblBoleto3raEdad.Name = "LblBoleto3raEdad";
            this.LblBoleto3raEdad.Size = new System.Drawing.Size(113, 31);
            this.LblBoleto3raEdad.TabIndex = 18;
            this.LblBoleto3raEdad.Text = "3ra Edad";
            // 
            // LblBoletoAdulto
            // 
            this.LblBoletoAdulto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBoletoAdulto.AutoEllipsis = true;
            this.LblBoletoAdulto.AutoSize = true;
            this.LblBoletoAdulto.BackColor = System.Drawing.Color.Transparent;
            this.LblBoletoAdulto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblBoletoAdulto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoletoAdulto.ForeColor = System.Drawing.Color.White;
            this.LblBoletoAdulto.Location = new System.Drawing.Point(13, 93);
            this.LblBoletoAdulto.Name = "LblBoletoAdulto";
            this.LblBoletoAdulto.Size = new System.Drawing.Size(91, 31);
            this.LblBoletoAdulto.TabIndex = 17;
            this.LblBoletoAdulto.Text = "Adulto";
            // 
            // LblBoletoNiño
            // 
            this.LblBoletoNiño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBoletoNiño.AutoEllipsis = true;
            this.LblBoletoNiño.AutoSize = true;
            this.LblBoletoNiño.BackColor = System.Drawing.Color.Transparent;
            this.LblBoletoNiño.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblBoletoNiño.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoletoNiño.ForeColor = System.Drawing.Color.White;
            this.LblBoletoNiño.Location = new System.Drawing.Point(13, 29);
            this.LblBoletoNiño.Name = "LblBoletoNiño";
            this.LblBoletoNiño.Size = new System.Drawing.Size(70, 31);
            this.LblBoletoNiño.TabIndex = 16;
            this.LblBoletoNiño.Text = "Niño";
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTotal.AutoEllipsis = true;
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(1052, 558);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(76, 31);
            this.LblTotal.TabIndex = 20;
            this.LblTotal.Text = "Total";
            // 
            // LblTotalPesos
            // 
            this.LblTotalPesos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTotalPesos.AutoEllipsis = true;
            this.LblTotalPesos.AutoSize = true;
            this.LblTotalPesos.BackColor = System.Drawing.Color.Transparent;
            this.LblTotalPesos.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTotalPesos.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPesos.Location = new System.Drawing.Point(1052, 596);
            this.LblTotalPesos.Name = "LblTotalPesos";
            this.LblTotalPesos.Size = new System.Drawing.Size(28, 31);
            this.LblTotalPesos.TabIndex = 21;
            this.LblTotalPesos.Text = "$";
            // 
            // BtnAsientos
            // 
            this.BtnAsientos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnAsientos.BackColor = System.Drawing.Color.DarkGray;
            this.BtnAsientos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAsientos.FlatAppearance.BorderSize = 5;
            this.BtnAsientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsientos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnAsientos.Location = new System.Drawing.Point(1044, 639);
            this.BtnAsientos.Name = "BtnAsientos";
            this.BtnAsientos.Size = new System.Drawing.Size(131, 66);
            this.BtnAsientos.TabIndex = 22;
            this.BtnAsientos.Text = "Asientos";
            this.BtnAsientos.UseVisualStyleBackColor = false;
            this.BtnAsientos.Click += new System.EventHandler(this.BtnAsientos_Click);
            // 
            // PbxPortadaGrande
            // 
            this.PbxPortadaGrande.BackColor = System.Drawing.Color.Transparent;
            this.PbxPortadaGrande.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbxPortadaGrande.ErrorImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxPortadaGrande.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxPortadaGrande.Location = new System.Drawing.Point(0, 0);
            this.PbxPortadaGrande.Name = "PbxPortadaGrande";
            this.PbxPortadaGrande.Size = new System.Drawing.Size(560, 800);
            this.PbxPortadaGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPortadaGrande.TabIndex = 0;
            this.PbxPortadaGrande.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelPeliculaGrande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.BtnAsientos);
            this.Controls.Add(this.LblTotalPesos);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.PnlSeleccionBoletos);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.CbxHorarios);
            this.Controls.Add(this.LblSelecHorario);
            this.Controls.Add(this.LblContSinopsis);
            this.Controls.Add(this.LblSinopsis);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDuracionPelicula);
            this.Controls.Add(this.LblClasificacionPelicula);
            this.Controls.Add(this.LblNombrePelicula);
            this.Controls.Add(this.PbxPortadaGrande);
            this.DoubleBuffered = true;
            this.Name = "PanelPeliculaGrande";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.PanelPeliculaGrande_Load);
            this.PnlSeleccionBoletos.ResumeLayout(false);
            this.PnlSeleccionBoletos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPortadaGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxPortadaGrande;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblDuracionPelicula;
        private System.Windows.Forms.Label LblClasificacionPelicula;
        private System.Windows.Forms.Label LblNombrePelicula;
        private System.Windows.Forms.Label LblSinopsis;
        private System.Windows.Forms.Label LblContSinopsis;
        private System.Windows.Forms.Label LblSelecHorario;
        private System.Windows.Forms.ComboBox CbxHorarios;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.Panel PnlSeleccionBoletos;
        private System.Windows.Forms.Label LblBoleto3raEdad;
        private System.Windows.Forms.Label LblBoletoAdulto;
        private System.Windows.Forms.Label LblBoletoNiño;
        private System.Windows.Forms.Label LblPrecio3raEdad;
        private System.Windows.Forms.Label LblPrecioAdulto;
        private System.Windows.Forms.Label LblPrecioNiño;
        private System.Windows.Forms.Label LblCantidad3raEdad;
        private System.Windows.Forms.Label LblCantidadAdulto;
        private System.Windows.Forms.Label LblCantidadNiño;
        private System.Windows.Forms.Button BtnMenos3raEdad;
        private System.Windows.Forms.Button BtnMenosAdulto;
        private System.Windows.Forms.Button BtnMenosNiño;
        private System.Windows.Forms.Button BtnMas3raEdad;
        private System.Windows.Forms.Button BtnMasAdulto;
        private System.Windows.Forms.Button BtnMasNiño;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblTotalPesos;
        private System.Windows.Forms.Button BtnAsientos;
        private System.Windows.Forms.Timer timer1;
    }
}
