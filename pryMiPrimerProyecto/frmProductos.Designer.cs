namespace pryMiPrimerProyecto
{
    partial class frmProductos
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
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.optMedicamento = new System.Windows.Forms.RadioButton();
            this.optLimpieza = new System.Windows.Forms.RadioButton();
            this.optAlimento = new System.Windows.Forms.RadioButton();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lstLugar = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdSacar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.mrcTipoProducto = new System.Windows.Forms.GroupBox();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.LblFechaCaducidad = new System.Windows.Forms.Label();
            this.dtpFechaCaduca = new System.Windows.Forms.DateTimePicker();
            this.mrcCaducidad = new System.Windows.Forms.GroupBox();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.mrcTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.mrcTipoProducto.SuspendLayout();
            this.mrcCaducidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.optMedicamento);
            this.mrcTipo.Controls.Add(this.optLimpieza);
            this.mrcTipo.Controls.Add(this.optAlimento);
            this.mrcTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTipo.Location = new System.Drawing.Point(12, 32);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(245, 83);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo";
            // 
            // optMedicamento
            // 
            this.optMedicamento.AutoSize = true;
            this.optMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.optMedicamento.Location = new System.Drawing.Point(107, 25);
            this.optMedicamento.Name = "optMedicamento";
            this.optMedicamento.Size = new System.Drawing.Size(116, 22);
            this.optMedicamento.TabIndex = 2;
            this.optMedicamento.TabStop = true;
            this.optMedicamento.Text = "Medicamento";
            this.optMedicamento.UseVisualStyleBackColor = true;
            // 
            // optLimpieza
            // 
            this.optLimpieza.AutoSize = true;
            this.optLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.optLimpieza.Location = new System.Drawing.Point(6, 52);
            this.optLimpieza.Name = "optLimpieza";
            this.optLimpieza.Size = new System.Drawing.Size(85, 22);
            this.optLimpieza.TabIndex = 1;
            this.optLimpieza.TabStop = true;
            this.optLimpieza.Text = "Limpieza";
            this.optLimpieza.UseVisualStyleBackColor = true;
            // 
            // optAlimento
            // 
            this.optAlimento.AutoSize = true;
            this.optAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.optAlimento.Location = new System.Drawing.Point(6, 25);
            this.optAlimento.Name = "optAlimento";
            this.optAlimento.Size = new System.Drawing.Size(83, 22);
            this.optAlimento.TabIndex = 0;
            this.optAlimento.TabStop = true;
            this.optAlimento.Text = "Alimento";
            this.optAlimento.UseVisualStyleBackColor = true;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLugar.Location = new System.Drawing.Point(6, 46);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(52, 20);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Lugar";
            // 
            // lstLugar
            // 
            this.lstLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lstLugar.FormattingEnabled = true;
            this.lstLugar.Location = new System.Drawing.Point(88, 46);
            this.lstLugar.Name = "lstLugar";
            this.lstLugar.Size = new System.Drawing.Size(121, 21);
            this.lstLugar.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCantidad.Location = new System.Drawing.Point(6, 73);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.nudCantidad.Location = new System.Drawing.Point(87, 73);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(121, 20);
            this.nudCantidad.TabIndex = 4;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(6, 326);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(80, 37);
            this.cmdAgregar.TabIndex = 7;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdSacar
            // 
            this.cmdSacar.Location = new System.Drawing.Point(92, 326);
            this.cmdSacar.Name = "cmdSacar";
            this.cmdSacar.Size = new System.Drawing.Size(80, 37);
            this.cmdSacar.TabIndex = 8;
            this.cmdSacar.Text = "Sacar";
            this.cmdSacar.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(178, 326);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(80, 37);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(7, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(81, 20);
            this.lblProductos.TabIndex = 10;
            this.lblProductos.Text = "Productos";
            // 
            // mrcTipoProducto
            // 
            this.mrcTipoProducto.Controls.Add(this.lstProducto);
            this.mrcTipoProducto.Controls.Add(this.lblProducto);
            this.mrcTipoProducto.Controls.Add(this.nudCantidad);
            this.mrcTipoProducto.Controls.Add(this.lstLugar);
            this.mrcTipoProducto.Controls.Add(this.lblCantidad);
            this.mrcTipoProducto.Controls.Add(this.lblLugar);
            this.mrcTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTipoProducto.Location = new System.Drawing.Point(12, 121);
            this.mrcTipoProducto.Name = "mrcTipoProducto";
            this.mrcTipoProducto.Size = new System.Drawing.Size(246, 114);
            this.mrcTipoProducto.TabIndex = 11;
            this.mrcTipoProducto.TabStop = false;
            this.mrcTipoProducto.Text = "Tipo de Producto";
            // 
            // lstProducto
            // 
            this.lstProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(88, 19);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(121, 21);
            this.lstProducto.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblProducto.Location = new System.Drawing.Point(6, 20);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(76, 20);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // LblFechaCaducidad
            // 
            this.LblFechaCaducidad.AutoSize = true;
            this.LblFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCaducidad.Location = new System.Drawing.Point(6, 22);
            this.LblFechaCaducidad.Name = "LblFechaCaducidad";
            this.LblFechaCaducidad.Size = new System.Drawing.Size(134, 20);
            this.LblFechaCaducidad.TabIndex = 12;
            this.LblFechaCaducidad.Text = "Fecha Caducidad";
            // 
            // dtpFechaCaduca
            // 
            this.dtpFechaCaduca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCaduca.Location = new System.Drawing.Point(5, 45);
            this.dtpFechaCaduca.Name = "dtpFechaCaduca";
            this.dtpFechaCaduca.Size = new System.Drawing.Size(210, 26);
            this.dtpFechaCaduca.TabIndex = 13;
            // 
            // mrcCaducidad
            // 
            this.mrcCaducidad.Controls.Add(this.dtpFechaCaduca);
            this.mrcCaducidad.Controls.Add(this.LblFechaCaducidad);
            this.mrcCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mrcCaducidad.Location = new System.Drawing.Point(13, 241);
            this.mrcCaducidad.Name = "mrcCaducidad";
            this.mrcCaducidad.Size = new System.Drawing.Size(249, 79);
            this.mrcCaducidad.TabIndex = 14;
            this.mrcCaducidad.TabStop = false;
            this.mrcCaducidad.Text = "Caducidad";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(268, 32);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(177, 329);
            this.lstLista.TabIndex = 15;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 372);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.mrcCaducidad);
            this.Controls.Add(this.mrcTipoProducto);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSacar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.mrcTipo);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmAlimetos_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.mrcTipoProducto.ResumeLayout(false);
            this.mrcTipoProducto.PerformLayout();
            this.mrcCaducidad.ResumeLayout(false);
            this.mrcCaducidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.RadioButton optMedicamento;
        private System.Windows.Forms.RadioButton optLimpieza;
        private System.Windows.Forms.RadioButton optAlimento;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox lstLugar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdSacar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox mrcTipoProducto;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label LblFechaCaducidad;
        private System.Windows.Forms.DateTimePicker dtpFechaCaduca;
        private System.Windows.Forms.GroupBox mrcCaducidad;
        private System.Windows.Forms.ListBox lstLista;
    }
}