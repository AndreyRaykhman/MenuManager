using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
     class Button:MenuItem, IRunable
     {
          private MenuItem m_Father;

          public Button(MenuItem i_Father)
          {
               m_Father = i_Father;
          }

          public void Run()
          {
               if(base.MenuItemName == "Exit")
               {
                    Environment.Exit(1);
               }

               Console.WriteLine("{0} in process....", base.m_MenuItemName);
               //clear screen
               if(m_Father is Menu)
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
