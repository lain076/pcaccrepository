using System;
using CsFormation;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {




        static void Main(string[] args)
        {
            int passwordLenght = Tools.AskNumberWithLengthPositivAndNoNNull("");

            // 2 - alphabet
            // 3 - comment choisir un cacactère aléatoire

            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string uperCase = lowerCase.ToUpper();
            string numbers = "0123456789";
            string specialChar = "&éç*%@";
            string alphabet = lowerCase + uperCase + numbers + specialChar;
            string password = string.Empty;
            int alphabetLenght = alphabet.Length;
            Random rand = new Random();


            for (int i = 0; i < passwordLenght; i++)
            {
                int index = rand.Next(0, alphabetLenght);
                password += alphabet[index];
            }

            Console.WriteLine(password);

            // 4 - générer mot de passe
            // 5 - Amélioration
        }
    }
}