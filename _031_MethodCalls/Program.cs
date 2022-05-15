using System;

namespace _031_MethodCalls
{
    class Program
    {
        // base class
        public class Bird
        {
            // methods to allow overriding
            public virtual void talk()
            {
                Console.WriteLine("A bird talks...(base Bird class talk() method)");
            }

            public virtual void fly()
            {
                Console.WriteLine("A bird flies...(base Bird class fly() method)\n");
            }
        }

        // derived class from base
        public class Pigeon : Bird
        {
            public override void talk() 
            {
                Console.WriteLine("A pigeon says, coo! coo! (Derived Pigeon class talk() method)");
            }

            public override void fly()
            {
                Console.WriteLine("A pigeon flies away... (Derived Pigeon class fly() method)");
                // the fly method in each derived class also calls the base class fly() method directly
                base.fly();
            }
        }

        // derived class from base
        public class Chicken : Bird
        {
            public override void talk()
            {
                Console.WriteLine("A chicken says, cluck! cluck! (Derived Chicken class talk() method)");
            }

            public override void fly()
            {
                Console.WriteLine("A chicken can't fly... (Derived Chicken class fly() method)");
                // the fly method in each derived class also calls the base class fly() method directly
                base.fly();
            }
        }

        // call both overriding methods
        static void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }

        static void Main(string[] args)
        {
            // instances of non-base classes  
            Pigeon pigeon1 = new Pigeon();
            Chicken chicken1 = new Chicken();

            // call the describe method that call the overriding methods for each instance
            describe(pigeon1);
            describe(chicken1);

            Console.WriteLine();  // space in output
        }
    }
}
