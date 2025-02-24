using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator("cringe", 18);

            Console.WriteLine(admin.GetName());
            admin.CardNumber();

            Console.ReadKey();

        }
    }
}
