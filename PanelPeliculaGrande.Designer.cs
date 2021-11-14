
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPeliculaGrande));
            this.PbxPortadaGrande = new System.Windows.Forms.PictureBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblDuracionPelicula = new System.Windows.Forms.Label();
            this.LblClasificacionPelicula = new System.Windows.Forms.Label();
            this.LblNombrePelicula = new System.Windows.Forms.Label();
            this.LblSinopsis = new System.Windows.Forms.Label();
            this.LblContSinopsis = new System.Windows.Forms.Label();
            this.LblSelecHorario = new System.Windows.Forms.Label();
            this.CbxHorarios = new System.Windows.Forms.ComboBox();
            this.BtnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPortadaGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxPortadaGrande
            // 
            this.PbxPortadaGrande.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PbxPortadaGrande.ErrorImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxPortadaGrande.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxPortadaGrande.Location = new System.Drawing.Point(26, 37);
            this.PbxPortadaGrande.Name = "PbxPortadaGrande";
            this.PbxPortadaGrande.Size = new System.Drawing.Size(523, 702);
            this.PbxPortadaGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPortadaGrande.TabIndex = 0;
            this.PbxPortadaGrande.TabStop = false;
            // 
            // LblGenero
            // 
            this.LblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(569, 114);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(57, 20);
            this.LblGenero.TabIndex = 12;
            this.LblGenero.Text = "Genero";
            // 
            // LblDuracionPelicula
            // 
            this.LblDuracionPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDuracionPelicula.AutoSize = true;
            this.LblDuracionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionPelicula.Location = new System.Drawing.Point(569, 91);
            this.LblDuracionPelicula.Name = "LblDuracionPelicula";
            this.LblDuracionPelicula.Size = new System.Drawing.Size(60, 23);
            this.LblDuracionPelicula.TabIndex = 9;
            this.LblDuracionPelicula.Text = "-- min";
            // 
            // LblClasificacionPelicula
            // 
            this.LblClasificacionPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblClasificacionPelicula.AutoSize = true;
            this.LblClasificacionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasificacionPelicula.Location = new System.Drawing.Point(569, 68);
            this.LblClasificacionPelicula.Name = "LblClasificacionPelicula";
            this.LblClasificacionPelicula.Size = new System.Drawing.Size(112, 23);
            this.LblClasificacionPelicula.TabIndex = 8;
            this.LblClasificacionPelicula.Text = "Clasificación";
            // 
            // LblNombrePelicula
            // 
            this.LblNombrePelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombrePelicula.AutoEllipsis = true;
            this.LblNombrePelicula.AutoSize = true;
            this.LblNombrePelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombrePelicula.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePelicula.Location = new System.Drawing.Point(567, 37);
            this.LblNombrePelicula.Name = "LblNombrePelicula";
            this.LblNombrePelicula.Size = new System.Drawing.Size(79, 31);
            this.LblNombrePelicula.TabIndex = 7;
            this.LblNombrePelicula.Text = "Titulo";
            // 
            // LblSinopsis
            // 
            this.LblSinopsis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSinopsis.AutoEllipsis = true;
            this.LblSinopsis.AutoSize = true;
            this.LblSinopsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSinopsis.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSinopsis.Location = new System.Drawing.Point(567, 238);
            this.LblSinopsis.Name = "LblSinopsis";
            this.LblSinopsis.Size = new System.Drawing.Size(107, 31);
            this.LblSinopsis.TabIndex = 13;
            this.LblSinopsis.Text = "Sinopsis";
            // 
            // LblContSinopsis
            // 
            this.LblContSinopsis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblContSinopsis.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContSinopsis.Location = new System.Drawing.Point(569, 269);
            this.LblContSinopsis.Name = "LblContSinopsis";
            this.LblContSinopsis.Size = new System.Drawing.Size(681, 254);
            this.LblContSinopsis.TabIndex = 14;
            this.LblContSinopsis.Text = resources.GetString("LblContSinopsis.Text");
            // 
            // LblSelecHorario
            // 
            this.LblSelecHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblSelecHorario.AutoEllipsis = true;
            this.LblSelecHorario.AutoSize = true;
            this.LblSelecHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSelecHorario.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelecHorario.Location = new System.Drawing.Point(567, 601);
            this.LblSelecHorario.Name = "LblSelecHorario";
            this.LblSelecHorario.Size = new System.Drawing.Size(111, 31);
            this.LblSelecHorario.TabIndex = 15;
            this.LblSelecHorario.Text = "Horarios";
            // 
            // CbxHorarios
            // 
            this.CbxHorarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbxHorarios.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CbxHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxHorarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxHorarios.FormattingEnabled = true;
            this.CbxHorarios.Location = new System.Drawing.Point(573, 635);
            this.CbxHorarios.Name = "CbxHorarios";
            this.CbxHorarios.Size = new System.Drawing.Size(148, 31);
            this.CbxHorarios.TabIndex = 16;
            this.CbxHorarios.SelectedValueChanged += new System.EventHandler(this.CbxHorarios_SelectedValueChanged);
            // 
            // BtnComprar
            // 
            this.BtnComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnComprar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnComprar.Enabled = false;
            this.BtnComprar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnComprar.FlatAppearance.BorderSize = 5;
            this.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComprar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnComprar.Location = new System.Drawing.Point(770, 604);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(170, 64);
            this.BtnComprar.TabIndex = 17;
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = false;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // PanelPeliculaGrande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Name = "PanelPeliculaGrande";
            this.Size = new System.Drawing.Size(1275, 794);
            this.Load += new System.EventHandler(this.PanelPeliculaGrande_Load);
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
    }
}
