namespace Vista
{
    partial class Mesas
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
            this.panelMesas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelMesas
            // 
            this.panelMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesas.Location = new System.Drawing.Point(0, 0);
            this.panelMesas.Name = "panelMesas";
            this.panelMesas.Size = new System.Drawing.Size(852, 409);
            this.panelMesas.TabIndex = 0;
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 409);
            this.Controls.Add(this.panelMesas);
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Mesas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMesas;






    }
}