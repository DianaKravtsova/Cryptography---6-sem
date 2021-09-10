using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lw7_des_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            text = string.Join("", Encoding.ASCII.GetBytes(text).Select(c => c.ToString("X2")));

            Console.WriteLine("Введите ключ 1");
            string key1 = Console.ReadLine();
            Console.WriteLine("Введите ключ 2");
            string key2 = Console.ReadLine();
            Console.WriteLine("Введите ключ 3");
            string key3 = Console.ReadLine();
            key1 = string.Join("", Encoding.ASCII.GetBytes(key1).Select(c => c.ToString("X2")));
            key2 = string.Join("", Encoding.ASCII.GetBytes(key2).Select(c => c.ToString("X2")));
            key3 = string.Join("", Encoding.ASCII.GetBytes(key3).Select(c => c.ToString("X2")));

            var des = new DesEncryption();
            var res = des.Encrypt(text, key1);
            res = des.Encrypt(res, key2);
            res = des.Encrypt(res, key3);

            Console.WriteLine(res);

            var des2 = new DesEncryption();
            var res2 = des.Decrypt(res, key3);
            res2 = des.Decrypt(res2, key2);
            res2 = des.Decrypt(res2, key1);
            res2 = Regex.Replace(new string(Encoding.ASCII.GetChars(FromHex(res2))).Trim(), @"[^\u0020-\u007E]", string.Empty);
        
            Console.WriteLine(res2);
            Console.ReadKey();

        }

        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }
    }
}
