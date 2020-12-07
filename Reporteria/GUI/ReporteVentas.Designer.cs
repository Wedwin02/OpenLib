namespace Reporteria.GUI
{
    partial class ReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentas));
            this.crvVentas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVentas
            // 
            this.crvVentas.ActiveViewIndex = -1;
            this.crvVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVentas.Location = new System.Drawing.Point(0, 0);
            this.crvVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crvVentas.Name = "crvVentas";
            this.crvVentas.Size = new System.Drawing.Size(1116, 608);
            this.crvVentas.TabIndex = 0;
            this.crvVentas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.crvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVentas;
    }
}