using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RouteRearrangement cipherR = new RouteRearrangement();
            String textRU = "";
            Regex patternRU = new Regex(@"[А-Яа-яЁё]");

            String resultTextRU = "";
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                textRU = (sr.ReadToEnd());
                MatchCollection matches = patternRU.Matches(textRU);
                foreach (Match match in matches)
                    resultTextRU += match;
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            
            resultCode1.Text = cipherR.Code(resultTextRU.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeCode1.Text = elapsedTime;
            using (StreamWriter sw = new StreamWriter("routeCode.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultCode1.Text);
            }

            double[] countChar = cipherR.CountChar(cipherR.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + cipherR.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countCode1.Text = resultCountChar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RouteRearrangement cipherR = new RouteRearrangement();
            String textRU = "";
            Regex patternRU = new Regex(@"[А-Яа-яЁё\s]");

            String resultTextRU = "";
            using (StreamReader sr = new StreamReader("routeCode.txt"))
            {
                textRU = (sr.ReadToEnd());
                MatchCollection matches = patternRU.Matches(textRU);
                foreach (Match match in matches)
                    resultTextRU += match;
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();

            resultDecode1.Text = cipherR.Decode(resultTextRU.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeDecode1.Text = elapsedTime;
            using (StreamWriter sw = new StreamWriter("routeDecode.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultDecode1.Text);
            }

            double[] countChar = cipherR.CountChar(cipherR.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + cipherR.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countDecode1.Text = resultCountChar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MultipleRearrangement multiple = new MultipleRearrangement();
            String textRU = "";
            Regex patternRU = new Regex(@"[А-Яа-яЁё\s]");

            String resultTextRU = "";
            using (StreamReader sr = new StreamReader("text2.txt"))
            {
                textRU = (sr.ReadToEnd());
                MatchCollection matches = patternRU.Matches(textRU);
                foreach (Match match in matches)
                    resultTextRU += match;
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();

            resultCode2.Text = multiple.Code(resultTextRU.ToUpper(), keyWord1.Text.ToUpper(), keyWord2.Text.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeCode2.Text = elapsedTime;
            using (StreamWriter sw = new StreamWriter("multiCode.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultCode2.Text);
            }

            int[] countChar = multiple.CountChar(multiple.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + multiple.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countCode2.Text = resultCountChar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MultipleRearrangement multiple = new MultipleRearrangement();
            String textRU = "";
            Regex patternRU = new Regex(@"[А-Яа-яЁё\s]");

            String resultTextRU = "";
            using (StreamReader sr = new StreamReader("multiCode.txt"))
            {
                textRU = (sr.ReadToEnd());
                MatchCollection matches = patternRU.Matches(textRU);
                foreach (Match match in matches)
                    resultTextRU += match;
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();

            resultDecode2.Text = multiple.Decode(resultTextRU.ToUpper(), keyWord1.Text.ToUpper(), keyWord2.Text.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeDecode2.Text = elapsedTime;
            using (StreamWriter sw = new StreamWriter("multiDecode.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultDecode2.Text);
            }
            int[] countChar = multiple.CountChar(multiple.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + multiple.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countDecode2.Text = resultCountChar;
        }
    }
}
