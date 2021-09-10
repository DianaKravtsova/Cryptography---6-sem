using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(task1.Text);

            if (funcForLab.IsPrimeNumber(num)) resultTask1.Text = "простое";
            else resultTask1.Text = "составное";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task21.Text);
            int b = Convert.ToInt32(task22.Text);
            result2.Text = Convert.ToString(funcForLab.Evklid(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task31.Text);
            int b = Convert.ToInt32(task32.Text);
            int c = Convert.ToInt32(task33.Text);
            result3.Text = Convert.ToString(funcForLab.Evklid_3(a, b, c));
        }

        private void button_t41_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(task41.Text);
            int b = Convert.ToInt32(task42.Text);

            int countNum = 0;
            List<int> result = new List<int>();
            result = funcForLab.SieveEratosthenes(a, b);
            string resultToString = string.Join(", ", result);

            //while(a <= b)
            //{
            //    if (funcForLab.IsPrimeNumber(a))
            //    {
            //        result = result + Convert.ToString(a) + ',';
            //        countNum++;
            //    }

            //    a++;
            //}


            resul41.Text = resultToString;
            result42.Text = Convert.ToString(result.Count);
            result43.Text = Convert.ToString(b / Math.Log(b));
        }

        private void resul41_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
