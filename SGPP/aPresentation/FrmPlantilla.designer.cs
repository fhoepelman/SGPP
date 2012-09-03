namespace SCP
{
    partial class FrmPlantilla
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
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.tbControlPrincipal = new System.Windows.Forms.TabControl();
            this.tbpMaestro = new System.Windows.Forms.TabPage();
            this.toolStripPrincipal.SuspendLayout();
            this.tbControlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.toolStripSeparator2,
            this.btnCancelar,
            this.btnImprimir,
            this.btnBuscar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(875, 25);
            this.toolStripPrincipal.TabIndex = 1;
            this.toolStripPrincipal.Text = "Barra De Botones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::SCP.Properties.Resources.add;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo Registro";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::SCP.Properties.Resources.save;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.ToolTipText = "Guardar Registro";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::SCP.Properties.Resources.Edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 22);
            this.btnEditar.Text = "Editar ";
            this.btnEditar.ToolTipText = "Editar Registro";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SCP.Properties.Resources.Cancel;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTipText = "Cancelar Registro";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::SCP.Properties.Resources.Imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SCP.Properties.Resources.Buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.ToolTipText = "Buscar Registro";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::SCP.Properties.Resources.Delete;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.ToolTipText = "Eliminar Registro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::SCP.Properties.Resources.door_in;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbControlPrincipal
            // 
            this.tbControlPrincipal.Controls.Add(this.tbpMaestro);
            this.tbControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.tbControlPrincipal.Name = "tbControlPrincipal";
            this.tbControlPrincipal.SelectedIndex = 0;
            this.tbControlPrincipal.Size = new System.Drawing.Size(875, 416);
            this.tbControlPrincipal.TabIndex = 2;
            // 
            // tbpMaestro
            // 
            this.tbpMaestro.Location = new System.Drawing.Point(4, 22);
            this.tbpMaestro.Name = "tbpMaestro";
            this.tbpMaestro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMaestro.Size = new System.Drawing.Size(867, 390);
            this.tbpMaestro.TabIndex = 0;
            this.tbpMaestro.Text = "tbpMaestro";
            this.tbpMaestro.UseVisualStyleBackColor = true;
            // 
            // FrmPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 441);
            this.Controls.Add(this.tbControlPrincipal);
            this.Controls.Add(this.toolStripPrincipal);
            this.Name = "FrmPlantilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plantilla";
            this.Load += new System.EventHandler(this.FrmPlantilla_Load);
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.tbControlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        protected System.Windows.Forms.TabControl tbControlPrincipal;
        protected System.Windows.Forms.TabPage tbpMaestro;
        protected System.Windows.Forms.ToolStripButton btnNuevo;
        protected System.Windows.Forms.ToolStrip toolStripPrincipal;
        protected System.Windows.Forms.ToolStripButton btnGuardar;
        protected System.Windows.Forms.ToolStripButton btnEditar;
        protected System.Windows.Forms.ToolStripButton btnCancelar;
        protected System.Windows.Forms.ToolStripButton btnEliminar;
        protected System.Windows.Forms.ToolStripButton btnImprimir;
        protected System.Windows.Forms.ToolStripButton btnBuscar;

    }
}

