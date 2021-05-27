namespace Ex04.Menus.Interfaces
{
    public class Leaf : MenuItem
    {
        private readonly IExecutable r_ActionToExetute;

        public Leaf(string i_Title, IExecutable i_ActionToExetute) : base(i_Title)
        {
            r_ActionToExetute = i_ActionToExetute;
        }

        public void PrintAction() 
        {
            r_ActionToExetute.Invoke();
        }
    }
}
