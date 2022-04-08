using System;
using ClassDemoOperator.model;

namespace ClassDemoOperator
{
    internal class AWorker
    {
        public AWorker()
        {
        }

        public void Start()
        {
            Position p1 = new Position(3, 4);
            Position p2 = new Position(2, 6);
            Position p3 = new Position(3, 4); // same values as p1
            Position p4 = p1;

            Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);
            Console.WriteLine("p3: " + p3);
            Console.WriteLine("p4: " + p4);
            Console.WriteLine();


            Console.WriteLine("p1.Equals(p3): " + (p1.Equals(p3)));
            Console.WriteLine("p1.Equals(p4): " + (p1.Equals(p4))); 
            Console.WriteLine("p1 == p3: " + (p1 == p3));
            Console.WriteLine("p1 == p4: " + (p1 == p4));

            Console.WriteLine("p1 + p2: " + (p1 + p2));
            Console.WriteLine("p1 + 3: " + (p1 + 3));
            Console.WriteLine("3 + p2: " + (3 + p2));



        }
    }
}