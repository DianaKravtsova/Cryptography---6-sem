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

namespace ElGamal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int g_main;
        static int p_main;
        static int k;
        static int x;
        static List<BigInteger> a = new List<BigInteger>();
        static List<BigInteger> resultCode = new List<BigInteger>();
        static int textLength; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void codeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aNumber.Text = "";
                resultNumber.Text = "";
                p_main = Search_p();
                Random random = new Random();

                x = random.Next(1, p_main - 1); //Генерирую закрытый ключ
                BigInteger y = BigInteger.Pow(g_main, x) % p_main; //Нахожу открытый ключ

                pNumber.Text = p_main.ToString();
                gNumber.Text = g_main.ToString();
                xNumber.Text = x.ToString();
                yNumber.Text = y.ToString();

                string s = "";

                StreamReader sr = new StreamReader("text.txt");

                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine();
                }

                sr.Close();
                textLength = s.Length;
                s = s.ToUpper();
                resultCode.RemoveAll(u => true);
                var startTime = System.Diagnostics.Stopwatch.StartNew();
                resultCode = Code(s, p_main, y);
                startTime.Stop();
                var resultTime = startTime.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                    resultTime.Hours,
                                                    resultTime.Minutes,
                                                    resultTime.Seconds,
                                                    resultTime.Milliseconds);
                timeWork.Text = elapsedTime;
                kNumber.Text = k.ToString();
                StreamWriter sw = new StreamWriter("code.txt");

                foreach(var item in a)
                {
                    aNumber.Text += item.ToString() + '\n';
                }
                foreach (var item in resultCode)
                {
                    sw.WriteLine(item);
                    resultNumber.Text += item.ToString() + '\n';
                }

                sw.Close();
                
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
                List<string> input = new List<string>();
                StreamReader sr = new StreamReader("code.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                var startTime = System.Diagnostics.Stopwatch.StartNew();
                string resultDecode = Decode(textLength, resultCode, x, p_main);
                startTime.Stop();
                var resultTime = startTime.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                                                    resultTime.Hours,
                                                    resultTime.Minutes,
                                                    resultTime.Seconds,
                                                    resultTime.Milliseconds);
                timeWork.Text = elapsedTime;

                StreamWriter sw = new StreamWriter("decode.txt");
                sw.WriteLine(resultDecode);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static List<BigInteger> Code(string text, int p, BigInteger y)
        {
            List<BigInteger> array = new List<BigInteger>();
            a.RemoveAll(x => true);
            Random random = new Random();
            k = random.Next(1, p - 1);
           

            for (int i = 0; i != text.Length; i++)
            {
                a.Add(BigInteger.Pow(g_main, k) % p);
                
                array.Add((BigInteger.Pow(y, k) * (int)text[i]) % p);
            }
            return array;
        }

        public static bool Search_g(int p, int g)
        {
            bool boolean = false;
            List<BigInteger> array_mod_number = new List<BigInteger>();

            BigInteger integer = ((BigInteger.Pow(g, 1)) % p);
            array_mod_number.Add(integer);

            for (int i = 2; i != p; i++)
            {
                integer = BigInteger.Pow(g, i) % p;
                for (int j = 0; j != i - 1; j++)
                {
                    if (array_mod_number[j] == integer)
                    {
                        g--;
                        array_mod_number.Clear();
                        i = 1;
                        integer = BigInteger.Pow(g, 1) % p;
                        array_mod_number.Add(integer);
                        break;
                    }

                    if ((j == i - 2) && (array_mod_number[j] != integer))
                    {
                        array_mod_number.Add(integer);
                    }
                }
            }
            g_main = g;
            boolean = true;
            return boolean;
        }

        public static string Decode(int length_text, List<BigInteger> array_number, int x, int p)
        {
            string save_text = "";
            BigInteger integer;

            for (int i = 0; i != length_text; i++)
            {
                integer = (array_number[i] * (BigInteger.Pow(a[i], p - 1 - x))) % p;
                save_text += (char)integer;
            }
            return save_text;
        }
        public static int Search_p()
        {
            Random random = new Random();
            int p = 0;
            Boolean boolean = false;
            do
            {
                p = random.Next(2000, 2500);

                for (int i = 2; i != p; i++)
                {
                    if (i == p - 1)
                    {
                        boolean = Search_g(p, p - 1);
                        break;
                    }
                    if (p % i == 0) break;
                }
            }
            while (boolean == false);
            return p;
        }


    }
}
