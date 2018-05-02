namespace Vista
{
    partial class frmPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total S/.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago con";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vuelto";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(120, 17);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(137, 26);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(120, 89);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(137, 26);
            this.txtPago.TabIndex = 2;
            this.txtPago.Text = "0";
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Visa",
            "Mastercard"});
            this.cboTipoPago.Location = new System.Drawing.Point(120, 50);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(137, 28);
            this.cboTipoPago.TabIndex = 1;
            this.cboTipoPago.SelectedIndexChanged += new System.EventHandler(this.cboTipoPago_SelectedIndexChanged_1);
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(120, 127);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(137, 26);
            this.txtVuelto.TabIndex = 3;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBoleta
            // 
            this.btnBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleta.Location = new System.Drawing.Point(11, 181);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Size = new System.Drawing.Size(80, 35);
            this.btnBoleta.TabIndex = 4;
            this.btnBoleta.Text = "Boleta";
            this.btnBoleta.UseVisualStyleBackColor = true;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(108, 181);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(84, 35);
            this.btnFactura.TabIndex = 5;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFactura);
            this.groupBox1.Controls.Add(this.txtVuelto);
            this.groupBox1.Controls.Add(this.txtPago);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboTipoPago);
            this.groupBox1.Controls.Add(this.btnBoleta);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 225);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAGO";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(209, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(298, 231);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGO";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}