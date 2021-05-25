using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Leaf : MenuItem
    {
        private IExecutable m_ActionToExetute;

        public Leaf(string i_Title, IExecutable i_ActionToExetute) : base(i_Title)
        {
            m_ActionToExetute = i_ActionToExetute;
        }
        public void PrintAction() 
        {
            m_ActionToExetute.Invoke();
        }
    }
}
