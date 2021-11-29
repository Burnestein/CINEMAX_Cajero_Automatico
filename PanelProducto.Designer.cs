
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class PanelProducto
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
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblNumCantidad = new System.Windows.Forms.Label();
            this.BtnMenosProducto = new System.Windows.Forms.Button();
            this.BtnMasProducto = new System.Windows.Forms.Button();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.PbxProducto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombreProducto.AutoEllipsis = true;
            this.LblNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNombreProducto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(15, 16);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(773, 36);
            this.LblNombreProducto.TabIndex = 28;
            this.LblNombreProducto.Text = "Producto";
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPrecio.AutoEllipsis = true;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(603, 66);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(28, 31);
            this.LblPrecio.TabIndex = 34;
            this.LblPrecio.Text = "$";
            // 
            // LblNumCantidad
            // 
            this.LblNumCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNumCantidad.AutoEllipsis = true;
            this.LblNumCantidad.AutoSize = true;
            this.LblNumCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNumCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumCantidad.Location = new System.Drawing.Point(689, 183);
            this.LblNumCantidad.Name = "LblNumCantidad";
            this.LblNumCantidad.Size = new System.Drawing.Size(45, 36);
            this.LblNumCantidad.TabIndex = 33;
            this.LblNumCantidad.Text = "x0";
            // 
            // BtnMenosProducto
            // 
            this.BtnMenosProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenosProducto.AutoSize = true;
            this.BtnMenosProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenosProducto.Location = new System.Drawing.Point(647, 210);
            this.BtnMenosProducto.Name = "BtnMenosProducto";
            this.BtnMenosProducto.Size = new System.Drawing.Size(36, 36);
            this.BtnMenosProducto.TabIndex = 32;
            this.BtnMenosProducto.Text = "-";
            this.BtnMenosProducto.UseVisualStyleBackColor = false;
            this.BtnMenosProducto.Click += new System.EventHandler(this.BtnMenosProducto_Click);
            // 
            // BtnMasProducto
            // 
            this.BtnMasProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMasProducto.AutoSize = true;
            this.BtnMasProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMasProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasProducto.Location = new System.Drawing.Point(647, 168);
            this.BtnMasProducto.Name = "BtnMasProducto";
            this.BtnMasProducto.Size = new System.Drawing.Size(36, 36);
            this.BtnMasProducto.TabIndex = 31;
            this.BtnMasProducto.Text = "+";
            this.BtnMasProducto.UseVisualStyleBackColor = false;
            this.BtnMasProducto.Click += new System.EventHandler(this.BtnMasProducto_Click);
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarCarrito.BackColor = System.Drawing.Color.Khaki;
            this.BtnAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnAgregarCarrito.FlatAppearance.BorderSize = 5;
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCarrito.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(603, 703);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(185, 82);
            this.BtnAgregarCarrito.TabIndex = 30;
            this.BtnAgregarCarrito.Text = "Agregar al carrito";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = false;
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.BtnAgregarCarrito_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCantidad.AutoEllipsis = true;
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(605, 117);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(82, 23);
            this.LblCantidad.TabIndex = 29;
            this.LblCantidad.Text = "Cantidad";
            // 
            // PbxProducto
            // 
            this.PbxProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxProducto.BackColor = System.Drawing.Color.Transparent;
            this.PbxProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.PbxProducto.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxProducto.Location = new System.Drawing.Point(12, 66);
            this.PbxProducto.Name = "PbxProducto";
            this.PbxProducto.Size = new System.Drawing.Size(585, 719);
            this.PbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxProducto.TabIndex = 27;
            this.PbxProducto.TabStop = false;
            // 
            // PanelProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BtnMasProducto);
            this.Controls.Add(this.BtnMenosProducto);
            this.Controls.Add(this.LblNombreProducto);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNumCantidad);
            this.Controls.Add(this.BtnAgregarCarrito);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.PbxProducto);
            this.Name = "PanelProducto";
            this.Size = new System.Drawing.Size(800, 800);
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblNumCantidad;
        private System.Windows.Forms.Button BtnMenosProducto;
        private System.Windows.Forms.Button BtnMasProducto;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.PictureBox PbxProducto;
    }
}
