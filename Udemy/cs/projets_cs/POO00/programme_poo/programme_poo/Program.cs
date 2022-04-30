using System;

namespace programme_poo 
{
    class person
    {

        private string name;
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
            person david = new person("David", 46, "coder");
            david.DisplayInfo();
            person grathy = new person("Grathy", 42, "cooker");
            grathy.DisplayInfo();
            
        }
    }
}