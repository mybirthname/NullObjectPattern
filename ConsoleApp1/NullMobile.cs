using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    public class NullMobile : IMobile
    {

        private static NullMobile _instance;

        private NullMobile()
        {

        }

        public static NullMobile GetInstance()
        {
            if (_instance == null)
                _instance = new NullMobile();

            return _instance;
        }

        public void Turnoff()
        {
            Console.WriteLine();
        }

        public void TurnOn()
        {
            Console.WriteLine();
        }
    }
}
