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
            this.gbDetalleMesa = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.gbDetalleMesa.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategorias
            // 
            this.gbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategorias.Location = new System.Drawing.Point(10, 30);
            this.gbCategorias.Name = "gbCategorias";
            this.gbCategorias.Size = new System.Drawing.Size(345, 122);
            this.gbCategorias.TabIndex = 0;
            this.gbCategorias.TabStop = false;
            this.gbCategorias.Text = "CATEGORÍAS";
            // 
            // gbProductos
            // 
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(10, 157);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(345, 355);
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
            this.dgvDetalles.Location = new System.Drawing.Point(372, 27);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(585, 424);
            this.dgvDetalles.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(766, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total: S/.";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(853, 473);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(104, 26);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(976, 40);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(52, 54);
            this.btnAumentar.TabIndex = 16;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(976, 110);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(52, 54);
            this.btnDisminuir.TabIndex = 17;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(976, 180);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(52, 54);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Text = "x";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(372, 464);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 44);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(504, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 44);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(638, 464);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(96, 44);
            this.btnPagar.TabIndex = 21;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // gbDetalleMesa
            // 
            this.gbDetalleMesa.BackColor = System.Drawing.SystemColors.Control;
            this.gbDetalleMesa.Controls.Add(this.gbProductos);
            this.gbDetalleMesa.Controls.Add(this.btnPagar);
            this.gbDetalleMesa.Controls.Add(this.gbCategorias);
            this.gbDetalleMesa.Controls.Add(this.btnAumentar);
            this.gbDetalleMesa.Controls.Add(this.btnGuardar);
            this.gbDetalleMesa.Controls.Add(this.btnDisminuir);
            this.gbDetalleMesa.Controls.Add(this.btnCancelar);
            this.gbDetalleMesa.Controls.Add(this.btnQuitar);
            this.gbDetalleMesa.Controls.Add(this.label8);
            this.gbDetalleMesa.Controls.Add(this.dgvDetalles);
            this.gbDetalleMesa.Controls.Add(this.txtTotal);
            this.gbDetalleMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleMesa.Location = new System.Drawing.Point(2, 3);
            this.gbDetalleMesa.Name = "gbDetalleMesa";
            this.gbDetalleMesa.Size = new System.Drawing.Size(1043, 520);
            this.gbDetalleMesa.TabIndex = 0;
            this.gbDetalleMesa.TabStop = false;
            // 
            // frmDetalleMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1048, 525);
            this.Controls.Add(this.gbDetalleMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDetalleMesa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleMesa";
            this.Load += new System.EventHandler(this.frmDetalleMesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.gbDetalleMesa.ResumeLayout(false);
            this.gbDetalleMesa.PerformLayout();
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
        public System.Windows.Forms.GroupBox gbDetalleMesa;


    }
}