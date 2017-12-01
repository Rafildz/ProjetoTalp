namespace ProjetoTalpRaf.Cliente
{
    partial class ClienteBuscar
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
            this.dtGridCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCliente
            // 
            this.dtGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCliente.Location = new System.Drawing.Point(12, 12);
            this.dtGridCliente.Name = "dtGridCliente";
            this.dtGridCliente.Size = new System.Drawing.Size(454, 250);
            this.dtGridCliente.TabIndex = 0;
            // 
            // ClienteBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 274);
            this.Controls.Add(this.dtGridCliente);
            this.Name = "ClienteBuscar";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridCliente;
    }
}