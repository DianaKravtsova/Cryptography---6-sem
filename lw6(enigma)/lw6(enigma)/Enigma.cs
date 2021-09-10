using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw6_enigma_
{
    class Enigma
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      
     
        private  string rotorVconf = "VZBRGITYUPSDNHLXAWMJQOFECK";
        private  string rotorBetaconf = "LEYJVCNIXWPBQMDRTAKZFGUHOS";     
        private  string rotorGammaconf = "FSOKANUERHMBTIYCWLQPZXVGJD";

        private const string reflectorBDUNNconf = "AEBNCKDQFUGYHWIJLOMPRXSZTV";

        private  int settingL = 0;
        private  int settingM = 0;
        private  int settingR = 0;
   
        public Dictionary<char, char> useReflector { get; set; }

        Dictionary<char,char> GetReflector(string nameReflector)
        {
            Dictionary<char, char> result = new Dictionary<char, char>();
            for (int i = 0; i < nameReflector.Length; i += 2)
            {
                result.Add(nameReflector[i], nameReflector[i + 1]);
                result.Add(nameReflector[i+1], nameReflector[i]);
            }

            return result;
        }

        Dictionary<int, char> GetDictionary(string param)
        {
            Dictionary<int, char> result = new Dictionary<int, char>();
            for (int i = 0; i < param.Length; i++)
            {
                result.Add(i, param[i]);
            }

            return result;
        }

        public char Encript(char charForEncrypt)
        {
            char resultChar= ' ';
            Dictionary<int, char> lRotor = GetDictionary(rotorBetaconf),
                   mRotor = GetDictionary(rotorGammaconf) ,
                   rRotor = GetDictionary(rotorVconf),
                   alphabetDictionary = GetDictionary(alphabet);

            Dictionary<char, char> useReflector = GetReflector(reflectorBDUNNconf);

            bool circleM = false; //review

            int numberChar = alphabetDictionary.Where(v => v.Value == charForEncrypt).FirstOrDefault().Key;

            forwardStepRotor(rRotor, alphabetDictionary, ref resultChar, ref numberChar);
            Console.WriteLine($"Символ {charForEncrypt} после правого ротора {resultChar}");

            forwardStepRotor(mRotor, alphabetDictionary, ref resultChar, ref numberChar);
          Console.WriteLine($"Символ {charForEncrypt} после центрального ротора  {resultChar}");

            forwardStepRotor(lRotor, alphabetDictionary, ref resultChar, ref numberChar);
            Console.WriteLine($"Символ {charForEncrypt} после левого ротора  {resultChar}");

            char t = useReflector.Where(k => k.Key == resultChar).FirstOrDefault().Value; ;
            if (char.IsLetter(t))
            {
                resultChar = t;
                numberChar = alphabetDictionary.Where(v => v.Value == resultChar).FirstOrDefault().Key;
            }
           Console.WriteLine($"Символ {charForEncrypt} после рефлектора {resultChar}");

            backStepRotor(lRotor, alphabetDictionary, ref resultChar, ref numberChar);
            Console.WriteLine($"Символ {charForEncrypt} после левого ротора  {resultChar}");

            backStepRotor(mRotor, alphabetDictionary, ref resultChar, ref numberChar);
            Console.WriteLine($"Символ {charForEncrypt} после центрального ротора  {resultChar}");

            backStepRotor(rRotor, alphabetDictionary, ref resultChar, ref numberChar);
            Console.WriteLine($"Символ {charForEncrypt} после правого ротора {resultChar}");
        

            if (settingR % 26 != 0 || settingR == 0)
            {
                settingR += 2;
                updateSettingRotor(ref rotorVconf, 2);
            }
            else if(settingR % 26 == 1)
            {
                settingR = 0;
                settingR += 2;
                updateSettingRotor(ref rotorVconf, 2);
            }

            if (settingM % 26 != 0 || settingM == 0)
            {
                settingM += 2;
                updateSettingRotor(ref rotorGammaconf, 2);
            }
            else if (settingM % 26 == 1)
            {
                settingM = 0;
                settingM += 2;
                updateSettingRotor(ref rotorGammaconf, 2);
                if(settingL % 26 == 0)
                {
                    settingL += 1;
                    updateSettingRotor(ref rotorBetaconf, 1);
                }
                else if (settingL % 26 == 1)
                {
                    settingL = 0;
                    settingL += 1;
                    updateSettingRotor(ref rotorBetaconf, 1);
                }
            }

            Console.WriteLine("___________________________");



            return resultChar;
        }

        void updateSettingRotor(ref string rotor, int step)
        {
            string removeChar = "";

            for (int i = 0; i < step; i++)
                removeChar += rotor[i];

            rotor = rotor.Remove(0, step);
            rotor += removeChar;
        }
        void forwardStepRotor(Dictionary<int, char> rotor, Dictionary<int, char> alph, ref char character, ref int numberChar)
        {
            int num = numberChar;
            character = rotor.Where(k => k.Key == num).FirstOrDefault().Value;
            char s = character;
            numberChar = alph.Where(v => v.Value == s).FirstOrDefault().Key;
        }

        void backStepRotor(Dictionary<int, char> rotor, Dictionary<int, char> alph, ref char character, ref int numberChar)
        {
            char s = character;
            numberChar = rotor.Where(v => v.Value == s).FirstOrDefault().Key;
            int num = numberChar;
            character = alph.Where(k => k.Key == num).FirstOrDefault().Value;
        }

    }
}
