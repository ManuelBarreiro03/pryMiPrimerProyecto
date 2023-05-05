namespace pryMiPrimerProyecto
{
    partial class frmPrincipal
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
            this.cmdAlimentos = new System.Windows.Forms.Button();
            this.cmdFinancias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAlimentos
            // 
            this.cmdAlimentos.Location = new System.Drawing.Point(12, 12);
            this.cmdAlimentos.Name = "cmdAlimentos";
            this.cmdAlimentos.Size = new System.Drawing.Size(442, 187);
            this.cmdAlimentos.TabIndex = 0;
            this.cmdAlimentos.Text = "Alimentos";
            this.cmdAlimentos.UseVisualStyleBackColor = true;
            this.cmdAlimentos.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdFinancias
            // 
            this.cmdFinancias.Location = new System.Drawing.Point(12, 205);
            this.cmdFinancias.Name = "cmdFinancias";
            this.cmdFinancias.Size = new System.Drawing.Size(442, 187);
            this.cmdFinancias.TabIndex = 1;
            this.cmdFinancias.Text = "Financias";
            this.cmdFinancias.UseVisualStyleBackColor = true;
            this.cmdFinancias.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(442, 187);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdFinancias);
            this.Controls.Add(this.cmdAlimentos);
            this.Name = "frmPrincipal";
            this.Text = "frmAlimentos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAlimentos;
        private System.Windows.Forms.Button cmdFinancias;
        private System.Windows.Forms.Button button1;
    }
}