using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long SSN { get; set; }

        public Human(string name, int age, long ssn)
        {
            this.Name = name;
            this.Age = age;
            this.SSN = ssn;
        }

        public void DoSomething()
        {
            Console.WriteLine("HEY PEOPLE MY NAME IS: " + this.Name + ", my age is: " + this.Age + " and my ssn is: " + this.SSN + " !!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Jack", 37, 3713712371317);
            human.DoSomething();
            Console.ReadLine();
        }
    }
}
