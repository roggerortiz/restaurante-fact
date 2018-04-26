namespace Vista
{
    partial class frmSistema
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnSunat = new System.Windows.Forms.Button();
            this.btnUBL = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnVersions = new System.Windows.Forms.Button();
            this.btnEmisor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductos.Location = new System.Drawing.Point(3, 3);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(158, 45);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vista.Properties.Resources.LogoFonseca;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.Location = new System.Drawing.Point(167, 3);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(158, 45);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesas.Location = new System.Drawing.Point(331, 3);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(158, 45);
            this.btnMesas.TabIndex = 3;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.UseVisualStyleBackColor = true;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.Location = new System.Drawing.Point(495, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(161, 45);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDir
            // 
            this.btnDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDir.Location = new System.Drawing.Point(3, 54);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(158, 45);
            this.btnDir.TabIndex = 5;
            this.btnDir.Text = "Directorios";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnSunat
            // 
            this.btnSunat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSunat.Location = new System.Drawing.Point(167, 54);
            this.btnSunat.Name = "btnSunat";
            this.btnSunat.Size = new System.Drawing.Size(158, 45);
            this.btnSunat.TabIndex = 6;
            this.btnSunat.Text = "Datos SUNAT";
            this.btnSunat.UseVisualStyleBackColor = true;
            this.btnSunat.Click += new System.EventHandler(this.btnSunat_Click);
            // 
            // btnUBL
            // 
            this.btnUBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUBL.Location = new System.Drawing.Point(331, 54);
            this.btnUBL.Name = "btnUBL";
            this.btnUBL.Size = new System.Drawing.Size(158, 45);
            this.btnUBL.TabIndex = 7;
            this.btnUBL.Text = "Parametros UBL";
            this.btnUBL.UseVisualStyleBackColor = true;
            this.btnUBL.Click += new System.EventHandler(this.btnUBL_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmail.Location = new System.Drawing.Point(495, 54);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(161, 45);
            this.btnEmail.TabIndex = 8;
            this.btnEmail.Text = "Datos E-Mail";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnVersions
            // 
            this.btnVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVersions.Location = new System.Drawing.Point(167, 105);
            this.btnVersions.Name = "btnVersions";
            this.btnVersions.Size = new System.Drawing.Size(158, 47);
            this.btnVersions.TabIndex = 9;
            this.btnVersions.Text = "Acerca de FactISG";
            this.btnVersions.UseVisualStyleBackColor = true;
            this.btnVersions.Click += new System.EventHandler(this.btnVersions_Click);
            // 
            // btnEmisor
            // 
            this.btnEmisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmisor.Location = new System.Drawing.Point(3, 105);
            this.btnEmisor.Name = "btnEmisor";
            this.btnEmisor.Size = new System.Drawing.Size(158, 47);
            this.btnEmisor.TabIndex = 10;
            this.btnEmisor.Text = "Datos del Emisor";
            this.btnEmisor.UseVisualStyleBackColor = true;
            this.btnEmisor.Click += new System.EventHandler(this.btnEmisor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 57);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(18, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 155);
            this.panel2.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnProductos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClientes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVersions, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEmisor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMesas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEmail, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUBL, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSunat, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control de Opciones del Sistema";
            this.Load += new System.EventHandler(this.frmSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnSunat;
        private System.Windows.Forms.Button btnUBL;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnVersions;
        private System.Windows.Forms.Button btnEmisor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}