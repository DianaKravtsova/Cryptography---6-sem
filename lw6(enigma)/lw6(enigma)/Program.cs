using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lw6_enigma_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "", result = "",
                   resultDec = "";

            Regex patternEN = new Regex(@"[A-za-z]");
            Console.WriteLine("Введите текс:");
            text = Console.ReadLine().ToUpper();
            MatchCollection matches = patternEN.Matches(text);
            text = "";
            foreach (Match match in matches)
                text += match;

            
            Enigma e = new Enigma();
            Console.WriteLine("Encript");
            foreach(var i in text)
            {
                if (i != ' ')
                    result += e.Encript(i);
            }
            Console.WriteLine($"Результат шифрования {result}");
            Enigma d = new Enigma();
            Console.WriteLine("Decript");
            foreach (var i in result)
            {
                if (i != ' ')
                    resultDec += d.Encript(i);
            }
            Console.WriteLine($"Результат дешифрования {resultDec}");

            Console.ReadKey();
        }
    }
}
