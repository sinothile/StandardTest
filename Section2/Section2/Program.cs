using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var wordManager = new WordManager();

            Console.WriteLine("Please enter a sentence: ");
            var sentence = Console.ReadLine();
            var reversedSentence = wordManager.ReverseSentence(sentence);
            Console.WriteLine(reversedSentence);
        }
    }
}
