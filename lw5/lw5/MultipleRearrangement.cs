using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw5
{
    class MultipleRearrangement
    {
        char[] alphabetRus = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public char[] AlphabetRus { get => alphabetRus; set => alphabetRus = value; }

        public string Code(String fileText, string key1, string key2)
        {
            string result = "";

            if (fileText.Length > key1.Length * key2.Length)
                return "Текст больше допустимого";
            int []keyArr1 = new int[key1.Length];
            int []keyArr2 = new int[key2.Length];
            int[] keyArrSort1 = new int[key1.Length];
            int[] keyArrSort2 = new int[key2.Length];
            char[,] textArr = new char[key1.Length, key2.Length];
            int k1 = 1, k2 = 1;
            for (int i = 0; i < AlphabetRus.Length; i++)
            {
                for (int j = 0; j < key1.Length; j++)
                {
                    if(key1[j] == AlphabetRus[i])
                    {
                        keyArr1[j] = k1;
                        keyArrSort1[k1 - 1] = k1; 
                        k1++;
                    }

                }
                for (int j = 0; j < key2.Length; j++)
                {
                    if (key2[j] == AlphabetRus[i])
                    {
                        keyArr2[j] = k2;
                        keyArrSort2[k2 - 1] = k2;
                        k2++;
                    }
                }
            }

            int k = 0;
            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    if (k < fileText.Length) textArr[i, j] = fileText[k];
                    else textArr[i, j] = ' ';
                    k++;
                }
            }

            char[,] sortRowArr = new char[key1.Length, key2.Length];
            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key1.Length; j++)
                {
                    if (keyArr1[i] == keyArrSort1[j])
                    {
                        for (int c = 0; c < key2.Length; c++)
                        {
                            //   sortRowArr[i,c] = textArr[j,c];
                            sortRowArr[j, c] = textArr[i, c];
                        }
                    }
                }
                
            }

            char[,] resultArr = new char[key1.Length, key2.Length];
            for (int i = 0; i < key2.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    if (keyArr2[i] == keyArrSort2[j])
                    {
                        for (int r = 0; r < key1.Length; r++)
                        {
                            //resultArr[r,i] = sortRowArr[r,j];
                            resultArr[r, j] = sortRowArr[r, i];
                        }
                    }
                }

            }

            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    result += resultArr[i, j];
                }
            }

            return result;
        }

        public string Decode(String fileText, string key1, string key2)
        {
            string result = "";

            if (fileText.Length - 2 > key1.Length * key2.Length)
                return "Текст больше допустимого";
            int[] keyArr1 = new int[key1.Length];
            int[] keyArr2 = new int[key2.Length];
            int[] keyArrSort1 = new int[key1.Length];
            int[] keyArrSort2 = new int[key2.Length];
            char[,] textArr = new char[key1.Length, key2.Length];
            int k1 = 1, k2 = 1;
            for (int i = 0; i < AlphabetRus.Length; i++)
            {
                for (int j = 0; j < key1.Length; j++)
                {
                    if (key1[j] == AlphabetRus[i])
                    {
                        keyArr1[j] = k1;
                        keyArrSort1[k1 - 1] = k1;
                        k1++;
                    }

                }
                for (int j = 0; j < key2.Length; j++)
                {
                    if (key2[j] == AlphabetRus[i])
                    {
                        keyArr2[j] = k2;
                        keyArrSort2[k2 - 1] = k2;
                        k2++;
                    }
                }
            }

            int k = 0;
            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    if (k < fileText.Length -2) textArr[i, j] = fileText[k];
                    else textArr[i, j] = ' ';
                    k++;
                }
            }

            char[,] sortRowArr = new char[key1.Length, key2.Length];
            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key1.Length; j++)
                {
                    if (keyArr1[i] == keyArrSort1[j])
                    {
                        for (int c = 0; c < key2.Length; c++)
                        {
                            sortRowArr[i,c] = textArr[j,c];
                           // sortRowArr[j, c] = textArr[i, c];
                        }
                    }
                }

            }

            char[,] resultArr = new char[key1.Length, key2.Length];
            for (int i = 0; i < key2.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    if (keyArr2[i] == keyArrSort2[j])
                    {
                        for (int r = 0; r < key1.Length; r++)
                        {
                            resultArr[r,i] = sortRowArr[r,j];
                            //resultArr[r, j] = sortRowArr[r, i];
                        }
                    }
                }

            }

            for (int i = 0; i < key1.Length; i++)
            {
                for (int j = 0; j < key2.Length; j++)
                {
                    result += resultArr[i, j];
                }
            }

            return result;
        }

        public int[] CountChar(char[] alph, String fileText)
        {
            int[] count = new int[alph.Length];
            for (int i = 0; i < alph.Length; i++)
            {
                count[i] = fileText.ToUpper().Where(el => el == alph[i]).Count() ;
            }
            return count;
        }
    }

    
}

