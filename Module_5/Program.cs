using System;

namespace Module_5
{
    public class Program
    {
        public string saidSentence { get; set; }

        static void Main(string[] args)
        {
        }

        public static string[] SentenceCuter(string saidSentence)
        {
            return saidSentence.Split(' ');
        }

        public static string[] SentenceReverse(string inputPhrase)
        {
            string[] reversString;
            reversString = SentenceCuter(inputPhrase);
            Array.Reverse(reversString);
            return reversString;
        }
    }
}
