namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
        }

        public void Show()
        {
            PrintSubMenu();
        }
    }
}
