namespace pryMiPrimerProyecto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDepocito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcGastoFijos = new System.Windows.Forms.GroupBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.mrcGastoFijos.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepocito
            // 
            this.lblDepocito.AutoSize = true;
            this.lblDepocito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepocito.Location = new System.Drawing.Point(51, 32);
            this.lblDepocito.Name = "lblDepocito";
            this.lblDepocito.Size = new System.Drawing.Size(73, 20);
            this.lblDepocito.TabIndex = 0;
            this.lblDepocito.Text = "Deposito";
            this.lblDepocito.Click += new System.EventHandler(this.lblDepocito_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(143, 32);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(291, 26);
            this.txtDeposito.TabIndex = 1;
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtDeposito_TextChanged);
            // 
            // mrcGastoFijos
            // 
            this.mrcGastoFijos.Controls.Add(this.txtComida);
            this.mrcGastoFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastoFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastoFijos.Controls.Add(this.lblComida);
            this.mrcGastoFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastoFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastoFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastoFijos.Location = new System.Drawing.Point(33, 89);
            this.mrcGastoFijos.Name = "mrcGastoFijos";
            this.mrcGastoFijos.Size = new System.Drawing.Size(421, 139);
            this.mrcGastoFijos.TabIndex = 2;
            this.mrcGastoFijos.TabStop = false;
            this.mrcGastoFijos.Text = "Gastos Fijos";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblImpuestos.Location = new System.Drawing.Point(18, 33);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(86, 20);
            this.lblImpuestos.TabIndex = 0;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAlquiler.Location = new System.Drawing.Point(18, 65);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(65, 20);
            this.lblAlquiler.TabIndex = 1;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblComida.Location = new System.Drawing.Point(18, 95);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(66, 20);
            this.lblComida.TabIndex = 2;
            this.lblComida.Text = "Comida";
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(110, 27);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(291, 26);
            this.txtImpuestos.TabIndex = 3;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(110, 59);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(291, 26);
            this.txtAlquiler.TabIndex = 4;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(110, 92);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(291, 26);
            this.txtComida.TabIndex = 5;
            this.txtComida.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.Controls.Add(this.txtMonto);
            this.mrcGastosFijos.Controls.Add(this.lblMonto);
            this.mrcGastosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijos.Location = new System.Drawing.Point(33, 254);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(421, 117);
            this.mrcGastosFijos.TabIndex = 3;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos Varios";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblMonto.Location = new System.Drawing.Point(18, 55);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 22);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(110, 51);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(291, 26);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackColor = System.Drawing.Color.Lime;
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCalcular.Location = new System.Drawing.Point(33, 466);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(202, 67);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Yellow;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(260, 467);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(194, 66);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(51, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(491, 563);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcGastoFijos);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.lblDepocito);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmPrincipal";
            this.Text = "Gestion De Preosupuesto Mensual";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcGastoFijos.ResumeLayout(false);
            this.mrcGastoFijos.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepocito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcGastoFijos;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblTotal;
    }
}

