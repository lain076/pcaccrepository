using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsFormation
{
    static class Tools
    {
        public static int AskNumberWithLengthPositivAndNoNNull(string question)
        {
            return AskNumberWithLengthBetween(question, 1, int.MaxValue);
        }

        public static int AskNumberWithLengthBetween(string question, int min, int max)
        {
            int passwordLenght = AskNumberWithLength("Lenght of the password : ");
            if ((passwordLenght >= min) && (passwordLenght <= max))
            {
                return passwordLenght;
            }
            Console.WriteLine("Error : the number must between " + min + " " + max);
            return AskNumberWithLengthBetween(question, min, max);
        }

        public static int AskNumberWithLength(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string answord = Console.ReadLine();
                try
                {
                    int answordInt = int.Parse(answord);
                    return answordInt;
                }
                catch
                {
                    Console.WriteLine("Error you must enter a number");
                }
            }
        }
    }
}
