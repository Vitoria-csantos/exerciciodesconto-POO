using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exerciciodesconto_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double num1,codigo , result ;
            num1 = Convert.ToDouble(txtpreco.Text);
           
            if(codigo = "norte")
            {
                (5 /num1) * 100;
                txtdesconto.Text == result.ToString();
            }
            else
            {
                if(codigo = "sul")
                {
                    (15 / num1) * 100;
                    txtdesconto.Text == result.ToString();
                }
                else
                {
                    if (codigo = "sudeste")
                    {
                        (7 / num1) * 100;
                        txtdesconto.Text == result.ToString();
                    }
                    else
                    {
                        if(codigo = "nordeste")
                        {
                            (12 / num1) * 100;
                            txtdesconto.Text == result.ToString();
                        }
                        else
                        {
                            if(codigo = "centro-oeste")
                            {
                                (20 / num1) * 100;
                                txtdesconto.Text == result.ToString();
                            }
                            else
                            {

                            }
                        }
                    }
                }
                

            }
        }
    }
}
