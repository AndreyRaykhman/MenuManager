using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.ConsoleUtils;

namespace Ex04.Menus.Interfaces
{
     class Button:MenuItem, IRunable
     {
          private MenuItem m_Father;

          public Button(MenuItem i_Father)
          {
               m_Father = i_Father;
               if (m_Father is Menu)
               {
                    (m_Father as Menu).AddMenuItem(this);
               }
               else
               {
                    (m_Father as MainMenu).AddMenuItem(this);
               }
          }

          public void Run()
          {
               if(base.MenuItemName == "Exit")
               {
                    Environment.Exit(1);
               }

               Console.WriteLine("{0} in process....", base.m_MenuItemName);
               Screen.Clear();
               if (m_Father is Menu)
               {
                    (m_Father as Menu).Show();
               }
               else
               {
                    (m_Father as MainMenu).Show();
               }
          }                     
     }
}
