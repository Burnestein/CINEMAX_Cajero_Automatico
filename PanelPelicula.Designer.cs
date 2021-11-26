
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class PanelPelicula
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
            this.PnlSala = new System.Windows.Forms.Panel();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblHorarios = new System.Windows.Forms.Label();
            this.LblDuracionPelicula = new System.Windows.Forms.Label();
            this.LblClasificacionPelicula = new System.Windows.Forms.Label();
            this.LblNombrePelicula = new System.Windows.Forms.Label();
            this.PbxPelicula = new System.Windows.Forms.PictureBox();
            this.LbxHorariosPelicula = new System.Windows.Forms.ListBox();
            this.PnlSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSala
            // 
            this.PnlSala.Controls.Add(this.LbxHorariosPelicula);
            this.PnlSala.Controls.Add(this.LblGenero);
            this.PnlSala.Controls.Add(this.LblHorarios);
            this.PnlSala.Controls.Add(this.LblDuracionPelicula);
            this.PnlSala.Controls.Add(this.LblClasificacionPelicula);
            this.PnlSala.Controls.Add(this.LblNombrePelicula);
            this.PnlSala.Controls.Add(this.PbxPelicula);
            this.PnlSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSala.Location = new System.Drawing.Point(0, 0);
            this.PnlSala.Name = "PnlSala";
            this.PnlSala.Size = new System.Drawing.Size(400, 400);
            this.PnlSala.TabIndex = 1;
            // 
            // LblGenero
            // 
            this.LblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(253, 73);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(57, 20);
            this.LblGenero.TabIndex = 6;
            this.LblGenero.Text = "Género";
            // 
            // LblHorarios
            // 
            this.LblHorarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHorarios.AutoSize = true;
            this.LblHorarios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHorarios.Location = new System.Drawing.Point(252, 112);
            this.LblHorarios.Name = "LblHorarios";
            this.LblHorarios.Size = new System.Drawing.Size(99, 27);
            this.LblHorarios.TabIndex = 4;
            this.LblHorarios.Text = "Horarios:";
            // 
            // LblDuracionPelicula
            // 
            this.LblDuracionPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDuracionPelicula.AutoSize = true;
            this.LblDuracionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionPelicula.Location = new System.Drawing.Point(252, 46);
            this.LblDuracionPelicula.Name = "LblDuracionPelicula";
            this.LblDuracionPelicula.Size = new System.Drawing.Size(60, 23);
            this.LblDuracionPelicula.TabIndex = 3;
            this.LblDuracionPelicula.Text = "-- min";
            // 
            // LblClasificacionPelicula
            // 
            this.LblClasificacionPelicula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblClasificacionPelicula.AutoSize = true;
            this.LblClasificacionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasificacionPelicula.Location = new System.Drawing.Point(252, 17);
            this.LblClasificacionPelicula.Name = "LblClasificacionPelicula";
            this.LblClasificacionPelicula.Size = new System.Drawing.Size(112, 23);
            this.LblClasificacionPelicula.TabIndex = 2;
            this.LblClasificacionPelicula.Text = "Clasificación";
            // 
            // LblNombrePelicula
            // 
            this.LblNombrePelicula.AutoEllipsis = true;
            this.LblNombrePelicula.AutoSize = true;
            this.LblNombrePelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombrePelicula.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePelicula.Location = new System.Drawing.Point(2, 11);
            this.LblNombrePelicula.Name = "LblNombrePelicula";
            this.LblNombrePelicula.Size = new System.Drawing.Size(79, 31);
            this.LblNombrePelicula.TabIndex = 1;
            this.LblNombrePelicula.Text = "Titulo";
            this.LblNombrePelicula.Click += new System.EventHandler(this.LblNombrePelicula_Click);
            // 
            // PbxPelicula
            // 
            this.PbxPelicula.BackColor = System.Drawing.SystemColors.Control;
            this.PbxPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxPelicula.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxPelicula.Location = new System.Drawing.Point(3, 45);
            this.PbxPelicula.Name = "PbxPelicula";
            this.PbxPelicula.Size = new System.Drawing.Size(248, 352);
            this.PbxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPelicula.TabIndex = 0;
            this.PbxPelicula.TabStop = false;
            this.PbxPelicula.Click += new System.EventHandler(this.PbxPelicula_Click);
            this.PbxPelicula.MouseEnter += new System.EventHandler(this.PbxPelicula_MouseEnter);
            // 
            // LbxHorariosPelicula
            // 
            this.LbxHorariosPelicula.BackColor = System.Drawing.SystemColors.Control;
            this.LbxHorariosPelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbxHorariosPelicula.FormattingEnabled = true;
            this.LbxHorariosPelicula.ItemHeight = 16;
            this.LbxHorariosPelicula.Location = new System.Drawing.Point(257, 142);
            this.LbxHorariosPelicula.Name = "LbxHorariosPelicula";
            this.LbxHorariosPelicula.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LbxHorariosPelicula.Size = new System.Drawing.Size(140, 256);
            this.LbxHorariosPelicula.Sorted = true;
            this.LbxHorariosPelicula.TabIndex = 7;
            // 
            // PanelPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlSala);
            this.Name = "PanelPelicula";
            this.Size = new System.Drawing.Size(400, 400);
            this.PnlSala.ResumeLayout(false);
            this.PnlSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSala;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblHorarios;
        private System.Windows.Forms.Label LblDuracionPelicula;
        private System.Windows.Forms.Label LblClasificacionPelicula;
        private System.Windows.Forms.Label LblNombrePelicula;
        private System.Windows.Forms.PictureBox PbxPelicula;
        private System.Windows.Forms.ListBox LbxHorariosPelicula;
    }
}
