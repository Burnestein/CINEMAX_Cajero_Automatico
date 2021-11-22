
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
            this.SuspendLayout();
            // 
            // LblTuCanasta
            // 
            this.LblTuCanasta.AutoSize = true;
            this.LblTuCanasta.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuCanasta.Location = new System.Drawing.Point(76, 53);
            this.LblTuCanasta.Name = "LblTuCanasta";
            this.LblTuCanasta.Size = new System.Drawing.Size(245, 52);
            this.LblTuCanasta.TabIndex = 0;
            this.LblTuCanasta.Text = "Tu Canasta";
            // 
            // RtbListaCompras
            // 
            this.RtbListaCompras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RtbListaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbListaCompras.Cursor = System.Windows.Forms.Cursors.Default;
            this.RtbListaCompras.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbListaCompras.Location = new System.Drawing.Point(85, 140);
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
            this.BtnPagar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnPagar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
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
            // 
            // PanelCanastaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.RtbListaCompras);
            this.Controls.Add(this.LblTuCanasta);
            this.Name = "PanelCanastaCompras";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.PanelCanastaCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTuCanasta;
        private System.Windows.Forms.RichTextBox RtbListaCompras;
        private System.Windows.Forms.Button BtnPagar;
    }
}
