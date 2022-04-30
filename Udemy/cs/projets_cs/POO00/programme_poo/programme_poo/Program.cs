using System.Collections;

namespace programme_poo 
{
    class person
    {
        private static int _peopleNumber;
        public string name;
        private int age;
        private string job;
        private int number;
        
        public person(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            _peopleNumber++;
            number = _peopleNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"NAME : {name}");
            Console.WriteLine($"AGE  : {age}");
            Console.WriteLine($"JOB  : {job}");
            Console.WriteLine($"NUM  : {number}");
            Console.WriteLine("");
        }

        public static void TotalOfPeople()
        {
            Console.WriteLine("Total number of people " + _peopleNumber);
        }
            
    }
        
    
    internal class programme_poo
    {
        static void Main(string[] args)
        {
            var people = new List<person>();

            people.Add(new person("David", 46, "coder"));
            people.Add(new person("Samsam", 15, "student"));
            people.Add(new person("Grathy", 42, "cooker"));
            people.Add(new person("Anais", 16, "student"));
            
            people = people.OrderBy(p =>p.name).ToList();
            
            foreach (var person in people)
            {
                person.DisplayInfo();
            }
            person.TotalOfPeople();
        }
    }
}