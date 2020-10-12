using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 frm=new Form1();
        private void TextBoxNumber_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNumber.Text!=null)
            {
                ButtonCalculate.Enabled = true;
                ButtonClean.Enabled = true;
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ButtonCalculate.Enabled = false;
            ButtonClean.Enabled = false;
            TextBoxSum.ReadOnly = true;
        }

        private void ButtonClaculate_Click(object sender, EventArgs e)
        {
            TextBoxNumber.Text= TextBoxNumber.Text.Replace('.', ',');
            if( Form1.vrbd()=="11")
            {
                TextBoxSum.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber.Text) * Convert.ToDouble(Form1.EuroPurchase));
            }
            else if (Form1.vrbd() == "12")
            {
                TextBoxSum.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber.Text) * Convert.ToDouble(Form1.EuroSale));
            }
            else if (Form1.vrbd() == "21")
            {
                TextBoxSum.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber.Text) * Convert.ToDouble(Form1.DollarPurchase));
            }
            else if (Form1.vrbd() == "22")
            {
                TextBoxSum.Text = Convert.ToString(Convert.ToDouble(TextBoxNumber.Text) * Convert.ToDouble(Form1.DollarSale));
            }
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            TextBoxNumber.Text = null;
            TextBoxSum.Text = null;
            ButtonCalculate.Enabled = false;
            ButtonClean.Enabled = false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Form1.ctbd(TextBoxSum.Text);
            this.Close();
            
        }
    }
}
