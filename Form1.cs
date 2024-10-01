using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjCalculadoraRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int virgula = 0;
        Double v1, v2 = 0.0;
        String op = "";
        Calcula calc = new Calcula();
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            lblVisor.Text = "";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text = lblDisplay.Text + "0";
            } else
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "1";
            }
            else
            {
                lblDisplay.Text = "1";
            }
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "2";
            }
            else
            {
                lblDisplay.Text = "2";
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "3";
            }
            else
            {
                lblDisplay.Text = "3";
            }
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "4";
            }
            else
            {
                lblDisplay.Text = "4";
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "5";
            }
            else
            {
                lblDisplay.Text = "5";
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "6";
            }
            else
            {
                lblDisplay.Text = "6";
            }
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "7";
            }
            else
            {
                lblDisplay.Text = "7";
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "8";
            }
            else
            {
                lblDisplay.Text = "8";
            }
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "0")
            {
                lblDisplay.Text += "9";
            }
            else
            {
                lblDisplay.Text = "9";
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            op = "+";
            v1 = Double.Parse(lblDisplay.Text);
            lblVisor.Text = lblDisplay.Text + " " + op + " ";
            lblDisplay.Text = "0";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            op = "-";
            v1 = Double.Parse(lblDisplay.Text);
            lblVisor.Text = lblDisplay.Text + " " + op + " ";
            lblDisplay.Text = "0";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            op = "x";
            v1 = Double.Parse(lblDisplay.Text);
            lblVisor.Text = lblDisplay.Text + " " + op + " ";
            lblDisplay.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op = "/";
            v1 = Double.Parse(lblDisplay.Text);
            lblVisor.Text = lblDisplay.Text + " " + "÷" + " ";
            lblDisplay.Text = "0";
        }

        private void rdoSen_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "Sen " + lblDisplay.Text;
            v1 = Double.Parse(lblDisplay.Text);
            v2 = 0.0;
            op = "sen";
            lblDisplay.Text = (calc.CalcularRadio(v1, v2, op)).ToString();
        }

        private void rdoCos_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "Cos " + lblDisplay.Text;
            v1 = Double.Parse(lblDisplay.Text);
            v2 = 0.0;
            op = "cos";
            lblDisplay.Text = (calc.CalcularRadio(v1, v2, op)).ToString();
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            virgula = 0;
            for (int i = 0; i <= lblDisplay.Text.Length - 1; i++)
            {
                if (lblDisplay.Text[i] == ',')
                {
                    virgula++;
                }
            }
            if (virgula == 0)
            {
                lblDisplay.Text += ',';
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            v2 = Double.Parse(lblDisplay.Text);
            lblVisor.Text = lblVisor.Text + lblDisplay.Text + " = ";
            lblDisplay.Text = (calc.Calcular(v1, v2, op)).ToString();
        }
    }
}
