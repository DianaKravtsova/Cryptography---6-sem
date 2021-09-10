using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RSA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                        'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void codeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pNumber.Text.Length > 0 && qNumber.Text.Length > 0)
                {
                    int p = Convert.ToInt32(pNumber.Text);
                    int q = Convert.ToInt32(qNumber.Text);
                    if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                    {
                        string s = "";

                        StreamReader sr = new StreamReader("text.txt");

                        while (!sr.EndOfStream)
                        {
                            s += sr.ReadLine();
                        }

                        sr.Close();

                        s = s.ToUpper();

                        long n = p * q;
                        long m = (p - 1) * (q - 1);
                        long e_ = Calculate_e(m);
                        long d = Calculate_d(e_, m);

                        var startTime = System.Diagnostics.Stopwatch.StartNew();
                        List<string> result = RSA_Endoce(s, e_, n);
                        startTime.Stop();
                        var resultTime = startTime.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                            resultTime.Hours,
                                                            resultTime.Minutes,
                                                            resultTime.Seconds,
                                                            resultTime.Milliseconds);
                        timeWork.Text = elapsedTime;

                        StreamWriter sw = new StreamWriter("code.txt");
                        foreach (string item in result)
                            sw.WriteLine(item);
                        sw.Close();

                        dNumber.Text = d.ToString();
                        nNumber.Text = n.ToString();
                        eNumber.Text = e_.ToString();
                        nNumber_Copy.Text = n.ToString();

                    }
                    else
                        MessageBox.Show("p и q должны быть простыми");
                }
                else
                    MessageBox.Show("Введите p и q");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void decodeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((dNumber.Text.Length > 0) && (nNumber_Copy.Text.Length > 0))
                {
                    long d = Convert.ToInt64(dNumber.Text);
                    long n = Convert.ToInt64(nNumber_Copy.Text);

                    List<string> input = new List<string>();

                    StreamReader sr = new StreamReader("code.txt");

                    while (!sr.EndOfStream)
                    {
                        input.Add(sr.ReadLine());
                    }

                    sr.Close();

                    var startTime = System.Diagnostics.Stopwatch.StartNew();
                    string result = RSA_Dedoce(input, d, n);
                    startTime.Stop();
                    var resultTime = startTime.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                        resultTime.Hours,
                                                        resultTime.Minutes,
                                                        resultTime.Seconds,
                                                        resultTime.Milliseconds);
                    timeWork.Text = elapsedTime;
               
                    StreamWriter sw = new StreamWriter("decode.txt");
                    sw.WriteLine(result);
                    sw.Close();

                }
                else
                    MessageBox.Show("Введите секретный ключ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();
            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }
            return result;
        }
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        //вычисление параметра e. e должно быть взаимно простым с m
        private long Calculate_e(long m)
        {
            long e = m - 1;// е это взаимно простое число с фи от n m- это фи от n

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (e % i == 0)) //если имеют общие делители
                {
                    e--;
                    i = 1;
                }
            return e;
        }

        //вычисление параметра d
        private long Calculate_d(long e, long m)
        {
            long d = 1000;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    d++;
            }

            return d;
        }

     
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            System.Numerics.BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
    }
}
