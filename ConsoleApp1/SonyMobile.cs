using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class SonyMobile : IMobile
    {
        public void Turnoff()
        {
            Console.WriteLine("Sony Mobile phone is turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony Mobile phone is turn on");
        }
    }
}
