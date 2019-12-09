using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");
            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Operator +: {one + two} ");

            Console.WriteLine($"Subtraction -: {one - two}");


            Console.WriteLine($"Scalar multiplication: {two * 2}");


            Console.WriteLine($"Should not be equal: {one == two}");


            Console.WriteLine($"Increment: {one++}");
        }
    }
}
