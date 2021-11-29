
namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    partial class PanelAsiento
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
            this.PbxAsiento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxAsiento
            // 
            this.PbxAsiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxAsiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxAsiento.Image = global::SSPP21B_ProyectoFinal_NemesisSIerra.Properties.Resources.Cinema_gray_chair;
            this.PbxAsiento.Location = new System.Drawing.Point(0, 0);
            this.PbxAsiento.Name = "PbxAsiento";
            this.PbxAsiento.Size = new System.Drawing.Size(50, 50);
            this.PbxAsiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxAsiento.TabIndex = 0;
            this.PbxAsiento.TabStop = false;
            this.PbxAsiento.Click += new System.EventHandler(this.PbxAsiento_Click);
            // 
            // PanelAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PbxAsiento);
            this.Name = "PanelAsiento";
            this.Size = new System.Drawing.Size(50, 50);
            ((System.ComponentModel.ISupportInitialize)(this.PbxAsiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxAsiento;
    }
}
