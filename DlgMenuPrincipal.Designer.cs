
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class DlgMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgMenuPrincipal));
            this.MstPrincipal = new System.Windows.Forms.MenuStrip();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlBotones = new System.Windows.Forms.Panel();
            this.BtnCompras = new System.Windows.Forms.Button();
            this.BtnFuenteSodas = new System.Windows.Forms.Button();
            this.BtnCartelera = new System.Windows.Forms.Button();
            this.LblCaja = new System.Windows.Forms.Label();
            this.LblCurrentTime = new System.Windows.Forms.Label();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.PnlCartelera = new System.Windows.Forms.Panel();
            this.PnlBtnIzquierdo = new System.Windows.Forms.Panel();
            this.BtnIzquierdo = new System.Windows.Forms.Button();
            this.PnlBtnDerecho = new System.Windows.Forms.Panel();
            this.BtnDerecho = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SspMenuPrincipal = new System.Windows.Forms.StatusStrip();
            this.realizarCorteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MstPrincipal.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBotones.SuspendLayout();
            this.PnlSuperior.SuspendLayout();
            this.PnlBtnIzquierdo.SuspendLayout();
            this.PnlBtnDerecho.SuspendLayout();
            this.SspMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MstPrincipal
            // 
            this.MstPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.MstPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.VolverToolStripMenuItem});
            this.MstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MstPrincipal.Name = "MstPrincipal";
            this.MstPrincipal.Size = new System.Drawing.Size(1583, 28);
            this.MstPrincipal.TabIndex = 2;
            this.MstPrincipal.Text = "menuStrip1";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteleraToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // carteleraToolStripMenuItem
            // 
            this.carteleraToolStripMenuItem.Name = "carteleraToolStripMenuItem";
            this.carteleraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.carteleraToolStripMenuItem.Text = "Cartelera";
            this.carteleraToolStripMenuItem.Click += new System.EventHandler(this.carteleraToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCorteToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ayudaToolStripMenuItem.Text = "Caja";
            // 
            // VolverToolStripMenuItem
            // 
            this.VolverToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem";
            this.VolverToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.VolverToolStripMenuItem.Text = "Volver a terminal";
            this.VolverToolStripMenuItem.Click += new System.EventHandler(this.VolverToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.pictureBox1);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(308, 148);
            this.PnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.CinemaxWhite_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlBotones
            // 
            this.PnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.PnlBotones.Controls.Add(this.BtnCompras);
            this.PnlBotones.Controls.Add(this.BtnFuenteSodas);
            this.PnlBotones.Controls.Add(this.BtnCartelera);
            this.PnlBotones.Controls.Add(this.PnlLogo);
            this.PnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBotones.Location = new System.Drawing.Point(0, 28);
            this.PnlBotones.Name = "PnlBotones";
            this.PnlBotones.Size = new System.Drawing.Size(308, 942);
            this.PnlBotones.TabIndex = 0;
            // 
            // BtnCompras
            // 
            this.BtnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.White;
            this.BtnCompras.Image = ((System.Drawing.Image)(resources.GetObject("BtnCompras.Image")));
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 348);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCompras.Size = new System.Drawing.Size(308, 100);
            this.BtnCompras.TabIndex = 3;
            this.BtnCompras.Text = "Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = true;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnFuenteSodas
            // 
            this.BtnFuenteSodas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnFuenteSodas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFuenteSodas.FlatAppearance.BorderSize = 0;
            this.BtnFuenteSodas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.BtnFuenteSodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuenteSodas.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFuenteSodas.ForeColor = System.Drawing.Color.White;
            this.BtnFuenteSodas.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.popcorn_tiny_white;
            this.BtnFuenteSodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuenteSodas.Location = new System.Drawing.Point(0, 248);
            this.BtnFuenteSodas.Name = "BtnFuenteSodas";
            this.BtnFuenteSodas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnFuenteSodas.Size = new System.Drawing.Size(308, 100);
            this.BtnFuenteSodas.TabIndex = 2;
            this.BtnFuenteSodas.Text = "Snacks";
            this.BtnFuenteSodas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuenteSodas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFuenteSodas.UseVisualStyleBackColor = true;
            this.BtnFuenteSodas.Click += new System.EventHandler(this.BtnFuenteSodas_Click);
            // 
            // BtnCartelera
            // 
            this.BtnCartelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCartelera.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCartelera.FlatAppearance.BorderSize = 0;
            this.BtnCartelera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.BtnCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCartelera.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCartelera.ForeColor = System.Drawing.Color.White;
            this.BtnCartelera.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.clapperboard_tiny_white;
            this.BtnCartelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCartelera.Location = new System.Drawing.Point(0, 148);
            this.BtnCartelera.Name = "BtnCartelera";
            this.BtnCartelera.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCartelera.Size = new System.Drawing.Size(308, 100);
            this.BtnCartelera.TabIndex = 1;
            this.BtnCartelera.Text = "Cartelera";
            this.BtnCartelera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCartelera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCartelera.UseVisualStyleBackColor = true;
            this.BtnCartelera.Click += new System.EventHandler(this.BtnCartelera_Click);
            // 
            // LblCaja
            // 
            this.LblCaja.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblCaja.AutoSize = true;
            this.LblCaja.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaja.ForeColor = System.Drawing.Color.White;
            this.LblCaja.Location = new System.Drawing.Point(1126, 57);
            this.LblCaja.Name = "LblCaja";
            this.LblCaja.Size = new System.Drawing.Size(83, 31);
            this.LblCaja.TabIndex = 0;
            this.LblCaja.Text = "Caja 1";
            // 
            // LblCurrentTime
            // 
            this.LblCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCurrentTime.AutoSize = true;
            this.LblCurrentTime.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.LblCurrentTime.Location = new System.Drawing.Point(6, 57);
            this.LblCurrentTime.Name = "LblCurrentTime";
            this.LblCurrentTime.Size = new System.Drawing.Size(145, 30);
            this.LblCurrentTime.TabIndex = 2;
            this.LblCurrentTime.Text = "--/--/-- --:--";
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.PnlSuperior.Controls.Add(this.LblCurrentTime);
            this.PnlSuperior.Controls.Add(this.BtnConfiguracion);
            this.PnlSuperior.Controls.Add(this.LblCaja);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(308, 28);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(1275, 148);
            this.PnlSuperior.TabIndex = 1;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(214)))), ((int)(((byte)(30)))));
            this.BtnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracion.BackgroundImage")));
            this.BtnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Location = new System.Drawing.Point(1250, 0);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(25, 25);
            this.BtnConfiguracion.TabIndex = 1;
            this.BtnConfiguracion.UseVisualStyleBackColor = false;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // PnlCartelera
            // 
            this.PnlCartelera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlCartelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlCartelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCartelera.Location = new System.Drawing.Point(358, 176);
            this.PnlCartelera.Margin = new System.Windows.Forms.Padding(10);
            this.PnlCartelera.Name = "PnlCartelera";
            this.PnlCartelera.Size = new System.Drawing.Size(1175, 794);
            this.PnlCartelera.TabIndex = 7;
            // 
            // PnlBtnIzquierdo
            // 
            this.PnlBtnIzquierdo.Controls.Add(this.BtnIzquierdo);
            this.PnlBtnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBtnIzquierdo.Location = new System.Drawing.Point(308, 176);
            this.PnlBtnIzquierdo.Name = "PnlBtnIzquierdo";
            this.PnlBtnIzquierdo.Size = new System.Drawing.Size(50, 794);
            this.PnlBtnIzquierdo.TabIndex = 8;
            this.PnlBtnIzquierdo.Visible = false;
            // 
            // BtnIzquierdo
            // 
            this.BtnIzquierdo.BackgroundImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.left_arrow;
            this.BtnIzquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnIzquierdo.FlatAppearance.BorderSize = 0;
            this.BtnIzquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.BtnIzquierdo.Name = "BtnIzquierdo";
            this.BtnIzquierdo.Size = new System.Drawing.Size(50, 794);
            this.BtnIzquierdo.TabIndex = 10;
            this.BtnIzquierdo.UseVisualStyleBackColor = true;
            this.BtnIzquierdo.Click += new System.EventHandler(this.BtnIzquierdo_Click);
            // 
            // PnlBtnDerecho
            // 
            this.PnlBtnDerecho.Controls.Add(this.BtnDerecho);
            this.PnlBtnDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlBtnDerecho.Location = new System.Drawing.Point(1533, 176);
            this.PnlBtnDerecho.Name = "PnlBtnDerecho";
            this.PnlBtnDerecho.Size = new System.Drawing.Size(50, 794);
            this.PnlBtnDerecho.TabIndex = 9;
            this.PnlBtnDerecho.Visible = false;
            // 
            // BtnDerecho
            // 
            this.BtnDerecho.BackgroundImage = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.right_arrow;
            this.BtnDerecho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDerecho.FlatAppearance.BorderSize = 0;
            this.BtnDerecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDerecho.Location = new System.Drawing.Point(0, 0);
            this.BtnDerecho.Name = "BtnDerecho";
            this.BtnDerecho.Size = new System.Drawing.Size(50, 794);
            this.BtnDerecho.TabIndex = 11;
            this.BtnDerecho.UseVisualStyleBackColor = true;
            this.BtnDerecho.Click += new System.EventHandler(this.BtnDerecho_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 20);
            this.toolStripStatusLabel1.Text = "NJSA";
            // 
            // SspMenuPrincipal
            // 
            this.SspMenuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SspMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SspMenuPrincipal.Location = new System.Drawing.Point(0, 944);
            this.SspMenuPrincipal.Name = "SspMenuPrincipal";
            this.SspMenuPrincipal.Size = new System.Drawing.Size(1583, 26);
            this.SspMenuPrincipal.TabIndex = 4;
            this.SspMenuPrincipal.Text = "statusStrip1";
            this.SspMenuPrincipal.Visible = false;
            // 
            // realizarCorteToolStripMenuItem
            // 
            this.realizarCorteToolStripMenuItem.Name = "realizarCorteToolStripMenuItem";
            this.realizarCorteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.realizarCorteToolStripMenuItem.Text = "Realizar corte";
            this.realizarCorteToolStripMenuItem.Click += new System.EventHandler(this.realizarCorteToolStripMenuItem_Click);
            // 
            // DlgMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1583, 970);
            this.Controls.Add(this.PnlCartelera);
            this.Controls.Add(this.PnlBtnDerecho);
            this.Controls.Add(this.PnlBtnIzquierdo);
            this.Controls.Add(this.PnlSuperior);
            this.Controls.Add(this.PnlBotones);
            this.Controls.Add(this.MstPrincipal);
            this.Controls.Add(this.SspMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MstPrincipal;
            this.MaximizeBox = false;
            this.Name = "DlgMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinemax || Punto de venta automático";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DlgMenuPrincipal_Load);
            this.MstPrincipal.ResumeLayout(false);
            this.MstPrincipal.PerformLayout();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBotones.ResumeLayout(false);
            this.PnlSuperior.ResumeLayout(false);
            this.PnlSuperior.PerformLayout();
            this.PnlBtnIzquierdo.ResumeLayout(false);
            this.PnlBtnDerecho.ResumeLayout(false);
            this.SspMenuPrincipal.ResumeLayout(false);
            this.SspMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteleraToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCartelera;
        private System.Windows.Forms.Button BtnFuenteSodas;
        private System.Windows.Forms.Button BtnCompras;
        private System.Windows.Forms.Panel PnlBotones;
        private System.Windows.Forms.Label LblCaja;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Label LblCurrentTime;
        private System.Windows.Forms.Panel PnlSuperior;
        private System.Windows.Forms.Panel PnlCartelera;
        private System.Windows.Forms.Panel PnlBtnIzquierdo;
        private System.Windows.Forms.Button BtnIzquierdo;
        private System.Windows.Forms.Panel PnlBtnDerecho;
        private System.Windows.Forms.Button BtnDerecho;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip SspMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem realizarCorteToolStripMenuItem;
    }
}

