using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{

    public partial class Program
    {
        static string[] SentenceCuter(string SaidSentence)
        {
            return SaidSentence.Split(' ');
        }
        static void DebugSentence(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static string[] SentenceReverse(string inputPhrase)
        {
            string[] reversString;
            reversString = SentenceCuter(inputPhrase);
            Array.Reverse(reversString);
            return reversString;
        }

    }
}
