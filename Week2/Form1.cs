using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD.Week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password former = new Password();//object of type Password for using method RondomSymbol()
            char[] pass = new char[8];//array for symbols formation

            textBox1.Clear();

            for(int i = 0; i < 8; i++)//a lot of sites and registration forms asks a password that consists 8 symbols
            {
                pass[i] = former.RandomSymbol();
                if (i == 0) textBox1.Text += pass[i];//formation of first symbol
                else if (pass[i] == pass[i - 1]) i--;//try not to repeat
                else textBox1.Text += pass[i];//formation of other symbols

            }
            
        }
    }
}
