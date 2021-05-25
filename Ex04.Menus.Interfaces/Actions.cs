using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class Actions
    {
        public class ShowVersion : IExecutable
        {
            public void Invoke()
            {
                Console.WriteLine("Version: 21.1.4.8930");
            }
        }

        public class CountSpacesInSenteces : IExecutable
        {
            public void Invoke()
            {
                Console.WriteLine("Please Enter a sentences.");
                string sentences = Console.ReadLine();
                int count = 0;
                foreach (char letter in sentences)
                {
                    if (char.IsWhiteSpace(letter))
                    {
                        count++;
                    }
                }
            }
        }

        public class ShowTime : IExecutable
        {
            public void Invoke()
            {
                DateTime time = DateTime.Now;
                Console.WriteLine("The time is {0}", time.ToShortTimeString());
            }
        }

        public class ShowDate: IExecutable
        {
            public void Invoke()
            {
                DateTime time = DateTime.Now;
                Console.WriteLine("The Date is {0}", time.ToShortDateString());
            }
        }
    }
}

