using System;

namespace Methods_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number.");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Multyply(6, 8));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            WelcomeUser(name);

            Goodbye();
        }

        static int Multyply(int nun1, int num2)
        {
            return nun1 * num2;
        }


        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}. I am proud that I have met you.");

        }
         
        static void Goodbye()
        {
            Console.WriteLine("have a fantastic day!");
        }
    }
}
