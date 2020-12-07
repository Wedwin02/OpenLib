namespace General.GUI.Recordatorios
{
    partial class RecordatorioGestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordatorioGestiones));
            this.dtgRecordatorios = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrevFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDRecordatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecordatorios)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgRecordatorios
            // 
            this.dtgRecordatorios.AllowUserToAddRows = false;
            this.dtgRecordatorios.AllowUserToDeleteRows = false;
            this.dtgRecordatorios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dtgRecordatorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRecordatorios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgRecordatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecordatorios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgRecordatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecordatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.FechaCreacion,
            this.FechaPrevFin,
            this.Descripcion,
            this.Prioridad,
            this.EstadoActividad,
            this.IDRecordatorio});
            this.dtgRecordatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecordatorios.GridColor = System.Drawing.SystemColors.Control;
            this.dtgRecordatorios.Location = new System.Drawing.Point(0, 32);
            this.dtgRecordatorios.Name = "dtgRecordatorios";
            this.dtgRecordatorios.ReadOnly = true;
            this.dtgRecordatorios.RowHeadersVisible = false;
            this.dtgRecordatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecordatorios.Size = new System.Drawing.Size(801, 234);
            this.dtgRecordatorios.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 150;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "F. de creacion";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // FechaPrevFin
            // 
            this.FechaPrevFin.DataPropertyName = "FechaPrevFin";
            this.FechaPrevFin.HeaderText = "F. de Finalizacion";
            this.FechaPrevFin.Name = "FechaPrevFin";
            this.FechaPrevFin.ReadOnly = true;
            this.FechaPrevFin.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Prioridad
            // 
            this.Prioridad.DataPropertyName = "Prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            this.Prioridad.Width = 75;
            // 
            // EstadoActividad
            // 
            this.EstadoActividad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EstadoActividad.DataPropertyName = "EstadoActividad";
            this.EstadoActividad.HeaderText = "Estado ";
            this.EstadoActividad.Name = "EstadoActividad";
            this.EstadoActividad.ReadOnly = true;
            // 
            // IDRecordatorio
            // 
            this.IDRecordatorio.DataPropertyName = "IDRecordatorio";
            this.IDRecordatorio.HeaderText = "IDRecordatorio";
            this.IDRecordatorio.Name = "IDRecordatorio";
            this.IDRecordatorio.ReadOnly = true;
            this.IDRecordatorio.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.toolStripSeparator1,
            this.btnEditar,
            this.toolStripSeparator2,
            this.btnEliminar,
            this.txbFiltro,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.btnFinalizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::General.Properties.Resources.add;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 29);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::General.Properties.Resources.edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(74, 29);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::General.Properties.Resources.delete;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 29);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(150, 32);
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = global::General.Properties.Resources.lupa;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 29);
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Image = global::General.Properties.Resources.done;
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(155, 29);
            this.btnFinalizar.Text = "Finalizar actividad";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(194, 17);
            this.lblEstado.Text = "0 Recordatorios Encontrados";
            // 
            // RecordatorioGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 288);
            this.Controls.Add(this.dtgRecordatorios);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordatorioGestiones";
            this.Text = "Gestion de Recordatorio";
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecordatorios)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRecordatorios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrevFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRecordatorio;
    }
}