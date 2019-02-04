using System;
using System.Collections.Generic;

namespace permutation
{
    //3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //    Например: badc ​являются перестановкой ​abcd.​
    // Дмитрий Волков

    class Program
    {
        static Dictionary<char, int> CharFreqAnalysis(string inputWord)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < inputWord.Length; i++)
            {
                char indexChar = inputWord[i];
                if (result.ContainsKey(indexChar))
                {
                    result[indexChar] = result[indexChar] + 1;
                } else
                {
                    result.Add(indexChar, 1);
                }
            }
            return result;
        }

        static public bool IsMutation(string a, string b)
        {
            if (a.Length == b.Length && a.Length == b.Length)
            {
                Dictionary<char, int> ar = CharFreqAnalysis(a);
                Dictionary<char, int> br = CharFreqAnalysis(b);
                foreach (KeyValuePair<char, int> kvp in ar)
                {
                    try
                    {
                        if (br[kvp.Key] != kvp.Value) return false;
                    }
                    catch (KeyNotFoundException)
                    {
                        return false;
                    }
                    
                }
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(IsMutation("badc", "abcd"));
        }
    }
}
