namespace General.GUI.Pedidos
{
    partial class PedidosEdicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgCurrentDetails = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalNumDetalles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnDelDetallePedido = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.btnCreatePedido = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurrentDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1217, 649);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(611, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 643);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgCurrentDetails);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 89);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(603, 554);
            this.panel5.TabIndex = 1;
            // 
            // dtgCurrentDetails
            // 
            this.dtgCurrentDetails.AllowUserToAddRows = false;
            this.dtgCurrentDetails.AllowUserToResizeRows = false;
            this.dtgCurrentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCurrentDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgCurrentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCurrentDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCurrentDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCurrentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurrentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.Cantidad,
            this.IDProducto,
            this.Producto});
            this.dtgCurrentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCurrentDetails.Location = new System.Drawing.Point(10, 10);
            this.dtgCurrentDetails.MultiSelect = false;
            this.dtgCurrentDetails.Name = "dtgCurrentDetails";
            this.dtgCurrentDetails.ReadOnly = true;
            this.dtgCurrentDetails.RowHeadersVisible = false;
            this.dtgCurrentDetails.RowHeadersWidth = 51;
            this.dtgCurrentDetails.RowTemplate.Height = 24;
            this.dtgCurrentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCurrentDetails.Size = new System.Drawing.Size(583, 534);
            this.dtgCurrentDetails.TabIndex = 0;
            // 
            // idDetalle
            // 
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.MinimumWidth = 6;
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // IDProducto
            // 
            this.IDProducto.DataPropertyName = "IDProducto";
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.MinimumWidth = 6;
            this.IDProducto.Name = "IDProducto";
            this.IDProducto.ReadOnly = true;
            this.IDProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnSaveChange);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.btnDelDetallePedido);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(603, 89);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalNumDetalles);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(451, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Productos";
            // 
            // lblTotalNumDetalles
            // 
            this.lblTotalNumDetalles.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumDetalles.Location = new System.Drawing.Point(17, 27);
            this.lblTotalNumDetalles.Name = "lblTotalNumDetalles";
            this.lblTotalNumDetalles.Size = new System.Drawing.Size(125, 33);
            this.lblTotalNumDetalles.TabIndex = 0;
            this.lblTotalNumDetalles.Text = "0";
            this.lblTotalNumDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opciones de Detalle";
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Enabled = false;
            this.btnSaveChange.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.Image = global::General.Properties.Resources.floppy_disk;
            this.btnSaveChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChange.Location = new System.Drawing.Point(296, 32);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(149, 49);
            this.btnSaveChange.TabIndex = 5;
            this.btnSaveChange.Text = "Guardar";
            this.btnSaveChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::General.Properties.Resources.add;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(10, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 49);
            this.button6.TabIndex = 2;
            this.button6.Text = "Agregar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnDelDetallePedido
            // 
            this.btnDelDetallePedido.Enabled = false;
            this.btnDelDetallePedido.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelDetallePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelDetallePedido.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelDetallePedido.Image = global::General.Properties.Resources.delete;
            this.btnDelDetallePedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelDetallePedido.Location = new System.Drawing.Point(159, 32);
            this.btnDelDetallePedido.Name = "btnDelDetallePedido";
            this.btnDelDetallePedido.Size = new System.Drawing.Size(131, 49);
            this.btnDelDetallePedido.TabIndex = 1;
            this.btnDelDetallePedido.Text = "Eliminar";
            this.btnDelDetallePedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelDetallePedido.UseVisualStyleBackColor = true;
            this.btnDelDetallePedido.Click += new System.EventHandler(this.btnDelDetallePedido_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 643);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 554);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxFiltro);
            this.panel3.Controls.Add(this.btnCreatePedido);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 89);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::General.Properties.Resources.edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(145, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Editar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filtrar Resultados";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opciones de Pedido";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(405, 45);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(168, 31);
            this.comboBoxFiltro.TabIndex = 4;
            this.comboBoxFiltro.SelectedValueChanged += new System.EventHandler(this.comboBoxFiltro_SelectedValueChanged);
            // 
            // btnCreatePedido
            // 
            this.btnCreatePedido.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCreatePedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePedido.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePedido.Image = global::General.Properties.Resources.add;
            this.btnCreatePedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePedido.Location = new System.Drawing.Point(9, 34);
            this.btnCreatePedido.Name = "btnCreatePedido";
            this.btnCreatePedido.Size = new System.Drawing.Size(130, 49);
            this.btnCreatePedido.TabIndex = 3;
            this.btnCreatePedido.Text = "Nuevo";
            this.btnCreatePedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatePedido.UseVisualStyleBackColor = true;
            this.btnCreatePedido.Click += new System.EventHandler(this.btnCreatePedido_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::General.Properties.Resources.send_opcion;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(277, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 49);
            this.button4.TabIndex = 0;
            this.button4.Text = "Enviar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PedidosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1217, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PedidosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Pedidos";
            this.Load += new System.EventHandler(this.PedidosEdicion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurrentDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgCurrentDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnDelDetallePedido;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCreatePedido;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalNumDetalles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
    }
}