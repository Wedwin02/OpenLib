namespace General.GUI.Pedidos
{
    partial class ItemPedido
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.imgEstado = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.78022F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.21978F));
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProveedor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalProductos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaEmision, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(133, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.63415F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.36585F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 120);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.onClickShowDetails);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEstado.Location = new System.Drawing.Point(10, 10);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(247, 40);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Finalizado";
            this.lblEstado.Click += new System.EventHandler(this.onClickShowDetails);
            this.lblEstado.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.lblEstado.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // lblProveedor
            // 
            this.lblProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProveedor.Location = new System.Drawing.Point(5, 65);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(5);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(257, 22);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor | DIDATA";
            this.lblProveedor.Click += new System.EventHandler(this.onClickShowDetails);
            this.lblProveedor.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.lblProveedor.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalProductos.Location = new System.Drawing.Point(5, 97);
            this.lblTotalProductos.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(257, 18);
            this.lblTotalProductos.TabIndex = 4;
            this.lblTotalProductos.Text = "23 Productos Solicitados";
            this.lblTotalProductos.Click += new System.EventHandler(this.onClickShowDetails);
            this.lblTotalProductos.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.lblTotalProductos.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFechaEmision.Location = new System.Drawing.Point(272, 5);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(5);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(170, 50);
            this.lblFechaEmision.TabIndex = 2;
            this.lblFechaEmision.Text = "Emision: 20/12/2020";
            this.lblFechaEmision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaEmision.Click += new System.EventHandler(this.onClickShowDetails);
            this.lblFechaEmision.MouseEnter += new System.EventHandler(this.tableLayoutPanel1_MouseEnter);
            this.lblFechaEmision.MouseLeave += new System.EventHandler(this.tableLayoutPanel1_MouseLeave);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.tableLayoutPanel1);
            this.panelContainer.Controls.Add(this.imgEstado);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelContainer.Size = new System.Drawing.Size(585, 130);
            this.panelContainer.TabIndex = 0;
            // 
            // imgEstado
            // 
            this.imgEstado.BackColor = System.Drawing.Color.Silver;
            this.imgEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgEstado.Image = global::General.Properties.Resources.send_pedido_redi;
            this.imgEstado.Location = new System.Drawing.Point(5, 5);
            this.imgEstado.Margin = new System.Windows.Forms.Padding(10);
            this.imgEstado.Name = "imgEstado";
            this.imgEstado.Size = new System.Drawing.Size(128, 120);
            this.imgEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEstado.TabIndex = 0;
            this.imgEstado.TabStop = false;
            this.imgEstado.Click += new System.EventHandler(this.onClickShowDetails);
            // 
            // ItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelContainer);
            this.Name = "ItemPedido";
            this.Size = new System.Drawing.Size(585, 130);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox imgEstado;
    }
}
