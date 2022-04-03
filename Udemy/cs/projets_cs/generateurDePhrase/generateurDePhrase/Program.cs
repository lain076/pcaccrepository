using System;

namespace GenerateurDePhrase // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateSentences(int.Parse(args[0]));
        }

        private static List<string> GenerateSubjectList()
        {
            var subjectList = new List<string>();
            subjectList.Add("Un lapin");
            subjectList.Add("Une grand mère");
            subjectList.Add("Un chat");
            subjectList.Add("Un bonhomme de neige");
            subjectList.Add("Une limace");
            subjectList.Add("Une fee");
            subjectList.Add("Un magicien");
            subjectList.Add("Une totrtue");
            return subjectList;
        }
        
        private static List<string> GenerateVerbList()
        {
            var verbList = new List<string>();
            verbList.Add("mange");
            verbList.Add("écrase");
            verbList.Add("détruit");
            verbList.Add("observe");
            verbList.Add("attrape");
            verbList.Add("regarde");
            verbList.Add("avale");
            verbList.Add("nettoie");
            verbList.Add("se bat avec");
            verbList.Add("s'accroche à");
            return verbList;
        }
        
        private static List<string> GenerateComplementList()
        {
            var complementList = new List<string>();
            complementList.Add("un arbre");
            complementList.Add("un livre");
            complementList.Add("la lune");
            complementList.Add("la lune");
            complementList.Add("le soleil");
            complementList.Add("un serpent");
            complementList.Add("une carte");
            complementList.Add("une girafe");
            complementList.Add("le ciel");
            complementList.Add("une piscine");
            complementList.Add("un gateau");
            complementList.Add("une souris");
            complementList.Add("un crapaud");
            return complementList;
        }

        private static string ReturnRandomElement(IReadOnlyList<string> elementList)
        {
            var randomizer = new Random();
            return elementList[randomizer.Next(0, elementList.Count - 1)];
        }

        private static void GenerateSentences(int numberOfSentences)
        {
            var createdSentences = 0;
            var duplicatedSentences = 0;
            var createdSentencesList = new List<string>(); 

            do
            {
                string sentence = GenerateSentence();
                if (createdSentencesList.Contains((sentence)))
                {
                    duplicatedSentences++;
                }
                else
                {
                    createdSentencesList.Add(sentence);
                    createdSentences++;
                }
                
            } while (createdSentences != numberOfSentences);
            
            var sentenceNumber = 0;
            foreach (var sentence in createdSentencesList)
            {
                sentenceNumber++;
                Console.WriteLine($"{sentenceNumber} {sentence}");
            }
            Console.WriteLine((""));
            Console.WriteLine($"Duplicated sentences : {duplicatedSentences}");
        }

        private static string GenerateSentence()
        {
            var sentence = string.Empty;
            sentence = ReturnRandomElement(GenerateSubjectList()) + " ";
            sentence += ReturnRandomElement(GenerateVerbList()) + " ";
            sentence += ReturnRandomElement(GenerateComplementList());
            return sentence;
        }
    }
}
