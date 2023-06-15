using System.Data;

namespace MyFristWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Yozuv qismi uchun 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Contains('\n'))
                {
                    DataTable a = new DataTable();
                    var jovob = a.Compute(textBox1.Text, "");
                    textBox1.Text = jovob.ToString();
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
            catch 
            {
                textBox1.Text = string.Empty;
            }
            
        }
        // ( - knopkasi uchun 
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }
        // ) - knopkasi uchun
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }
        // % - knopkasi uchun 
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }
        // / - knopkasi uchun 
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }
        // 7 - knopkasi uchun
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        // 8 - knopkasi uchun 
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        // 9 - knopkasi uchun 
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        // * - knopkasi uchun
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }
        // 4 - knopkasi uchun
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }
        // 5 - knopkasi uchun 
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        // 6 - knopkasi uchun 
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        // - - knopkasi uchun
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }
        // 1 - knopkasi uchun 
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }
        // 2 - knopkasi uchun
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }
        //3 - knopkasi uchun
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }
        //+ - knopkasi uchun 
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }
        // 0 - knopkasi uchun 
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        // = - knopkasi uchun 
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable a = new DataTable();
                var jovob = a.Compute(textBox1.Text, "");
                textBox1.Text = jovob.ToString();
            }
            catch
            {
                textBox1.Text = string.Empty;
            }

        }
        // -1 - knopkasi uchun
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }
        // AC - knopkasi uchun
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
    }
}