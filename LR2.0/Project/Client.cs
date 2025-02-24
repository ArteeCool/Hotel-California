using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Client : User
    {
        public Client() { }

        public Client(string name, int age) : base(name, age) { }

        public override void SaySomething()
        {
            Console.WriteLine("Something!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
