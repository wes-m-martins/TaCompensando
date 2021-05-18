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
            errorProvider.Clear();

            bool erros = false;

            if (txtAlcool.Text.Trim() == "")
            {
                errorProvider.SetError(txtAlcool, "Campo obrigatório");
                erros = true;
            }
            if (txtGasolina.Text.Trim() == "")
            {
                errorProvider.SetError(txtGasolina, "Campo obrigatório");
                erros = true;
            }
            if (txtConsAlc.Text.Trim() == "")
            {
                errorProvider.SetError(txtConsAlc, "Campo obrigatório");
                erros = true;
            }
            if (txtConsGas.Text.Trim() == "")
            {
                errorProvider.SetError(txtConsGas, "Campo obrigatório");
                erros = true;
            }
            if (txtVlrAbast.Text.Trim() == "")
            {
                errorProvider.SetError(txtVlrAbast, "Campo obrigatório");
                erros = true;
            }



            if (erros == false)
            {
                double a = double.Parse(txtAlcool.Text);
                double g = double.Parse(txtGasolina.Text);
                double kAlc = double.Parse(txtConsAlc.Text);
                double kGas = double.Parse(txtConsGas.Text);

                double vlr = double.Parse(txtVlrAbast.Text);
                double i = 0;

                if (rdoCombustivel.Checked == true)
                    i = Simulador.Indicar(a, g);
                if (i > 0.7)
                {
                    lblGasolina.Visible = true;
                    lblGasolina.Focus();
                }
                else if (i < 0.7)
                {
                    lblAlcool.Visible = true;
                    lblAlcool.Focus();
                }
                i = 0;
                if (rdoConsumo.Checked == true)
                    i = Simulador.Calcular(kAlc, a , vlr) - Simulador.Calcular(kGas,g,vlr);
                if (i < 0)
                {
                    lblGasolina.Visible = true;
                    lblGasolina.Focus();
                }
                else if (i > 0)
                {
                    lblAlcool.Visible = true;
                    lblAlcool.Focus();
                }
                i = 0;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
