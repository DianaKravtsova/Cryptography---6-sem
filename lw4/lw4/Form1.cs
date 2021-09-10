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

namespace lw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cipherPort cipherP = new cipherPort();
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
            resultTask1.Text = cipherP.codePort(resultTextRU.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeTask1.Text = elapsedTime; 
            using (StreamWriter sw = new StreamWriter("codePortText.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultTask1.Text);
            }

            int[] countChar = cipherP.CountChar(cipherP.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + cipherP.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countChar1.Text = resultCountChar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cipherPort cipherP = new cipherPort();
            String codeText = "";
            using (StreamReader sr = new StreamReader("codePortText.txt"))
            {
                codeText = (sr.ReadToEnd());
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            resultTask11.Text = cipherP.decodePort(codeText);
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeTask1.Text = elapsedTime;

            int[] countChar = cipherP.CountChar(cipherP.AlphabetNum, codeText);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + cipherP.AlphabetNum[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countChar1.Text = resultCountChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cipherCesar cipherC = new cipherCesar();
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
            resultTask2.Text = cipherC.codeCesar(resultTextRU.ToUpper(), keyWord.Text.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeTask2.Text = elapsedTime;
            using (StreamWriter sw = new StreamWriter("codeCesarText.txt", false, System.Text.Encoding.Unicode))
            {
                sw.WriteLine(resultTask2.Text);
            }
            int[] countChar = cipherC.CountChar(cipherC.AlphabetRus, resultTextRU);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + cipherC.AlphabetRus[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countChar2.Text = resultCountChar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cipherCesar cipherC = new cipherCesar();
            String codeText = "";
            Regex patternRU = new Regex(@"[А-Яа-яЁё]");

            String resultCodeText = "";
            using (StreamReader sr = new StreamReader("codeCesarText.txt"))
            {
                codeText = (sr.ReadToEnd());
                MatchCollection matches = patternRU.Matches(codeText);
                foreach (Match match in matches)
                    resultCodeText += match;
            }
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            resultTask22.Text = cipherC.decodeCesar(resultCodeText.ToUpper(), keyWord.Text.ToUpper());
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                resultTime.Hours,
                                                resultTime.Minutes,
                                                resultTime.Seconds,
                                                resultTime.Milliseconds);
            resultTimeTask2.Text = elapsedTime;
            char[] codeAlph = cipherC.GetCodeAlphabet(keyWord.Text.ToUpper());
            int[] countChar = cipherC.CountChar(codeAlph, resultCodeText);
            string resultCountChar = "";
            for (int i = 0; i < countChar.Length; i++)
            {
                resultCountChar = resultCountChar + codeAlph[i] + ":" + Convert.ToString(countChar[i]) + " ";
            }

            countChar2.Text = resultCountChar;

        }
    }
}
