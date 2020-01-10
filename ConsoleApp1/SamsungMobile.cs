using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class SamsungMobile : IMobile
    {
        public void Turnoff()
        {
            Console.WriteLine("Samsung Mobile phone is turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung Mobile phone is turn off");
        }
    }
}
