using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akilli_ev
{
    public partial class Form1 : Form
    {
        double dolar, lira, euro;
        public Form1()
        {
    
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(cbKlima.Checked && cbLambalar.Checked)
            {
                listBox1.Items.Add("Klima acik");
                listBox1.Items.Add("Lambalar Acik");

            }  
            else if (cbLambalar.Checked)
            {
                listBox1.Items.Add("Lambalar acik");

            }
            else if (cbKlima.Checked)
            {
                listBox1.Items.Add("Klimalar acik");

            }
            else
            {
                listBox1.Items.Add("Tum sistem kapali");
            }
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            double para = Convert.ToDouble(tbPara.Text);
            double dolar = Convert.ToDouble(tbDolar.Text);
            double euro = Convert.ToDouble(tbEuro.Text);

            if (rbTlDolar.Checked)
            {
                listBox1.Items.Add("Tum sistem kapali");
                lbSonuc.Text = Convert.ToString(para / dolar) + "TL";


            }
            else if (rbTlDolar.Checked)
            {
                lbSonuc.Text = Convert.ToString(dolar * para) + "Dolar";
            }
            else if (rbEuroTl.Checked)
            {
                lbSonuc.Text = Convert.ToString(euro / para) + "tl";
            }
            else if (rbEuroTl.Checked)
            {
                lbSonuc.Text = Convert.ToString(euro / para) + "tl";

            }
            else if (rbTlEuro.Checked)
            {
                lbSonuc.Text = Convert.ToString(euro * para) + "Euro":
            }
            
        }
    }
}
