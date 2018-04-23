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
            this.msIzquierda = new System.Windows.Forms.MenuStrip();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.mnuMantenedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComprobantes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNumeroMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msIzquierda.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIzquierda
            // 
            this.msIzquierda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.msIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.msIzquierda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenedores,
            this.mnuSistema,
            this.mnuMesas,
            this.mnuSalir});
            this.msIzquierda.Location = new System.Drawing.Point(0, 0);
            this.msIzquierda.Name = "msIzquierda";
            this.msIzquierda.Size = new System.Drawing.Size(101, 390);
            this.msIzquierda.TabIndex = 0;
            this.msIzquierda.Text = "menuStrip1";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(101, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(556, 390);
            this.panelPrincipal.TabIndex = 2;
            // 
            // mnuMantenedores
            // 
            this.mnuMantenedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCategorias,
            this.mnuProductos,
            this.mnuClientes,
            this.mnuComprobantes});
            this.mnuMantenedores.Image = global::Vista.Properties.Resources.mantenedores;
            this.mnuMantenedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMantenedores.Name = "mnuMantenedores";
            this.mnuMantenedores.Size = new System.Drawing.Size(88, 89);
            this.mnuMantenedores.Text = "Mantenedores";
            this.mnuMantenedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuComprobantes
            // 
            this.mnuComprobantes.Name = "mnuComprobantes";
            this.mnuComprobantes.Size = new System.Drawing.Size(153, 22);
            this.mnuComprobantes.Text = "Comprobantes";
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNumeroMesas,
            this.mnuUsuarios});
            this.mnuSistema.Image = global::Vista.Properties.Resources.sistema;
            this.mnuSistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(88, 89);
            this.mnuSistema.Text = "Sistema";
            this.mnuSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuNumeroMesas
            // 
            this.mnuNumeroMesas.Name = "mnuNumeroMesas";
            this.mnuNumeroMesas.Size = new System.Drawing.Size(152, 22);
            this.mnuNumeroMesas.Text = "Mesas";
            this.mnuNumeroMesas.Click += new System.EventHandler(this.mnuNumeroMesas_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(152, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.msIzquierda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzquierda;
            this.Name = "frmMenuPrincipal";
            this.Text = ".: RESTAURANTE :.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.msIzquierda.ResumeLayout(false);
            this.msIzquierda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzquierda;
        private System.Windows.Forms.ToolStripMenuItem mnuProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuComprobantes;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuMesas;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenedores;
        private System.Windows.Forms.ToolStripMenuItem menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuNumeroMesas;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}