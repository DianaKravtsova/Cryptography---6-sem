using System.Collections.Generic;

namespace lw3
{
    class funcForLab
    {
        public static bool IsPrimeNumber(int n)
        {
            bool result = true;

            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static List<int> SieveEratosthenes(int a, int b)
        {
            List<int> list = new List<int>();
            int n = a;
            for (int i = 2; i <= b; i++)
            {
                list.Add(i);
            }
           
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 2; j <= b; j++)
                {
                    list.Remove(list[i] * j);
                  
                }
            }
         
            list.RemoveAll(num => num < a);

            return list;
        }

        public static int Evklid(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            return a;
        }

        public static int Evklid_3(int a, int b, int c)
        {
            return Evklid(Evklid(a, b), c);
        }

    }
}
