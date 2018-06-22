namespace FormCorreo
{
    partial class FrmPpal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxEstados = new System.Windows.Forms.GroupBox();
            this.listBoxEstadoEntregado = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.listBoxEstadoIngresado = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBoxEstados.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEstados
            // 
            this.groupBoxEstados.Controls.Add(this.listBoxEstadoEntregado);
            this.groupBoxEstados.Controls.Add(this.listBoxEstadoEnViaje);
            this.groupBoxEstados.Controls.Add(this.listBoxEstadoIngresado);
            this.groupBoxEstados.Controls.Add(this.label3);
            this.groupBoxEstados.Controls.Add(this.label2);
            this.groupBoxEstados.Controls.Add(this.label1);
            this.groupBoxEstados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEstados.Name = "groupBoxEstados";
            this.groupBoxEstados.Size = new System.Drawing.Size(630, 241);
            this.groupBoxEstados.TabIndex = 0;
            this.groupBoxEstados.TabStop = false;
            this.groupBoxEstados.Text = "Estados Paquetes";
            // 
            // listBoxEstadoEntregado
            // 
            this.listBoxEstadoEntregado.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxEstadoEntregado.FormattingEnabled = true;
            this.listBoxEstadoEntregado.Location = new System.Drawing.Point(437, 55);
            this.listBoxEstadoEntregado.Name = "listBoxEstadoEntregado";
            this.listBoxEstadoEntregado.Size = new System.Drawing.Size(187, 186);
            this.listBoxEstadoEntregado.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar...";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // listBoxEstadoEnViaje
            // 
            this.listBoxEstadoEnViaje.FormattingEnabled = true;
            this.listBoxEstadoEnViaje.Location = new System.Drawing.Point(220, 55);
            this.listBoxEstadoEnViaje.Name = "listBoxEstadoEnViaje";
            this.listBoxEstadoEnViaje.Size = new System.Drawing.Size(187, 186);
            this.listBoxEstadoEnViaje.TabIndex = 15;
            // 
            // listBoxEstadoIngresado
            // 
            this.listBoxEstadoIngresado.FormattingEnabled = true;
            this.listBoxEstadoIngresado.Location = new System.Drawing.Point(6, 54);
            this.listBoxEstadoIngresado.Name = "listBoxEstadoIngresado";
            this.listBoxEstadoIngresado.Size = new System.Drawing.Size(187, 186);
            this.listBoxEstadoIngresado.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Entregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "En Viaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresado";
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.mtxtTrackingID);
            this.groupBoxPaquete.Controls.Add(this.btnMostrarTodos);
            this.groupBoxPaquete.Controls.Add(this.btnAgregar);
            this.groupBoxPaquete.Controls.Add(this.txtDireccion);
            this.groupBoxPaquete.Controls.Add(this.label5);
            this.groupBoxPaquete.Controls.Add(this.label4);
            this.groupBoxPaquete.Location = new System.Drawing.Point(329, 259);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(313, 128);
            this.groupBoxPaquete.TabIndex = 1;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquete";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(9, 43);
            this.mtxtTrackingID.Mask = "000-00-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(153, 20);
            this.mtxtTrackingID.TabIndex = 1;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(181, 72);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(106, 39);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(181, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 39);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(9, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(153, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tracking ID";
            // 
            // richTxtMostrar
            // 
            this.richTxtMostrar.Enabled = false;
            this.richTxtMostrar.Location = new System.Drawing.Point(12, 265);
            this.richTxtMostrar.Name = "richTxtMostrar";
            this.richTxtMostrar.ReadOnly = true;
            this.richTxtMostrar.Size = new System.Drawing.Size(311, 120);
            this.richTxtMostrar.TabIndex = 17;
            this.richTxtMostrar.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 397);
            this.Controls.Add(this.richTxtMostrar);
            this.Controls.Add(this.groupBoxPaquete);
            this.Controls.Add(this.groupBoxEstados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Moreno.Samantha.2A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPpal_FormClosing);
            this.groupBoxEstados.ResumeLayout(false);
            this.groupBoxEstados.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstados;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ListBox listBoxEstadoEntregado;
        private System.Windows.Forms.ListBox listBoxEstadoEnViaje;
        private System.Windows.Forms.ListBox listBoxEstadoIngresado;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.RichTextBox richTxtMostrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

