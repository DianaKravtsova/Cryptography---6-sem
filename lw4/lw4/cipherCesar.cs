using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw4
{
    class cipherCesar
    {
        char[] alphabetRus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public char[] AlphabetRus { get => alphabetRus; set => alphabetRus = value; }

        public string codeCesar(String fileText, string keyWord)
        {
            string result = "";
            char[] codeAlphabet = GetCodeAlphabet(keyWord);
            for (int i = 0; i < fileText.Length; i++)
            {
                for (int j = 0; j < AlphabetRus.Length; j++)
                {
                    if(fileText[i] == AlphabetRus[j])
                    {
                        result += codeAlphabet[j];
                        break;
                    }

                }
            }
            return result;
        }

        public string decodeCesar(String fileText, string keyWord)
        {
            string result = "";
            char[] codeAlphabet = GetCodeAlphabet(keyWord);
            for (int i = 0; i < fileText.Length; i++)
            {
                for (int j = 0; j < AlphabetRus.Length; j++)
                {
                    if (fileText[i] == codeAlphabet[j])
                    {
                        result += AlphabetRus[j];
                        break;
                    }

                }
            }
            return result;
        }

        public char[] GetCodeAlphabet(string keyWord)
        {
            char[] result = new char[33];
            bool flag = false;
            int count = 0;
            for (int i = 0; i < keyWord.Length; i++)
            {
                result[i] = keyWord[i];
                count++;
            }
            for (int a = 0; a < AlphabetRus.Length; a++)
            {
                for (int c = 0; c < keyWord.Length; c++)
                {
                    if (result[c] == AlphabetRus[a])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    result[count] = AlphabetRus[a];
                    count++;
                }

                flag = false;
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
