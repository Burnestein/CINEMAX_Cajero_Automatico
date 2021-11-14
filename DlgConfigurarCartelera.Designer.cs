
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class DlgConfigurarCartelera
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgConfigurarCartelera));
            this.BtnGuardarPelicula = new System.Windows.Forms.Button();
            this.TbxTituloPelicula = new System.Windows.Forms.TextBox();
            this.LblTituloPelicula = new System.Windows.Forms.Label();
            this.LblGeneroPelicula = new System.Windows.Forms.Label();
            this.CbxGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.CbxClasificacionPelicula = new System.Windows.Forms.ComboBox();
            this.LblClasificacionPelicula = new System.Windows.Forms.Label();
            this.LblDuracionPelicula = new System.Windows.Forms.Label();
            this.NudDuracionPelicula = new System.Windows.Forms.NumericUpDown();
            this.LblMinutos = new System.Windows.Forms.Label();
            this.LblHorariosPelicula = new System.Windows.Forms.Label();
            this.LbxHorariosPelicula = new System.Windows.Forms.ListBox();
            this.LblNuevoHorario = new System.Windows.Forms.Label();
            this.BtnRemoverHorario = new System.Windows.Forms.Button();
            this.BtnAgregarHorario = new System.Windows.Forms.Button();
            this.RtbSinopsisPelicula = new System.Windows.Forms.RichTextBox();
            this.LblSinopsisPelicula = new System.Windows.Forms.Label();
            this.LblImportarXML = new System.Windows.Forms.Button();
            this.LblExportarXML = new System.Windows.Forms.Button();
            this.DtpHorarioPelicula = new System.Windows.Forms.DateTimePicker();
            this.BtnRemoverPelicula = new System.Windows.Forms.Button();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DgvPeliculas = new System.Windows.Forms.DataGridView();
            this.PnlTablaPeliculas = new System.Windows.Forms.Panel();
            this.BtnLimpiarFormulario = new System.Windows.Forms.Button();
            this.PbxImagenPelicula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudDuracionPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).BeginInit();
            this.PnlTablaPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardarPelicula
            // 
            this.BtnGuardarPelicula.Location = new System.Drawing.Point(397, 289);
            this.BtnGuardarPelicula.Name = "BtnGuardarPelicula";
            this.BtnGuardarPelicula.Size = new System.Drawing.Size(121, 42);
            this.BtnGuardarPelicula.TabIndex = 1;
            this.BtnGuardarPelicula.Text = "Guardar Pelicula";
            this.BtnGuardarPelicula.UseVisualStyleBackColor = true;
            this.BtnGuardarPelicula.Click += new System.EventHandler(this.BtnGuardarPelicula_Click);
            // 
            // TbxTituloPelicula
            // 
            this.TbxTituloPelicula.Location = new System.Drawing.Point(9, 92);
            this.TbxTituloPelicula.Name = "TbxTituloPelicula";
            this.TbxTituloPelicula.Size = new System.Drawing.Size(387, 22);
            this.TbxTituloPelicula.TabIndex = 3;
            // 
            // LblTituloPelicula
            // 
            this.LblTituloPelicula.AutoSize = true;
            this.LblTituloPelicula.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblTituloPelicula.Location = new System.Drawing.Point(9, 69);
            this.LblTituloPelicula.Name = "LblTituloPelicula";
            this.LblTituloPelicula.Size = new System.Drawing.Size(43, 17);
            this.LblTituloPelicula.TabIndex = 4;
            this.LblTituloPelicula.Text = "Título";
            // 
            // LblGeneroPelicula
            // 
            this.LblGeneroPelicula.AutoSize = true;
            this.LblGeneroPelicula.Location = new System.Drawing.Point(9, 129);
            this.LblGeneroPelicula.Name = "LblGeneroPelicula";
            this.LblGeneroPelicula.Size = new System.Drawing.Size(56, 17);
            this.LblGeneroPelicula.TabIndex = 6;
            this.LblGeneroPelicula.Text = "Género";
            // 
            // CbxGeneroPelicula
            // 
            this.CbxGeneroPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGeneroPelicula.FormattingEnabled = true;
            this.CbxGeneroPelicula.Items.AddRange(new object[] {
            "Acción",
            "Ciencia Ficción",
            "Comedia",
            "Drama",
            "Fantasía",
            "Melodrama",
            "Musical",
            "Romance",
            "Suspenso",
            "Terror",
            "Documental"});
            this.CbxGeneroPelicula.Location = new System.Drawing.Point(81, 126);
            this.CbxGeneroPelicula.Name = "CbxGeneroPelicula";
            this.CbxGeneroPelicula.Size = new System.Drawing.Size(121, 24);
            this.CbxGeneroPelicula.TabIndex = 7;
            // 
            // CbxClasificacionPelicula
            // 
            this.CbxClasificacionPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxClasificacionPelicula.FormattingEnabled = true;
            this.CbxClasificacionPelicula.Items.AddRange(new object[] {
            "AA",
            "A",
            "B",
            "B-15",
            "C",
            "D"});
            this.CbxClasificacionPelicula.Location = new System.Drawing.Point(315, 126);
            this.CbxClasificacionPelicula.Name = "CbxClasificacionPelicula";
            this.CbxClasificacionPelicula.Size = new System.Drawing.Size(81, 24);
            this.CbxClasificacionPelicula.TabIndex = 9;
            // 
            // LblClasificacionPelicula
            // 
            this.LblClasificacionPelicula.AutoSize = true;
            this.LblClasificacionPelicula.Location = new System.Drawing.Point(223, 129);
            this.LblClasificacionPelicula.Name = "LblClasificacionPelicula";
            this.LblClasificacionPelicula.Size = new System.Drawing.Size(86, 17);
            this.LblClasificacionPelicula.TabIndex = 8;
            this.LblClasificacionPelicula.Text = "Clasificación";
            // 
            // LblDuracionPelicula
            // 
            this.LblDuracionPelicula.AutoSize = true;
            this.LblDuracionPelicula.Location = new System.Drawing.Point(9, 172);
            this.LblDuracionPelicula.Name = "LblDuracionPelicula";
            this.LblDuracionPelicula.Size = new System.Drawing.Size(65, 17);
            this.LblDuracionPelicula.TabIndex = 10;
            this.LblDuracionPelicula.Text = "Duración";
            // 
            // NudDuracionPelicula
            // 
            this.NudDuracionPelicula.Location = new System.Drawing.Point(81, 172);
            this.NudDuracionPelicula.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NudDuracionPelicula.Name = "NudDuracionPelicula";
            this.NudDuracionPelicula.Size = new System.Drawing.Size(65, 22);
            this.NudDuracionPelicula.TabIndex = 11;
            // 
            // LblMinutos
            // 
            this.LblMinutos.AutoSize = true;
            this.LblMinutos.Location = new System.Drawing.Point(145, 174);
            this.LblMinutos.Name = "LblMinutos";
            this.LblMinutos.Size = new System.Drawing.Size(57, 17);
            this.LblMinutos.TabIndex = 12;
            this.LblMinutos.Text = "minutos";
            // 
            // LblHorariosPelicula
            // 
            this.LblHorariosPelicula.AutoSize = true;
            this.LblHorariosPelicula.Location = new System.Drawing.Point(9, 215);
            this.LblHorariosPelicula.Name = "LblHorariosPelicula";
            this.LblHorariosPelicula.Size = new System.Drawing.Size(66, 17);
            this.LblHorariosPelicula.TabIndex = 13;
            this.LblHorariosPelicula.Text = "Horarios:";
            // 
            // LbxHorariosPelicula
            // 
            this.LbxHorariosPelicula.FormattingEnabled = true;
            this.LbxHorariosPelicula.ItemHeight = 16;
            this.LbxHorariosPelicula.Location = new System.Drawing.Point(82, 215);
            this.LbxHorariosPelicula.Name = "LbxHorariosPelicula";
            this.LbxHorariosPelicula.Size = new System.Drawing.Size(133, 116);
            this.LbxHorariosPelicula.TabIndex = 14;
            // 
            // LblNuevoHorario
            // 
            this.LblNuevoHorario.AutoSize = true;
            this.LblNuevoHorario.Location = new System.Drawing.Point(223, 215);
            this.LblNuevoHorario.Name = "LblNuevoHorario";
            this.LblNuevoHorario.Size = new System.Drawing.Size(100, 17);
            this.LblNuevoHorario.TabIndex = 15;
            this.LblNuevoHorario.Text = "Nuevo Horario";
            // 
            // BtnRemoverHorario
            // 
            this.BtnRemoverHorario.Location = new System.Drawing.Point(226, 304);
            this.BtnRemoverHorario.Name = "BtnRemoverHorario";
            this.BtnRemoverHorario.Size = new System.Drawing.Size(141, 27);
            this.BtnRemoverHorario.TabIndex = 19;
            this.BtnRemoverHorario.Text = "Remover Horario";
            this.BtnRemoverHorario.UseVisualStyleBackColor = true;
            this.BtnRemoverHorario.Click += new System.EventHandler(this.BtnRemoverHorario_Click);
            // 
            // BtnAgregarHorario
            // 
            this.BtnAgregarHorario.Location = new System.Drawing.Point(226, 271);
            this.BtnAgregarHorario.Name = "BtnAgregarHorario";
            this.BtnAgregarHorario.Size = new System.Drawing.Size(141, 27);
            this.BtnAgregarHorario.TabIndex = 20;
            this.BtnAgregarHorario.Text = "Agregar Horario";
            this.BtnAgregarHorario.UseVisualStyleBackColor = true;
            this.BtnAgregarHorario.Click += new System.EventHandler(this.BtnAgregarHorario_Click);
            // 
            // RtbSinopsisPelicula
            // 
            this.RtbSinopsisPelicula.Location = new System.Drawing.Point(664, 92);
            this.RtbSinopsisPelicula.Name = "RtbSinopsisPelicula";
            this.RtbSinopsisPelicula.Size = new System.Drawing.Size(306, 239);
            this.RtbSinopsisPelicula.TabIndex = 21;
            this.RtbSinopsisPelicula.Text = "";
            // 
            // LblSinopsisPelicula
            // 
            this.LblSinopsisPelicula.AutoSize = true;
            this.LblSinopsisPelicula.Location = new System.Drawing.Point(661, 69);
            this.LblSinopsisPelicula.Name = "LblSinopsisPelicula";
            this.LblSinopsisPelicula.Size = new System.Drawing.Size(61, 17);
            this.LblSinopsisPelicula.TabIndex = 22;
            this.LblSinopsisPelicula.Text = "Sinópsis";
            // 
            // LblImportarXML
            // 
            this.LblImportarXML.Location = new System.Drawing.Point(712, 12);
            this.LblImportarXML.Name = "LblImportarXML";
            this.LblImportarXML.Size = new System.Drawing.Size(126, 27);
            this.LblImportarXML.TabIndex = 23;
            this.LblImportarXML.Text = "Importar XML";
            this.LblImportarXML.UseVisualStyleBackColor = true;
            // 
            // LblExportarXML
            // 
            this.LblExportarXML.Location = new System.Drawing.Point(844, 12);
            this.LblExportarXML.Name = "LblExportarXML";
            this.LblExportarXML.Size = new System.Drawing.Size(126, 27);
            this.LblExportarXML.TabIndex = 24;
            this.LblExportarXML.Text = "Exportar XML";
            this.LblExportarXML.UseVisualStyleBackColor = true;
            // 
            // DtpHorarioPelicula
            // 
            this.DtpHorarioPelicula.CustomFormat = "hh:mm tt";
            this.DtpHorarioPelicula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpHorarioPelicula.Location = new System.Drawing.Point(226, 236);
            this.DtpHorarioPelicula.Name = "DtpHorarioPelicula";
            this.DtpHorarioPelicula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpHorarioPelicula.ShowUpDown = true;
            this.DtpHorarioPelicula.Size = new System.Drawing.Size(106, 22);
            this.DtpHorarioPelicula.TabIndex = 25;
            this.DtpHorarioPelicula.Value = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            // 
            // BtnRemoverPelicula
            // 
            this.BtnRemoverPelicula.Location = new System.Drawing.Point(524, 289);
            this.BtnRemoverPelicula.Name = "BtnRemoverPelicula";
            this.BtnRemoverPelicula.Size = new System.Drawing.Size(121, 42);
            this.BtnRemoverPelicula.TabIndex = 26;
            this.BtnRemoverPelicula.Text = "Remover Pelicula";
            this.BtnRemoverPelicula.UseVisualStyleBackColor = true;
            this.BtnRemoverPelicula.Click += new System.EventHandler(this.BtnRemoverPelicula_Click);
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(449, 231);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(160, 27);
            this.BtnCargarImagen.TabIndex = 28;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Selecciona una imagen";
            // 
            // DgvPeliculas
            // 
            this.DgvPeliculas.AllowUserToAddRows = false;
            this.DgvPeliculas.AllowUserToDeleteRows = false;
            this.DgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPeliculas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPeliculas.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPeliculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvPeliculas.Location = new System.Drawing.Point(0, 0);
            this.DgvPeliculas.MultiSelect = false;
            this.DgvPeliculas.Name = "DgvPeliculas";
            this.DgvPeliculas.ReadOnly = true;
            this.DgvPeliculas.RowHeadersWidth = 51;
            this.DgvPeliculas.RowTemplate.Height = 24;
            this.DgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPeliculas.Size = new System.Drawing.Size(958, 195);
            this.DgvPeliculas.TabIndex = 0;
            this.DgvPeliculas.DoubleClick += new System.EventHandler(this.DgvPeliculas_DoubleClick);
            // 
            // PnlTablaPeliculas
            // 
            this.PnlTablaPeliculas.AutoScroll = true;
            this.PnlTablaPeliculas.BackColor = System.Drawing.Color.White;
            this.PnlTablaPeliculas.Controls.Add(this.DgvPeliculas);
            this.PnlTablaPeliculas.Location = new System.Drawing.Point(12, 346);
            this.PnlTablaPeliculas.Name = "PnlTablaPeliculas";
            this.PnlTablaPeliculas.Size = new System.Drawing.Size(958, 195);
            this.PnlTablaPeliculas.TabIndex = 0;
            // 
            // BtnLimpiarFormulario
            // 
            this.BtnLimpiarFormulario.Location = new System.Drawing.Point(9, 11);
            this.BtnLimpiarFormulario.Name = "BtnLimpiarFormulario";
            this.BtnLimpiarFormulario.Size = new System.Drawing.Size(193, 28);
            this.BtnLimpiarFormulario.TabIndex = 29;
            this.BtnLimpiarFormulario.Text = "Limpiar Formulario";
            this.BtnLimpiarFormulario.UseVisualStyleBackColor = true;
            this.BtnLimpiarFormulario.Click += new System.EventHandler(this.BtnLimpiarFormulario_Click);
            // 
            // PbxImagenPelicula
            // 
            this.PbxImagenPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbxImagenPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImagenPelicula.ErrorImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenPelicula.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenPelicula.InitialImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenPelicula.Location = new System.Drawing.Point(449, 22);
            this.PbxImagenPelicula.Name = "PbxImagenPelicula";
            this.PbxImagenPelicula.Size = new System.Drawing.Size(160, 200);
            this.PbxImagenPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagenPelicula.TabIndex = 27;
            this.PbxImagenPelicula.TabStop = false;
            // 
            // DlgConfigurarCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BtnLimpiarFormulario);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.PbxImagenPelicula);
            this.Controls.Add(this.BtnRemoverPelicula);
            this.Controls.Add(this.DtpHorarioPelicula);
            this.Controls.Add(this.LblExportarXML);
            this.Controls.Add(this.LblImportarXML);
            this.Controls.Add(this.LblSinopsisPelicula);
            this.Controls.Add(this.RtbSinopsisPelicula);
            this.Controls.Add(this.BtnAgregarHorario);
            this.Controls.Add(this.BtnRemoverHorario);
            this.Controls.Add(this.LblNuevoHorario);
            this.Controls.Add(this.LbxHorariosPelicula);
            this.Controls.Add(this.LblHorariosPelicula);
            this.Controls.Add(this.LblMinutos);
            this.Controls.Add(this.NudDuracionPelicula);
            this.Controls.Add(this.LblDuracionPelicula);
            this.Controls.Add(this.CbxClasificacionPelicula);
            this.Controls.Add(this.LblClasificacionPelicula);
            this.Controls.Add(this.CbxGeneroPelicula);
            this.Controls.Add(this.LblGeneroPelicula);
            this.Controls.Add(this.LblTituloPelicula);
            this.Controls.Add(this.TbxTituloPelicula);
            this.Controls.Add(this.BtnGuardarPelicula);
            this.Controls.Add(this.PnlTablaPeliculas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgConfigurarCartelera";
            this.Text = "Configurar Cartelera";
            this.Load += new System.EventHandler(this.DlgConfigurarCartelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudDuracionPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeliculas)).EndInit();
            this.PnlTablaPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGuardarPelicula;
        private System.Windows.Forms.TextBox TbxTituloPelicula;
        private System.Windows.Forms.Label LblTituloPelicula;
        private System.Windows.Forms.Label LblGeneroPelicula;
        private System.Windows.Forms.ComboBox CbxGeneroPelicula;
        private System.Windows.Forms.ComboBox CbxClasificacionPelicula;
        private System.Windows.Forms.Label LblClasificacionPelicula;
        private System.Windows.Forms.Label LblDuracionPelicula;
        private System.Windows.Forms.NumericUpDown NudDuracionPelicula;
        private System.Windows.Forms.Label LblMinutos;
        private System.Windows.Forms.Label LblHorariosPelicula;
        private System.Windows.Forms.ListBox LbxHorariosPelicula;
        private System.Windows.Forms.Label LblNuevoHorario;
        private System.Windows.Forms.Button BtnRemoverHorario;
        private System.Windows.Forms.Button BtnAgregarHorario;
        private System.Windows.Forms.RichTextBox RtbSinopsisPelicula;
        private System.Windows.Forms.Label LblSinopsisPelicula;
        private System.Windows.Forms.Button LblImportarXML;
        private System.Windows.Forms.Button LblExportarXML;
        private System.Windows.Forms.DateTimePicker DtpHorarioPelicula;
        private System.Windows.Forms.Button BtnRemoverPelicula;
        private System.Windows.Forms.PictureBox PbxImagenPelicula;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView DgvPeliculas;
        private System.Windows.Forms.Panel PnlTablaPeliculas;
        private System.Windows.Forms.Button BtnLimpiarFormulario;
    }
}