namespace Vista
{
    partial class frmClientes
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazSoc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(377, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(296, 216);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(93, 216);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 216);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.txtRazonSocial);
            this.groupBoxProducto.Controls.Add(this.txtRUC);
            this.groupBoxProducto.Controls.Add(this.txtTelefono);
            this.groupBoxProducto.Controls.Add(this.label8);
            this.groupBoxProducto.Controls.Add(this.txtDireccion);
            this.groupBoxProducto.Controls.Add(this.label6);
            this.groupBoxProducto.Controls.Add(this.txtApellidos);
            this.groupBoxProducto.Controls.Add(this.lblApellido);
            this.groupBoxProducto.Controls.Add(this.txtDNI);
            this.groupBoxProducto.Controls.Add(this.lblDoc);
            this.groupBoxProducto.Controls.Add(this.txtCorreo);
            this.groupBoxProducto.Controls.Add(this.txtNombres);
            this.groupBoxProducto.Controls.Add(this.label2);
            this.groupBoxProducto.Controls.Add(this.lblRazSoc);
            this.groupBoxProducto.Controls.Add(this.txtID);
            this.groupBoxProducto.Location = new System.Drawing.Point(12, 41);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(440, 169);
            this.groupBoxProducto.TabIndex = 15;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Datos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(83, 130);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(108, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Teléfono: ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(83, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(341, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dirección: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(289, 59);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(134, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(228, 62);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(55, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellidos: ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(83, 27);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(108, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(19, 30);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(32, 13);
            this.lblDoc.TabIndex = 12;
            this.lblDoc.Text = "DNI: ";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(252, 130);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(171, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(83, 59);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(134, 20);
            this.txtNombres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correo: ";
            // 
            // lblRazSoc
            // 
            this.lblRazSoc.AutoSize = true;
            this.lblRazSoc.Location = new System.Drawing.Point(18, 62);
            this.lblRazSoc.Name = "lblRazSoc";
            this.lblRazSoc.Size = new System.Drawing.Size(54, 13);
            this.lblRazSoc.TabIndex = 1;
            this.lblRazSoc.Text = "Raz, Soc.";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 21;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 245);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(440, 193);
            this.dgvClientes.TabIndex = 14;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(83, 27);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(108, 20);
            this.txtRUC.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(82, 59);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(341, 20);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Persona: ";
            // 
            // cboPersona
            // 
            this.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Items.AddRange(new object[] {
            "Natural",
            "Jurídica"});
            this.cboPersona.Location = new System.Drawing.Point(77, 12);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(126, 21);
            this.cboPersona.TabIndex = 0;
            this.cboPersona.SelectedIndexChanged += new System.EventHandler(this.cboPersona_SelectedIndexChanged);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRazSoc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label label4;
    }
}