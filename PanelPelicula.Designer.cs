﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelPelicula));
            this.PnlSala = new System.Windows.Forms.Panel();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TlpHorariosPelicula = new System.Windows.Forms.TableLayoutPanel();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblHorarios = new System.Windows.Forms.Label();
            this.LblDuracionPelicula = new System.Windows.Forms.Label();
            this.LblClasificacionPelicula = new System.Windows.Forms.Label();
            this.LblNombrePelicula = new System.Windows.Forms.Label();
            this.PbxPelicula = new System.Windows.Forms.PictureBox();
            this.PnlSala.SuspendLayout();
            this.TlpHorariosPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSala
            // 
            this.PnlSala.Controls.Add(this.LblGenero);
            this.PnlSala.Controls.Add(this.TlpHorariosPelicula);
            this.PnlSala.Controls.Add(this.LblHorarios);
            this.PnlSala.Controls.Add(this.LblDuracionPelicula);
            this.PnlSala.Controls.Add(this.LblClasificacionPelicula);
            this.PnlSala.Controls.Add(this.LblNombrePelicula);
            this.PnlSala.Controls.Add(this.PbxPelicula);
            this.PnlSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSala.Location = new System.Drawing.Point(0, 0);
            this.PnlSala.Name = "PnlSala";
            this.PnlSala.Size = new System.Drawing.Size(910, 568);
            this.PnlSala.TabIndex = 1;
            // 
            // LblGenero
            // 
            this.LblGenero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LblGenero.Font = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(281, 187);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(102, 20);
            this.LblGenero.TabIndex = 6;
            this.LblGenero.Text = "Ciencia Ficción";
            // 
            // TlpHorariosPelicula
            // 
            this.TlpHorariosPelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TlpHorariosPelicula.ColumnCount = 1;
            this.TlpHorariosPelicula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpHorariosPelicula.Controls.Add(this.LblHora, 0, 0);
            this.TlpHorariosPelicula.Location = new System.Drawing.Point(285, 254);
            this.TlpHorariosPelicula.Name = "TlpHorariosPelicula";
            this.TlpHorariosPelicula.RowCount = 4;
            this.TlpHorariosPelicula.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpHorariosPelicula.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpHorariosPelicula.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpHorariosPelicula.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TlpHorariosPelicula.Size = new System.Drawing.Size(142, 228);
            this.TlpHorariosPelicula.TabIndex = 5;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(3, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(65, 27);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "18:20";
            // 
            // LblHorarios
            // 
            this.LblHorarios.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblHorarios.AutoSize = true;
            this.LblHorarios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHorarios.Location = new System.Drawing.Point(280, 226);
            this.LblHorarios.Name = "LblHorarios";
            this.LblHorarios.Size = new System.Drawing.Size(99, 27);
            this.LblHorarios.TabIndex = 4;
            this.LblHorarios.Text = "Horarios:";
            // 
            // LblDuracionPelicula
            // 
            this.LblDuracionPelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDuracionPelicula.AutoSize = true;
            this.LblDuracionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionPelicula.Location = new System.Drawing.Point(280, 160);
            this.LblDuracionPelicula.Name = "LblDuracionPelicula";
            this.LblDuracionPelicula.Size = new System.Drawing.Size(90, 27);
            this.LblDuracionPelicula.TabIndex = 3;
            this.LblDuracionPelicula.Text = "157 min";
            // 
            // LblClasificacionPelicula
            // 
            this.LblClasificacionPelicula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblClasificacionPelicula.AutoSize = true;
            this.LblClasificacionPelicula.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClasificacionPelicula.Location = new System.Drawing.Point(280, 133);
            this.LblClasificacionPelicula.Name = "LblClasificacionPelicula";
            this.LblClasificacionPelicula.Size = new System.Drawing.Size(147, 27);
            this.LblClasificacionPelicula.TabIndex = 2;
            this.LblClasificacionPelicula.Text = "Clasificación B";
            // 
            // LblNombrePelicula
            // 
            this.LblNombrePelicula.AutoEllipsis = true;
            this.LblNombrePelicula.AutoSize = true;
            this.LblNombrePelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombrePelicula.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePelicula.Location = new System.Drawing.Point(29, 21);
            this.LblNombrePelicula.Name = "LblNombrePelicula";
            this.LblNombrePelicula.Size = new System.Drawing.Size(75, 31);
            this.LblNombrePelicula.TabIndex = 1;
            this.LblNombrePelicula.Text = "Duna";
            // 
            // PbxPelicula
            // 
            this.PbxPelicula.Image = ((System.Drawing.Image)(resources.GetObject("PbxPelicula.Image")));
            this.PbxPelicula.Location = new System.Drawing.Point(35, 55);
            this.PbxPelicula.Name = "PbxPelicula";
            this.PbxPelicula.Size = new System.Drawing.Size(239, 349);
            this.PbxPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxPelicula.TabIndex = 0;
            this.PbxPelicula.TabStop = false;
            // 
            // PanelPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlSala);
            this.Name = "PanelPelicula";
            this.Size = new System.Drawing.Size(910, 568);
            this.PnlSala.ResumeLayout(false);
            this.PnlSala.PerformLayout();
            this.TlpHorariosPelicula.ResumeLayout(false);
            this.TlpHorariosPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPelicula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSala;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TableLayoutPanel TlpHorariosPelicula;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblHorarios;
        private System.Windows.Forms.Label LblDuracionPelicula;
        private System.Windows.Forms.Label LblClasificacionPelicula;
        private System.Windows.Forms.Label LblNombrePelicula;
        private System.Windows.Forms.PictureBox PbxPelicula;
    }
}