﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            frmFinancias ventanaFinancias = new frmFinancias();

            ventanaFinancias.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmProductos ventanaProducts = new frmProductos();
            ventanaProducts.ShowDialog();
        }
    }
}
