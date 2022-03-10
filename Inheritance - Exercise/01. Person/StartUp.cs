using System;
namespace Person
{
    public class StartUp
    {
        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public Person(string name, int age)
            {
                
                
                    this.Age = age;
                    this.Name = name;
                
                
            }
            public override string ToString()
            {
                return $@"Name: {this.Name}, Age: {Age}";
            }

        }

        public class Child : Person
        {
            
            public Child(string name, int age) 
                : base(name,age)
            {

            }
        }
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child child = new Child(name, age);
            Console.WriteLine(child);
        }
    }
}