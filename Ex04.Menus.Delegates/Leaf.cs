using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void LeafMenuSelectedEventHandler();
    public class Leaf : MenuItem
    {
        public event LeafMenuSelectedEventHandler MenuSelected;
        public Leaf(string i_Title, LeafMenuSelectedEventHandler i_ActionToExecute) : base(i_Title)
        {
            MenuSelected += i_ActionToExecute;
        }
        public void DoWhenChosen()
        {
            OnMenuChosen();
        }
        protected virtual void OnMenuChosen()
        {
            if(MenuSelected != null)
            {
                MenuSelected.Invoke();
            }
        }

       
    }
}
