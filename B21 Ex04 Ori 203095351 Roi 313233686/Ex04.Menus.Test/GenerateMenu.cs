using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    class GenerateMenu
    {
        public MainMenu MakeMenuUsingInterfaces() 
        {
            MainMenu main = new MainMenu("Main Menu");
            MenuItem versionAndSpaces = new MenuItem("Version and Spaces");
            Leaf showVersion = new Leaf("Show Version",new Actions.ShowVersion());
            Leaf countSpaces = new Leaf("Count Spaces",new Actions.CountSpaces());
            MenuItem showDateAndTime = new MenuItem("Show Date/Time");
            Leaf showTime = new Leaf("Show Time", new Actions.ShowTime());
            Leaf showDate = new Leaf("Show Date", new Actions.ShowDate());

            versionAndSpaces.add(showVersion);
            versionAndSpaces.add(countSpaces);
            main.add(versionAndSpaces);
            showDateAndTime.add(showTime);
            showDateAndTime.add(showDate);
            main.add(showDateAndTime);

            return main;

        }
        public void MakeMenuUsingDelegates()
        {

        }

        public void RunMenu() 
        {
            MainMenu menu = MakeMenuUsingInterfaces();
            menu.Show();
            //MakeMenuUsingDelegates();
        }
    }
}
