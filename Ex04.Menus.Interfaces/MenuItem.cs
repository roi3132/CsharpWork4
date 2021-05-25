using System;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {

        private readonly string m_Title;

        public string Title
        {
            get { return m_Title; }
        }

        public MenuItem(string i_Titls) 
        {
            m_Title = i_Titls;
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
