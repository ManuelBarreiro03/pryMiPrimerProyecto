using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerProyecto
{
    public partial class frmFinancias : Form
    {
        decimal varMonto, varPresupuesto, varImpuesto, varComida, varVario, varAlquiler, varGastado;


        private void cmdCalcular_Click(object sender, EventArgs e)
        {
           
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varImpuesto = Convert.ToDecimal(txtImpuesto.Text); 
            varPresupuesto = Convert.ToDecimal(txtPresupuesto.Text);
            varVario = Convert.ToDecimal(txtVario.Text);   
            varGastado = - varComida - varImpuesto - varVario - varAlquiler;
            varMonto = varPresupuesto - (varComida + varImpuesto + varVario + varAlquiler);
            lblMonto.Text="Monto: " + varMonto.ToString();
            lblGastado.Text="Gastado: " + varGastado.ToString();

        }

        public frmFinancias()
        {
            InitializeComponent();
        }

        private void frmFinancias_Load(object sender, EventArgs e)
        {
            varAlquiler = 0;
            varPresupuesto = 0;
            varImpuesto = 0;
            varComida = 0;
            varVario = 0;
            varMonto = 0;
            varGastado = 0;

        }
    }
}
