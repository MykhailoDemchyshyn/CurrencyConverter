using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static StreamReader sr = new StreamReader("DataRead.txt");
        public static double DollarPurchase { get; set; } = Convert.ToDouble(sr.ReadLine());
        public static double DollarSale { get; set; }=Convert.ToDouble(sr.ReadLine());
        public static double EuroPurchase { get; set; }= Convert.ToDouble(sr.ReadLine()); 
        public static double EuroSale { get; set; }= Convert.ToDouble(sr.ReadLine()); 
        


        public static ValueRadioButtonDelegat vrbd;
        public static ChangeTextBoxDelegate ctbd;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = $"{ "купівя",30}" + $"{"продаж",15}";
            label1.Text+= "\n\n" +"курс євро"+$"{EuroPurchase.ToString(),13}"+$"{EuroSale,17}";
            label1.Text+= "\n\n" + "курс долара" + $"{DollarPurchase.ToString(),9}" + $"{DollarSale,17}";
            TextBoxSum.ReadOnly = true;
            ButtonSave.Enabled = false;
            vrbd = ValueRadioButton;
            ctbd = ChangeTextBox;
            sr.Close();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Form2 NewForm=new Form2();
            if (ValueRadioButton() != "choose")
            {
                NewForm.Show();
            }
            else
            {
                //TextBoxSum.Text = ValueRadioButton();
            }
        }
        public delegate string ValueRadioButtonDelegat();
        
        public string ValueRadioButton()
        {
            
            if (RadioButtonEuro.Checked && RadioButtonPurchase.Checked)
            {
                return "11";
                
            }
            else if(RadioButtonEuro.Checked && RadioButtonSale.Checked)
            {
                return "12";
            }
            if (RadioButtonDollar.Checked && RadioButtonPurchase.Checked)
            {
                return "21";

            }
            else if (RadioButtonDollar.Checked && RadioButtonSale.Checked)
            {
                return "22";
            }
            else
            {
                return "choose";
            }
        }
        public void ChangeTextBox(string x)
        {
            
            if (x!="")
            {
                TextBoxSum.Text = x;
                ButtonSave.Enabled = true;
            }
        }
        public delegate void ChangeTextBoxDelegate(string x);

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void RadioButtonEuro_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            if (ValueRadioButton() == "11")
            {
                using (StreamWriter sw = new StreamWriter("DataWritte.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"євро, купівля, курс={EuroPurchase}, сума={TextBoxSum.Text}");
                }
            }
            else if (ValueRadioButton() == "12")
            {
                using (StreamWriter sw = new StreamWriter("DataWritte.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"євро, продаж, курс={EuroSale}, сума={TextBoxSum.Text}");
                }
            }
            else if (ValueRadioButton() == "21")
            {
                using (StreamWriter sw = new StreamWriter("DataWritte.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"долар, купівля, курс={DollarPurchase}, сума={TextBoxSum.Text}");
                }
            }
            else if (ValueRadioButton() == "22")
            {
                using (StreamWriter sw = new StreamWriter("DataWritte.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"долар, продаж, курс={DollarSale}, сума={TextBoxSum.Text}");
                }
            }
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
