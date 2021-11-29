
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class PanelCanastaCompras
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
            this.LblTuCanasta = new System.Windows.Forms.Label();
            this.RtbListaCompras = new System.Windows.Forms.RichTextBox();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.PnlFormaPago = new System.Windows.Forms.Panel();
            this.BtnTarjeta = new System.Windows.Forms.Button();
            this.BtnEfectivo = new System.Windows.Forms.Button();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.LblGracias = new System.Windows.Forms.Label();
            this.LblDisfrute = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PnlFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTuCanasta
            // 
            this.LblTuCanasta.AutoSize = true;
            this.LblTuCanasta.BackColor = System.Drawing.Color.Transparent;
            this.LblTuCanasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuCanasta.Location = new System.Drawing.Point(76, 53);
            this.LblTuCanasta.Name = "LblTuCanasta";
            this.LblTuCanasta.Size = new System.Drawing.Size(245, 52);
            this.LblTuCanasta.TabIndex = 0;
            this.LblTuCanasta.Text = "Tu Canasta";
            // 
            // RtbListaCompras
            // 
            this.RtbListaCompras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RtbListaCompras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RtbListaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbListaCompras.Cursor = System.Windows.Forms.Cursors.Default;
            this.RtbListaCompras.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbListaCompras.Location = new System.Drawing.Point(85, 149);
            this.RtbListaCompras.Name = "RtbListaCompras";
            this.RtbListaCompras.ReadOnly = true;
            this.RtbListaCompras.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RtbListaCompras.Size = new System.Drawing.Size(682, 386);
            this.RtbListaCompras.TabIndex = 1;
            this.RtbListaCompras.Text = "";
            // 
            // BtnPagar
            // 
            this.BtnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPagar.BackColor = System.Drawing.Color.Khaki;
            this.BtnPagar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnPagar.FlatAppearance.BorderSize = 5;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnPagar.Location = new System.Drawing.Point(1046, 714);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(131, 66);
            this.BtnPagar.TabIndex = 18;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Visible = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // PnlFormaPago
            // 
            this.PnlFormaPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.PnlFormaPago.Controls.Add(this.BtnTarjeta);
            this.PnlFormaPago.Controls.Add(this.BtnEfectivo);
            this.PnlFormaPago.Controls.Add(this.LblFormaPago);
            this.PnlFormaPago.Location = new System.Drawing.Point(368, 389);
            this.PnlFormaPago.Name = "PnlFormaPago";
            this.PnlFormaPago.Size = new System.Drawing.Size(467, 158);
            this.PnlFormaPago.TabIndex = 19;
            this.PnlFormaPago.Visible = false;
            // 
            // BtnTarjeta
            // 
            this.BtnTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTarjeta.BackColor = System.Drawing.Color.Khaki;
            this.BtnTarjeta.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnTarjeta.FlatAppearance.BorderSize = 5;
            this.BtnTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarjeta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnTarjeta.Location = new System.Drawing.Point(244, 79);
            this.BtnTarjeta.Name = "BtnTarjeta";
            this.BtnTarjeta.Size = new System.Drawing.Size(213, 53);
            this.BtnTarjeta.TabIndex = 20;
            this.BtnTarjeta.Text = "Tarjeta";
            this.BtnTarjeta.UseVisualStyleBackColor = false;
            this.BtnTarjeta.Click += new System.EventHandler(this.BtnTarjeta_Click);
            // 
            // BtnEfectivo
            // 
            this.BtnEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEfectivo.BackColor = System.Drawing.Color.Khaki;
            this.BtnEfectivo.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BtnEfectivo.FlatAppearance.BorderSize = 5;
            this.BtnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEfectivo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnEfectivo.Location = new System.Drawing.Point(19, 79);
            this.BtnEfectivo.Name = "BtnEfectivo";
            this.BtnEfectivo.Size = new System.Drawing.Size(213, 53);
            this.BtnEfectivo.TabIndex = 19;
            this.BtnEfectivo.Text = "Efectivo";
            this.BtnEfectivo.UseVisualStyleBackColor = false;
            this.BtnEfectivo.Click += new System.EventHandler(this.BtnEfectivo_Click);
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormaPago.ForeColor = System.Drawing.Color.White;
            this.LblFormaPago.Location = new System.Drawing.Point(123, 23);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(230, 37);
            this.LblFormaPago.TabIndex = 0;
            this.LblFormaPago.Text = "Forma de pago";
            // 
            // LblGracias
            // 
            this.LblGracias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblGracias.AutoSize = true;
            this.LblGracias.BackColor = System.Drawing.Color.Transparent;
            this.LblGracias.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGracias.Location = new System.Drawing.Point(100, 95);
            this.LblGracias.Name = "LblGracias";
            this.LblGracias.Size = new System.Drawing.Size(1001, 106);
            this.LblGracias.TabIndex = 20;
            this.LblGracias.Text = "¡Gracias por su compra!";
            this.LblGracias.Visible = false;
            // 
            // LblDisfrute
            // 
            this.LblDisfrute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDisfrute.AutoSize = true;
            this.LblDisfrute.BackColor = System.Drawing.Color.Transparent;
            this.LblDisfrute.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisfrute.Location = new System.Drawing.Point(204, 629);
            this.LblDisfrute.Name = "LblDisfrute";
            this.LblDisfrute.Size = new System.Drawing.Size(793, 106);
            this.LblDisfrute.TabIndex = 21;
            this.LblDisfrute.Text = "Disfrute la función";
            this.LblDisfrute.Visible = false;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(518, 659);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(163, 52);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "Total $";
            this.LblTotal.TextChanged += new System.EventHandler(this.LblTotal_TextChanged);
            // 
            // PanelCanastaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LblGracias);
            this.Controls.Add(this.PnlFormaPago);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblDisfrute);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.RtbListaCompras);
            this.Controls.Add(this.LblTuCanasta);
            this.Name = "PanelCanastaCompras";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.PanelCanastaCompras_Load);
            this.PnlFormaPago.ResumeLayout(false);
            this.PnlFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTuCanasta;
        private System.Windows.Forms.RichTextBox RtbListaCompras;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Panel PnlFormaPago;
        private System.Windows.Forms.Button BtnTarjeta;
        private System.Windows.Forms.Button BtnEfectivo;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.Label LblGracias;
        private System.Windows.Forms.Label LblDisfrute;
        private System.Windows.Forms.Label LblTotal;
    }
}
