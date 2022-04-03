namespace HangmanGame 
{
    internal class HangmanGame
    {
        private static void PrintWord(string word, List<char> letters)
        {
            Console.Write("Word : ");
            for (var i = 0; i < word.Length; i++)
            {
                if (letters.Contains(word[i]))
                {
                    Console.Write(word[i]+" ");
                }
                else
                {
                    Console.Write("_ ");    
                }
            }
            Console.WriteLine("");
        }
        
        private static void GuessWord(string word)
        {
            
        }

        private static string AskForLetter()
        {
            string? letter;
            do
            {
                letter = Console.ReadLine();
                
                
                
            } while (letter.Length != 1);

            return letter.ToUpper();
        }
        
        static void Main(string[] args)
        {
            //only uppercase
            var word = "ELEPHANT";
            PrintWord(word,new List<char> {'E','P','N'});
            //Console.ReadLine();
        }
    }
}