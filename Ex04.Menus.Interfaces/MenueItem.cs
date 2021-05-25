using System;

namespace Ex04.Menus.Interfaces
{
    public class MenueItem
    {

        private readonly string m_Title;

        public string Text
        {
            get { return m_Title; }
        }

        public MenueItem(string i_Titls) 
        {
            m_Title = i_Titls;
        }

        public override string ToString()
        {
            return m_Title;
        }
    }
}
