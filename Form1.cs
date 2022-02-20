using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace guessNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Ghiciti un numar intre 50 si 100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int correctNumber = r.Next(50,100);

                try
                {
                 int g = Convert.ToInt32(textBox2.Text);
                    if (g != correctNumber)
                    {
                    textBox1.Text = "Numărul "+textBox2.Text+" este greșit!";
                    }
                    else
                    {
                    textBox1.Text= "Corect, ati ghicit numarul "+textBox2.Text+"!!! ***";
                    }
                }
                catch
                {
                textBox1.Text="Format incorect, vă rog introduceți un număr";
                }
            textBox2.Text = "";
        }
    }
    
}
