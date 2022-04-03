using System;

namespace premier_programme
{
    internal class Program
    {

        static string DemanderNom()
        {
            string nomDeLAPersonne = "";

            while (nomDeLAPersonne == "")
            {
                Console.Write("What is your name?");
                nomDeLAPersonne = Console.ReadLine();
                nomDeLAPersonne = nomDeLAPersonne.Trim();
                if (nomDeLAPersonne == "")
                {
                    Console.WriteLine("You must enter a valid name");
                }
            }
            return nomDeLAPersonne;
        }

        static int DemanderAge()
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("What is your age?");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num <= 0)
                    {
                        Console.WriteLine("age must be positive");
                    }
                }
                catch
                {
                    Console.WriteLine("error invalid age");
                }

            }
            return age_num;
        }



        static void Main(string[] args)
        {
            string nomDeLAPersonne = DemanderNom();
            int age_num = DemanderAge();

            Console.WriteLine("Hello my name is " + nomDeLAPersonne + " your are " + age_num + "year old");
            age_num++;
            Console.Write(" you soon will be " + age_num + " years old ");
        }
    }
}