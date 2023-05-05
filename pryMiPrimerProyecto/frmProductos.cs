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
    public partial class frmProductos : Form
    {
        int varCantidad;
        string varTipo, varLugar, varProducto;
        DateTime varCaduca;

        private void button1_Click(object sender, EventArgs e)
        {
            varLugar = lstLugar.Text;
            varProducto = lstProducto.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            varCaduca = dtpFechaCaduca.Value;
            varTipo = "";
        }

        

        public frmProductos()
        {
            InitializeComponent();
        }

       

        private void frmAlimetos_Load(object sender, EventArgs e)
        {
            lstLugar.Items.Add("Heladera ");
            lstLugar.Items.Add("Alacena ");
            lstLugar.Items.Add("Freezer ");
            lstProducto.Items.Add("Limpia pisos ");
            lstProducto.Items.Add("Leche ");
            lstProducto.Items.Add("Mate cocido ");
            lstProducto.Items.Add("Carne ");

        }
    }
}
