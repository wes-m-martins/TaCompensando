using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taCompensando
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtAlcool.Text);
            double g = double.Parse(txtGasolina.Text);

            double i = Simulador.Indicar(a, g);

            if (rdoCombustivel.Checked ==true)
                if (i > 0.7)
                {
                    lblGasolina.Visible = true;
                    lblGasolina.Focus();
                }
                else if (i<0.7)
                {
                    lblAlcool.Visible = true;
                    lblAlcool.Focus();
                }
        }
            
        private void lblGasolina_Leave(object sender, EventArgs e)
        {
            lblGasolina.Visible = false;
        }

        private void lblAlcool_Leave(object sender, EventArgs e)
        {
            lblAlcool.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
