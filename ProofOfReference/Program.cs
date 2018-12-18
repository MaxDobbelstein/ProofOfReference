using System;

namespace ProofOfReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var proof = new ProofOfReference();
            proof.FirstMethod();
            proof.SecondMethod();
            proof.ThirdMethod();
            Console.ReadLine();
        }
    }
}
