namespace Ex04.Menus.Test
{
    public class GenerateMenu
    {
        public Interfaces.MainMenu MakeMenuUsingInterfaces() 
        {
            Interfaces.MainMenu menu = new Interfaces.MainMenu("Main Menu Interfaces");
            Interfaces.MenuItem versionAndSpaces = new Interfaces.MenuItem("Version and Spaces");
            Interfaces.Leaf showVersion = new Interfaces.Leaf("Show Version", new Actions.ShowVersion());
            Interfaces.Leaf countSpaces = new Interfaces.Leaf("Count Spaces", new Actions.CountSpaces());
            Interfaces.MenuItem showDateAndTime = new Interfaces.MenuItem("Show Date/Time");
            Interfaces.Leaf showTime = new Interfaces.Leaf("Show Time", new Actions.ShowTime());
            Interfaces.Leaf showDate = new Interfaces.Leaf("Show Date", new Actions.ShowDate());

            versionAndSpaces.add(showVersion);
            versionAndSpaces.add(countSpaces);
            menu.add(versionAndSpaces);
            showDateAndTime.add(showTime);
            showDateAndTime.add(showDate);
            menu.add(showDateAndTime);

            return menu;
        }

        public Delegates.MainMenu MakeMenuUsingDelegates()
        {
            Delegates.MainMenu menu = new Delegates.MainMenu("Main Menu Delegates");
            Delegates.MenuItem versionAndSpaces = new Delegates.MenuItem("Version and Spaces");
            Delegates.Leaf showVersion = new Delegates.Leaf("Show Version", new Actions.ShowVersion().Invoke);
            Delegates.Leaf countSpaces = new Delegates.Leaf("Count Spaces", new Actions.CountSpaces().Invoke);
            Delegates.MenuItem showDateAndTime = new Delegates.MenuItem("Show Date/Time");
            Delegates.Leaf showTime = new Delegates.Leaf("Show Time", new Actions.ShowTime().Invoke);
            Delegates.Leaf showDate = new Delegates.Leaf("Show Date", new Actions.ShowDate().Invoke);

            versionAndSpaces.add(showVersion);
            versionAndSpaces.add(countSpaces);
            menu.add(versionAndSpaces);
            showDateAndTime.add(showTime);
            showDateAndTime.add(showDate);
            menu.add(showDateAndTime);

            return menu;
        }

        public void RunMenu() 
        {
            Interfaces.MainMenu menuByInterfaces = MakeMenuUsingInterfaces();
            menuByInterfaces.Show();
            Delegates.MainMenu menuByDelegates = MakeMenuUsingDelegates();
            menuByDelegates.Show();   
        }
    }  
}
