using System;

namespace LoopInsideALoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word.");
            string newWord = Console.ReadLine();
            string currentWinner =//need to find a way to define currentWinner here so it doesnt break on loop ;
            while (true) ;          
            {
                if (newWord.Length > currentWinner.length);
                {
                    currentWinner = Console.ReadLine();
                }
            }


        }
    }
}
