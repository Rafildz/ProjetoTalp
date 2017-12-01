namespace ProjetoTalpRaf.Gasto
{
    partial class GastoBuscar
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
            this.dtGridGastos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridGastos
            // 
            this.dtGridGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGastos.Location = new System.Drawing.Point(13, 13);
            this.dtGridGastos.Name = "dtGridGastos";
            this.dtGridGastos.Size = new System.Drawing.Size(497, 256);
            this.dtGridGastos.TabIndex = 0;
            // 
            // GastoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 281);
            this.Controls.Add(this.dtGridGastos);
            this.Name = "GastoBuscar";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.GastoBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridGastos;
    }
}