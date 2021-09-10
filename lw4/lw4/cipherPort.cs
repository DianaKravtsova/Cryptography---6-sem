using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw4
{
    class cipherPort
    {
        char[] alphabetRus =  {'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'};
        public char[] AlphabetRus { get => alphabetRus; set => alphabetRus = value; }

        char[] alphabetNum = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        public char[] AlphabetNum { get => alphabetNum; set => alphabetNum = value; }

        private string[,] codeTable;
        public string[,] CodeTable
        {
            get
            {
                return GetCodeTable(AlphabetRus);
            }
            set
            {
                this.codeTable = value;
            }
        }

        string[,] GetCodeTable(char[] alphabet)
        {
            int count = 1;
            string[,] resultArr = new string[alphabet.Length, alphabet.Length];

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(count < 10)
                    {
                        resultArr[i, j] = "00" + Convert.ToString(count);
                        count++;
                    }
                    else if(count < 100)
                    {
                        resultArr[i, j] = "0" + Convert.ToString(count);
                        count++;
                    }
                    else
                    {
                        resultArr[i, j] = Convert.ToString(count);
                        count++;
                    }
                }
            }

            return resultArr;
        }

        public string codePort(String fileText)
        {
            int row = 0, column = 0;
            string result = "";

            if (fileText.Length % 2 != 0)
                fileText += "А";

            for (int i = 0; i < fileText.Length-1; i +=2)
            {
                for (int r = 0; r < AlphabetRus.Length; r++)
                {
                    if (fileText[i] == AlphabetRus[r]) {
                        row = r;
                        break;
                    }
                }
                for (int c = 0; c < AlphabetRus.Length; c++)
                {
                    if (fileText[i+1] == AlphabetRus[c])
                    {
                        column = c;
                        break;
                    }
                }
                result = result + CodeTable[row, column] + ' ';
            }

            return result;
        }

        public string decodePort(String fileText)
        {
            string result = "";
            int row = 0, column = 0;
            string[] charFromFileText = fileText.Split(new char[] { ' ' });

            for (int i = 0; i < charFromFileText.Length; i++)
            {
                if (charFromFileText[i] == "\r\n")
                    break;
                for (int r = 0; r < AlphabetRus.Length; r++)
                {
                    for (int c = 0; c < AlphabetRus.Length; c++)
                    {
                        if(charFromFileText[i] == CodeTable[r,c])
                        {
                            row = r;
                            column = c;
                            break;
                        }
                    }
                }

                result = result + AlphabetRus[row] + AlphabetRus[column];
            }
            return result;
        }

        public int[] CountChar(char[] alph, String fileText)
        {
            int[] count = new int[alph.Length];
            for (int i = 0; i < alph.Length; i++)
            {
                count[i] = fileText.ToUpper().Where(el => el == alph[i]).Count();
            }
            return count;
        }

    }
}
