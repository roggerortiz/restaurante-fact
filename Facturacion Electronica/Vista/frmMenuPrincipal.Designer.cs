namespace Vista
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComprobantes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNumeroMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMesas = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.mnuMesas,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(101, 390);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategorias,
            this.mnuProductos,
            this.mnuClientes,
            this.mnuComprobantes});
            this.mantenedoresToolStripMenuItem.Image = global::Vista.Properties.Resources.mantenedores;
            this.mantenedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(88, 89);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            this.mantenedoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCategorias
            // 
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(153, 22);
            this.menuCategorias.Text = "Categorías";
            // 
            // mnuProductos
            // 
            this.mnuProductos.Name = "mnuProductos";
            this.mnuProductos.Size = new System.Drawing.Size(153, 22);
            this.mnuProductos.Text = "Productos";
            this.mnuProductos.Click += new System.EventHandler(this.mnuProductos_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(153, 22);
            this.mnuClientes.Text = "Clientes";
            // 
            // mnuComprobantes
            // 
            this.mnuComprobantes.Name = "mnuComprobantes";
            this.mnuComprobantes.Size = new System.Drawing.Size(153, 22);
            this.mnuComprobantes.Text = "Comprobantes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNumeroMesas,
            this.mnuUsuarios});
            this.sistemaToolStripMenuItem.Image = global::Vista.Properties.Resources.sistema;
            this.sistemaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(88, 89);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuNumeroMesas
            // 
            this.mnuNumeroMesas.Name = "mnuNumeroMesas";
            this.mnuNumeroMesas.Size = new System.Drawing.Size(119, 22);
            this.mnuNumeroMesas.Text = "Mesas";
            this.mnuNumeroMesas.Click += new System.EventHandler(this.mnuNumeroMesas_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(119, 22);
            this.mnuUsuarios.Text = "Usuarios";
            // 
            // mnuMesas
            // 
            this.mnuMesas.Image = global::Vista.Properties.Resources.mesas;
            this.mnuMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMesas.Name = "mnuMesas";
            this.mnuMesas.Size = new System.Drawing.Size(88, 89);
            this.mnuMesas.Text = "Mesas";
            this.mnuMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuMesas.Click += new System.EventHandler(this.mnuMesas_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Image = global::Vista.Properties.Resources.salir;
            this.mnuSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(88, 89);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // panelMesas
            // 
            this.panelMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesas.Location = new System.Drawing.Point(101, 0);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(556, 390);
            this.panelMesas.TabIndex = 2;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.Controls.Add(this.panelMesas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = ".: RESTAURANTE :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuComprobantes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMesas;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuNumeroMesas;
        private System.Windows.Forms.Panel panelMesas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}