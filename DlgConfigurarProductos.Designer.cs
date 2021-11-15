
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class DlgConfigurarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgConfigurarProductos));
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.LblCodigoProducto = new System.Windows.Forms.Label();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.TbxNombreProducto = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.NudStockProducto = new System.Windows.Forms.NumericUpDown();
            this.NudPrecioProducto = new System.Windows.Forms.NumericUpDown();
            this.NudCodigoProducto = new System.Windows.Forms.NumericUpDown();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.PbxImagenProducto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnNuevoProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecioProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCodigoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvProductos.Location = new System.Drawing.Point(311, 12);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(459, 529);
            this.DgvProductos.TabIndex = 1;
            this.DgvProductos.DoubleClick += new System.EventHandler(this.DgvProductos_DoubleClick);
            // 
            // LblCodigoProducto
            // 
            this.LblCodigoProducto.AutoSize = true;
            this.LblCodigoProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblCodigoProducto.Location = new System.Drawing.Point(9, 40);
            this.LblCodigoProducto.Name = "LblCodigoProducto";
            this.LblCodigoProducto.Size = new System.Drawing.Size(52, 17);
            this.LblCodigoProducto.TabIndex = 6;
            this.LblCodigoProducto.Text = "Código";
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNombreProducto.Location = new System.Drawing.Point(12, 97);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(142, 17);
            this.LblNombreProducto.TabIndex = 8;
            this.LblNombreProducto.Text = "Nombre del Producto";
            // 
            // TbxNombreProducto
            // 
            this.TbxNombreProducto.Location = new System.Drawing.Point(12, 117);
            this.TbxNombreProducto.Name = "TbxNombreProducto";
            this.TbxNombreProducto.Size = new System.Drawing.Size(279, 22);
            this.TbxNombreProducto.TabIndex = 7;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblStock.Location = new System.Drawing.Point(12, 158);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(121, 17);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Cantidad en stock";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPrecio.Location = new System.Drawing.Point(172, 158);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(48, 17);
            this.LblPrecio.TabIndex = 12;
            this.LblPrecio.Text = "Precio";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(12, 481);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(279, 28);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(12, 515);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(279, 26);
            this.BtnRemover.TabIndex = 14;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // NudStockProducto
            // 
            this.NudStockProducto.Location = new System.Drawing.Point(15, 179);
            this.NudStockProducto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudStockProducto.Name = "NudStockProducto";
            this.NudStockProducto.Size = new System.Drawing.Size(87, 22);
            this.NudStockProducto.TabIndex = 15;
            // 
            // NudPrecioProducto
            // 
            this.NudPrecioProducto.DecimalPlaces = 2;
            this.NudPrecioProducto.Location = new System.Drawing.Point(175, 179);
            this.NudPrecioProducto.Name = "NudPrecioProducto";
            this.NudPrecioProducto.Size = new System.Drawing.Size(87, 22);
            this.NudPrecioProducto.TabIndex = 16;
            this.NudPrecioProducto.Tag = "$";
            this.NudPrecioProducto.ThousandsSeparator = true;
            // 
            // NudCodigoProducto
            // 
            this.NudCodigoProducto.Location = new System.Drawing.Point(12, 60);
            this.NudCodigoProducto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NudCodigoProducto.Name = "NudCodigoProducto";
            this.NudCodigoProducto.Size = new System.Drawing.Size(279, 22);
            this.NudCodigoProducto.TabIndex = 17;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(12, 431);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(279, 27);
            this.BtnCargarImagen.TabIndex = 30;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // PbxImagenProducto
            // 
            this.PbxImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PbxImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxImagenProducto.ErrorImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenProducto.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenProducto.InitialImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinemax_Logo;
            this.PbxImagenProducto.Location = new System.Drawing.Point(12, 222);
            this.PbxImagenProducto.Name = "PbxImagenProducto";
            this.PbxImagenProducto.Size = new System.Drawing.Size(279, 200);
            this.PbxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagenProducto.TabIndex = 29;
            this.PbxImagenProducto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnNuevoProducto
            // 
            this.BtnNuevoProducto.Location = new System.Drawing.Point(12, 12);
            this.BtnNuevoProducto.Name = "BtnNuevoProducto";
            this.BtnNuevoProducto.Size = new System.Drawing.Size(75, 25);
            this.BtnNuevoProducto.TabIndex = 31;
            this.BtnNuevoProducto.Text = "Nuevo";
            this.BtnNuevoProducto.UseVisualStyleBackColor = true;
            this.BtnNuevoProducto.Click += new System.EventHandler(this.BtnNuevoProducto_Click);
            // 
            // DlgConfigurarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.BtnNuevoProducto);
            this.Controls.Add(this.BtnCargarImagen);
            this.Controls.Add(this.PbxImagenProducto);
            this.Controls.Add(this.NudCodigoProducto);
            this.Controls.Add(this.NudPrecioProducto);
            this.Controls.Add(this.NudStockProducto);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblNombreProducto);
            this.Controls.Add(this.TbxNombreProducto);
            this.Controls.Add(this.LblCodigoProducto);
            this.Controls.Add(this.DgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DlgConfigurarProductos";
            this.Text = "Configurar Productos";
            this.Load += new System.EventHandler(this.DlgConfigurarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStockProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecioProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCodigoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label LblCodigoProducto;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.TextBox TbxNombreProducto;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.NumericUpDown NudStockProducto;
        private System.Windows.Forms.NumericUpDown NudPrecioProducto;
        private System.Windows.Forms.NumericUpDown NudCodigoProducto;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.PictureBox PbxImagenProducto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnNuevoProducto;
    }
}