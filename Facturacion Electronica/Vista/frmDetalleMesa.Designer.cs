namespace Vista
{
    partial class frmDetalleMesa
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
            this.gbCategorias = new System.Windows.Forms.GroupBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panelIzquierdo = new System.Windows.Forms.TableLayoutPanel();
            this.panelDerecho = new System.Windows.Forms.TableLayoutPanel();
            this.panelDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotonesDeta = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotal = new System.Windows.Forms.TableLayoutPanel();
            this.gbDetalleMesa = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.panelBotonesDeta.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.gbDetalleMesa.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategorias
            // 
            this.gbCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategorias.Location = new System.Drawing.Point(3, 49);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(399, 168);
            this.gbCategorias.TabIndex = 0;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "CATEGORÍAS";
            // 
            // gbProductos
            // 
            this.gbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(3, 223);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(399, 357);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "PRODUCTOS";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.Location = new System.Drawing.Point(3, 3);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(848, 512);
            this.dgvDetalles.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total: S/.";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(718, 10);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(10, 10, 1, 10);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(131, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(10, 10);
            this.btnAumentar.Margin = new System.Windows.Forms.Padding(10);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(69, 56);
            this.btnAumentar.TabIndex = 16;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(10, 86);
            this.btnDisminuir.Margin = new System.Windows.Forms.Padding(10);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(69, 56);
            this.btnDisminuir.TabIndex = 17;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(10, 162);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(10);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(69, 56);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Text = "x";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(10, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 33);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(199, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(169, 33);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(388, 10);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(10);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(169, 33);
            this.btnPagar.TabIndex = 21;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.panelPrincipal.ColumnCount = 2;
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelPrincipal.Controls.Add(this.panelDerecho, 1, 0);
            this.panelPrincipal.Controls.Add(this.panelIzquierdo, 0, 0);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(3, 25);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.RowCount = 1;
            this.panelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPrincipal.Size = new System.Drawing.Size(1372, 589);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.SystemColors.Control;
            this.panelIzquierdo.ColumnCount = 1;
            this.panelIzquierdo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelIzquierdo.Controls.Add(this.gbUsuario, 0, 0);
            this.panelIzquierdo.Controls.Add(this.gbProductos, 0, 2);
            this.panelIzquierdo.Controls.Add(this.gbCategorias, 0, 1);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzquierdo.Location = new System.Drawing.Point(3, 3);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.RowCount = 3;
            this.panelIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.panelIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelIzquierdo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.panelIzquierdo.Size = new System.Drawing.Size(405, 583);
            this.panelIzquierdo.TabIndex = 2;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.SystemColors.Control;
            this.panelDerecho.ColumnCount = 1;
            this.panelDerecho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDerecho.Controls.Add(this.panelTotal, 0, 1);
            this.panelDerecho.Controls.Add(this.panelDetalles, 0, 0);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerecho.Location = new System.Drawing.Point(414, 3);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.RowCount = 2;
            this.panelDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelDerecho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelDerecho.Size = new System.Drawing.Size(955, 583);
            this.panelDerecho.TabIndex = 2;
            // 
            // panelDetalles
            // 
            this.panelDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.panelDetalles.ColumnCount = 2;
            this.panelDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelDetalles.Controls.Add(this.panelBotonesDeta, 1, 0);
            this.panelDetalles.Controls.Add(this.dgvDetalles, 0, 0);
            this.panelDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalles.Location = new System.Drawing.Point(3, 3);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.RowCount = 1;
            this.panelDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDetalles.Size = new System.Drawing.Size(949, 518);
            this.panelDetalles.TabIndex = 2;
            // 
            // panelBotonesDeta
            // 
            this.panelBotonesDeta.BackColor = System.Drawing.SystemColors.Control;
            this.panelBotonesDeta.ColumnCount = 1;
            this.panelBotonesDeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBotonesDeta.Controls.Add(this.btnAumentar, 0, 0);
            this.panelBotonesDeta.Controls.Add(this.btnDisminuir, 0, 1);
            this.panelBotonesDeta.Controls.Add(this.btnQuitar, 0, 2);
            this.panelBotonesDeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotonesDeta.Location = new System.Drawing.Point(857, 3);
            this.panelBotonesDeta.Name = "panelBotonesDeta";
            this.panelBotonesDeta.RowCount = 4;
            this.panelBotonesDeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelBotonesDeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelBotonesDeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelBotonesDeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.panelBotonesDeta.Size = new System.Drawing.Size(89, 512);
            this.panelBotonesDeta.TabIndex = 3;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotal.ColumnCount = 7;
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelTotal.Controls.Add(this.txtTotal, 5, 0);
            this.panelTotal.Controls.Add(this.label8, 4, 0);
            this.panelTotal.Controls.Add(this.btnPagar, 2, 0);
            this.panelTotal.Controls.Add(this.btnCancelar, 0, 0);
            this.panelTotal.Controls.Add(this.btnGuardar, 1, 0);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotal.Location = new System.Drawing.Point(3, 527);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.RowCount = 1;
            this.panelTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTotal.Size = new System.Drawing.Size(949, 53);
            this.panelTotal.TabIndex = 4;
            // 
            // gbDetalleMesa
            // 
            this.gbDetalleMesa.BackColor = System.Drawing.SystemColors.Control;
            this.gbDetalleMesa.Controls.Add(this.panelPrincipal);
            this.gbDetalleMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetalleMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleMesa.Location = new System.Drawing.Point(0, 0);
            this.gbDetalleMesa.Name = "gbDetalleMesa";
            this.gbDetalleMesa.Size = new System.Drawing.Size(1378, 617);
            this.gbDetalleMesa.TabIndex = 2;
            this.gbDetalleMesa.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(3, 16);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(393, 26);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Visible = false;
            // 
            // gbUsuario
            // 
            this.gbUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.Location = new System.Drawing.Point(3, 3);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(399, 40);
            this.gbUsuario.TabIndex = 4;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Mozo";
            // 
            // frmDetalleMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1378, 617);
            this.Controls.Add(this.gbDetalleMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDetalleMesa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleMesa";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDetalleMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelIzquierdo.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            this.panelDetalles.ResumeLayout(false);
            this.panelBotonesDeta.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.gbDetalleMesa.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategorias;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TableLayoutPanel panelPrincipal;
        private System.Windows.Forms.TableLayoutPanel panelDerecho;
        private System.Windows.Forms.TableLayoutPanel panelIzquierdo;
        private System.Windows.Forms.TableLayoutPanel panelDetalles;
        private System.Windows.Forms.TableLayoutPanel panelBotonesDeta;
        private System.Windows.Forms.TableLayoutPanel panelTotal;
        public System.Windows.Forms.GroupBox gbDetalleMesa;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox gbUsuario;


    }
}