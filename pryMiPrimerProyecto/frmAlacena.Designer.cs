namespace pryMiPrimerProyecto
{
    partial class frmAlacena
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
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.mrcAlacena = new System.Windows.Forms.GroupBox();
            this.lblCantidadAlacena = new System.Windows.Forms.Label();
            this.lblCuantoConsumioAlacena = new System.Windows.Forms.Label();
            this.cmdSacarAlacena = new System.Windows.Forms.Button();
            this.cmdAgregarAlcena = new System.Windows.Forms.Button();
            this.lstAlimentosAlacena = new System.Windows.Forms.ComboBox();
            this.txtAlacena = new System.Windows.Forms.TextBox();
            this.lblAlimentoAlacena = new System.Windows.Forms.Label();
            this.mrcHeladera = new System.Windows.Forms.GroupBox();
            this.lblCantidadHeladera = new System.Windows.Forms.Label();
            this.lblCuantoConsumioHeladera = new System.Windows.Forms.Label();
            this.cmdSacarHeladera = new System.Windows.Forms.Button();
            this.cmdAgrgarHeladera = new System.Windows.Forms.Button();
            this.lstAlimentosHeladera = new System.Windows.Forms.ComboBox();
            this.txtHeladera = new System.Windows.Forms.TextBox();
            this.lblAlimentoHeladera = new System.Windows.Forms.Label();
            this.mrcAlacena.SuspendLayout();
            this.mrcHeladera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.AutoSize = true;
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAlimentos.Location = new System.Drawing.Point(12, 9);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(83, 20);
            this.lblAlimentos.TabIndex = 0;
            this.lblAlimentos.Text = "Alimentos";
            // 
            // mrcAlacena
            // 
            this.mrcAlacena.Controls.Add(this.lblCantidadAlacena);
            this.mrcAlacena.Controls.Add(this.lblCuantoConsumioAlacena);
            this.mrcAlacena.Controls.Add(this.cmdSacarAlacena);
            this.mrcAlacena.Controls.Add(this.cmdAgregarAlcena);
            this.mrcAlacena.Controls.Add(this.lstAlimentosAlacena);
            this.mrcAlacena.Controls.Add(this.txtAlacena);
            this.mrcAlacena.Controls.Add(this.lblAlimentoAlacena);
            this.mrcAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mrcAlacena.Location = new System.Drawing.Point(16, 43);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(302, 186);
            this.mrcAlacena.TabIndex = 1;
            this.mrcAlacena.TabStop = false;
            this.mrcAlacena.Text = "Alacena";
            // 
            // lblCantidadAlacena
            // 
            this.lblCantidadAlacena.AutoSize = true;
            this.lblCantidadAlacena.Location = new System.Drawing.Point(29, 70);
            this.lblCantidadAlacena.Name = "lblCantidadAlacena";
            this.lblCantidadAlacena.Size = new System.Drawing.Size(75, 20);
            this.lblCantidadAlacena.TabIndex = 7;
            this.lblCantidadAlacena.Text = "Cantidad";
            // 
            // lblCuantoConsumioAlacena
            // 
            this.lblCuantoConsumioAlacena.AutoSize = true;
            this.lblCuantoConsumioAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCuantoConsumioAlacena.Location = new System.Drawing.Point(83, 98);
            this.lblCuantoConsumioAlacena.Name = "lblCuantoConsumioAlacena";
            this.lblCuantoConsumioAlacena.Size = new System.Drawing.Size(137, 13);
            this.lblCuantoConsumioAlacena.TabIndex = 6;
            this.lblCuantoConsumioAlacena.Text = "Cuanto Consumio/Compro?";
            // 
            // cmdSacarAlacena
            // 
            this.cmdSacarAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmdSacarAlacena.Location = new System.Drawing.Point(152, 146);
            this.cmdSacarAlacena.Name = "cmdSacarAlacena";
            this.cmdSacarAlacena.Size = new System.Drawing.Size(68, 23);
            this.cmdSacarAlacena.TabIndex = 5;
            this.cmdSacarAlacena.Text = "Sacar";
            this.cmdSacarAlacena.UseVisualStyleBackColor = true;
            // 
            // cmdAgregarAlcena
            // 
            this.cmdAgregarAlcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmdAgregarAlcena.Location = new System.Drawing.Point(84, 146);
            this.cmdAgregarAlcena.Name = "cmdAgregarAlcena";
            this.cmdAgregarAlcena.Size = new System.Drawing.Size(62, 23);
            this.cmdAgregarAlcena.TabIndex = 4;
            this.cmdAgregarAlcena.Text = "Agregar";
            this.cmdAgregarAlcena.UseVisualStyleBackColor = true;
            this.cmdAgregarAlcena.Click += new System.EventHandler(this.cmdAgregarAlcena_Click);
            // 
            // lstAlimentosAlacena
            // 
            this.lstAlimentosAlacena.FormattingEnabled = true;
            this.lstAlimentosAlacena.Location = new System.Drawing.Point(120, 33);
            this.lstAlimentosAlacena.Name = "lstAlimentosAlacena";
            this.lstAlimentosAlacena.Size = new System.Drawing.Size(167, 28);
            this.lstAlimentosAlacena.TabIndex = 3;
            // 
            // txtAlacena
            // 
            this.txtAlacena.Location = new System.Drawing.Point(86, 114);
            this.txtAlacena.Name = "txtAlacena";
            this.txtAlacena.Size = new System.Drawing.Size(134, 26);
            this.txtAlacena.TabIndex = 2;
            // 
            // lblAlimentoAlacena
            // 
            this.lblAlimentoAlacena.AutoSize = true;
            this.lblAlimentoAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAlimentoAlacena.Location = new System.Drawing.Point(30, 37);
            this.lblAlimentoAlacena.Name = "lblAlimentoAlacena";
            this.lblAlimentoAlacena.Size = new System.Drawing.Size(65, 18);
            this.lblAlimentoAlacena.TabIndex = 1;
            this.lblAlimentoAlacena.Text = "Alimento";
            // 
            // mrcHeladera
            // 
            this.mrcHeladera.Controls.Add(this.lblCantidadHeladera);
            this.mrcHeladera.Controls.Add(this.lblCuantoConsumioHeladera);
            this.mrcHeladera.Controls.Add(this.cmdSacarHeladera);
            this.mrcHeladera.Controls.Add(this.cmdAgrgarHeladera);
            this.mrcHeladera.Controls.Add(this.lstAlimentosHeladera);
            this.mrcHeladera.Controls.Add(this.txtHeladera);
            this.mrcHeladera.Controls.Add(this.lblAlimentoHeladera);
            this.mrcHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mrcHeladera.Location = new System.Drawing.Point(16, 235);
            this.mrcHeladera.Name = "mrcHeladera";
            this.mrcHeladera.Size = new System.Drawing.Size(306, 169);
            this.mrcHeladera.TabIndex = 2;
            this.mrcHeladera.TabStop = false;
            this.mrcHeladera.Text = "Heladera o Freezer";
            // 
            // lblCantidadHeladera
            // 
            this.lblCantidadHeladera.AutoSize = true;
            this.lblCantidadHeladera.Location = new System.Drawing.Point(29, 63);
            this.lblCantidadHeladera.Name = "lblCantidadHeladera";
            this.lblCantidadHeladera.Size = new System.Drawing.Size(75, 20);
            this.lblCantidadHeladera.TabIndex = 13;
            this.lblCantidadHeladera.Text = "Cantidad";
            // 
            // lblCuantoConsumioHeladera
            // 
            this.lblCuantoConsumioHeladera.AutoSize = true;
            this.lblCuantoConsumioHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCuantoConsumioHeladera.Location = new System.Drawing.Point(83, 88);
            this.lblCuantoConsumioHeladera.Name = "lblCuantoConsumioHeladera";
            this.lblCuantoConsumioHeladera.Size = new System.Drawing.Size(137, 13);
            this.lblCuantoConsumioHeladera.TabIndex = 12;
            this.lblCuantoConsumioHeladera.Text = "Cuanto Consumio/Compro?";
            // 
            // cmdSacarHeladera
            // 
            this.cmdSacarHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmdSacarHeladera.Location = new System.Drawing.Point(152, 136);
            this.cmdSacarHeladera.Name = "cmdSacarHeladera";
            this.cmdSacarHeladera.Size = new System.Drawing.Size(68, 23);
            this.cmdSacarHeladera.TabIndex = 11;
            this.cmdSacarHeladera.Text = "Sacar";
            this.cmdSacarHeladera.UseVisualStyleBackColor = true;
            // 
            // cmdAgrgarHeladera
            // 
            this.cmdAgrgarHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmdAgrgarHeladera.Location = new System.Drawing.Point(84, 136);
            this.cmdAgrgarHeladera.Name = "cmdAgrgarHeladera";
            this.cmdAgrgarHeladera.Size = new System.Drawing.Size(62, 23);
            this.cmdAgrgarHeladera.TabIndex = 10;
            this.cmdAgrgarHeladera.Text = "Agregar";
            this.cmdAgrgarHeladera.UseVisualStyleBackColor = true;
            // 
            // lstAlimentosHeladera
            // 
            this.lstAlimentosHeladera.FormattingEnabled = true;
            this.lstAlimentosHeladera.Location = new System.Drawing.Point(120, 25);
            this.lstAlimentosHeladera.Name = "lstAlimentosHeladera";
            this.lstAlimentosHeladera.Size = new System.Drawing.Size(167, 28);
            this.lstAlimentosHeladera.TabIndex = 9;
            // 
            // txtHeladera
            // 
            this.txtHeladera.Location = new System.Drawing.Point(86, 104);
            this.txtHeladera.Name = "txtHeladera";
            this.txtHeladera.Size = new System.Drawing.Size(134, 26);
            this.txtHeladera.TabIndex = 8;
            // 
            // lblAlimentoHeladera
            // 
            this.lblAlimentoHeladera.AutoSize = true;
            this.lblAlimentoHeladera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAlimentoHeladera.Location = new System.Drawing.Point(30, 29);
            this.lblAlimentoHeladera.Name = "lblAlimentoHeladera";
            this.lblAlimentoHeladera.Size = new System.Drawing.Size(65, 18);
            this.lblAlimentoHeladera.TabIndex = 7;
            this.lblAlimentoHeladera.Text = "Alimento";
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 409);
            this.Controls.Add(this.mrcHeladera);
            this.Controls.Add(this.mrcAlacena);
            this.Controls.Add(this.lblAlimentos);
            this.Name = "frmAlacena";
            this.Text = "frmAlacena";
            this.mrcAlacena.ResumeLayout(false);
            this.mrcAlacena.PerformLayout();
            this.mrcHeladera.ResumeLayout(false);
            this.mrcHeladera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.GroupBox mrcAlacena;
        private System.Windows.Forms.Label lblCantidadAlacena;
        private System.Windows.Forms.Label lblCuantoConsumioAlacena;
        private System.Windows.Forms.Button cmdSacarAlacena;
        private System.Windows.Forms.Button cmdAgregarAlcena;
        private System.Windows.Forms.ComboBox lstAlimentosAlacena;
        private System.Windows.Forms.TextBox txtAlacena;
        private System.Windows.Forms.Label lblAlimentoAlacena;
        private System.Windows.Forms.GroupBox mrcHeladera;
        private System.Windows.Forms.Label lblCuantoConsumioHeladera;
        private System.Windows.Forms.Button cmdSacarHeladera;
        private System.Windows.Forms.Button cmdAgrgarHeladera;
        private System.Windows.Forms.ComboBox lstAlimentosHeladera;
        private System.Windows.Forms.TextBox txtHeladera;
        private System.Windows.Forms.Label lblAlimentoHeladera;
        private System.Windows.Forms.Label lblCantidadHeladera;
    }
}