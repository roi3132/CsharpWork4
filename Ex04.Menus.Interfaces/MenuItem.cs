using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {

        private readonly string m_Title;
        private readonly List<MenuItem> m_ListOfItems;

        public string Title
        {
            get { return m_Title; }
        }

        public MenuItem(string i_Titls)
        {
            if (!(this is Leaf)) 
            {
                m_ListOfItems = new List<MenuItem>();
            }        
            m_Title = i_Titls;
        }

        public void PrintSubMenu()
        {
            bool menuRun = true;
            while (menuRun) 
            {
                Console.WriteLine(Title);
                Console.WriteLine("=====================");
                int num = 1;
                Console.WriteLine("Select form {0} option.", m_ListOfItems.Count + 1);

                foreach (MenuItem menu in ListOfItems)
                {
                    Console.WriteLine(num + ")" + menu.m_Title);
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

                Leaf leaf = m_ListOfItems[userChoise] as Leaf;
               
                if (leaf != null)
                {
                    leaf.PrintAction();
                }
                else 
                {
                    m_ListOfItems[userChoise].PrintSubMenu();
                }
            }          
        }

        public List<MenuItem> ListOfItems
        {
            get { return m_ListOfItems; }
        }

     

        public override string ToString()
        {
            return m_Title;
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
