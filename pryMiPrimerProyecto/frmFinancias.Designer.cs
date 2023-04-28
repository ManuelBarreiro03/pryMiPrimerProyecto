namespace pryMiPrimerProyecto
{
    partial class frmFinancias
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
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.mrcConsumo = new System.Windows.Forms.GroupBox();
            this.txtVario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblGastado = new System.Windows.Forms.Label();
            this.mrcConsumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(8, 26);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(99, 20);
            this.lblPresupuesto.TabIndex = 0;
            this.lblPresupuesto.Text = "Presupuesto";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(110, 28);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(148, 20);
            this.txtPresupuesto.TabIndex = 1;
            // 
            // mrcConsumo
            // 
            this.mrcConsumo.Controls.Add(this.txtVario);
            this.mrcConsumo.Controls.Add(this.label4);
            this.mrcConsumo.Controls.Add(this.txtComida);
            this.mrcConsumo.Controls.Add(this.txtAlquiler);
            this.mrcConsumo.Controls.Add(this.txtImpuesto);
            this.mrcConsumo.Controls.Add(this.label3);
            this.mrcConsumo.Controls.Add(this.label2);
            this.mrcConsumo.Controls.Add(this.label1);
            this.mrcConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mrcConsumo.Location = new System.Drawing.Point(12, 54);
            this.mrcConsumo.Name = "mrcConsumo";
            this.mrcConsumo.Size = new System.Drawing.Size(259, 174);
            this.mrcConsumo.TabIndex = 2;
            this.mrcConsumo.TabStop = false;
            this.mrcConsumo.Text = "Consumo";
            // 
            // txtVario
            // 
            this.txtVario.Location = new System.Drawing.Point(98, 131);
            this.txtVario.Name = "txtVario";
            this.txtVario.Size = new System.Drawing.Size(148, 26);
            this.txtVario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vario";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(98, 99);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(148, 26);
            this.txtComida.TabIndex = 6;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(98, 67);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(148, 26);
            this.txtAlquiler.TabIndex = 5;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(98, 31);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(148, 26);
            this.txtImpuesto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alquiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impuestos";
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmdCalcular.Location = new System.Drawing.Point(12, 300);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(136, 52);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(172, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblMonto.Location = new System.Drawing.Point(19, 242);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(112, 18);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto restante:";
            // 
            // lblGastado
            // 
            this.lblGastado.AutoSize = true;
            this.lblGastado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblGastado.Location = new System.Drawing.Point(19, 269);
            this.lblGastado.Name = "lblGastado";
            this.lblGastado.Size = new System.Drawing.Size(69, 18);
            this.lblGastado.TabIndex = 7;
            this.lblGastado.Text = "Gastado:";
            // 
            // frmFinancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 394);
            this.Controls.Add(this.lblGastado);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.mrcConsumo);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Name = "frmFinancias";
            this.Text = "frmFinansas";
            this.Load += new System.EventHandler(this.frmFinancias_Load);
            this.mrcConsumo.ResumeLayout(false);
            this.mrcConsumo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.GroupBox mrcConsumo;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblGastado;
    }
}