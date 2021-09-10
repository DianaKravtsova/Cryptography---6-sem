using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw5
{
    class RouteRearrangement
    {
        char[] alphabetRus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public char[] AlphabetRus { get => alphabetRus; set => alphabetRus = value; }

        public string Code(String fileText)
        {
            string result = "";
            int N = Convert.ToInt32(Math.Ceiling(Math.Sqrt(fileText.Length)));
            char[,] resultArr = new char[N, N];

            char[,] textArr = new char[N, N];
            int k = 0;
            int i = 0;
            int j = 0;
            for ( i = 0; i < N; i++)
            {
                for ( j = 0; j < N; j++)
                {
                    if(k >= fileText.Length || fileText[k] == '\0')
                    {
                       textArr[i, j] = ' ';
                        k++;
                    }
                    else if(fileText[k] != '\0')
                    {
                        textArr[i, j] = fileText[k];
                        k++;
                    }
                }
            }

            int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
            k = 0;
            j = 0;
            i = 0;
            while (k < N * N)
            {
               result += textArr[i, j];
                

                if (j == Jbeg && i < N - Ifin - 1)
                    ++i;
                else if (j < N - Jfin - 1 && i == N - Ifin - 1)
                    ++j;
                else if (i == Ibeg  && j > Jbeg)
                    --j;
                else
                    --i;

                if ((j == Jbeg + 1) && (i == Ibeg))
                {
                    ++Ibeg;
                    ++Ifin;
                    ++Jbeg;
                    ++Jfin;
                }
                ++k;
            }

            return result;
        }

        public string Decode(String fileText)
        {
            string result = "";
            int N = Convert.ToInt32(Math.Ceiling(Math.Sqrt(fileText.Length-2)));
            char[,] resultArr = new char[N, N];

            int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
            int k = 0;
            int j = 0;
            int i = 0;
            char[,] textArr = new char[N, N];

            while (k < N * N)
            {
                if (k >= fileText.Length || fileText[k] == '\0') textArr[i, j] = ' ';
                else if (fileText[k] != '\0') textArr[i, j] = fileText[k];
                  

                if (j == Jbeg && i < N - Ifin - 1)
                    ++i;
                else if (j < N - Jfin - 1 && i == N - Ifin - 1)
                    ++j;
                else if (i == Ibeg && j > Jbeg)
                    --j;
                else
                    --i;

                if ((j == Jbeg + 1) && (i == Ibeg))
                {
                    ++Ibeg;
                    ++Ifin;
                    ++Jbeg;
                    ++Jfin;
                }
                ++k;
            }

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    if (textArr[r, c] != ' ')
                        result += textArr[r, c];
                }
            }
            return result;
        }

        public double[] CountChar(char[] alph, String fileText)
        {
            double[] count = new double[alph.Length];
            for (int i = 0; i < alph.Length; i++)
            {
                count[i] = fileText.ToUpper().Where(el => el == alph[i]).Count() ;
            }
            return count;
        }
    }
}
