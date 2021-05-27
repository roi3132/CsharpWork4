namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class MenuItem
    {
        private readonly string r_Title;
        private readonly List<MenuItem> r_ListOfItems;

        public string Title
        {
            get { return r_Title; }
        }

        public MenuItem(string i_Titls)
        {
            if (!(this is Leaf)) 
            {
                r_ListOfItems = new List<MenuItem>();
            }
            
            r_Title = i_Titls;
        }

        public void PrintSubMenu()
        {
            bool menuRun = true;
            while (menuRun) 
            {
                Console.WriteLine(Title);
                Console.WriteLine("=====================");
                int num = 1;
                Console.WriteLine("Select form {0} option.", r_ListOfItems.Count + 1);

                foreach (MenuItem menu in ListOfItems)
                {
                    Console.WriteLine(num + ")" + menu.r_Title);
                    num++;
                }

                if (this is MainMenu)
                {
                    Console.WriteLine("0)Exit.");
                }
                else 
                {
                    Console.WriteLine("0)Back.");
                }

                int userChoise = GetChoiceFromUser(ListOfItems.Count);
                Console.Clear();
                if (userChoise == 0)
                {                
                    Console.Clear();
                    break;
                }   
                
                userChoise -= 1;

                Leaf leaf = r_ListOfItems[userChoise] as Leaf;
               
                if (leaf != null)
                {
                    leaf.PrintAction();
                }
                else 
                {
                    r_ListOfItems[userChoise].PrintSubMenu();
                }
            }          
        }

        public List<MenuItem> ListOfItems
        {
            get { return r_ListOfItems; }
        }  

        public override string ToString()
        {
            return r_Title;
        }

        public void add(MenuItem i_Item) 
        {
            ListOfItems.Add(i_Item);
        }

        public int GetChoiceFromUser(int i_UpperRange)
        {
            bool invalidChoice = true;
            string userInputStr = string.Empty;
            int userInput = -1;
            while (invalidChoice)
            {
                userInputStr = Console.ReadLine();
                try
                {
                    userInput = int.Parse(userInputStr);
                    if (userInput <= i_UpperRange && userInput >= 0)
                    {
                        invalidChoice = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. plese enter number acoording to the menu options.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalide input. please enter only numbers and try again.");
                }
            }

            return userInput;
        }
    }
}
