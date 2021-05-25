using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected readonly string m_Title;
        protected readonly List<MenuItem> m_ListOfItems;

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

        public void add(MenuItem i_Item) 
        {
            m_ListOfItems.Add(i_Item);
        }
    }
}
