namespace ProjetoTalpRaf.Gasto
{
    partial class GastoExcluir
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
            this.dtGridGasto = new System.Windows.Forms.DataGridView();
            this.cmbGasto = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridGasto
            // 
            this.dtGridGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridGasto.Location = new System.Drawing.Point(13, 13);
            this.dtGridGasto.Name = "dtGridGasto";
            this.dtGridGasto.Size = new System.Drawing.Size(475, 237);
            this.dtGridGasto.TabIndex = 0;
            // 
            // cmbGasto
            // 
            this.cmbGasto.FormattingEnabled = true;
            this.cmbGasto.Location = new System.Drawing.Point(13, 257);
            this.cmbGasto.Name = "cmbGasto";
            this.cmbGasto.Size = new System.Drawing.Size(232, 21);
            this.cmbGasto.TabIndex = 1;
            this.cmbGasto.SelectedIndexChanged += new System.EventHandler(this.cmbGasto_SelectedIndexChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 285);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(80, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor Escolhido";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(328, 257);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 41);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // GastoExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbGasto);
            this.Controls.Add(this.dtGridGasto);
            this.Name = "GastoExcluir";
            this.Text = "GastoExcluir";
            this.Load += new System.EventHandler(this.GastoExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridGasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridGasto;
        private System.Windows.Forms.ComboBox cmbGasto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnExcluir;
    }
}