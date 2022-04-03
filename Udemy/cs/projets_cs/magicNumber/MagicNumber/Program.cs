using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private const int MinimalLimit = 1;
        private const int MaximalLimit = 10;

        private static int GenerateNumberToFind(int maximumNumber = 10)
        {
            var randomizer = new Random();
            return randomizer.Next(1, maximumNumber);
        }
        private static int GetUserChoice()
        {
            var numericUserChoice=0;
            while(numericUserChoice == 0)
            {
                Console.WriteLine("Choose a number between 1 and 10");
                string? userChoice = Console.ReadLine();
                try
                {
                    numericUserChoice = int.Parse(userChoice);
                }
                catch
                {
                    Console.WriteLine("Error not a number");
                }
            }
            return numericUserChoice;
        }
        private static Boolean CheckUserChoice(int randomizedNumber,int userChoice)
        {
            Boolean result = false;
            if(userChoice == randomizedNumber)
            {
                Console.WriteLine("Right");
                result = true;
            }

            if (userChoice < randomizedNumber)
            {
                Console.WriteLine("Down");
                result = false;
            }

            if (userChoice > randomizedNumber)
            {
                Console.WriteLine("Greater");
                result = false;
            }
            return result;
        }
        static Boolean NumberBetweenLimits(int userChoice,int minimalLimit,int maximalLimit)
        {
            if(userChoice < minimalLimit)
            {
                Console.WriteLine("Number under min limit");
                return false;
            }

            if(userChoice > maximalLimit)
            {
                Console.WriteLine("Number greater max limit");
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            var numberFound = false;
            int numberToFind = GenerateNumberToFind();
            int userChoice;
            var lives = 5;
            
            while (!numberFound)
            {
                userChoice = GetUserChoice();
                if(NumberBetweenLimits(userChoice,MinimalLimit,MaximalLimit))
                {
                    numberFound = CheckUserChoice(numberToFind, userChoice);
                }
                lives--;
                if (lives == 0)
                {
                    Console.WriteLine("You loose");
                    numberFound = true;
                }
            }
        }
    }
}







