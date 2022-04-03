using System.Net.Sockets;

namespace ObjectsList 
{
    internal class Program
    {

        class Person
        {
            private static int totalPeoples = 0;
            public int Number { get; init; }
            public string Name { get; init; }
            public int Age { get; init; }
            public string Job { get; init; }

            public Person()
            {
                totalPeoples++;
                Number = totalPeoples;
            }
            
            public Person(string name,int age) : this(name,age,"No job")
            {
                
            }
            public Person(string name,int age,string job) :this()
            {
                Name = name;
                Age = age;
                Job = job;
            }

            public void ShowInfo()
            {
                Console.WriteLine("NAME : " + Name + " Number : " + Number);
                Console.WriteLine("    Age : " + Age);
                Console.WriteLine("    Job : " + Job);
                Console.WriteLine(" ");
            }

            public static void ShowTotalPeoples()
            {
                Console.WriteLine("Total peoples : " + totalPeoples);
            }
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Run");
            var peoples = CreatePeoples();
            ShowPeoples(peoples);
        }

        private static List<Person> CreatePeoples()
        {
            var peoples = new List<Person>();
            
            peoples.Add(new Person{Name = "Pierre",Age=32,Job="Vendeur"});
            peoples.Add(new Person{Name = "Lupe",Age=20,Job="Actrice"});            
            
            peoples.Add(new Person("David",45,"Développeur"));
            peoples.Add(new Person("Grathy",42,"Secrétaire"));
            peoples.Add(new Person("Samsam",12,"Etudiant"));
            peoples.Add(new Person("Nathalie",40));
            return peoples;
        }

        private static void ShowPeoples(List<Person> peoples)
        {
            peoples = peoples.OrderBy(people => people.Name).ToList();
            foreach (Person person in peoples)
            {
                person.ShowInfo();
            }
            Person.ShowTotalPeoples();
            
        }
    }
}