using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Leaf : MenuItem
    {
        private eFunction m_Function;
        public Leaf(string i_Title, eFunction i_Function) : base(i_Title)
        {
            m_Function = i_Function;
        }
        public event Action<Leaf> Selected;

        private void OnSelected()
        {
            if (Selected != null)
            {
                Selected.Invoke(this);
            }
        }
        public enum eFunction
        {
            ShowVersion,
            CountSpaces,
            ShowTime,
            ShowDate
        }

        public void RunConcreteFunction()
        {
            switch (m_Function)
            {
                case eFunction.CountSpaces:
                    {
                        Console.WriteLine("Please Enter a sentences.");
                        string sentences = Console.ReadLine();
                        int countSpaces = 0;
                        foreach (char letter in sentences)
                        {
                            if (char.IsWhiteSpace(letter))
                            {
                                countSpaces++;
                            }
                        }
                        Console.WriteLine("The numbur of spaces is {0}", countSpaces);
                        break;
                    }
                case eFunction.ShowDate:
                    {
                        DateTime time = DateTime.Now;
                        Console.WriteLine("The Date is {0}", time.ToShortDateString());
                        break;
                    }
                case eFunction.ShowTime:
                    {
                        DateTime time = DateTime.Now;
                        Console.WriteLine("The time is {0}", time.ToShortTimeString());
                        break;
                    }
                case eFunction.ShowVersion:
                    {
                        Console.WriteLine("Version: 21.1.4.8930");
                        break;
                    }
            }
        }
    }
}
