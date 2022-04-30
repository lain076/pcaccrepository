using System.Collections;

namespace programme_poo 
{
    class person
    {

        public string name;
        private int age;
        private string job;        
        
        public person(string name, int age, string job)
        {
            this.name = name;
            this.age = age;
            this.job = job;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"NAME : {name}");
            Console.WriteLine($"AGE  : {age}");
            Console.WriteLine($"JOB  : {job}");
        }
    }
        
    
    internal class programme_poo
    {
        static void Main(string[] args)
        {
            var people = new List<person>();

            people.Add(new person("David", 46, "coder"));
            people.Add(new person("Grathy", 42, "cooker"));

            people = people.OrderBy(p =>p.name).ToList();
            
            foreach (person person in people)
            {
                person.DisplayInfo();
            }
            
        }
    }
}