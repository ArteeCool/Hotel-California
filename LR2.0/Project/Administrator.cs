using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Administrator :  User, Interface
    {
        public Administrator(string name, int age) : base(name, age) { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void SaySomething()
        {
            Console.WriteLine("Abstraction is everywhere!");
        }

        public void BanUser(string username) // Унікальний метод
        {
            Console.WriteLine( $"{username} is banned now!");
        }

        public void CardNumber()
        {
            Console.Write("Enter your card number: ");
            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            Console.WriteLine($"Your card number is {number}. Thanks for your money, pal");
        }

    }
}
