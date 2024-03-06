namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    internal class Program
    {
        class Cat : Animal
        {
            public override string Name { get; set; }
            public string Color { get; set; }
            public int Age { get; set; }

            public override string Describe()
            {
                return "I am a " + Color + " color, I am " + Age + " years old. My Name is " + Name;
            }

            public Cat()
            {
                Name = string.Empty;
                Color = string.Empty;
                Age = 0;
            }
            public Cat(string name, string color, int age)
            {
                Name = name;
                Color = color;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "MooCow";
            cat1.Color = "Grey and white";
            cat1.Age = 3;
            Console.WriteLine(cat1.whatAmI());
            Console.WriteLine(cat1.Describe());

            Cat cat2 = new Cat("Gemini","Orange",5);
            Console.WriteLine(cat2.whatAmI());
            Console.WriteLine(cat2.Describe());
        }
    }
}
