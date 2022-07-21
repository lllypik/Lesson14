using System;

namespace Task
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        bool wool;
        string speech;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name, string speech, bool wool)
            : base(name)
        {
            this.speech = speech;
            this.wool = wool;
        }

        public override void Say()
        {
            Console.WriteLine(speech);
        }
    }

    class Dog : Animal
    {
        string speech;
        string ears;
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name, string speech, string ears)
            : base(name)
        {
            this.speech = speech;
            this.ears = ears;
        }

        public override void Say()
        {
            Console.WriteLine(speech);
        }

    }
}

