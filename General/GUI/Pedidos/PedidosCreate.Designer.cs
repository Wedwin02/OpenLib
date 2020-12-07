namespace General.GUI.Pedidos
{
    partial class PedidosCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosCreate));
            this.btnConfirmCreatePedido = new System.Windows.Forms.Button();
            this.btnCancelConfirmPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProviders = new System.Windows.Forms.ComboBox();
            this.datepckFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmCreatePedido
            // 
            this.btnConfirmCreatePedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCreatePedido.Image = global::General.Properties.Resources.done;
            this.btnConfirmCreatePedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmCreatePedido.Location = new System.Drawing.Point(71, 250);
            this.btnConfirmCreatePedido.Name = "btnConfirmCreatePedido";
            this.btnConfirmCreatePedido.Size = new System.Drawing.Size(163, 48);
            this.btnConfirmCreatePedido.TabIndex = 0;
            this.btnConfirmCreatePedido.Text = "Aceptar";
            this.btnConfirmCreatePedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmCreatePedido.UseVisualStyleBackColor = true;
            this.btnConfirmCreatePedido.Click += new System.EventHandler(this.btnConfirmCreatePedido_Click);
            // 
            // btnCancelConfirmPedido
            // 
            this.btnCancelConfirmPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelConfirmPedido.Image = global::General.Properties.Resources.cancel;
            this.btnCancelConfirmPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelConfirmPedido.Location = new System.Drawing.Point(240, 250);
            this.btnCancelConfirmPedido.Name = "btnCancelConfirmPedido";
            this.btnCancelConfirmPedido.Size = new System.Drawing.Size(170, 48);
            this.btnCancelConfirmPedido.TabIndex = 1;
            this.btnCancelConfirmPedido.Text = "Cancelar";
            this.btnCancelConfirmPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelConfirmPedido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecionar Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Estimada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Emision";
            // 
            // comboProviders
            // 
            this.comboProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProviders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProviders.FormattingEnabled = true;
            this.comboProviders.Location = new System.Drawing.Point(68, 51);
            this.comboProviders.Name = "comboProviders";
            this.comboProviders.Size = new System.Drawing.Size(342, 31);
            this.comboProviders.TabIndex = 5;
            // 
            // datepckFechaEstimada
            // 
            this.datepckFechaEstimada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepckFechaEstimada.Location = new System.Drawing.Point(71, 126);
            this.datepckFechaEstimada.Name = "datepckFechaEstimada";
            this.datepckFechaEstimada.Size = new System.Drawing.Size(339, 32);
            this.datepckFechaEstimada.TabIndex = 6;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.Location = new System.Drawing.Point(68, 206);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(270, 23);
            this.lblFechaEmision.TabIndex = 7;
            this.lblFechaEmision.Text = "dd/MM/yyyy";
            // 
            // PedidosCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 310);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.datepckFechaEstimada);
            this.Controls.Add(this.comboProviders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelConfirmPedido);
            this.Controls.Add(this.btnConfirmCreatePedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidosCreate";
            this.Text = "Crear pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmCreatePedido;
        private System.Windows.Forms.Button btnCancelConfirmPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProviders;
        private System.Windows.Forms.DateTimePicker datepckFechaEstimada;
        private System.Windows.Forms.Label lblFechaEmision;
    }
}