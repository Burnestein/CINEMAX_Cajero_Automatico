
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
            this.PnlSala = new System.Windows.Forms.Panel();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblNumCantidad = new System.Windows.Forms.Label();
            this.BtnMenosProducto = new System.Windows.Forms.Button();
            this.BtnMasProducto = new System.Windows.Forms.Button();
            this.BtnAgregarCarrito = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.PbxProducto = new System.Windows.Forms.PictureBox();
            this.PnlSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSala
            // 
            this.PnlSala.Controls.Add(this.LblNombreProducto);
            this.PnlSala.Controls.Add(this.LblPrecio);
            this.PnlSala.Controls.Add(this.LblNumCantidad);
            this.PnlSala.Controls.Add(this.BtnMenosProducto);
            this.PnlSala.Controls.Add(this.BtnMasProducto);
            this.PnlSala.Controls.Add(this.BtnAgregarCarrito);
            this.PnlSala.Controls.Add(this.LblCantidad);
            this.PnlSala.Controls.Add(this.PbxProducto);
            this.PnlSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSala.Location = new System.Drawing.Point(0, 0);
            this.PnlSala.Name = "PnlSala";
            this.PnlSala.Size = new System.Drawing.Size(400, 400);
            this.PnlSala.TabIndex = 2;
            this.PnlSala.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSala_Paint);
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrecio.AutoEllipsis = true;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(224, 144);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(28, 31);
            this.LblPrecio.TabIndex = 26;
            this.LblPrecio.Text = "$";
            // 
            // LblNumCantidad
            // 
            this.LblNumCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNumCantidad.AutoEllipsis = true;
            this.LblNumCantidad.AutoSize = true;
            this.LblNumCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNumCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumCantidad.Location = new System.Drawing.Point(277, 241);
            this.LblNumCantidad.Name = "LblNumCantidad";
            this.LblNumCantidad.Size = new System.Drawing.Size(45, 36);
            this.LblNumCantidad.TabIndex = 25;
            this.LblNumCantidad.Text = "x0";
            this.LblNumCantidad.TextChanged += new System.EventHandler(this.LblNumCantidad_TextChanged);
            // 
            // BtnMenosProducto
            // 
            this.BtnMenosProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMenosProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMenosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenosProducto.Location = new System.Drawing.Point(235, 268);
            this.BtnMenosProducto.Name = "BtnMenosProducto";
            this.BtnMenosProducto.Size = new System.Drawing.Size(36, 36);
            this.BtnMenosProducto.TabIndex = 24;
            this.BtnMenosProducto.Text = "-";
            this.BtnMenosProducto.UseVisualStyleBackColor = false;
            this.BtnMenosProducto.Click += new System.EventHandler(this.BtnMenosProducto_Click);
            // 
            // BtnMasProducto
            // 
            this.BtnMasProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMasProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMasProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMasProducto.Location = new System.Drawing.Point(235, 226);
            this.BtnMasProducto.Name = "BtnMasProducto";
            this.BtnMasProducto.Size = new System.Drawing.Size(36, 36);
            this.BtnMasProducto.TabIndex = 23;
            this.BtnMasProducto.Text = "+";
            this.BtnMasProducto.UseVisualStyleBackColor = false;
            this.BtnMasProducto.Click += new System.EventHandler(this.BtnMasProducto_Click);
            // 
            // BtnAgregarCarrito
            // 
            this.BtnAgregarCarrito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarCarrito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAgregarCarrito.BackColor = System.Drawing.Color.Khaki;
            this.BtnAgregarCarrito.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnAgregarCarrito.FlatAppearance.BorderSize = 5;
            this.BtnAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCarrito.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnAgregarCarrito.Location = new System.Drawing.Point(174, 323);
            this.BtnAgregarCarrito.Name = "BtnAgregarCarrito";
            this.BtnAgregarCarrito.Size = new System.Drawing.Size(226, 46);
            this.BtnAgregarCarrito.TabIndex = 18;
            this.BtnAgregarCarrito.Text = "Agregar al carrito";
            this.BtnAgregarCarrito.UseVisualStyleBackColor = false;
            this.BtnAgregarCarrito.Click += new System.EventHandler(this.BtnAgregarCarrito_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCantidad.AutoEllipsis = true;
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(226, 191);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(82, 23);
            this.LblCantidad.TabIndex = 3;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombreProducto.AutoEllipsis = true;
            this.LblNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblNombreProducto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreProducto.Location = new System.Drawing.Point(218, 33);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(179, 111);
            this.LblNombreProducto.TabIndex = 1;
            this.LblNombreProducto.Text = "Producto";
            // 
            // PbxProducto
            // 
            this.PbxProducto.BackColor = System.Drawing.SystemColors.Control;
            this.PbxProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxProducto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbxProducto.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxProducto.Location = new System.Drawing.Point(0, 0);
            this.PbxProducto.Name = "PbxProducto";
            this.PbxProducto.Size = new System.Drawing.Size(212, 400);
            this.PbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxProducto.TabIndex = 0;
            this.PbxProducto.TabStop = false;
            // 
            // PanelProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlSala);
            this.Name = "PanelProducto";
            this.Size = new System.Drawing.Size(400, 400);
            this.PnlSala.ResumeLayout(false);
            this.PnlSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSala;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.PictureBox PbxProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnAgregarCarrito;
        private System.Windows.Forms.Label LblNumCantidad;
        private System.Windows.Forms.Button BtnMenosProducto;
        private System.Windows.Forms.Button BtnMasProducto;
        private System.Windows.Forms.Label LblPrecio;
    }
}
